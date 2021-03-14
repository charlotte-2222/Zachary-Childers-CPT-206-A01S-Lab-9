'CPT-206-A01S-Lab-9
'Zachary Childers
'3/13/21
Option Strict On
Option Explicit On
Option Infer Off
Public Class MainForm
    'Dim Vars, Array
    Dim FileInfo(14, 1) As String
    Dim intStudentIndx As Integer
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LstOfGrades.SelectedIndex = 0
        Dim LoadFile As IO.StreamReader 'Stream Readers
        Dim FailFile As OpenFileDialog = New OpenFileDialog 'On failure will request user to open from Dir

        If IO.File.Exists("C:\Users\ZChil\Desktop\Spring 2021\VisualBasic\Zachary-Childers-CPT-206-A01S-Lab-9\NamesAndGrades.txt") Then
            'If it exists or is read-able -- we open it.
            LoadFile = IO.File.OpenText("C:\Users\ZChil\Desktop\Spring 2021\VisualBasic\Zachary-Childers-CPT-206-A01S-Lab-9\NamesAndGrades.txt")
            Do Until LoadFile.Peek = -1
                FileInfo(intStudentIndx, 0) = LoadFile.ReadLine
                FileInfo(intStudentIndx, 1) = LoadFile.ReadLine
                intStudentIndx += 1
            Loop
        Else
            '''If it does not exist, we look for a file to open in directory'''
            MessageBox.Show("Unable to open file, please select from Directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If FailFile.ShowDialog() = DialogResult.OK Then
                LoadFile = IO.File.OpenText(FailFile.FileName)
                Do Until LoadFile.Peek = -1
                    FileInfo(intStudentIndx, 0) = LoadFile.ReadLine
                    FileInfo(intStudentIndx, 1) = LoadFile.ReadLine
                    intStudentIndx += 1
                Loop
            Else
                Me.Close() ' Close
            End If
        End If
    End Sub

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click
        LstNames.Items.Clear()
        Dim Student As Integer = 0
        For Y As Integer = 0 To intStudentIndx - 1
            If FileInfo(Y, 1) = LstOfGrades.SelectedItem.ToString Then
                LstNames.Items.Add(FileInfo(Y, 0))
                Student += 1
            End If
        Next
        TxtNumStudents.Text = Student.ToString
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

End Class
' #TODO: 
' - Splash screen, will need timers on splash + on MainForm itself - seconds tick
' - format, coloration - work on theme of form and buttons
' - tool tips
' - tabs, shortcuts, center form 
' - double buffer