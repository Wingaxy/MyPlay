<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbX = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tbMusics = New MetroFramework.Controls.MetroTabPage()
        Me.lbxMusic2 = New System.Windows.Forms.ListBox()
        Me.lbxMusic1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbVideos = New MetroFramework.Controls.MetroTabPage()
        Me.lbxVideo2 = New System.Windows.Forms.ListBox()
        Me.lbxVideo1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.tbMusics.SuspendLayout()
        Me.tbVideos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lbX)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(482, 50)
        Me.Panel1.TabIndex = 0
        '
        'lbX
        '
        Me.lbX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbX.AutoSize = True
        Me.lbX.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbX.ForeColor = System.Drawing.Color.White
        Me.lbX.Location = New System.Drawing.Point(451, 9)
        Me.lbX.Name = "lbX"
        Me.lbX.Size = New System.Drawing.Size(27, 31)
        Me.lbX.TabIndex = 0
        Me.lbX.Text = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Library"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTabControl1.Controls.Add(Me.tbMusics)
        Me.MetroTabControl1.Controls.Add(Me.tbVideos)
        Me.MetroTabControl1.Location = New System.Drawing.Point(1, 61)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(482, 312)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTabControl1.TabIndex = 1
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tbMusics
        '
        Me.tbMusics.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbMusics.Controls.Add(Me.lbxMusic2)
        Me.tbMusics.Controls.Add(Me.lbxMusic1)
        Me.tbMusics.Controls.Add(Me.Button1)
        Me.tbMusics.HorizontalScrollbarBarColor = True
        Me.tbMusics.Location = New System.Drawing.Point(4, 35)
        Me.tbMusics.Name = "tbMusics"
        Me.tbMusics.Size = New System.Drawing.Size(474, 273)
        Me.tbMusics.Style = MetroFramework.MetroColorStyle.Silver
        Me.tbMusics.TabIndex = 0
        Me.tbMusics.Text = "Musics"
        Me.tbMusics.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tbMusics.VerticalScrollbarBarColor = True
        '
        'lbxMusic2
        '
        Me.lbxMusic2.FormattingEnabled = True
        Me.lbxMusic2.Location = New System.Drawing.Point(401, 12)
        Me.lbxMusic2.Name = "lbxMusic2"
        Me.lbxMusic2.Size = New System.Drawing.Size(56, 17)
        Me.lbxMusic2.TabIndex = 5
        Me.lbxMusic2.Visible = False
        '
        'lbxMusic1
        '
        Me.lbxMusic1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbxMusic1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lbxMusic1.ForeColor = System.Drawing.Color.White
        Me.lbxMusic1.FormattingEnabled = True
        Me.lbxMusic1.Location = New System.Drawing.Point(5, 42)
        Me.lbxMusic1.Name = "lbxMusic1"
        Me.lbxMusic1.Size = New System.Drawing.Size(466, 225)
        Me.lbxMusic1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(5, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tbVideos
        '
        Me.tbVideos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbVideos.Controls.Add(Me.lbxVideo2)
        Me.tbVideos.Controls.Add(Me.lbxVideo1)
        Me.tbVideos.Controls.Add(Me.Button2)
        Me.tbVideos.HorizontalScrollbarBarColor = True
        Me.tbVideos.Location = New System.Drawing.Point(4, 35)
        Me.tbVideos.Name = "tbVideos"
        Me.tbVideos.Size = New System.Drawing.Size(474, 273)
        Me.tbVideos.Style = MetroFramework.MetroColorStyle.Silver
        Me.tbVideos.TabIndex = 1
        Me.tbVideos.Text = "Videos"
        Me.tbVideos.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tbVideos.VerticalScrollbarBarColor = True
        '
        'lbxVideo2
        '
        Me.lbxVideo2.FormattingEnabled = True
        Me.lbxVideo2.Location = New System.Drawing.Point(400, 9)
        Me.lbxVideo2.Name = "lbxVideo2"
        Me.lbxVideo2.Size = New System.Drawing.Size(56, 17)
        Me.lbxVideo2.TabIndex = 7
        Me.lbxVideo2.Visible = False
        '
        'lbxVideo1
        '
        Me.lbxVideo1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbxVideo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lbxVideo1.ForeColor = System.Drawing.Color.White
        Me.lbxVideo1.FormattingEnabled = True
        Me.lbxVideo1.Location = New System.Drawing.Point(4, 39)
        Me.lbxVideo1.Name = "lbxVideo1"
        Me.lbxVideo1.Size = New System.Drawing.Size(466, 225)
        Me.lbxVideo1.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(4, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 377)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MinimumSize = New System.Drawing.Size(485, 377)
        Me.Name = "frmList"
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Text = "Library"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tbMusics.ResumeLayout(False)
        Me.tbVideos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbX As Label
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tbMusics As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tbVideos As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lbxMusic2 As ListBox
    Friend WithEvents lbxMusic1 As ListBox
    Friend WithEvents lbxVideo2 As ListBox
    Friend WithEvents lbxVideo1 As ListBox
End Class
