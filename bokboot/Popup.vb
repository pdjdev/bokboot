Public Class Popup
    Public mode As String = ""

    Private Sub Popup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim scrnSize As Rectangle = Screen.PrimaryScreen.WorkingArea

        SetDesktopLocation((scrnSize.Width - Width) / 2, scrnSize.Height * 0.75)
        TopMost = True
    End Sub

    Public Sub SetMode(mode As String)
        Select Case mode
            Case "txt"
                TextMenuPanel.Visible = True
                FileMenuPanel.Visible = False

            Case "file"
                TextMenuPanel.Visible = False
                FileMenuPanel.Visible = True
        End Select
    End Sub
End Class