'CPT-206-A01S-Lab-9
'Zachary Childers
'3/13/21
Option Strict On
Option Explicit On
Option Infer Off
Public Class MainForm
    Dim strNamesAndGrades(14, 1) As String

    Dim intStudent As Integer
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' LstOfGrades.SelectedIndex = 0

        Dim inFile As IO.StreamReader

        Dim dlgFile As OpenFileDialog = New OpenFileDialog

        If IO.File.Exists("Zachary-Childers-CPT-206-A01S-Lab-9\Solution Items\NamesAndGrades.txt") Then
            inFile = IO.File.OpenText("Zachary-Childers-CPT-206-A01S-Lab-9\Solution Items\NamesAndGrades.txt")
            Do Until inFile.Peek = -1
                strNamesAndGrades(intStudent, 0) = inFile.ReadLine
                strNamesAndGrades(intStudent, 1) = inFile.ReadLine
                intStudent += 1
            Loop

            'inFile.Close()
        Else
            MessageBox.Show("Gradebook not available for processing. Press OK to selet a new gradebook file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If dlgFile.ShowDialog() = DialogResult.OK Then
                inFile = IO.File.OpenText(dlgFile.FileName)
                Do Until inFile.Peek = -1
                    strNamesAndGrades(intStudent, 0) = inFile.ReadLine
                    strNamesAndGrades(intStudent, 1) = inFile.ReadLine
                    intStudent += 1
                Loop
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click
        LstNames.Items.Clear()
        Dim intStudentCount As Integer = 0
        For intIndex As Integer = 0 To intStudent - 1
            If strNamesAndGrades(intIndex, 1) = LstOfGrades.SelectedItem.ToString Then
                LstNames.Items.Add(strNamesAndGrades(intIndex, 0))
                intStudentCount += 1
            End If
        Next
        TxtNumStudents.Text = intStudentCount.ToString
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub LstOfGrades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstOfGrades.SelectedIndexChanged
        LstOfGrades.SelectedIndex = 0
    End Sub
End Class
' #TODO: 
' - Splash screen, will need timers on splash + on MainForm itself - seconds tick
'  - Update txtbox
' - exit button code, message box
' - format, coloration - work on theme of form and buttons
' - tool tips
' - tabs, shortcuts, center form 
' - double buffer