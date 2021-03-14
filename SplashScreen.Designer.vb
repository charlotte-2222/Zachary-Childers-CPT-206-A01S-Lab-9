<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.date_time = New System.Windows.Forms.Label()
        Me.prgSplah = New System.Windows.Forms.ProgressBar()
        Me.lblSplash = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'date_time
        '
        Me.date_time.AutoSize = True
        Me.date_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_time.Location = New System.Drawing.Point(7, 327)
        Me.date_time.Name = "date_time"
        Me.date_time.Size = New System.Drawing.Size(121, 17)
        Me.date_time.TabIndex = 14
        Me.date_time.Text = "PLACEHOLDER"
        '
        'prgSplah
        '
        Me.prgSplah.Location = New System.Drawing.Point(12, 347)
        Me.prgSplah.Maximum = 110
        Me.prgSplah.Name = "prgSplah"
        Me.prgSplah.Size = New System.Drawing.Size(221, 23)
        Me.prgSplah.Step = 11
        Me.prgSplah.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgSplah.TabIndex = 13
        '
        'lblSplash
        '
        Me.lblSplash.AutoSize = True
        Me.lblSplash.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSplash.Location = New System.Drawing.Point(12, 9)
        Me.lblSplash.Name = "lblSplash"
        Me.lblSplash.Size = New System.Drawing.Size(156, 25)
        Me.lblSplash.TabIndex = 15
        Me.lblSplash.Text = "Zachary Childers"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 260)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 373)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblSplash)
        Me.Controls.Add(Me.date_time)
        Me.Controls.Add(Me.prgSplah)
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents date_time As Label
    Friend WithEvents prgSplah As ProgressBar
    Friend WithEvents lblSplash As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
