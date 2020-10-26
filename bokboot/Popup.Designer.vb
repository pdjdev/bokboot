<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Popup
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MainText = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FileMenuPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.OpenDirBT = New System.Windows.Forms.Button()
        Me.CopyDirBT = New System.Windows.Forms.Button()
        Me.TextMenuPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SaveToTxtBT = New System.Windows.Forms.Button()
        Me.OpenNotepadBT = New System.Windows.Forms.Button()
        Me.WebSearchBT = New System.Windows.Forms.Button()
        Me.PlainTextBT = New System.Windows.Forms.Button()
        Me.CloseBT = New System.Windows.Forms.Button()
        Me.MouseFadeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TimeoutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.FileMenuPanel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TextMenuPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
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
        'OpenDirBT
        '
        Me.OpenDirBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OpenDirBT.FlatAppearance.BorderSize = 0
        Me.OpenDirBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpenDirBT.Font = New System.Drawing.Font("맑은 고딕", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.OpenDirBT.ForeColor = System.Drawing.Color.White
        Me.OpenDirBT.Location = New System.Drawing.Point(317, 3)
        Me.OpenDirBT.Name = "OpenDirBT"
        Me.OpenDirBT.Size = New System.Drawing.Size(308, 46)
        Me.OpenDirBT.TabIndex = 2
        Me.OpenDirBT.Text = "탐색기로 위치 열기"
        Me.OpenDirBT.UseVisualStyleBackColor = True
        '
        'CopyDirBT
        '
        Me.CopyDirBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CopyDirBT.FlatAppearance.BorderSize = 0
        Me.CopyDirBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CopyDirBT.Font = New System.Drawing.Font("맑은 고딕", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CopyDirBT.ForeColor = System.Drawing.Color.White
        Me.CopyDirBT.Location = New System.Drawing.Point(3, 3)
        Me.CopyDirBT.Name = "CopyDirBT"
        Me.CopyDirBT.Size = New System.Drawing.Size(308, 46)
        Me.CopyDirBT.TabIndex = 1
        Me.CopyDirBT.Text = "디렉토리 텍스트 복사"
        Me.CopyDirBT.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel1.Controls.Add(Me.SaveToTxtBT, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OpenNotepadBT, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.WebSearchBT, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PlainTextBT, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(628, 52)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'SaveToTxtBT
        '
        Me.SaveToTxtBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaveToTxtBT.FlatAppearance.BorderSize = 0
        Me.SaveToTxtBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveToTxtBT.Font = New System.Drawing.Font("맑은 고딕", 10.2!)
        Me.SaveToTxtBT.ForeColor = System.Drawing.Color.White
        Me.SaveToTxtBT.Location = New System.Drawing.Point(474, 3)
        Me.SaveToTxtBT.Name = "SaveToTxtBT"
        Me.SaveToTxtBT.Size = New System.Drawing.Size(151, 46)
        Me.SaveToTxtBT.TabIndex = 3
        Me.SaveToTxtBT.Text = "명령줄 실행"
        Me.SaveToTxtBT.UseVisualStyleBackColor = True
        '
        'OpenNotepadBT
        '
        Me.OpenNotepadBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OpenNotepadBT.FlatAppearance.BorderSize = 0
        Me.OpenNotepadBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpenNotepadBT.Font = New System.Drawing.Font("맑은 고딕", 10.2!)
        Me.OpenNotepadBT.ForeColor = System.Drawing.Color.White
        Me.OpenNotepadBT.Location = New System.Drawing.Point(317, 3)
        Me.OpenNotepadBT.Name = "OpenNotepadBT"
        Me.OpenNotepadBT.Size = New System.Drawing.Size(151, 46)
        Me.OpenNotepadBT.TabIndex = 2
        Me.OpenNotepadBT.Text = "메모장으로 열기"
        Me.OpenNotepadBT.UseVisualStyleBackColor = True
        '
        'WebSearchBT
        '
        Me.WebSearchBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebSearchBT.FlatAppearance.BorderSize = 0
        Me.WebSearchBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WebSearchBT.Font = New System.Drawing.Font("맑은 고딕", 10.2!)
        Me.WebSearchBT.ForeColor = System.Drawing.Color.White
        Me.WebSearchBT.Location = New System.Drawing.Point(160, 3)
        Me.WebSearchBT.Name = "WebSearchBT"
        Me.WebSearchBT.Size = New System.Drawing.Size(151, 46)
        Me.WebSearchBT.TabIndex = 1
        Me.WebSearchBT.Text = "웹 검색"
        Me.WebSearchBT.UseVisualStyleBackColor = True
        '
        'PlainTextBT
        '
        Me.PlainTextBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlainTextBT.FlatAppearance.BorderSize = 0
        Me.PlainTextBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlainTextBT.Font = New System.Drawing.Font("맑은 고딕", 10.2!)
        Me.PlainTextBT.ForeColor = System.Drawing.Color.White
        Me.PlainTextBT.Location = New System.Drawing.Point(3, 3)
        Me.PlainTextBT.Name = "PlainTextBT"
        Me.PlainTextBT.Size = New System.Drawing.Size(151, 46)
        Me.PlainTextBT.TabIndex = 0
        Me.PlainTextBT.Text = "서식 지우기"
        Me.PlainTextBT.UseVisualStyleBackColor = True
        '
        'CloseBT
        '
        Me.CloseBT.FlatAppearance.BorderSize = 0
        Me.CloseBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBT.Font = New System.Drawing.Font("맑은 고딕", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CloseBT.Location = New System.Drawing.Point(573, 0)
        Me.CloseBT.Name = "CloseBT"
        Me.CloseBT.Size = New System.Drawing.Size(55, 32)
        Me.CloseBT.TabIndex = 2
        Me.CloseBT.Text = "Close"
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
        Me.TextMenuPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainText As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextMenuPanel As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SaveToTxtBT As Button
    Friend WithEvents OpenNotepadBT As Button
    Friend WithEvents WebSearchBT As Button
    Friend WithEvents PlainTextBT As Button
    Friend WithEvents FileMenuPanel As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents OpenDirBT As Button
    Friend WithEvents CopyDirBT As Button
    Friend WithEvents CloseBT As Button
    Friend WithEvents MouseFadeTimer As Timer
    Friend WithEvents TimeoutTimer As Timer
End Class
