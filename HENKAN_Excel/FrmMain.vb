Imports System.IO

Public Class FrmMain
#Region "共有変数"
    Private filePath As String
    Private rootPath As String
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
                MsgBox("SYSTEM.INIが見つかりません。" & vbCrLf & "プログラムを終了します。",, "エラー")
                Try
                Finally
                    Application.Exit()
                End Try
            End If

            'インスタンス生成
            Dim INI As New RWini(strPath)


            'フォルダ選択のRoot設定
            rootPath = INI.GetIniString("ROOTFOLDER", "PATH")



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

    Private Function btnFolderSelect_Click(sender As Object, e As EventArgs) Handles btnFolderSelect.Click

        Try

            FolderBrowserDialog1.SelectedPath = rootPath
            FolderBrowserDialog1.ShowNewFolderButton = False

            'フォルダ選択画面を表示し
            'ＯＫが押された時に、TextBoxへ選択フォルダのPathを表示
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                filePath = FolderBrowserDialog1.SelectedPath
                lblFilePath.Text = filePath
            Else
                Return False
            End If

            'TextBoxへ指定したディレクトリが存在するかのチェック
            If Not Directory.Exists(filePath) Then
                MsgBox("指定のディレクトリは存在しません。")
                Return False
            End If

            Call FunSetListData(Me.dgvBefo)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try


    End Function
#Region "DataGridView関連"
    'DataGridView列作成
    Private Function FunSetDgvCulumns(dgv As DataGridView) As Boolean

        With dgv

            dgv.ColumnHeadersHeight = 30
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray
            dgv.ColumnHeadersHeightSizeMode = False
            dgv.RowHeadersWidthSizeMode = False
            dgv.RowTemplate.Height = 30

            Dim checkBox As New DataGridViewCheckBoxColumn
            .Columns.Add(checkBox)
            .Columns(0).HeaderText = "選択"
            .Columns(.ColumnCount - 1).DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            .Columns(.ColumnCount - 1).DataPropertyName = .Columns(.ColumnCount - 1).Name
            .Columns(.ColumnCount - 1).Width = 40

            .Columns.Add("fileName", "ファイル名")
            .Columns(.ColumnCount - 1).DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            .Columns(.ColumnCount - 1).DataPropertyName = .Columns(.ColumnCount - 1).Name
            .Columns(.ColumnCount - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


        End With

    End Function

    'DataGridView出力
    Private Function FunSetListData(dgv As DataGridView) As Boolean
        Try
            Dim dt As New DataTable
            Dim files As String()

            dt.Columns.Add("fileName")

            files = Directory.GetFiles(filePath)

            For Each filename As String In files
                Dim fi As New FileInfo(filename)
                Dim dr As DataRow = dt.NewRow()
                dr("fileName") = fi.Name
                dt.Rows.Add(dr)
            Next

            dgv.DataSource = dt

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function
#End Region

End Class
