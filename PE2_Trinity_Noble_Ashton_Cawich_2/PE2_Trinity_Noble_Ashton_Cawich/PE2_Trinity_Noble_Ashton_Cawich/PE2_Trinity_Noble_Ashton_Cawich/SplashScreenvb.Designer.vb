<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreenvb
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pbSplashScreen = New System.Windows.Forms.PictureBox()
        Me.pbProgBar = New System.Windows.Forms.ProgressBar()
        Me.pbPercent = New System.Windows.Forms.Label()
        Me.tmrProgTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbSplashScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbSplashScreen
        '
        Me.pbSplashScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbSplashScreen.Image = Global.PE2_Trinity_Noble_Ashton_Cawich.My.Resources.Resources.skywalker
        Me.pbSplashScreen.Location = New System.Drawing.Point(0, 0)
        Me.pbSplashScreen.Margin = New System.Windows.Forms.Padding(6)
        Me.pbSplashScreen.Name = "pbSplashScreen"
        Me.pbSplashScreen.Size = New System.Drawing.Size(1605, 865)
        Me.pbSplashScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSplashScreen.TabIndex = 0
        Me.pbSplashScreen.TabStop = False
        '
        'pbProgBar
        '
        Me.pbProgBar.Location = New System.Drawing.Point(0, 765)
        Me.pbProgBar.Margin = New System.Windows.Forms.Padding(6)
        Me.pbProgBar.Name = "pbProgBar"
        Me.pbProgBar.Size = New System.Drawing.Size(1600, 100)
        Me.pbProgBar.TabIndex = 1
        '
        'pbPercent
        '
        Me.pbPercent.AutoSize = True
        Me.pbPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pbPercent.Location = New System.Drawing.Point(1474, 796)
        Me.pbPercent.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.pbPercent.Name = "pbPercent"
        Me.pbPercent.Size = New System.Drawing.Size(0, 36)
        Me.pbPercent.TabIndex = 2
        '
        'tmrProgTimer
        '
        '
        'SplashScreenvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1605, 865)
        Me.Controls.Add(Me.pbPercent)
        Me.Controls.Add(Me.pbProgBar)
        Me.Controls.Add(Me.pbSplashScreen)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "SplashScreenvb"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreenvb"
        CType(Me.pbSplashScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbSplashScreen As PictureBox
    Friend WithEvents pbProgBar As ProgressBar
    Friend WithEvents pbPercent As Label
    Friend WithEvents tmrProgTimer As Timer
End Class
