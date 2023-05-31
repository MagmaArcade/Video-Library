<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports))
        Me.PbxReport = New System.Windows.Forms.PictureBox()
        Me.PbxSignOut = New System.Windows.Forms.PictureBox()
        Me.PbxExit = New System.Windows.Forms.PictureBox()
        Me.PbxAdd = New System.Windows.Forms.PictureBox()
        Me.PbxSettings = New System.Windows.Forms.PictureBox()
        Me.PbxExplore = New System.Windows.Forms.PictureBox()
        Me.PbxHome = New System.Windows.Forms.PictureBox()
        CType(Me.PbxReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxSignOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxExplore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PbxReport
        '
        Me.PbxReport.Image = CType(resources.GetObject("PbxReport.Image"), System.Drawing.Image)
        Me.PbxReport.Location = New System.Drawing.Point(29, 300)
        Me.PbxReport.Name = "PbxReport"
        Me.PbxReport.Size = New System.Drawing.Size(44, 44)
        Me.PbxReport.TabIndex = 155
        Me.PbxReport.TabStop = False
        '
        'PbxSignOut
        '
        Me.PbxSignOut.Image = CType(resources.GetObject("PbxSignOut.Image"), System.Drawing.Image)
        Me.PbxSignOut.Location = New System.Drawing.Point(29, 457)
        Me.PbxSignOut.Name = "PbxSignOut"
        Me.PbxSignOut.Size = New System.Drawing.Size(44, 44)
        Me.PbxSignOut.TabIndex = 154
        Me.PbxSignOut.TabStop = False
        '
        'PbxExit
        '
        Me.PbxExit.Image = CType(resources.GetObject("PbxExit.Image"), System.Drawing.Image)
        Me.PbxExit.Location = New System.Drawing.Point(29, 523)
        Me.PbxExit.Name = "PbxExit"
        Me.PbxExit.Size = New System.Drawing.Size(44, 44)
        Me.PbxExit.TabIndex = 153
        Me.PbxExit.TabStop = False
        '
        'PbxAdd
        '
        Me.PbxAdd.Image = CType(resources.GetObject("PbxAdd.Image"), System.Drawing.Image)
        Me.PbxAdd.Location = New System.Drawing.Point(29, 171)
        Me.PbxAdd.Name = "PbxAdd"
        Me.PbxAdd.Size = New System.Drawing.Size(44, 44)
        Me.PbxAdd.TabIndex = 152
        Me.PbxAdd.TabStop = False
        '
        'PbxSettings
        '
        Me.PbxSettings.Image = CType(resources.GetObject("PbxSettings.Image"), System.Drawing.Image)
        Me.PbxSettings.Location = New System.Drawing.Point(29, 237)
        Me.PbxSettings.Name = "PbxSettings"
        Me.PbxSettings.Size = New System.Drawing.Size(44, 44)
        Me.PbxSettings.TabIndex = 151
        Me.PbxSettings.TabStop = False
        '
        'PbxExplore
        '
        Me.PbxExplore.Image = CType(resources.GetObject("PbxExplore.Image"), System.Drawing.Image)
        Me.PbxExplore.Location = New System.Drawing.Point(29, 112)
        Me.PbxExplore.Name = "PbxExplore"
        Me.PbxExplore.Size = New System.Drawing.Size(44, 44)
        Me.PbxExplore.TabIndex = 150
        Me.PbxExplore.TabStop = False
        '
        'PbxHome
        '
        Me.PbxHome.Image = CType(resources.GetObject("PbxHome.Image"), System.Drawing.Image)
        Me.PbxHome.Location = New System.Drawing.Point(29, 49)
        Me.PbxHome.Name = "PbxHome"
        Me.PbxHome.Size = New System.Drawing.Size(44, 44)
        Me.PbxHome.TabIndex = 149
        Me.PbxHome.TabStop = False
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(912, 604)
        Me.Controls.Add(Me.PbxReport)
        Me.Controls.Add(Me.PbxSignOut)
        Me.Controls.Add(Me.PbxExit)
        Me.Controls.Add(Me.PbxAdd)
        Me.Controls.Add(Me.PbxSettings)
        Me.Controls.Add(Me.PbxExplore)
        Me.Controls.Add(Me.PbxHome)
        Me.Name = "Reports"
        Me.Text = "Form1"
        CType(Me.PbxReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxSignOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxExplore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PbxReport As System.Windows.Forms.PictureBox
    Friend WithEvents PbxSignOut As System.Windows.Forms.PictureBox
    Friend WithEvents PbxExit As System.Windows.Forms.PictureBox
    Friend WithEvents PbxAdd As System.Windows.Forms.PictureBox
    Friend WithEvents PbxSettings As System.Windows.Forms.PictureBox
    Friend WithEvents PbxExplore As System.Windows.Forms.PictureBox
    Friend WithEvents PbxHome As System.Windows.Forms.PictureBox
End Class
