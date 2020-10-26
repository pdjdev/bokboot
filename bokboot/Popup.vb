Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class Popup
    Public mode As String = ""

    Public txtdata As String = Nothing
    Public filedata As New StringCollection

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        CreateDropShadow(Me)
        MyBase.OnHandleCreated(e)
    End Sub

    Private Sub Popup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim scrnSize As Rectangle = Screen.PrimaryScreen.WorkingArea
        Refresh()
        Opacity = 0

        SetDesktopLocation((scrnSize.Width - Width) / 2, scrnSize.Height * 0.75)
        TopMost = True

        SetMode(mode)
    End Sub

    Public Sub SetMode(mode As String)
        Select Case mode
            Case "txt"
                TextMenuPanel.Visible = True
                FileMenuPanel.Visible = False
                MainText.Text = "텍스트("

                If txtdata.Length > 20 Then
                    MainText.Text += Mid(txtdata, 1, 10) + "..." + Mid(txtdata, txtdata.Length - 9, txtdata.Length) + ")"
                Else
                    MainText.Text += txtdata + ")"
                End If

                MainText.Text += "가 추가되었습니다."

            Case "file"
                TextMenuPanel.Visible = False
                FileMenuPanel.Visible = True

                Dim firstFileName As String = Mid(filedata(0), filedata(0).LastIndexOf("\") + 2, filedata(0).Length)
                If firstFileName.Length > 20 Then _
                    firstFileName = Mid(firstFileName, 1, 10) + "..." + Mid(firstFileName, firstFileName.Length - 9, firstFileName.Length)

                If filedata.Count > 1 Then
                    MainText.Text = "파일(" + firstFileName + "외 " + filedata.Count.ToString + ")이 복사되었습니다."
                Else
                    MainText.Text = "파일(" + firstFileName + ")이 복사되었습니다."
                End If
        End Select
    End Sub

    Private Sub Popup_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Refresh()

        Do While Opacity < 0.9 - 0.1
            Opacity += 0.1
            Threading.Thread.Sleep(10)
        Loop

        Opacity = 0.9
    End Sub

    Private Sub Popup_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Do While Not Opacity = 0
            Opacity = Opacity - 0.1
            Threading.Thread.Sleep(10)
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    '텍스트 서식 지우기 -> 일반 텍스트 클립보드에 저장
    Private Sub PlainTextBT_Click(sender As Object, e As EventArgs) Handles PlainTextBT.Click
        Clipboard.SetText(txtdata)
    End Sub
End Class