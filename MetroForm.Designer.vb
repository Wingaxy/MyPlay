<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MetroForm
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MetroForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btList = New MetroFramework.Controls.MetroButton()
        Me.btMinimize = New MetroFramework.Controls.MetroButton()
        Me.btMaximize = New MetroFramework.Controls.MetroButton()
        Me.btExit = New MetroFramework.Controls.MetroButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.LabelPos = New System.Windows.Forms.Label()
        Me.SpeedPanel = New System.Windows.Forms.Panel()
        Me.Speedvaluelabel = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbxSafeName = New System.Windows.Forms.ListBox()
        Me.lbxLocation = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mlOpenList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mlOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mlPrevious = New System.Windows.Forms.ToolStripMenuItem()
        Me.mlMext = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mlSpeed = New System.Windows.Forms.ToolStripMenuItem()
        Me.mlLibrary = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mlPS = New System.Windows.Forms.ToolStripMenuItem()
        Me.mlRS = New System.Windows.Forms.ToolStripMenuItem()
        Me.mlCL = New System.Windows.Forms.ToolStripMenuItem()
        Me.mlSL = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.ButtonOpen = New System.Windows.Forms.Button()
        Me.ButtonRew = New System.Windows.Forms.Button()
        Me.ButtonFstFrwrd = New System.Windows.Forms.Button()
        Me.ButtoPlayPause = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.ElementHost1 = New System.Windows.Forms.Integration.ElementHost()
        Me.AxPlayer1 = New MyPlayBetaMetro.UserControl1()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SpeedPanel.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btList)
        Me.Panel1.Controls.Add(Me.btMinimize)
        Me.Panel1.Controls.Add(Me.btMaximize)
        Me.Panel1.Controls.Add(Me.btExit)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pbLogo)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 64)
        Me.Panel1.TabIndex = 0
        '
        'btList
        '
        Me.btList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btList.Location = New System.Drawing.Point(439, 5)
        Me.btList.Name = "btList"
        Me.btList.Size = New System.Drawing.Size(25, 23)
        Me.btList.Style = MetroFramework.MetroColorStyle.Silver
        Me.btList.TabIndex = 3
        Me.btList.Text = "■"
        Me.btList.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btMinimize
        '
        Me.btMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btMinimize.Location = New System.Drawing.Point(470, 5)
        Me.btMinimize.Name = "btMinimize"
        Me.btMinimize.Size = New System.Drawing.Size(25, 23)
        Me.btMinimize.Style = MetroFramework.MetroColorStyle.Silver
        Me.btMinimize.TabIndex = 3
        Me.btMinimize.Text = "&_"
        Me.btMinimize.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btMaximize
        '
        Me.btMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btMaximize.Location = New System.Drawing.Point(501, 5)
        Me.btMaximize.Name = "btMaximize"
        Me.btMaximize.Size = New System.Drawing.Size(25, 23)
        Me.btMaximize.Style = MetroFramework.MetroColorStyle.Silver
        Me.btMaximize.TabIndex = 3
        Me.btMaximize.Text = "□"
        Me.btMaximize.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btExit
        '
        Me.btExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btExit.Location = New System.Drawing.Point(532, 5)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(25, 23)
        Me.btExit.Style = MetroFramework.MetroColorStyle.Silver
        Me.btExit.TabIndex = 3
        Me.btExit.Text = "X"
        Me.btExit.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "<nomedia>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MyPlay"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LabelStatus)
        Me.Panel2.Controls.Add(Me.LabelPos)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.ButtonStop)
        Me.Panel2.Controls.Add(Me.ButtonOpen)
        Me.Panel2.Controls.Add(Me.ButtonRew)
        Me.Panel2.Controls.Add(Me.ButtonFstFrwrd)
        Me.Panel2.Controls.Add(Me.ButtoPlayPause)
        Me.Panel2.Location = New System.Drawing.Point(0, 368)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(560, 58)
        Me.Panel2.TabIndex = 1
        '
        'LabelStatus
        '
        Me.LabelStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelStatus.AutoEllipsis = True
        Me.LabelStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabelStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelStatus.Location = New System.Drawing.Point(484, 5)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(73, 48)
        Me.LabelStatus.TabIndex = 8
        Me.LabelStatus.Text = "Loading..."
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelStatus.Visible = False
        '
        'LabelPos
        '
        Me.LabelPos.AutoEllipsis = True
        Me.LabelPos.BackColor = System.Drawing.Color.Transparent
        Me.LabelPos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelPos.Location = New System.Drawing.Point(3, 6)
        Me.LabelPos.Name = "LabelPos"
        Me.LabelPos.Size = New System.Drawing.Size(76, 48)
        Me.LabelPos.TabIndex = 7
        Me.LabelPos.Text = "00:00:00"
        Me.LabelPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SpeedPanel
        '
        Me.SpeedPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SpeedPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SpeedPanel.Controls.Add(Me.Speedvaluelabel)
        Me.SpeedPanel.Controls.Add(Me.TrackBar1)
        Me.SpeedPanel.Controls.Add(Me.Label3)
        Me.SpeedPanel.Controls.Add(Me.PictureBox4)
        Me.SpeedPanel.Controls.Add(Me.PictureBox5)
        Me.SpeedPanel.Controls.Add(Me.Button1)
        Me.SpeedPanel.Location = New System.Drawing.Point(232, 35)
        Me.SpeedPanel.Name = "SpeedPanel"
        Me.SpeedPanel.Size = New System.Drawing.Size(325, 31)
        Me.SpeedPanel.TabIndex = 6
        Me.SpeedPanel.Visible = False
        '
        'Speedvaluelabel
        '
        Me.Speedvaluelabel.BackColor = System.Drawing.Color.DimGray
        Me.Speedvaluelabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.Speedvaluelabel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Speedvaluelabel.ForeColor = System.Drawing.Color.White
        Me.Speedvaluelabel.Location = New System.Drawing.Point(66, 1)
        Me.Speedvaluelabel.Name = "Speedvaluelabel"
        Me.Speedvaluelabel.Size = New System.Drawing.Size(51, 29)
        Me.Speedvaluelabel.TabIndex = 4
        Me.Speedvaluelabel.Text = "x1"
        Me.Speedvaluelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.Location = New System.Drawing.Point(123, 3)
        Me.TrackBar1.Maximum = 6
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(157, 21)
        Me.TrackBar1.TabIndex = 3
        Me.TrackBar1.Value = 1
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Speed"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbxSafeName
        '
        Me.lbxSafeName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbxSafeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lbxSafeName.ForeColor = System.Drawing.Color.White
        Me.lbxSafeName.FormattingEnabled = True
        Me.lbxSafeName.Location = New System.Drawing.Point(0, 65)
        Me.lbxSafeName.Name = "lbxSafeName"
        Me.lbxSafeName.Size = New System.Drawing.Size(560, 303)
        Me.lbxSafeName.TabIndex = 7
        Me.lbxSafeName.Visible = False
        '
        'lbxLocation
        '
        Me.lbxLocation.FormattingEnabled = True
        Me.lbxLocation.Location = New System.Drawing.Point(76, 65)
        Me.lbxLocation.Name = "lbxLocation"
        Me.lbxLocation.Size = New System.Drawing.Size(72, 17)
        Me.lbxLocation.TabIndex = 8
        Me.lbxLocation.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mlOpenList, Me.mlOpen, Me.ToolStripSeparator1, Me.mlPrevious, Me.mlMext, Me.ToolStripSeparator2, Me.mlSpeed, Me.mlLibrary, Me.ToolStripSeparator3, Me.mlPS, Me.mlRS, Me.mlCL, Me.mlSL})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(165, 242)
        '
        'mlOpenList
        '
        Me.mlOpenList.ForeColor = System.Drawing.Color.White
        Me.mlOpenList.Name = "mlOpenList"
        Me.mlOpenList.Size = New System.Drawing.Size(164, 22)
        Me.mlOpenList.Text = "Open List"
        '
        'mlOpen
        '
        Me.mlOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.mlOpen.ForeColor = System.Drawing.Color.White
        Me.mlOpen.Name = "mlOpen"
        Me.mlOpen.Size = New System.Drawing.Size(164, 22)
        Me.mlOpen.Text = "Open File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.White
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'mlPrevious
        '
        Me.mlPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.mlPrevious.ForeColor = System.Drawing.Color.White
        Me.mlPrevious.Name = "mlPrevious"
        Me.mlPrevious.Size = New System.Drawing.Size(164, 22)
        Me.mlPrevious.Text = "Previous"
        '
        'mlMext
        '
        Me.mlMext.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.mlMext.ForeColor = System.Drawing.Color.White
        Me.mlMext.Name = "mlMext"
        Me.mlMext.Size = New System.Drawing.Size(164, 22)
        Me.mlMext.Text = "Next"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ToolStripSeparator2.ForeColor = System.Drawing.Color.White
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(161, 6)
        '
        'mlSpeed
        '
        Me.mlSpeed.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.mlSpeed.ForeColor = System.Drawing.Color.White
        Me.mlSpeed.Name = "mlSpeed"
        Me.mlSpeed.Size = New System.Drawing.Size(164, 22)
        Me.mlSpeed.Text = "Speed"
        '
        'mlLibrary
        '
        Me.mlLibrary.ForeColor = System.Drawing.Color.White
        Me.mlLibrary.Name = "mlLibrary"
        Me.mlLibrary.Size = New System.Drawing.Size(164, 22)
        Me.mlLibrary.Text = "Library"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ToolStripSeparator3.ForeColor = System.Drawing.Color.White
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(161, 6)
        '
        'mlPS
        '
        Me.mlPS.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.mlPS.ForeColor = System.Drawing.Color.White
        Me.mlPS.Name = "mlPS"
        Me.mlPS.Size = New System.Drawing.Size(164, 22)
        Me.mlPS.Text = "Play Selected"
        '
        'mlRS
        '
        Me.mlRS.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.mlRS.ForeColor = System.Drawing.Color.White
        Me.mlRS.Name = "mlRS"
        Me.mlRS.Size = New System.Drawing.Size(164, 22)
        Me.mlRS.Text = "Remove Selected"
        '
        'mlCL
        '
        Me.mlCL.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.mlCL.ForeColor = System.Drawing.Color.White
        Me.mlCL.Name = "mlCL"
        Me.mlCL.Size = New System.Drawing.Size(164, 22)
        Me.mlCL.Text = "Clear List"
        '
        'mlSL
        '
        Me.mlSL.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.mlSL.ForeColor = System.Drawing.Color.White
        Me.mlSL.Name = "mlSL"
        Me.mlSL.Size = New System.Drawing.Size(164, 22)
        Me.mlSL.Text = "Save List"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(325, 1)
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox5.Location = New System.Drawing.Point(0, 30)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(325, 1)
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(276, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox3.Location = New System.Drawing.Point(0, 57)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(560, 1)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(560, 1)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'ButtonStop
        '
        Me.ButtonStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ButtonStop.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ButtonStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ButtonStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ButtonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStop.Image = Global.MyPlayBetaMetro.My.Resources.Resources.icon_stop_32
        Me.ButtonStop.Location = New System.Drawing.Point(377, 0)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(66, 58)
        Me.ButtonStop.TabIndex = 5
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'ButtonOpen
        '
        Me.ButtonOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ButtonOpen.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ButtonOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ButtonOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ButtonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOpen.Image = Global.MyPlayBetaMetro.My.Resources.Resources.icon_refresh_32
        Me.ButtonOpen.Location = New System.Drawing.Point(117, 0)
        Me.ButtonOpen.Name = "ButtonOpen"
        Me.ButtonOpen.Size = New System.Drawing.Size(66, 58)
        Me.ButtonOpen.TabIndex = 1
        Me.ButtonOpen.UseVisualStyleBackColor = True
        '
        'ButtonRew
        '
        Me.ButtonRew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ButtonRew.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ButtonRew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ButtonRew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ButtonRew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRew.Image = Global.MyPlayBetaMetro.My.Resources.Resources.icon_ios7_rewind_48
        Me.ButtonRew.Location = New System.Drawing.Point(182, 0)
        Me.ButtonRew.Name = "ButtonRew"
        Me.ButtonRew.Size = New System.Drawing.Size(66, 58)
        Me.ButtonRew.TabIndex = 2
        Me.ButtonRew.UseVisualStyleBackColor = True
        '
        'ButtonFstFrwrd
        '
        Me.ButtonFstFrwrd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ButtonFstFrwrd.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ButtonFstFrwrd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ButtonFstFrwrd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ButtonFstFrwrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFstFrwrd.Image = Global.MyPlayBetaMetro.My.Resources.Resources.icon_ios7_fastforward_48
        Me.ButtonFstFrwrd.Location = New System.Drawing.Point(312, 0)
        Me.ButtonFstFrwrd.Name = "ButtonFstFrwrd"
        Me.ButtonFstFrwrd.Size = New System.Drawing.Size(66, 58)
        Me.ButtonFstFrwrd.TabIndex = 4
        Me.ButtonFstFrwrd.UseVisualStyleBackColor = True
        '
        'ButtoPlayPause
        '
        Me.ButtoPlayPause.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ButtoPlayPause.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ButtoPlayPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ButtoPlayPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ButtoPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtoPlayPause.Image = Global.MyPlayBetaMetro.My.Resources.Resources.icon_play_48
        Me.ButtoPlayPause.Location = New System.Drawing.Point(247, 0)
        Me.ButtoPlayPause.Name = "ButtoPlayPause"
        Me.ButtoPlayPause.Size = New System.Drawing.Size(66, 58)
        Me.ButtoPlayPause.TabIndex = 3
        Me.ButtoPlayPause.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.PictureBox1.Image = Global.MyPlayBetaMetro.My.Resources.Resources.settings_128
        Me.PictureBox1.Location = New System.Drawing.Point(408, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'pbLogo
        '
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(4, 4)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(46, 53)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'ElementHost1
        '
        Me.ElementHost1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ElementHost1.BackColor = System.Drawing.Color.Black
        Me.ElementHost1.Location = New System.Drawing.Point(0, 63)
        Me.ElementHost1.Name = "ElementHost1"
        Me.ElementHost1.Size = New System.Drawing.Size(560, 307)
        Me.ElementHost1.TabIndex = 2
        Me.ElementHost1.Text = "ElementHost1"
        Me.ElementHost1.Child = Me.AxPlayer1
        '
        'MetroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 426)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.lbxLocation)
        Me.Controls.Add(Me.SpeedPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbxSafeName)
        Me.Controls.Add(Me.ElementHost1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(560, 426)
        Me.Name = "MetroForm"
        Me.Text = "3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.SpeedPanel.ResumeLayout(False)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelStatus As Label
    Friend WithEvents LabelPos As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ButtonStop As Button
    Friend WithEvents ButtonOpen As Button
    Friend WithEvents ButtonRew As Button
    Friend WithEvents ButtonFstFrwrd As Button
    Friend WithEvents ButtoPlayPause As Button
    Friend WithEvents btMinimize As MetroFramework.Controls.MetroButton
    Friend WithEvents btMaximize As MetroFramework.Controls.MetroButton
    Friend WithEvents btExit As MetroFramework.Controls.MetroButton
    Friend WithEvents Label2 As Label
    Friend WithEvents ElementHost1 As Integration.ElementHost
    Friend AxPlayer1 As UserControl1
    Friend WithEvents btList As MetroFramework.Controls.MetroButton
    Friend WithEvents SpeedPanel As Panel
    Friend WithEvents Speedvaluelabel As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbxSafeName As ListBox
    Friend WithEvents lbxLocation As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents mlOpen As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mlPrevious As ToolStripMenuItem
    Friend WithEvents mlMext As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mlSpeed As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mlPS As ToolStripMenuItem
    Friend WithEvents mlRS As ToolStripMenuItem
    Friend WithEvents mlCL As ToolStripMenuItem
    Friend WithEvents mlSL As ToolStripMenuItem
    Friend WithEvents mlOpenList As ToolStripMenuItem
    Friend WithEvents mlLibrary As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
