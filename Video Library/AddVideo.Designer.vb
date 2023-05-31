<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddVideo
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddVideo))
        Me.BtnAddVideo = New System.Windows.Forms.Button()
        Me.TbxTitle = New System.Windows.Forms.TextBox()
        Me.TbxReleaseDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblMenu = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.PictureBox()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnExplore = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.TbxSearch = New System.Windows.Forms.TextBox()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PbxSignOut = New System.Windows.Forms.PictureBox()
        Me.PbxExit = New System.Windows.Forms.PictureBox()
        Me.PbxAdd = New System.Windows.Forms.PictureBox()
        Me.PbxExplore = New System.Windows.Forms.PictureBox()
        Me.PbxHome = New System.Windows.Forms.PictureBox()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.CbxGenre = New System.Windows.Forms.ComboBox()
        Me.TbxGenre = New System.Windows.Forms.TextBox()
        Me.BtnAddGenre = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbxClassification = New System.Windows.Forms.ComboBox()
        Me.PbxR = New System.Windows.Forms.PictureBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.PbxMA = New System.Windows.Forms.PictureBox()
        Me.PbxM = New System.Windows.Forms.PictureBox()
        Me.PbxG = New System.Windows.Forms.PictureBox()
        Me.PbxPG = New System.Windows.Forms.PictureBox()
        Me.PbxCTC = New System.Windows.Forms.PictureBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSettings = New System.Windows.Forms.Button()
        Me.PbxEdit = New System.Windows.Forms.PictureBox()
        Me.PbxSettings = New System.Windows.Forms.PictureBox()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxSignOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxExplore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxPG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxCTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAddVideo
        '
        Me.BtnAddVideo.Location = New System.Drawing.Point(1170, 834)
        Me.BtnAddVideo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAddVideo.Name = "BtnAddVideo"
        Me.BtnAddVideo.Size = New System.Drawing.Size(141, 55)
        Me.BtnAddVideo.TabIndex = 4
        Me.BtnAddVideo.Text = "Add New Video"
        Me.BtnAddVideo.UseVisualStyleBackColor = True
        '
        'TbxTitle
        '
        Me.TbxTitle.Location = New System.Drawing.Point(772, 292)
        Me.TbxTitle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TbxTitle.MaxLength = 50
        Me.TbxTitle.Name = "TbxTitle"
        Me.TbxTitle.Size = New System.Drawing.Size(334, 26)
        Me.TbxTitle.TabIndex = 1
        '
        'TbxReleaseDate
        '
        Me.TbxReleaseDate.Location = New System.Drawing.Point(815, 542)
        Me.TbxReleaseDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TbxReleaseDate.MaxLength = 4
        Me.TbxReleaseDate.Name = "TbxReleaseDate"
        Me.TbxReleaseDate.Size = New System.Drawing.Size(238, 26)
        Me.TbxReleaseDate.TabIndex = 3
        Me.TbxReleaseDate.Text = "YYYY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(519, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(494, 108)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Add Video"
        '
        'LblMenu
        '
        Me.LblMenu.AutoSize = True
        Me.LblMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMenu.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblMenu.Location = New System.Drawing.Point(45, 25)
        Me.LblMenu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMenu.Name = "LblMenu"
        Me.LblMenu.Size = New System.Drawing.Size(136, 52)
        Me.LblMenu.TabIndex = 143
        Me.LblMenu.Text = "Menu"
        '
        'BtnSearch
        '
        Me.BtnSearch.ErrorImage = CType(resources.GetObject("BtnSearch.ErrorImage"), System.Drawing.Image)
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(1280, 34)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(45, 46)
        Me.BtnSearch.TabIndex = 142
        Me.BtnSearch.TabStop = False
        '
        'BtnLogout
        '
        Me.BtnLogout.AutoSize = True
        Me.BtnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnLogout.Location = New System.Drawing.Point(93, 728)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(203, 68)
        Me.BtnLogout.TabIndex = 137
        Me.BtnLogout.Text = "Sign-out"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.AutoSize = True
        Me.BtnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnExit.Location = New System.Drawing.Point(93, 834)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(150, 68)
        Me.BtnExit.TabIndex = 136
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.AutoSize = True
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnAdd.Location = New System.Drawing.Point(93, 292)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(113, 68)
        Me.BtnAdd.TabIndex = 131
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnExplore
        '
        Me.BtnExplore.AutoSize = True
        Me.BtnExplore.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnExplore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnExplore.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnExplore.FlatAppearance.BorderSize = 0
        Me.BtnExplore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExplore.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExplore.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnExplore.Location = New System.Drawing.Point(93, 202)
        Me.BtnExplore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExplore.Name = "BtnExplore"
        Me.BtnExplore.Size = New System.Drawing.Size(188, 68)
        Me.BtnExplore.TabIndex = 130
        Me.BtnExplore.Text = "Explore"
        Me.BtnExplore.UseVisualStyleBackColor = False
        '
        'BtnHome
        '
        Me.BtnHome.AutoSize = True
        Me.BtnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnHome.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnHome.FlatAppearance.BorderSize = 0
        Me.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnHome.Location = New System.Drawing.Point(93, 105)
        Me.BtnHome.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(154, 68)
        Me.BtnHome.TabIndex = 128
        Me.BtnHome.Text = "Home"
        Me.BtnHome.UseVisualStyleBackColor = False
        '
        'TbxSearch
        '
        Me.TbxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxSearch.Location = New System.Drawing.Point(1030, 34)
        Me.TbxSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TbxSearch.Name = "TbxSearch"
        Me.TbxSearch.Size = New System.Drawing.Size(238, 40)
        Me.TbxSearch.TabIndex = 127
        '
        'PbxLogo
        '
        Me.PbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbxLogo.Image = CType(resources.GetObject("PbxLogo.Image"), System.Drawing.Image)
        Me.PbxLogo.Location = New System.Drawing.Point(330, 25)
        Me.PbxLogo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(149, 153)
        Me.PbxLogo.TabIndex = 145
        Me.PbxLogo.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(393, 523)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(414, 47)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Year of Release Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(393, 386)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 47)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "Genre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(393, 285)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 47)
        Me.Label7.TabIndex = 151
        Me.Label7.Text = "Title"
        '
        'PbxSignOut
        '
        Me.PbxSignOut.Image = CType(resources.GetObject("PbxSignOut.Image"), System.Drawing.Image)
        Me.PbxSignOut.Location = New System.Drawing.Point(18, 732)
        Me.PbxSignOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxSignOut.Name = "PbxSignOut"
        Me.PbxSignOut.Size = New System.Drawing.Size(66, 68)
        Me.PbxSignOut.TabIndex = 159
        Me.PbxSignOut.TabStop = False
        '
        'PbxExit
        '
        Me.PbxExit.Image = CType(resources.GetObject("PbxExit.Image"), System.Drawing.Image)
        Me.PbxExit.Location = New System.Drawing.Point(18, 834)
        Me.PbxExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxExit.Name = "PbxExit"
        Me.PbxExit.Size = New System.Drawing.Size(66, 68)
        Me.PbxExit.TabIndex = 158
        Me.PbxExit.TabStop = False
        '
        'PbxAdd
        '
        Me.PbxAdd.Image = CType(resources.GetObject("PbxAdd.Image"), System.Drawing.Image)
        Me.PbxAdd.Location = New System.Drawing.Point(18, 292)
        Me.PbxAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxAdd.Name = "PbxAdd"
        Me.PbxAdd.Size = New System.Drawing.Size(66, 68)
        Me.PbxAdd.TabIndex = 157
        Me.PbxAdd.TabStop = False
        '
        'PbxExplore
        '
        Me.PbxExplore.Image = CType(resources.GetObject("PbxExplore.Image"), System.Drawing.Image)
        Me.PbxExplore.Location = New System.Drawing.Point(18, 202)
        Me.PbxExplore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxExplore.Name = "PbxExplore"
        Me.PbxExplore.Size = New System.Drawing.Size(66, 68)
        Me.PbxExplore.TabIndex = 155
        Me.PbxExplore.TabStop = False
        '
        'PbxHome
        '
        Me.PbxHome.Image = CType(resources.GetObject("PbxHome.Image"), System.Drawing.Image)
        Me.PbxHome.Location = New System.Drawing.Point(18, 105)
        Me.PbxHome.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxHome.Name = "PbxHome"
        Me.PbxHome.Size = New System.Drawing.Size(66, 68)
        Me.PbxHome.TabIndex = 154
        Me.PbxHome.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 206
        Me.LineShape1.X2 = 206
        Me.LineShape1.Y1 = 28
        Me.LineShape1.Y2 = 580
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1368, 929)
        Me.ShapeContainer1.TabIndex = 161
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 215
        Me.LineShape3.X2 = 900
        Me.LineShape3.Y1 = 130
        Me.LineShape3.Y2 = 130
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 195
        Me.LineShape2.X2 = 19
        Me.LineShape2.Y1 = 55
        Me.LineShape2.Y2 = 55
        '
        'CbxGenre
        '
        Me.CbxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxGenre.FormattingEnabled = True
        Me.CbxGenre.Items.AddRange(New Object() {"Action", "Adventure", "Animation", "Comedy", "Crime", "Documentary", "Drama", "Experimental", "Family", "Fantasy", "Historical", "Horror", "Live-action", "Mystery", "Philosophical", "Political", "Romance", "Science Fiction", "Superhero", "Thriller", "War", "Western"})
        Me.CbxGenre.Location = New System.Drawing.Point(1114, 403)
        Me.CbxGenre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CbxGenre.Name = "CbxGenre"
        Me.CbxGenre.Size = New System.Drawing.Size(180, 28)
        Me.CbxGenre.TabIndex = 162
        '
        'TbxGenre
        '
        Me.TbxGenre.Location = New System.Drawing.Point(772, 405)
        Me.TbxGenre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TbxGenre.MaxLength = 30
        Me.TbxGenre.Multiline = True
        Me.TbxGenre.Name = "TbxGenre"
        Me.TbxGenre.Size = New System.Drawing.Size(238, 59)
        Me.TbxGenre.TabIndex = 163
        Me.TbxGenre.Text = "XXX, YYY, ZZZ"
        '
        'BtnAddGenre
        '
        Me.BtnAddGenre.Location = New System.Drawing.Point(1184, 445)
        Me.BtnAddGenre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAddGenre.Name = "BtnAddGenre"
        Me.BtnAddGenre.Size = New System.Drawing.Size(112, 35)
        Me.BtnAddGenre.TabIndex = 164
        Me.BtnAddGenre.Text = "Add Genre"
        Me.BtnAddGenre.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(393, 637)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 47)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "Movie Classification"
        '
        'CbxClassification
        '
        Me.CbxClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxClassification.FormattingEnabled = True
        Me.CbxClassification.Items.AddRange(New Object() {"G", "PG", "M", "MA 15+", "R 18+"})
        Me.CbxClassification.Location = New System.Drawing.Point(815, 646)
        Me.CbxClassification.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CbxClassification.Name = "CbxClassification"
        Me.CbxClassification.Size = New System.Drawing.Size(130, 28)
        Me.CbxClassification.TabIndex = 166
        '
        'PbxR
        '
        Me.PbxR.Image = CType(resources.GetObject("PbxR.Image"), System.Drawing.Image)
        Me.PbxR.Location = New System.Drawing.Point(1056, 637)
        Me.PbxR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxR.Name = "PbxR"
        Me.PbxR.Size = New System.Drawing.Size(135, 138)
        Me.PbxR.TabIndex = 167
        Me.PbxR.TabStop = False
        Me.PbxR.Visible = False
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(1020, 834)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(141, 55)
        Me.BtnClear.TabIndex = 168
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'PbxMA
        '
        Me.PbxMA.Image = CType(resources.GetObject("PbxMA.Image"), System.Drawing.Image)
        Me.PbxMA.Location = New System.Drawing.Point(1056, 637)
        Me.PbxMA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxMA.Name = "PbxMA"
        Me.PbxMA.Size = New System.Drawing.Size(135, 138)
        Me.PbxMA.TabIndex = 169
        Me.PbxMA.TabStop = False
        Me.PbxMA.Visible = False
        '
        'PbxM
        '
        Me.PbxM.Image = CType(resources.GetObject("PbxM.Image"), System.Drawing.Image)
        Me.PbxM.Location = New System.Drawing.Point(1056, 637)
        Me.PbxM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxM.Name = "PbxM"
        Me.PbxM.Size = New System.Drawing.Size(135, 138)
        Me.PbxM.TabIndex = 170
        Me.PbxM.TabStop = False
        Me.PbxM.Visible = False
        '
        'PbxG
        '
        Me.PbxG.Image = CType(resources.GetObject("PbxG.Image"), System.Drawing.Image)
        Me.PbxG.Location = New System.Drawing.Point(1056, 637)
        Me.PbxG.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxG.Name = "PbxG"
        Me.PbxG.Size = New System.Drawing.Size(135, 138)
        Me.PbxG.TabIndex = 171
        Me.PbxG.TabStop = False
        Me.PbxG.Visible = False
        '
        'PbxPG
        '
        Me.PbxPG.Image = CType(resources.GetObject("PbxPG.Image"), System.Drawing.Image)
        Me.PbxPG.Location = New System.Drawing.Point(1056, 637)
        Me.PbxPG.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxPG.Name = "PbxPG"
        Me.PbxPG.Size = New System.Drawing.Size(135, 138)
        Me.PbxPG.TabIndex = 172
        Me.PbxPG.TabStop = False
        Me.PbxPG.Visible = False
        '
        'PbxCTC
        '
        Me.PbxCTC.Image = CType(resources.GetObject("PbxCTC.Image"), System.Drawing.Image)
        Me.PbxCTC.Location = New System.Drawing.Point(1056, 637)
        Me.PbxCTC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxCTC.Name = "PbxCTC"
        Me.PbxCTC.Size = New System.Drawing.Size(135, 138)
        Me.PbxCTC.TabIndex = 173
        Me.PbxCTC.TabStop = False
        '
        'BtnEdit
        '
        Me.BtnEdit.AutoSize = True
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnEdit.Location = New System.Drawing.Point(93, 394)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(112, 68)
        Me.BtnEdit.TabIndex = 175
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnSettings
        '
        Me.BtnSettings.AutoSize = True
        Me.BtnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnSettings.FlatAppearance.BorderSize = 0
        Me.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSettings.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnSettings.Location = New System.Drawing.Point(93, 491)
        Me.BtnSettings.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(198, 68)
        Me.BtnSettings.TabIndex = 174
        Me.BtnSettings.Text = "Settings"
        Me.BtnSettings.UseVisualStyleBackColor = False
        '
        'PbxEdit
        '
        Me.PbxEdit.Image = CType(resources.GetObject("PbxEdit.Image"), System.Drawing.Image)
        Me.PbxEdit.Location = New System.Drawing.Point(18, 394)
        Me.PbxEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxEdit.Name = "PbxEdit"
        Me.PbxEdit.Size = New System.Drawing.Size(66, 68)
        Me.PbxEdit.TabIndex = 177
        Me.PbxEdit.TabStop = False
        '
        'PbxSettings
        '
        Me.PbxSettings.Image = CType(resources.GetObject("PbxSettings.Image"), System.Drawing.Image)
        Me.PbxSettings.Location = New System.Drawing.Point(18, 491)
        Me.PbxSettings.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxSettings.Name = "PbxSettings"
        Me.PbxSettings.Size = New System.Drawing.Size(66, 68)
        Me.PbxSettings.TabIndex = 176
        Me.PbxSettings.TabStop = False
        '
        'AddVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1368, 929)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.CbxClassification)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAddGenre)
        Me.Controls.Add(Me.TbxGenre)
        Me.Controls.Add(Me.CbxGenre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblMenu)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnExplore)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.TbxSearch)
        Me.Controls.Add(Me.PbxLogo)
        Me.Controls.Add(Me.TbxReleaseDate)
        Me.Controls.Add(Me.TbxTitle)
        Me.Controls.Add(Me.BtnAddVideo)
        Me.Controls.Add(Me.PbxSignOut)
        Me.Controls.Add(Me.PbxExit)
        Me.Controls.Add(Me.PbxAdd)
        Me.Controls.Add(Me.PbxExplore)
        Me.Controls.Add(Me.PbxHome)
        Me.Controls.Add(Me.PbxPG)
        Me.Controls.Add(Me.PbxG)
        Me.Controls.Add(Me.PbxM)
        Me.Controls.Add(Me.PbxMA)
        Me.Controls.Add(Me.PbxR)
        Me.Controls.Add(Me.BtnSettings)
        Me.Controls.Add(Me.PbxSettings)
        Me.Controls.Add(Me.PbxEdit)
        Me.Controls.Add(Me.PbxCTC)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AddVideo"
        Me.Text = " Video Collection Library"
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxSignOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxExplore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxPG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxCTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAddVideo As System.Windows.Forms.Button
    Friend WithEvents TbxTitle As System.Windows.Forms.TextBox
    Friend WithEvents TbxReleaseDate As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents LblMenu As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.PictureBox
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnExplore As System.Windows.Forms.Button
    Friend WithEvents BtnHome As System.Windows.Forms.Button
    Friend WithEvents TbxSearch As System.Windows.Forms.TextBox
    Public WithEvents PbxLogo As System.Windows.Forms.PictureBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PbxSignOut As System.Windows.Forms.PictureBox
    Friend WithEvents PbxExit As System.Windows.Forms.PictureBox
    Friend WithEvents PbxAdd As System.Windows.Forms.PictureBox
    Friend WithEvents PbxExplore As System.Windows.Forms.PictureBox
    Friend WithEvents PbxHome As System.Windows.Forms.PictureBox
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents CbxGenre As System.Windows.Forms.ComboBox
    Friend WithEvents TbxGenre As System.Windows.Forms.TextBox
    Friend WithEvents BtnAddGenre As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CbxClassification As System.Windows.Forms.ComboBox
    Friend WithEvents PbxR As System.Windows.Forms.PictureBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents PbxMA As System.Windows.Forms.PictureBox
    Friend WithEvents PbxM As System.Windows.Forms.PictureBox
    Friend WithEvents PbxG As System.Windows.Forms.PictureBox
    Friend WithEvents PbxPG As System.Windows.Forms.PictureBox
    Friend WithEvents PbxCTC As System.Windows.Forms.PictureBox
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnSettings As System.Windows.Forms.Button
    Friend WithEvents PbxEdit As System.Windows.Forms.PictureBox
    Friend WithEvents PbxSettings As System.Windows.Forms.PictureBox
End Class
