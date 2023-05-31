<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Explore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Explore))
        Me.LblMenu = New System.Windows.Forms.Label()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnExplore = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.PictureBox()
        Me.TbxSearch = New System.Windows.Forms.TextBox()
        Me.PbxSignOut = New System.Windows.Forms.PictureBox()
        Me.PbxExit = New System.Windows.Forms.PictureBox()
        Me.PbxAdd = New System.Windows.Forms.PictureBox()
        Me.PbxExplore = New System.Windows.Forms.PictureBox()
        Me.PbxHome = New System.Windows.Forms.PictureBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSettings = New System.Windows.Forms.Button()
        Me.PbxEdit = New System.Windows.Forms.PictureBox()
        Me.PbxSettings = New System.Windows.Forms.PictureBox()
        Me.LbxVideos = New System.Windows.Forms.ListBox()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxSignOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxExplore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.LblMenu.TabIndex = 98
        Me.LblMenu.Text = "Menu"
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
        Me.BtnLogout.Location = New System.Drawing.Point(100, 732)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(187, 68)
        Me.BtnLogout.TabIndex = 93
        Me.BtnLogout.Text = "Log-out"
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
        Me.BtnExit.Location = New System.Drawing.Point(100, 832)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(110, 72)
        Me.BtnExit.TabIndex = 92
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
        Me.BtnAdd.TabIndex = 87
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
        Me.BtnExplore.TabIndex = 86
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
        Me.BtnHome.TabIndex = 84
        Me.BtnHome.Text = "Home"
        Me.BtnHome.UseVisualStyleBackColor = False
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
        Me.ShapeContainer1.TabIndex = 99
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
        'PbxLogo
        '
        Me.PbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbxLogo.Image = CType(resources.GetObject("PbxLogo.Image"), System.Drawing.Image)
        Me.PbxLogo.Location = New System.Drawing.Point(330, 25)
        Me.PbxLogo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(149, 153)
        Me.PbxLogo.TabIndex = 102
        Me.PbxLogo.TabStop = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.AutoSize = True
        Me.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnRefresh.FlatAppearance.BorderSize = 0
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnRefresh.Location = New System.Drawing.Point(1137, 837)
        Me.BtnRefresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(114, 45)
        Me.BtnRefresh.TabIndex = 159
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(519, 58)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(376, 108)
        Me.Label5.TabIndex = 160
        Me.Label5.Text = "Explore"
        '
        'BtnSearch
        '
        Me.BtnSearch.ErrorImage = CType(resources.GetObject("BtnSearch.ErrorImage"), System.Drawing.Image)
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(1280, 34)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(45, 46)
        Me.BtnSearch.TabIndex = 162
        Me.BtnSearch.TabStop = False
        '
        'TbxSearch
        '
        Me.TbxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxSearch.Location = New System.Drawing.Point(1030, 34)
        Me.TbxSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TbxSearch.Name = "TbxSearch"
        Me.TbxSearch.Size = New System.Drawing.Size(238, 40)
        Me.TbxSearch.TabIndex = 161
        '
        'PbxSignOut
        '
        Me.PbxSignOut.Image = CType(resources.GetObject("PbxSignOut.Image"), System.Drawing.Image)
        Me.PbxSignOut.Location = New System.Drawing.Point(18, 731)
        Me.PbxSignOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxSignOut.Name = "PbxSignOut"
        Me.PbxSignOut.Size = New System.Drawing.Size(66, 68)
        Me.PbxSignOut.TabIndex = 168
        Me.PbxSignOut.TabStop = False
        '
        'PbxExit
        '
        Me.PbxExit.Image = CType(resources.GetObject("PbxExit.Image"), System.Drawing.Image)
        Me.PbxExit.Location = New System.Drawing.Point(18, 832)
        Me.PbxExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxExit.Name = "PbxExit"
        Me.PbxExit.Size = New System.Drawing.Size(66, 68)
        Me.PbxExit.TabIndex = 167
        Me.PbxExit.TabStop = False
        '
        'PbxAdd
        '
        Me.PbxAdd.Image = CType(resources.GetObject("PbxAdd.Image"), System.Drawing.Image)
        Me.PbxAdd.Location = New System.Drawing.Point(18, 291)
        Me.PbxAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxAdd.Name = "PbxAdd"
        Me.PbxAdd.Size = New System.Drawing.Size(66, 68)
        Me.PbxAdd.TabIndex = 166
        Me.PbxAdd.TabStop = False
        '
        'PbxExplore
        '
        Me.PbxExplore.Image = CType(resources.GetObject("PbxExplore.Image"), System.Drawing.Image)
        Me.PbxExplore.Location = New System.Drawing.Point(18, 200)
        Me.PbxExplore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxExplore.Name = "PbxExplore"
        Me.PbxExplore.Size = New System.Drawing.Size(66, 68)
        Me.PbxExplore.TabIndex = 164
        Me.PbxExplore.TabStop = False
        '
        'PbxHome
        '
        Me.PbxHome.Image = CType(resources.GetObject("PbxHome.Image"), System.Drawing.Image)
        Me.PbxHome.Location = New System.Drawing.Point(18, 103)
        Me.PbxHome.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxHome.Name = "PbxHome"
        Me.PbxHome.Size = New System.Drawing.Size(66, 68)
        Me.PbxHome.TabIndex = 163
        Me.PbxHome.TabStop = False
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
        Me.BtnEdit.TabIndex = 171
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
        Me.BtnSettings.TabIndex = 170
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
        Me.PbxEdit.TabIndex = 173
        Me.PbxEdit.TabStop = False
        '
        'PbxSettings
        '
        Me.PbxSettings.Image = CType(resources.GetObject("PbxSettings.Image"), System.Drawing.Image)
        Me.PbxSettings.Location = New System.Drawing.Point(18, 491)
        Me.PbxSettings.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxSettings.Name = "PbxSettings"
        Me.PbxSettings.Size = New System.Drawing.Size(66, 68)
        Me.PbxSettings.TabIndex = 172
        Me.PbxSettings.TabStop = False
        '
        'LbxVideos
        '
        Me.LbxVideos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbxVideos.FormattingEnabled = True
        Me.LbxVideos.ItemHeight = 47
        Me.LbxVideos.Items.AddRange(New Object() {"Sorry There Are No Videos Found"})
        Me.LbxVideos.Location = New System.Drawing.Point(357, 249)
        Me.LbxVideos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LbxVideos.Name = "LbxVideos"
        Me.LbxVideos.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.LbxVideos.Size = New System.Drawing.Size(966, 568)
        Me.LbxVideos.TabIndex = 199
        '
        'Explore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1368, 929)
        Me.Controls.Add(Me.LbxVideos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TbxSearch)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.PbxLogo)
        Me.Controls.Add(Me.LblMenu)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnExplore)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.PbxSignOut)
        Me.Controls.Add(Me.PbxExit)
        Me.Controls.Add(Me.PbxAdd)
        Me.Controls.Add(Me.PbxExplore)
        Me.Controls.Add(Me.PbxHome)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnSettings)
        Me.Controls.Add(Me.PbxEdit)
        Me.Controls.Add(Me.PbxSettings)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Explore"
        Me.Text = " Video Collection Library"
        CType(Me.PbxLogo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BtnSearch,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PbxSignOut,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PbxExit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PbxAdd,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PbxExplore,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PbxHome,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PbxEdit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PbxSettings,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Public WithEvents LblMenu As System.Windows.Forms.Label
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnExplore As System.Windows.Forms.Button
    Friend WithEvents BtnHome As System.Windows.Forms.Button
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Public WithEvents PbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.PictureBox
    Friend WithEvents TbxSearch As System.Windows.Forms.TextBox
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents PbxSignOut As System.Windows.Forms.PictureBox
    Friend WithEvents PbxExit As System.Windows.Forms.PictureBox
    Friend WithEvents PbxAdd As System.Windows.Forms.PictureBox
    Friend WithEvents PbxExplore As System.Windows.Forms.PictureBox
    Friend WithEvents PbxHome As System.Windows.Forms.PictureBox
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnSettings As System.Windows.Forms.Button
    Friend WithEvents PbxEdit As System.Windows.Forms.PictureBox
    Friend WithEvents PbxSettings As System.Windows.Forms.PictureBox
    Friend WithEvents LbxVideos As System.Windows.Forms.ListBox
End Class
