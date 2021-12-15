Public Class FrmMain

    Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。        

        ''Form初期設定
        '最大サイズと最小サイズを現在のサイズに設定する
        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size
        'フォームが最大化されないようにする
        Me.MaximizeBox = False

    End Sub

End Class
