Imports System.Collections.Specialized

Public Class Form1
    Private Const WM_DRAWCLIPBOARD As Integer = &H308
    Private Declare Function SetClipboardViewer Lib "user32" Alias "SetClipboardViewer" (ByVal hwnd As Integer) As Integer
    Dim result As Integer = SetClipboardViewer(MyBase.Handle.ToInt32)

    Public prevStrData As String = Nothing
    Public prevFileData As New StringCollection

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_DRAWCLIPBOARD Then

            ClipboardScanner()
        End If
        MyBase.WndProc(m)
    End Sub

    Public Sub ClipboardScanner()
        If Clipboard.ContainsText() Then
            Dim d = Clipboard.GetText()

            If Not prevStrData = d Then
                Popup.Close()
                Popup.mode = "txt"
                Popup.txtdata = d
                Popup.Show()
            End If

            prevStrData = d

        ElseIf Clipboard.ContainsFileDropList Then

            Dim fileCollection As StringCollection = Clipboard.GetFileDropList()

            If Not fileCollection.Equals(prevFileData) And Not prevFileData Is Nothing Then

                Popup.Close()
                Popup.mode = "file"
                Popup.filedata = fileCollection
                Popup.Show()

            End If

            prevFileData = fileCollection

        Else

            Popup.mode = ""
        End If
    End Sub
End Class
