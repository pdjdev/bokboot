<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Popup
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MainText = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FileMenuPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.CopyDirBT = New System.Windows.Forms.Panel()
        Me.CopyDirBT_Icon = New System.Windows.Forms.Panel()
        Me.CopyDirBT_Label = New System.Windows.Forms.Label()
        Me.TextMenuPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OpenNotepadBT = New System.Windows.Forms.Panel()
        Me.OpenNotepadBT_Icon = New System.Windows.Forms.Panel()
        Me.OpenNotepadBT_Label = New System.Windows.Forms.Label()
        Me.ShellCMDBT = New System.Windows.Forms.Panel()
        Me.ShellCMDBT_Icon = New System.Windows.Forms.Panel()
        Me.ShellCMDBT_Label = New System.Windows.Forms.Label()
        Me.PlainTextBT = New System.Windows.Forms.Panel()
        Me.PlainTextBT_Icon = New System.Windows.Forms.Panel()
        Me.PlainTextBT_Label = New System.Windows.Forms.Label()
        Me.WebSearchBT = New System.Windows.Forms.Panel()
        Me.WebSearchBT_Icon = New System.Windows.Forms.Panel()
        Me.WebSearchBT_Label = New System.Windows.Forms.Label()
        Me.CloseBT = New System.Windows.Forms.Button()
        Me.MouseFadeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TimeoutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OpenDirBT = New System.Windows.Forms.Panel()
        Me.OpenDirBT_Icon = New System.Windows.Forms.Panel()
        Me.OpenDirBT_Label = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.FileMenuPanel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.CopyDirBT.SuspendLayout()
        Me.TextMenuPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.OpenNotepadBT.SuspendLayout()
        Me.ShellCMDBT.SuspendLayout()
        Me.PlainTextBT.SuspendLayout()
        Me.WebSearchBT.SuspendLayout()
        Me.OpenDirBT.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainText
        '
        Me.MainText.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MainText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainText.Font = New System.Drawing.Font("맑은 고딕 Semilight", 13.0!)
        Me.MainText.Location = New System.Drawing.Point(0, 0)
        Me.MainText.Margin = New System.Windows.Forms.Padding(0)
        Me.MainText.Name = "MainText"
        Me.MainText.Size = New System.Drawing.Size(628, 55)
        Me.MainText.TabIndex = 0
        Me.MainText.Text = "MainText"
        Me.MainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FileMenuPanel)
        Me.Panel1.Controls.Add(Me.TextMenuPanel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(628, 52)
        Me.Panel1.TabIndex = 1
        '
        'FileMenuPanel
        '
        Me.FileMenuPanel.Controls.Add(Me.TableLayoutPanel2)
        Me.FileMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileMenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.FileMenuPanel.Name = "FileMenuPanel"
        Me.FileMenuPanel.Size = New System.Drawing.Size(628, 52)
        Me.FileMenuPanel.TabIndex = 3
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.OpenDirBT, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CopyDirBT, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(628, 52)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'CopyDirBT
        '
        Me.CopyDirBT.Controls.Add(Me.CopyDirBT_Icon)
        Me.CopyDirBT.Controls.Add(Me.CopyDirBT_Label)
        Me.CopyDirBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CopyDirBT.Location = New System.Drawing.Point(3, 3)
        Me.CopyDirBT.Name = "CopyDirBT"
        Me.CopyDirBT.Padding = New System.Windows.Forms.Padding(10)
        Me.CopyDirBT.Size = New System.Drawing.Size(308, 46)
        Me.CopyDirBT.TabIndex = 4
        '
        'CopyDirBT_Icon
        '
        Me.CopyDirBT_Icon.BackgroundImage = Global.bokboot.My.Resources.Resources.icon_copydir
        Me.CopyDirBT_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CopyDirBT_Icon.Dock = System.Windows.Forms.DockStyle.Right
        Me.CopyDirBT_Icon.Location = New System.Drawing.Point(55, 10)
        Me.CopyDirBT_Icon.Name = "CopyDirBT_Icon"
        Me.CopyDirBT_Icon.Size = New System.Drawing.Size(33, 26)
        Me.CopyDirBT_Icon.TabIndex = 0
        '
        'CopyDirBT_Label
        '
        Me.CopyDirBT_Label.Dock = System.Windows.Forms.DockStyle.Right
        Me.CopyDirBT_Label.Font = New System.Drawing.Font("맑은 고딕", 9.5!)
        Me.CopyDirBT_Label.Location = New System.Drawing.Point(88, 10)
        Me.CopyDirBT_Label.Margin = New System.Windows.Forms.Padding(0)
        Me.CopyDirBT_Label.Name = "CopyDirBT_Label"
        Me.CopyDirBT_Label.Size = New System.Drawing.Size(210, 26)
        Me.CopyDirBT_Label.TabIndex = 0
        Me.CopyDirBT_Label.Text = "디렉토리 텍스트 복사"
        Me.CopyDirBT_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextMenuPanel
        '
        Me.TextMenuPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.TextMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextMenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.TextMenuPanel.Name = "TextMenuPanel"
        Me.TextMenuPanel.Size = New System.Drawing.Size(628, 52)
        Me.TextMenuPanel.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OpenNotepadBT, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ShellCMDBT, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PlainTextBT, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.WebSearchBT, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(628, 52)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OpenNotepadBT
        '
        Me.OpenNotepadBT.Controls.Add(Me.OpenNotepadBT_Icon)
        Me.OpenNotepadBT.Controls.Add(Me.OpenNotepadBT_Label)
        Me.OpenNotepadBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OpenNotepadBT.Location = New System.Drawing.Point(317, 3)
        Me.OpenNotepadBT.Name = "OpenNotepadBT"
        Me.OpenNotepadBT.Padding = New System.Windows.Forms.Padding(10)
        Me.OpenNotepadBT.Size = New System.Drawing.Size(151, 46)
        Me.OpenNotepadBT.TabIndex = 5
        '
        'OpenNotepadBT_Icon
        '
        Me.OpenNotepadBT_Icon.BackgroundImage = Global.bokboot.My.Resources.Resources.icon_notepad
        Me.OpenNotepadBT_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OpenNotepadBT_Icon.Dock = System.Windows.Forms.DockStyle.Right
        Me.OpenNotepadBT_Icon.Location = New System.Drawing.Point(12, 10)
        Me.OpenNotepadBT_Icon.Name = "OpenNotepadBT_Icon"
        Me.OpenNotepadBT_Icon.Size = New System.Drawing.Size(33, 26)
        Me.OpenNotepadBT_Icon.TabIndex = 0
        '
        'OpenNotepadBT_Label
        '
        Me.OpenNotepadBT_Label.Dock = System.Windows.Forms.DockStyle.Right
        Me.OpenNotepadBT_Label.Font = New System.Drawing.Font("맑은 고딕", 7.0!)
        Me.OpenNotepadBT_Label.Location = New System.Drawing.Point(45, 10)
        Me.OpenNotepadBT_Label.Margin = New System.Windows.Forms.Padding(0)
        Me.OpenNotepadBT_Label.Name = "OpenNotepadBT_Label"
        Me.OpenNotepadBT_Label.Size = New System.Drawing.Size(96, 26)
        Me.OpenNotepadBT_Label.TabIndex = 0
        Me.OpenNotepadBT_Label.Text = "메모장으로 열기"
        Me.OpenNotepadBT_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShellCMDBT
        '
        Me.ShellCMDBT.Controls.Add(Me.ShellCMDBT_Icon)
        Me.ShellCMDBT.Controls.Add(Me.ShellCMDBT_Label)
        Me.ShellCMDBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShellCMDBT.Location = New System.Drawing.Point(474, 3)
        Me.ShellCMDBT.Name = "ShellCMDBT"
        Me.ShellCMDBT.Padding = New System.Windows.Forms.Padding(10)
        Me.ShellCMDBT.Size = New System.Drawing.Size(151, 46)
        Me.ShellCMDBT.TabIndex = 6
        '
        'ShellCMDBT_Icon
        '
        Me.ShellCMDBT_Icon.BackgroundImage = Global.bokboot.My.Resources.Resources.icon_cmd
        Me.ShellCMDBT_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ShellCMDBT_Icon.Dock = System.Windows.Forms.DockStyle.Right
        Me.ShellCMDBT_Icon.Location = New System.Drawing.Point(12, 10)
        Me.ShellCMDBT_Icon.Name = "ShellCMDBT_Icon"
        Me.ShellCMDBT_Icon.Size = New System.Drawing.Size(33, 26)
        Me.ShellCMDBT_Icon.TabIndex = 0
        '
        'ShellCMDBT_Label
        '
        Me.ShellCMDBT_Label.Dock = System.Windows.Forms.DockStyle.Right
        Me.ShellCMDBT_Label.Font = New System.Drawing.Font("맑은 고딕", 9.5!)
        Me.ShellCMDBT_Label.Location = New System.Drawing.Point(45, 10)
        Me.ShellCMDBT_Label.Margin = New System.Windows.Forms.Padding(0)
        Me.ShellCMDBT_Label.Name = "ShellCMDBT_Label"
        Me.ShellCMDBT_Label.Size = New System.Drawing.Size(96, 26)
        Me.ShellCMDBT_Label.TabIndex = 0
        Me.ShellCMDBT_Label.Text = "명령줄 실행"
        Me.ShellCMDBT_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PlainTextBT
        '
        Me.PlainTextBT.Controls.Add(Me.PlainTextBT_Icon)
        Me.PlainTextBT.Controls.Add(Me.PlainTextBT_Label)
        Me.PlainTextBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlainTextBT.Location = New System.Drawing.Point(3, 3)
        Me.PlainTextBT.Name = "PlainTextBT"
        Me.PlainTextBT.Padding = New System.Windows.Forms.Padding(10)
        Me.PlainTextBT.Size = New System.Drawing.Size(151, 46)
        Me.PlainTextBT.TabIndex = 3
        '
        'PlainTextBT_Icon
        '
        Me.PlainTextBT_Icon.BackgroundImage = Global.bokboot.My.Resources.Resources.icon_rmtf
        Me.PlainTextBT_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PlainTextBT_Icon.Dock = System.Windows.Forms.DockStyle.Right
        Me.PlainTextBT_Icon.Location = New System.Drawing.Point(9, 10)
        Me.PlainTextBT_Icon.Name = "PlainTextBT_Icon"
        Me.PlainTextBT_Icon.Size = New System.Drawing.Size(33, 26)
        Me.PlainTextBT_Icon.TabIndex = 0
        '
        'PlainTextBT_Label
        '
        Me.PlainTextBT_Label.Dock = System.Windows.Forms.DockStyle.Right
        Me.PlainTextBT_Label.Font = New System.Drawing.Font("맑은 고딕", 9.5!)
        Me.PlainTextBT_Label.Location = New System.Drawing.Point(42, 10)
        Me.PlainTextBT_Label.Margin = New System.Windows.Forms.Padding(0)
        Me.PlainTextBT_Label.Name = "PlainTextBT_Label"
        Me.PlainTextBT_Label.Size = New System.Drawing.Size(99, 26)
        Me.PlainTextBT_Label.TabIndex = 0
        Me.PlainTextBT_Label.Text = "서식 지우기"
        Me.PlainTextBT_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WebSearchBT
        '
        Me.WebSearchBT.Controls.Add(Me.WebSearchBT_Icon)
        Me.WebSearchBT.Controls.Add(Me.WebSearchBT_Label)
        Me.WebSearchBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebSearchBT.Location = New System.Drawing.Point(160, 3)
        Me.WebSearchBT.Name = "WebSearchBT"
        Me.WebSearchBT.Padding = New System.Windows.Forms.Padding(10)
        Me.WebSearchBT.Size = New System.Drawing.Size(151, 46)
        Me.WebSearchBT.TabIndex = 4
        '
        'WebSearchBT_Icon
        '
        Me.WebSearchBT_Icon.BackgroundImage = Global.bokboot.My.Resources.Resources.icon_search
        Me.WebSearchBT_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.WebSearchBT_Icon.Dock = System.Windows.Forms.DockStyle.Right
        Me.WebSearchBT_Icon.Location = New System.Drawing.Point(28, 10)
        Me.WebSearchBT_Icon.Name = "WebSearchBT_Icon"
        Me.WebSearchBT_Icon.Size = New System.Drawing.Size(33, 26)
        Me.WebSearchBT_Icon.TabIndex = 0
        '
        'WebSearchBT_Label
        '
        Me.WebSearchBT_Label.Dock = System.Windows.Forms.DockStyle.Right
        Me.WebSearchBT_Label.Font = New System.Drawing.Font("맑은 고딕", 9.5!)
        Me.WebSearchBT_Label.Location = New System.Drawing.Point(61, 10)
        Me.WebSearchBT_Label.Margin = New System.Windows.Forms.Padding(0)
        Me.WebSearchBT_Label.Name = "WebSearchBT_Label"
        Me.WebSearchBT_Label.Size = New System.Drawing.Size(80, 26)
        Me.WebSearchBT_Label.TabIndex = 0
        Me.WebSearchBT_Label.Text = "웹 검색"
        Me.WebSearchBT_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CloseBT
        '
        Me.CloseBT.FlatAppearance.BorderSize = 0
        Me.CloseBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBT.Font = New System.Drawing.Font("맑은 고딕", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CloseBT.Location = New System.Drawing.Point(597, 0)
        Me.CloseBT.Name = "CloseBT"
        Me.CloseBT.Size = New System.Drawing.Size(31, 32)
        Me.CloseBT.TabIndex = 2
        Me.CloseBT.Text = "X"
        Me.CloseBT.UseVisualStyleBackColor = True
        '
        'MouseFadeTimer
        '
        Me.MouseFadeTimer.Enabled = True
        Me.MouseFadeTimer.Interval = 5000
        '
        'TimeoutTimer
        '
        Me.TimeoutTimer.Interval = 6000
        '
        'OpenDirBT
        '
        Me.OpenDirBT.Controls.Add(Me.OpenDirBT_Icon)
        Me.OpenDirBT.Controls.Add(Me.OpenDirBT_Label)
        Me.OpenDirBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OpenDirBT.Location = New System.Drawing.Point(317, 3)
        Me.OpenDirBT.Name = "OpenDirBT"
        Me.OpenDirBT.Padding = New System.Windows.Forms.Padding(10)
        Me.OpenDirBT.Size = New System.Drawing.Size(308, 46)
        Me.OpenDirBT.TabIndex = 5
        '
        'OpenDirBT_Icon
        '
        Me.OpenDirBT_Icon.BackgroundImage = Global.bokboot.My.Resources.Resources.icon_openexp
        Me.OpenDirBT_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OpenDirBT_Icon.Dock = System.Windows.Forms.DockStyle.Right
        Me.OpenDirBT_Icon.Location = New System.Drawing.Point(64, 10)
        Me.OpenDirBT_Icon.Name = "OpenDirBT_Icon"
        Me.OpenDirBT_Icon.Size = New System.Drawing.Size(33, 26)
        Me.OpenDirBT_Icon.TabIndex = 0
        '
        'OpenDirBT_Label
        '
        Me.OpenDirBT_Label.Dock = System.Windows.Forms.DockStyle.Right
        Me.OpenDirBT_Label.Font = New System.Drawing.Font("맑은 고딕", 9.5!)
        Me.OpenDirBT_Label.Location = New System.Drawing.Point(97, 10)
        Me.OpenDirBT_Label.Margin = New System.Windows.Forms.Padding(0)
        Me.OpenDirBT_Label.Name = "OpenDirBT_Label"
        Me.OpenDirBT_Label.Size = New System.Drawing.Size(201, 26)
        Me.OpenDirBT_Label.TabIndex = 0
        Me.OpenDirBT_Label.Text = "탐색기로 위치 열기"
        Me.OpenDirBT_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Popup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(628, 107)
        Me.Controls.Add(Me.CloseBT)
        Me.Controls.Add(Me.MainText)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = Global.bokboot.My.Resources.Resources.whiteicon_6xp_icon
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Popup"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Popup"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Panel1.ResumeLayout(False)
        Me.FileMenuPanel.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.CopyDirBT.ResumeLayout(False)
        Me.TextMenuPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.OpenNotepadBT.ResumeLayout(False)
        Me.ShellCMDBT.ResumeLayout(False)
        Me.PlainTextBT.ResumeLayout(False)
        Me.WebSearchBT.ResumeLayout(False)
        Me.OpenDirBT.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainText As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextMenuPanel As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FileMenuPanel As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents CloseBT As Button
    Friend WithEvents MouseFadeTimer As Timer
    Friend WithEvents TimeoutTimer As Timer
    Friend WithEvents PlainTextBT As Panel
    Friend WithEvents PlainTextBT_Icon As Panel
    Friend WithEvents PlainTextBT_Label As Label
    Friend WithEvents WebSearchBT As Panel
    Friend WithEvents WebSearchBT_Icon As Panel
    Friend WithEvents WebSearchBT_Label As Label
    Friend WithEvents OpenNotepadBT As Panel
    Friend WithEvents OpenNotepadBT_Icon As Panel
    Friend WithEvents OpenNotepadBT_Label As Label
    Friend WithEvents ShellCMDBT As Panel
    Friend WithEvents ShellCMDBT_Label As Label
    Friend WithEvents ShellCMDBT_Icon As Panel
    Friend WithEvents CopyDirBT As Panel
    Friend WithEvents CopyDirBT_Icon As Panel
    Friend WithEvents CopyDirBT_Label As Label
    Friend WithEvents OpenDirBT As Panel
    Friend WithEvents OpenDirBT_Icon As Panel
    Friend WithEvents OpenDirBT_Label As Label
End Class
