'CPT-206-A01S-Lab-9
'Zachary Childers
'3/13/21
Option Strict On
Option Explicit On
Option Infer Off
Public Class MainForm
    Private Declare Function HideCaret Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean ' <- Hide I beam Caret on disabled text boxes
    '''Button to Exit + Msg PopUp'''
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim frm As New MainForm ' MsgBox popup
        MessageBox.Show("Thank you for using this application!")
        SplashScreen.Close()
        Application.Exit()
    End Sub
    '''On Hitting [X] "Exit", will ask user if they're certain if they wish to leave'''
    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure you wish to exit?", "Woah!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ' they decided to exit so let them
            SplashScreen.Close()
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub
    '''HyperLink'''
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://im-zach.github.io/")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblTime.Text = DateTime.Now.ToString("M/d/yyyy h:mm:stt") '<-- Clock to label
    End Sub

    '------------
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
    Private Sub LstOfGrades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstOfGrades.SelectedIndexChanged
        TxtNumStudents.Text = ""
        LstNames.Items.Clear()
    End Sub
End Class
' #TODO: 
' - Splash screen
' - format, coloration - work on theme of form and buttons
' - tool tips
' - tabs , center form 
' - double buffer