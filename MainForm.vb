'CPT-206-A01S-Lab-9
'Zachary Childers
'3/13/21
Option Strict On
Option Explicit On
Option Infer Off
Public Class MainForm
    Dim strStudNameGrade(14, 1) As String
    Dim intStud As Integer
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' LstGrades.SelectedIndex = 0

        Dim FrmDotText As IO.StreamReader
        Dim OpnDotText As OpenFileDialog = New OpenFileDialog

        If IO.File.Exists("NamesAndGrades.txt") Then
            FrmDotText = IO.File.OpenText("NamesAndGrads.txt")

            Do Until FrmDotText.Peek = -1
                strStudNameGrade(intStud, 0) = FrmDotText.ReadLine
                strStudNameGrade(intStud, 1) = FrmDotText.ReadLine
            Loop
        Else
            MessageBox.Show("Unable to parse .txt file, please be sure that you have selected the correct file",
                            "Exception: Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If OpnDotText.ShowDialog() = DialogResult.OK Then
                FrmDotText = IO.File.OpenText(OpnDotText.FileName)
                Do Until FrmDotText.Peek = -1
                    strStudNameGrade(intStud, 0) = FrmDotText.ReadLine
                    strStudNameGrade(intStud, 1) = FrmDotText.ReadLine
                Loop
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click
        LstNames.Items.Clear()
        LstNames.Focus()
        Dim Students As Integer
        For indx As Integer = 0 To Students - 1
            If strStudNameGrade(indx, 1) = LstGrades.SelectedIndex.ToString Then
                LstNames.Items.Add(strStudNameGrade(indx, 0))
                Students += 1
            End If
        Next
        TxtNumStudents.Text = intStud.ToString
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
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