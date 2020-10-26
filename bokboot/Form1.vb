Imports System.Collections.Specialized

Public Class Form1
    Private Const WM_DRAWCLIPBOARD As Integer = &H308
    Private Declare Function SetClipboardViewer Lib "user32" Alias "SetClipboardViewer" (ByVal hwnd As Integer) As Integer
    Dim result As Integer = SetClipboardViewer(MyBase.Handle.ToInt32)

    Public prevClipboardData As IDataObject = Nothing

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_DRAWCLIPBOARD Then
            Beep()
            ClipboardScanner()

            '
            '이벤트
        End If
        MyBase.WndProc(m)
    End Sub

    Public Sub ClipboardScanner()
        If Clipboard.ContainsText() Then
            Dim d = Clipboard.GetText()
            MsgBox(d)

        ElseIf Clipboard.ContainsFileDropList Then

            Dim fileCollection As StringCollection = Clipboard.GetFileDropList()

            For Each f In fileCollection
                MsgBox(f)
            Next
        End If
    End Sub
End Class
