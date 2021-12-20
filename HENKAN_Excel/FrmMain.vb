Imports System.IO
Imports WK.Libraries.BetterFolderBrowserNS

Public Class FrmMain


#Region "共有変数"
    Private INPUTPath As String
    Private OUTPUTPath As String
#End Region
    'コンストラクタ
    Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。        

    End Sub
#Region "Form関連"
    Private Sub FrmLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            ''Form初期設定
            '最大サイズと最小サイズを現在のサイズに設定する
            Me.MaximumSize = Me.Size
            Me.MinimumSize = Me.Size
            'フォームが最大化されないようにする
            Me.MaximizeBox = False

            'DataGrudview列作成メソッド呼び出し
            Call FunSetDgvCulumns(Me.dgvBefo)

            'INI読取
            'SYSTEM.INIの存在するフォルダ
            Dim strPath As String = Application.StartupPath.Replace("EXE", "INI") + "\SYSTEM.INI"

            '<System.IO.FileNotFoundExceptionでも記述できる>
            'SYSTEM.INIが見つからない場合
            If System.IO.File.Exists(strPath) <> True Then
                MsgBox("SYSTEM.INIが見つかりません。" & vbCrLf & "デフォルトにデスクトップPathを指定します。",, "エラー")
                'フォルダ選択のRoot設定
                INPUTPath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
                OUTPUTPath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            Else
                'インスタンス生成
                Dim INI As New RWini(strPath)


                'フォルダ選択のRoot設定
                INPUTPath = INI.GetIniString("ROOTFOLDER", "INPUTPATH")
                OUTPUTPath = INI.GetIniString("ROOTFOLDER", "OUTPUTPATH")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

    Private Function btnFolderSelect_Click(sender As Object, e As EventArgs) Handles btnFolderSelect.Click

        Try

            Dim bfb As New BetterFolderBrowser()
            Dim filePath As String()

            If System.IO.File.Exists(INPUTPath) <> True Then
                MsgBox($"{INPUTPath}が見つかりません。" & vbCrLf & "デスクトップフォルダを開きます。",, "エラー")
                INPUTPath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            End If

            bfb.Title = "変換したいフォルダを選択してください。"
            bfb.Multiselect = False
            bfb.RootFolder = INPUTPath

            'フォルダ選択画面を表示し
            'ＯＫが押された時に、TextBoxへ選択フォルダのPathを表示
            If bfb.ShowDialog() = DialogResult.OK Then
                filePath = bfb.SelectedFolders
                lblFilePath.Text = String.Join(",", filePath)
            Else
                Return False
            End If

            'TextBoxへ指定したディレクトリが存在するかのチェック
            For Each fp As String In filePath
                If Not Directory.Exists(fp) Then
                    MsgBox($"指定のディレクトリ{fp}は存在しません。" & vbCrLf & "確認してください。")
                Else
                    Call FunSetListData(Me.dgvBefo, fp)
                End If
            Next


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try


    End Function

#Region "DataGridView関連"
    'DataGridView列作成
    Private Function FunSetDgvCulumns(dgv As DataGridView) As Boolean

        Try
            With dgv

                .EnableHeadersVisualStyles = False
                .ColumnHeadersHeight = 40
                .ColumnHeadersDefaultCellStyle.BackColor = Color.Gray
                .ColumnHeadersHeightSizeMode = False
                .RowHeadersWidthSizeMode = False
                .RowTemplate.Height = 30

                Dim checkBox As New DataGridViewCheckBoxColumn

                'CheckBox列作成
                .Columns.Add(checkBox)
                .Columns(0).HeaderText = "選択"
                .Columns(.ColumnCount - 1).DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleLeft
                .Columns(.ColumnCount - 1).DataPropertyName = .Columns(.ColumnCount - 1).Name
                .Columns(.ColumnCount - 1).Width = 40

                'ファイル名列作成
                .Columns.Add("fileName", "ファイル名")
                .Columns(.ColumnCount - 1).DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleLeft
                .Columns(.ColumnCount - 1).DataPropertyName = .Columns(.ColumnCount - 1).Name
                .Columns(.ColumnCount - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                '読み取り専用
                .Columns(1).ReadOnly = True

                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                'ソート禁止
                For Each c As DataGridViewColumn In dgv.Columns
                    c.SortMode = DataGridViewColumnSortMode.NotSortable
                Next c

            End With

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    'DataGridView出力
    Private Function FunSetListData(dgv As DataGridView, filePath As String) As Boolean
        Try
            Dim dt As New DataTable
            Dim files As String()

            dt.Columns.Add("fileName")

            files = Directory.GetFiles(filePath)

            For Each filename As String In files
                Dim fi As New FileInfo(filename)
                Dim dr As DataRow = dt.NewRow()

                'Excelファイルのみ表示
                If (fi.Extension Like ".xl*") Then
                    dr("fileName") = fi.Name
                    dt.Rows.Add(dr)
                End If

            Next

            'データソース設定
            dgv.DataSource = dt

            '件数表示
            lblCnt.Text = dgv.Rows.Count.ToString + "件"

            'すべてのチェックボックスを選択状態にする
            Call FunDgvCellAllChk(dgv)

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    'すべてのChkBox選択
    Private Function FunDgvCellAllChk(dgv As DataGridView) As Boolean

        Dim dgvRowCnt As Integer

        Try

            dgvRowCnt = dgv.Rows.Count

            For i As Integer = 0 To dgvRowCnt - 1
                dgv(0, i).Value = True
            Next i

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    'すべてのChkBox選択解除
    Private Function FunDgvCellAllCan(dgv As DataGridView) As Boolean

        Dim dgvRowCnt As Integer

        Try

            dgvRowCnt = dgv.Rows.Count

            For i As Integer = 0 To dgvRowCnt - 1
                dgv(0, i).Value = False
            Next i

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Private Sub cellChanged(sender As Object, e As EventArgs) Handles dgvBefo.CurrentCellDirtyStateChanged
        Dim dgvRowCnt As Integer
        Dim cnt As Integer

        Try

            dgvRowCnt = dgvBefo.Rows.Count

            For i As Integer = 0 To dgvRowCnt - 1

                If dgvBefo(0, i).Value = True Then
                    cnt += 1
                End If

            Next i

            lblCnt.Text = cnt.ToString + "件"
            'dgvBefo.CurrentCell = dgvBefo(, 1)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '全選択ボタン押下
    Private Sub btnAllChk_Click(sender As Object, e As EventArgs) Handles btnAllChk.Click
        Call FunDgvCellAllChk(Me.dgvBefo)
    End Sub

    '全解除ボタン押下
    Private Sub btnAllCancel_Click(sender As Object, e As EventArgs) Handles btnAllCancel.Click
        Call FunDgvCellAllCan(Me.dgvBefo)
    End Sub

#End Region

End Class
