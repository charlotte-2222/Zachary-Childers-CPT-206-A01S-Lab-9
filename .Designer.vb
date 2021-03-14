<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.LstOfGrades = New System.Windows.Forms.ListBox()
        Me.TxtNumStudents = New System.Windows.Forms.TextBox()
        Me.LstNames = New System.Windows.Forms.ListBox()
        Me.BtnDisplay = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LstOfGrades
        '
        Me.LstOfGrades.FormattingEnabled = True
        Me.LstOfGrades.Location = New System.Drawing.Point(25, 88)
        Me.LstOfGrades.Name = "LstOfGrades"
        Me.LstOfGrades.Size = New System.Drawing.Size(36, 108)
        Me.LstOfGrades.TabIndex = 0
        '
        'TxtNumStudents
        '
        Me.TxtNumStudents.Location = New System.Drawing.Point(270, 88)
        Me.TxtNumStudents.Name = "TxtNumStudents"
        Me.TxtNumStudents.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumStudents.TabIndex = 1
        '
        'LstNames
        '
        Me.LstNames.FormattingEnabled = True
        Me.LstNames.Location = New System.Drawing.Point(102, 88)
        Me.LstNames.Name = "LstNames"
        Me.LstNames.Size = New System.Drawing.Size(112, 108)
        Me.LstNames.TabIndex = 2
        '
        'BtnDisplay
        '
        Me.BtnDisplay.Location = New System.Drawing.Point(260, 173)
        Me.BtnDisplay.Name = "BtnDisplay"
        Me.BtnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.BtnDisplay.TabIndex = 3
        Me.BtnDisplay.Text = "Display"
        Me.BtnDisplay.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(353, 173)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Grade:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Students:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(267, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Number of Students:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 297)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnDisplay)
        Me.Controls.Add(Me.LstNames)
        Me.Controls.Add(Me.TxtNumStudents)
        Me.Controls.Add(Me.LstOfGrades)
        Me.Name = "MainForm"
        Me.Text = "Potter Jr High"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstOfGrades As ListBox
    Friend WithEvents TxtNumStudents As TextBox
    Friend WithEvents LstNames As ListBox
    Friend WithEvents BtnDisplay As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
