Imports System.Collections.Specialized

Public Class Form1
    Private Const WM_DRAWCLIPBOARD As Integer = &H308
    Private Declare Function SetClipboardViewer Lib "user32" Alias "SetClipboardViewer" (ByVal hwnd As Integer) As Integer
    Dim result As Integer = SetClipboardViewer(MyBase.Handle.ToInt32)

    Private prevStrData As String = ""
    Private prevFileData As New StringCollection

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

            If Not prevStrData = d Then
                Popup.Show()
            End If

            prevStrData = d

        ElseIf Clipboard.ContainsFileDropList Then

            Dim fileCollection As StringCollection = Clipboard.GetFileDropList()

            If Not fileCollection.Equals(prevFileData) Then

                Dim flist As List(Of String) = fileCollection.Cast(Of String).ToList
                Popup.Show()

            End If

            prevFileData = fileCollection

        End If
    End Sub
End Class
