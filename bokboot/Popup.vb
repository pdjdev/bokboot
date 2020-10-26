Imports System.Collections.Specialized

Public Class Popup
    Public mode As String = ""

    Public txtdata As String = Nothing
    Public filedata As New StringCollection

    Private Sub Popup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim scrnSize As Rectangle = Screen.PrimaryScreen.WorkingArea

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

                If txtdata.Length > 10 Then
                    MainText.Text += Mid(txtdata, 1, 5) + "..." + Mid(txtdata, txtdata.Length - 4, txtdata.Length) + ")"
                Else
                    MainText.Text += txtdata + ")"
                End If

                MainText.Text += "가 추가되었습니다."

            Case "file"
                TextMenuPanel.Visible = False
                FileMenuPanel.Visible = True

                Dim firstFileName As String = Mid(filedata(0), filedata(0).LastIndexOf("\") + 2, filedata(0).Length)

                If filedata.Count > 1 Then
                    MainText.Text = "파일(" + firstFileName + "외 " + filedata.Count.ToString + ")이 복사되었습니다."
                Else
                    MainText.Text = "파일(" + firstFileName + ")이 복사되었습니다."
                End If
        End Select
    End Sub
End Class