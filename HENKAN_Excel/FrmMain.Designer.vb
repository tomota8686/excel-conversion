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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.dgvBefo = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnConv = New System.Windows.Forms.Button()
        Me.btnFolderSelect = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblFilePath = New System.Windows.Forms.Label()
        CType(Me.dgvBefo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvBefo.Location = New System.Drawing.Point(12, 82)
        Me.dgvBefo.Name = "dgvBefo"
        Me.dgvBefo.RowHeadersVisible = False
        Me.dgvBefo.RowTemplate.Height = 21
        Me.dgvBefo.Size = New System.Drawing.Size(531, 617)
        Me.dgvBefo.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(725, 82)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 21
        Me.DataGridView2.Size = New System.Drawing.Size(527, 617)
        Me.DataGridView2.TabIndex = 2
        '
        'btnConv
        '
        Me.btnConv.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnConv.Location = New System.Drawing.Point(572, 399)
        Me.btnConv.Name = "btnConv"
        Me.btnConv.Size = New System.Drawing.Size(121, 66)
        Me.btnConv.TabIndex = 3
        Me.btnConv.Text = "変換"
        Me.btnConv.UseVisualStyleBackColor = True
        '
        'btnFolderSelect
        '
        Me.btnFolderSelect.BackColor = System.Drawing.Color.Yellow
        Me.btnFolderSelect.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnFolderSelect.Location = New System.Drawing.Point(12, 43)
        Me.btnFolderSelect.Name = "btnFolderSelect"
        Me.btnFolderSelect.Size = New System.Drawing.Size(130, 33)
        Me.btnFolderSelect.TabIndex = 5
        Me.btnFolderSelect.Text = "①フォルダ選択"
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
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 711)
        Me.Controls.Add(Me.lblFilePath)
        Me.Controls.Add(Me.btnFolderSelect)
        Me.Controls.Add(Me.btnConv)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.dgvBefo)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "給与明細変換システム"
        CType(Me.dgvBefo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvBefo As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnConv As Button
    Friend WithEvents btnFolderSelect As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lblFilePath As Label
End Class
