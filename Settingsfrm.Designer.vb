<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settingsfrm
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Türkçe", "Wingaxy tarafından çevirilmiştir."}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"English", "Translated by Wingaxy."}, -1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settingsfrm))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbMain = New System.Windows.Forms.TabPage()
        Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.tbSettings = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.cbNotify = New MetroFramework.Controls.MetroCheckBox()
        Me.cbUpdates = New MetroFramework.Controls.MetroCheckBox()
        Me.tbAbout = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.tbMain.SuspendLayout()
        Me.tbSettings.SuspendLayout()
        Me.tbAbout.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tbMain)
        Me.TabControl1.Controls.Add(Me.tbSettings)
        Me.TabControl1.Controls.Add(Me.tbAbout)
        Me.TabControl1.Location = New System.Drawing.Point(-8, 40)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(396, 339)
        Me.TabControl1.TabIndex = 0
        '
        'tbMain
        '
        Me.tbMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.tbMain.Controls.Add(Me.MetroTile4)
        Me.tbMain.Controls.Add(Me.MetroTile1)
        Me.tbMain.Location = New System.Drawing.Point(4, 22)
        Me.tbMain.Name = "tbMain"
        Me.tbMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tbMain.Size = New System.Drawing.Size(388, 313)
        Me.tbMain.TabIndex = 0
        Me.tbMain.Text = "Main"
        '
        'MetroTile4
        '
        Me.MetroTile4.Location = New System.Drawing.Point(191, 23)
        Me.MetroTile4.Name = "MetroTile4"
        Me.MetroTile4.Size = New System.Drawing.Size(146, 112)
        Me.MetroTile4.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTile4.TabIndex = 0
        Me.MetroTile4.Text = "About"
        Me.MetroTile4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile4.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroTile1
        '
        Me.MetroTile1.Location = New System.Drawing.Point(24, 22)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(146, 109)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTile1.TabIndex = 0
        Me.MetroTile1.Text = "Settings"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tbSettings
        '
        Me.tbSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.tbSettings.Controls.Add(Me.Label3)
        Me.tbSettings.Controls.Add(Me.ListView1)
        Me.tbSettings.Controls.Add(Me.MetroLabel1)
        Me.tbSettings.Controls.Add(Me.MetroButton1)
        Me.tbSettings.Controls.Add(Me.cbNotify)
        Me.tbSettings.Controls.Add(Me.cbUpdates)
        Me.tbSettings.Location = New System.Drawing.Point(4, 22)
        Me.tbSettings.Name = "tbSettings"
        Me.tbSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSettings.Size = New System.Drawing.Size(388, 313)
        Me.tbSettings.TabIndex = 1
        Me.tbSettings.Text = "Settings"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NOTE: Translatios are not may be %100 true."
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackColor = System.Drawing.Color.DimGray
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.ListView1.Location = New System.Drawing.Point(7, 97)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(375, 210)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 197
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Info"
        Me.ColumnHeader2.Width = 182
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(7, 54)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Library : "
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(74, 53)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroButton1.TabIndex = 1
        Me.MetroButton1.Text = "Clear"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'cbNotify
        '
        Me.cbNotify.AutoSize = True
        Me.cbNotify.Location = New System.Drawing.Point(6, 32)
        Me.cbNotify.Name = "cbNotify"
        Me.cbNotify.Size = New System.Drawing.Size(202, 15)
        Me.cbNotify.Style = MetroFramework.MetroColorStyle.Silver
        Me.cbNotify.TabIndex = 0
        Me.cbNotify.Text = "Notify Me when There is a Update"
        Me.cbNotify.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbNotify.UseVisualStyleBackColor = True
        '
        'cbUpdates
        '
        Me.cbUpdates.AutoSize = True
        Me.cbUpdates.Location = New System.Drawing.Point(6, 11)
        Me.cbUpdates.Name = "cbUpdates"
        Me.cbUpdates.Size = New System.Drawing.Size(122, 15)
        Me.cbUpdates.Style = MetroFramework.MetroColorStyle.Silver
        Me.cbUpdates.TabIndex = 0
        Me.cbUpdates.Text = "Check For Updates"
        Me.cbUpdates.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbUpdates.UseVisualStyleBackColor = True
        '
        'tbAbout
        '
        Me.tbAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.tbAbout.Controls.Add(Me.TextBox1)
        Me.tbAbout.Controls.Add(Me.Label7)
        Me.tbAbout.Controls.Add(Me.Label6)
        Me.tbAbout.Controls.Add(Me.Label5)
        Me.tbAbout.Controls.Add(Me.PictureBox1)
        Me.tbAbout.Location = New System.Drawing.Point(4, 22)
        Me.tbAbout.Name = "tbAbout"
        Me.tbAbout.Size = New System.Drawing.Size(388, 313)
        Me.tbAbout.TabIndex = 4
        Me.tbAbout.Text = "About"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Enabled = False
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(4, 138)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(378, 172)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!)
        Me.Label7.Location = New System.Drawing.Point(145, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 18)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Wingaxy"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!)
        Me.Label6.Location = New System.Drawing.Point(144, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Codename:Metro(1.7BETA)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label5.Location = New System.Drawing.Point(144, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 31)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "MyPlay"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(-6, -13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 89)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 65)
        Me.Panel1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(348, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 31)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Main"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Settings"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(5, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 120)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Settingsfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 372)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MinimumSize = New System.Drawing.Size(380, 372)
        Me.Name = "Settingsfrm"
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Text = "Settings"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TabControl1.ResumeLayout(False)
        Me.tbMain.ResumeLayout(False)
        Me.tbSettings.ResumeLayout(False)
        Me.tbSettings.PerformLayout()
        Me.tbAbout.ResumeLayout(False)
        Me.tbAbout.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbMain As TabPage
    Friend WithEvents tbSettings As TabPage
    Friend WithEvents tbAbout As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents Label2 As Label
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cbNotify As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cbUpdates As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
End Class
