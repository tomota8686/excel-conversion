<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.dgvBefo = New System.Windows.Forms.DataGridView()
        Me.btnConv = New System.Windows.Forms.Button()
        Me.btnFolderSelect = New System.Windows.Forms.Button()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.btnAllChk = New System.Windows.Forms.Button()
        Me.btnAllCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCnt = New System.Windows.Forms.Label()
        CType(Me.dgvBefo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(345, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "<給与明細書 Excel 変換>"
        '
        'dgvBefo
        '
        Me.dgvBefo.AllowUserToAddRows = False
        Me.dgvBefo.AllowUserToDeleteRows = False
        Me.dgvBefo.AllowUserToResizeColumns = False
        Me.dgvBefo.AllowUserToResizeRows = False
        Me.dgvBefo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBefo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBefo.Location = New System.Drawing.Point(12, 82)
        Me.dgvBefo.Name = "dgvBefo"
        Me.dgvBefo.RowHeadersVisible = False
        Me.dgvBefo.RowTemplate.Height = 21
        Me.dgvBefo.Size = New System.Drawing.Size(531, 617)
        Me.dgvBefo.TabIndex = 1
        '
        'btnConv
        '
        Me.btnConv.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnConv.Location = New System.Drawing.Point(553, 176)
        Me.btnConv.Name = "btnConv"
        Me.btnConv.Size = New System.Drawing.Size(157, 85)
        Me.btnConv.TabIndex = 3
        Me.btnConv.Text = "変換"
        Me.btnConv.UseVisualStyleBackColor = True
        '
        'btnFolderSelect
        '
        Me.btnFolderSelect.BackColor = System.Drawing.Color.Aqua
        Me.btnFolderSelect.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnFolderSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFolderSelect.Location = New System.Drawing.Point(12, 43)
        Me.btnFolderSelect.Name = "btnFolderSelect"
        Me.btnFolderSelect.Size = New System.Drawing.Size(130, 33)
        Me.btnFolderSelect.TabIndex = 5
        Me.btnFolderSelect.Text = "フォルダ選択"
        Me.btnFolderSelect.UseVisualStyleBackColor = False
        '
        'lblFilePath
        '
        Me.lblFilePath.BackColor = System.Drawing.Color.White
        Me.lblFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFilePath.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFilePath.Location = New System.Drawing.Point(148, 50)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(395, 23)
        Me.lblFilePath.TabIndex = 6
        '
        'btnAllChk
        '
        Me.btnAllChk.Location = New System.Drawing.Point(335, 87)
        Me.btnAllChk.Name = "btnAllChk"
        Me.btnAllChk.Size = New System.Drawing.Size(88, 31)
        Me.btnAllChk.TabIndex = 7
        Me.btnAllChk.Text = "すべて選択"
        Me.btnAllChk.UseVisualStyleBackColor = True
        '
        'btnAllCancel
        '
        Me.btnAllCancel.Location = New System.Drawing.Point(429, 87)
        Me.btnAllCancel.Name = "btnAllCancel"
        Me.btnAllCancel.Size = New System.Drawing.Size(88, 31)
        Me.btnAllCancel.TabIndex = 8
        Me.btnAllCancel.Text = "すべて解除"
        Me.btnAllCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(549, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "処理件数："
        '
        'lblCnt
        '
        Me.lblCnt.Font = New System.Drawing.Font("MS UI Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblCnt.Location = New System.Drawing.Point(593, 111)
        Me.lblCnt.Name = "lblCnt"
        Me.lblCnt.Size = New System.Drawing.Size(117, 48)
        Me.lblCnt.TabIndex = 10
        Me.lblCnt.Text = "0件"
        Me.lblCnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 711)
        Me.Controls.Add(Me.lblCnt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAllCancel)
        Me.Controls.Add(Me.btnAllChk)
        Me.Controls.Add(Me.lblFilePath)
        Me.Controls.Add(Me.btnFolderSelect)
        Me.Controls.Add(Me.btnConv)
        Me.Controls.Add(Me.dgvBefo)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "給与明細変換システム"
        CType(Me.dgvBefo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvBefo As DataGridView
    Friend WithEvents btnConv As Button
    Friend WithEvents btnFolderSelect As Button
    Friend WithEvents lblFilePath As Label
    Friend WithEvents btnAllChk As Button
    Friend WithEvents btnAllCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCnt As Label
End Class
