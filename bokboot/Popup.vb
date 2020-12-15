Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class Popup
    Public mode As String = ""

    Public txtdata As String = Nothing
    Public filedata As New StringCollection

    Dim mouseOn As Boolean = False

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
                MainText.Text = ""

                Dim tmptxt = txtdata.Replace(vbCr, "").Replace(vbLf, "").Replace(vbTab, "")

                If tmptxt.Length > 28 Then
                    MainText.Text += Mid(tmptxt, 1, 14) + " ... " + Mid(tmptxt, tmptxt.Length - 14, tmptxt.Length)
                Else
                    MainText.Text += tmptxt
                End If

                'MainText.Text += " 복사됨"

            Case "file"
                TextMenuPanel.Visible = False
                FileMenuPanel.Visible = True

                Dim firstFileName As String = Mid(filedata(0), filedata(0).LastIndexOf("\") + 2, filedata(0).Length)
                If firstFileName.Length > 20 Then _
                    firstFileName = Mid(firstFileName, 1, 10) + " ... " + Mid(firstFileName, firstFileName.Length - 9, firstFileName.Length)

                If filedata.Count > 1 Then
                    MainText.Text = "파일(" + firstFileName + "외 " + filedata.Count.ToString + ") 복사됨"
                Else
                    MainText.Text = "파일(" + firstFileName + ") 복사됨"
                End If
        End Select
    End Sub

    Private Sub Popup_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Refresh()

        Do While Opacity < 0.8
            Opacity += 0.1
            Threading.Thread.Sleep(30)
        Loop

        Opacity = 0.9
    End Sub

    Private Sub Popup_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Do While Not Opacity = 0
            Opacity = Opacity - 0.1
            Threading.Thread.Sleep(30)
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CloseBT.Click
        Close()
    End Sub

    '텍스트 서식 지우기 -> 일반 텍스트 클립보드에 저장
    Private Sub PlainTextBT_Click(sender As Object, e As EventArgs) Handles PlainTextBT.Click
        Clipboard.SetText(txtdata)
    End Sub

    Private Sub WebSearchBT_Click(sender As Object, e As EventArgs) Handles WebSearchBT.Click
        Process.Start("https://www.google.com/search?q=" + txtdata)
    End Sub

    Private Sub OpenNotepadBT_Click(sender As Object, e As EventArgs) Handles OpenNotepadBT.Click
        Dim exeFullpath As String = Application.ExecutablePath
        Dim exeDir As String = exeFullpath.Substring(0, exeFullpath.LastIndexOf("\"))
        Dim finalName As String = "clipboard.txt"

        '임시파일 디렉토리에 클립보드 텍스트 파일 저장
        'My.Computer.FileSystem.WriteAllText(exeDir + "\" + finalName, txtdata, False, System.Text.Encoding.GetEncoding(949))
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\" + finalName,
                                            txtdata, False, System.Text.Encoding.GetEncoding(949))


        Process.Start("notepad.exe", My.Computer.FileSystem.SpecialDirectories.Temp + "\" + finalName)
    End Sub

    Private Sub SaveToTxtBT_Click(sender As Object, e As EventArgs) Handles SaveToTxtBT.Click
        Process.Start("powershell.exe", "/c """ + txtdata + """")
    End Sub

    Private Sub CopyDirBT_Click(sender As Object, e As EventArgs) Handles CopyDirBT.Click
        Clipboard.SetText(String.Join(vbCrLf, filedata.Cast(Of String).ToList))
    End Sub

    Private Sub OpenDirBT_Click(sender As Object, e As EventArgs) Handles OpenDirBT.Click
        Process.Start(filedata(0).Substring(0, filedata(0).LastIndexOf("\")))
    End Sub

    Private Sub MouseFadeTimer_Tick(sender As Object, e As EventArgs) Handles MouseFadeTimer.Tick

        If mouseOn Then
            MouseFadeTimer.Interval = 30
            If Opacity < 0.8 Then
                Opacity += 0.02
            End If
            TimeoutTimer.Stop()
        Else
            MouseFadeTimer.Interval = 100
            If Opacity > 0.6 Then
                Opacity -= 0.01
            End If
            TimeoutTimer.Start()
        End If
    End Sub

    Private Sub MainText_MouseEnter(sender As Object, e As EventArgs) Handles MainText.MouseEnter, CopyDirBT.MouseEnter,
        OpenDirBT.MouseEnter, OpenNotepadBT.MouseEnter, PlainTextBT.MouseEnter, SaveToTxtBT.MouseEnter, WebSearchBT.MouseEnter
        mouseOn = True
    End Sub

    Private Sub MainText_MouseLeave(sender As Object, e As EventArgs) Handles MainText.MouseLeave, CopyDirBT.MouseLeave,
        OpenDirBT.MouseLeave, OpenNotepadBT.MouseLeave, PlainTextBT.MouseLeave, SaveToTxtBT.MouseLeave, WebSearchBT.MouseLeave
        mouseOn = False
    End Sub

    Private Sub TimeoutTimer_Tick(sender As Object, e As EventArgs) Handles TimeoutTimer.Tick
        Me.Close()
    End Sub
End Class