<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateDelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateDelete))
        Me.PbxCTC = New System.Windows.Forms.PictureBox()
        Me.CbxClassification = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGenre = New System.Windows.Forms.Button()
        Me.TbxGenre = New System.Windows.Forms.TextBox()
        Me.CbxGenre = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbxReleaseDate = New System.Windows.Forms.TextBox()
        Me.TbxTitle = New System.Windows.Forms.TextBox()
        Me.PbxPG = New System.Windows.Forms.PictureBox()
        Me.PbxG = New System.Windows.Forms.PictureBox()
        Me.PbxM = New System.Windows.Forms.PictureBox()
        Me.PbxMA = New System.Windows.Forms.PictureBox()
        Me.PbxR = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnUpdateVideo = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnReturn = New System.Windows.Forms.Button()
        CType(Me.PbxCTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxPG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PbxCTC
        '
        Me.PbxCTC.Image = CType(resources.GetObject("PbxCTC.Image"), System.Drawing.Image)
        Me.PbxCTC.Location = New System.Drawing.Point(702, 372)
        Me.PbxCTC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxCTC.Name = "PbxCTC"
        Me.PbxCTC.Size = New System.Drawing.Size(135, 138)
        Me.PbxCTC.TabIndex = 218
        Me.PbxCTC.TabStop = False
        '
        'CbxClassification
        '
        Me.CbxClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxClassification.FormattingEnabled = True
        Me.CbxClassification.Items.AddRange(New Object() {"G", "PG", "M", "MA 15+", "R 18+"})
        Me.CbxClassification.Location = New System.Drawing.Point(417, 422)
        Me.CbxClassification.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CbxClassification.Name = "CbxClassification"
        Me.CbxClassification.Size = New System.Drawing.Size(130, 28)
        Me.CbxClassification.TabIndex = 211
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(76, 422)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 47)
        Me.Label1.TabIndex = 210
        Me.Label1.Text = "Movie Classification"
        '
        'BtnGenre
        '
        Me.BtnGenre.Location = New System.Drawing.Point(771, 271)
        Me.BtnGenre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnGenre.Name = "BtnGenre"
        Me.BtnGenre.Size = New System.Drawing.Size(112, 35)
        Me.BtnGenre.TabIndex = 209
        Me.BtnGenre.Text = "Add Genre"
        Me.BtnGenre.UseVisualStyleBackColor = True
        '
        'TbxGenre
        '
        Me.TbxGenre.Location = New System.Drawing.Point(417, 229)
        Me.TbxGenre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TbxGenre.MaxLength = 30
        Me.TbxGenre.Multiline = True
        Me.TbxGenre.Name = "TbxGenre"
        Me.TbxGenre.Size = New System.Drawing.Size(238, 59)
        Me.TbxGenre.TabIndex = 208
        Me.TbxGenre.Text = "XXX, YYY, ZZZ"
        '
        'CbxGenre
        '
        Me.CbxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxGenre.FormattingEnabled = True
        Me.CbxGenre.Items.AddRange(New Object() {"Action", "Adventure", "Animation", "Comedy", "Crime", "Documentary", "Drama", "Experimental", "Family", "Fantasy", "Historical", "Horror", "Live-action", "Mystery", "Philosophical", "Political", "Romance", "Science Fiction", "Superhero", "Thriller", "War", "Western"})
        Me.CbxGenre.Location = New System.Drawing.Point(702, 229)
        Me.CbxGenre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CbxGenre.Name = "CbxGenre"
        Me.CbxGenre.Size = New System.Drawing.Size(180, 28)
        Me.CbxGenre.TabIndex = 207
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(76, 137)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 47)
        Me.Label7.TabIndex = 206
        Me.Label7.Text = "Title"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(76, 229)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 47)
        Me.Label5.TabIndex = 205
        Me.Label5.Text = "Genre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(76, 338)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(414, 47)
        Me.Label4.TabIndex = 204
        Me.Label4.Text = "Year of Release Date"
        '
        'TbxReleaseDate
        '
        Me.TbxReleaseDate.Location = New System.Drawing.Point(417, 338)
        Me.TbxReleaseDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TbxReleaseDate.MaxLength = 4
        Me.TbxReleaseDate.Name = "TbxReleaseDate"
        Me.TbxReleaseDate.Size = New System.Drawing.Size(238, 26)
        Me.TbxReleaseDate.TabIndex = 202
        Me.TbxReleaseDate.Text = "YYYY"
        '
        'TbxTitle
        '
        Me.TbxTitle.Location = New System.Drawing.Point(417, 154)
        Me.TbxTitle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TbxTitle.MaxLength = 30
        Me.TbxTitle.Name = "TbxTitle"
        Me.TbxTitle.Size = New System.Drawing.Size(238, 26)
        Me.TbxTitle.TabIndex = 201
        '
        'PbxPG
        '
        Me.PbxPG.Image = CType(resources.GetObject("PbxPG.Image"), System.Drawing.Image)
        Me.PbxPG.Location = New System.Drawing.Point(702, 372)
        Me.PbxPG.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxPG.Name = "PbxPG"
        Me.PbxPG.Size = New System.Drawing.Size(135, 138)
        Me.PbxPG.TabIndex = 217
        Me.PbxPG.TabStop = False
        Me.PbxPG.Visible = False
        '
        'PbxG
        '
        Me.PbxG.Image = CType(resources.GetObject("PbxG.Image"), System.Drawing.Image)
        Me.PbxG.Location = New System.Drawing.Point(702, 372)
        Me.PbxG.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxG.Name = "PbxG"
        Me.PbxG.Size = New System.Drawing.Size(135, 138)
        Me.PbxG.TabIndex = 216
        Me.PbxG.TabStop = False
        Me.PbxG.Visible = False
        '
        'PbxM
        '
        Me.PbxM.Image = CType(resources.GetObject("PbxM.Image"), System.Drawing.Image)
        Me.PbxM.Location = New System.Drawing.Point(702, 372)
        Me.PbxM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxM.Name = "PbxM"
        Me.PbxM.Size = New System.Drawing.Size(135, 138)
        Me.PbxM.TabIndex = 215
        Me.PbxM.TabStop = False
        Me.PbxM.Visible = False
        '
        'PbxMA
        '
        Me.PbxMA.Image = CType(resources.GetObject("PbxMA.Image"), System.Drawing.Image)
        Me.PbxMA.Location = New System.Drawing.Point(702, 372)
        Me.PbxMA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxMA.Name = "PbxMA"
        Me.PbxMA.Size = New System.Drawing.Size(135, 138)
        Me.PbxMA.TabIndex = 214
        Me.PbxMA.TabStop = False
        Me.PbxMA.Visible = False
        '
        'PbxR
        '
        Me.PbxR.Image = CType(resources.GetObject("PbxR.Image"), System.Drawing.Image)
        Me.PbxR.Location = New System.Drawing.Point(702, 372)
        Me.PbxR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PbxR.Name = "PbxR"
        Me.PbxR.Size = New System.Drawing.Size(135, 138)
        Me.PbxR.TabIndex = 212
        Me.PbxR.TabStop = False
        Me.PbxR.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(256, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(507, 64)
        Me.Label2.TabIndex = 219
        Me.Label2.Text = "Edit/Delete Videos"
        '
        'BtnUpdateVideo
        '
        Me.BtnUpdateVideo.Location = New System.Drawing.Point(742, 602)
        Me.BtnUpdateVideo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnUpdateVideo.Name = "BtnUpdateVideo"
        Me.BtnUpdateVideo.Size = New System.Drawing.Size(141, 55)
        Me.BtnUpdateVideo.TabIndex = 203
        Me.BtnUpdateVideo.Text = "Update Video"
        Me.BtnUpdateVideo.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(592, 602)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(141, 55)
        Me.BtnClear.TabIndex = 213
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(442, 602)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(141, 55)
        Me.BtnDelete.TabIndex = 220
        Me.BtnDelete.Text = "Delete Video"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnReturn
        '
        Me.BtnReturn.Location = New System.Drawing.Point(40, 602)
        Me.BtnReturn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(141, 55)
        Me.BtnReturn.TabIndex = 221
        Me.BtnReturn.Text = "Return"
        Me.BtnReturn.UseVisualStyleBackColor = True
        '
        'UpdateDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(921, 697)
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PbxCTC)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.CbxClassification)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGenre)
        Me.Controls.Add(Me.TbxGenre)
        Me.Controls.Add(Me.CbxGenre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbxReleaseDate)
        Me.Controls.Add(Me.TbxTitle)
        Me.Controls.Add(Me.BtnUpdateVideo)
        Me.Controls.Add(Me.PbxPG)
        Me.Controls.Add(Me.PbxG)
        Me.Controls.Add(Me.PbxM)
        Me.Controls.Add(Me.PbxMA)
        Me.Controls.Add(Me.PbxR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "UpdateDelete"
        Me.Text = " Video Collection Library"
        CType(Me.PbxCTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxPG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PbxCTC As System.Windows.Forms.PictureBox
    Friend WithEvents CbxClassification As System.Windows.Forms.ComboBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnGenre As System.Windows.Forms.Button
    Friend WithEvents TbxGenre As System.Windows.Forms.TextBox
    Friend WithEvents CbxGenre As System.Windows.Forms.ComboBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TbxReleaseDate As System.Windows.Forms.TextBox
    Friend WithEvents TbxTitle As System.Windows.Forms.TextBox
    Friend WithEvents PbxPG As System.Windows.Forms.PictureBox
    Friend WithEvents PbxG As System.Windows.Forms.PictureBox
    Friend WithEvents PbxM As System.Windows.Forms.PictureBox
    Friend WithEvents PbxMA As System.Windows.Forms.PictureBox
    Friend WithEvents PbxR As System.Windows.Forms.PictureBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnUpdateVideo As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnReturn As System.Windows.Forms.Button
End Class
