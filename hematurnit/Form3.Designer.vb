<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits BurtonSoftware.ThemeKit.ThemeForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New BurtonSoftware.ThemeKit.ThemeProgressBar
        Me.Button1 = New BurtonSoftware.ThemeKit.ThemeButton
        Me.ThemeButton1 = New BurtonSoftware.ThemeKit.ThemeButton
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(268, 23)
        Me.ProgressBar1.Style = "WLM"
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.Text = "ThemeProgressBar1"
        Me.ProgressBar1.Value = 0
        '
        'Button1
        '
        Me.Button1.DropDown = Nothing
        Me.Button1.DropDownAlignment = BurtonSoftware.ThemeKit.ThemeButton.DropDownPosition.Right
        Me.Button1.Image = Nothing
        Me.Button1.ImageIndex = 0
        Me.Button1.ImageList = Nothing
        Me.Button1.Location = New System.Drawing.Point(175, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.Style = "WLM"
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "اغلق الان"
        '
        'ThemeButton1
        '
        Me.ThemeButton1.DropDown = Nothing
        Me.ThemeButton1.DropDownAlignment = BurtonSoftware.ThemeKit.ThemeButton.DropDownPosition.Right
        Me.ThemeButton1.Image = Nothing
        Me.ThemeButton1.ImageIndex = 0
        Me.ThemeButton1.ImageList = Nothing
        Me.ThemeButton1.Location = New System.Drawing.Point(28, 64)
        Me.ThemeButton1.Name = "ThemeButton1"
        Me.ThemeButton1.Size = New System.Drawing.Size(75, 23)
        Me.ThemeButton1.Style = "WLM"
        Me.ThemeButton1.TabIndex = 5
        Me.ThemeButton1.Text = "لا تغلق"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(292, 103)
        Me.ControlBox = False
        Me.Controls.Add(Me.ThemeButton1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Style = "WLM"
        Me.Text = "جارى الاغلاق"
        Me.Theme = resources.GetString("$this.Theme")
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As BurtonSoftware.ThemeKit.ThemeProgressBar
    Friend WithEvents Button1 As BurtonSoftware.ThemeKit.ThemeButton
    Friend WithEvents ThemeButton1 As BurtonSoftware.ThemeKit.ThemeButton
End Class
