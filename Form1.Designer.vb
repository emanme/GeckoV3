<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.browser = New Gecko.GeckoWebBrowser()
        Me.loadingImage = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.posterCloseButton = New System.Windows.Forms.PictureBox()
        Me.OPACButton = New System.Windows.Forms.PictureBox()
        Me.DienstleistungenButton = New System.Windows.Forms.PictureBox()
        Me.FachgebieteButton = New System.Windows.Forms.PictureBox()
        Me.HomeButton = New System.Windows.Forms.PictureBox()
        Me.SignaturenButton = New System.Windows.Forms.PictureBox()
        CType(Me.loadingImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.posterCloseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OPACButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DienstleistungenButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FachgebieteButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignaturenButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'browser
        '
        Me.browser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.browser.Location = New System.Drawing.Point(0, 0)
        Me.browser.Name = "browser"
        Me.browser.Size = New System.Drawing.Size(1224, 508)
        Me.browser.TabIndex = 0
        Me.browser.UseHttpActivityObserver = False
        '
        'loadingImage
        '
        Me.loadingImage.Image = Global.GeckoV3.My.Resources.Resources.ajax_loader
        Me.loadingImage.Location = New System.Drawing.Point(119, 115)
        Me.loadingImage.Name = "loadingImage"
        Me.loadingImage.Size = New System.Drawing.Size(24, 24)
        Me.loadingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.loadingImage.TabIndex = 1
        Me.loadingImage.TabStop = False
        Me.loadingImage.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel2.Controls.Add(Me.posterCloseButton)
        Me.Panel2.Controls.Add(Me.OPACButton)
        Me.Panel2.Controls.Add(Me.DienstleistungenButton)
        Me.Panel2.Controls.Add(Me.FachgebieteButton)
        Me.Panel2.Controls.Add(Me.HomeButton)
        Me.Panel2.Controls.Add(Me.SignaturenButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 298)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1224, 210)
        Me.Panel2.TabIndex = 71
        '
        'posterCloseButton
        '
        Me.posterCloseButton.Location = New System.Drawing.Point(1311, 31)
        Me.posterCloseButton.Name = "posterCloseButton"
        Me.posterCloseButton.Size = New System.Drawing.Size(100, 50)
        Me.posterCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.posterCloseButton.TabIndex = 5
        Me.posterCloseButton.TabStop = False
        '
        'OPACButton
        '
        Me.OPACButton.Location = New System.Drawing.Point(865, 3)
        Me.OPACButton.Name = "OPACButton"
        Me.OPACButton.Size = New System.Drawing.Size(200, 200)
        Me.OPACButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OPACButton.TabIndex = 4
        Me.OPACButton.TabStop = False
        '
        'DienstleistungenButton
        '
        Me.DienstleistungenButton.Location = New System.Drawing.Point(649, 3)
        Me.DienstleistungenButton.Name = "DienstleistungenButton"
        Me.DienstleistungenButton.Size = New System.Drawing.Size(200, 200)
        Me.DienstleistungenButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DienstleistungenButton.TabIndex = 3
        Me.DienstleistungenButton.TabStop = False
        '
        'FachgebieteButton
        '
        Me.FachgebieteButton.Location = New System.Drawing.Point(217, 3)
        Me.FachgebieteButton.Name = "FachgebieteButton"
        Me.FachgebieteButton.Size = New System.Drawing.Size(200, 200)
        Me.FachgebieteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FachgebieteButton.TabIndex = 2
        Me.FachgebieteButton.TabStop = False
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(1, 3)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(200, 200)
        Me.HomeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HomeButton.TabIndex = 2
        Me.HomeButton.TabStop = False
        '
        'SignaturenButton
        '
        Me.SignaturenButton.Location = New System.Drawing.Point(433, 3)
        Me.SignaturenButton.Name = "SignaturenButton"
        Me.SignaturenButton.Size = New System.Drawing.Size(200, 200)
        Me.SignaturenButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SignaturenButton.TabIndex = 2
        Me.SignaturenButton.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 508)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.loadingImage)
        Me.Controls.Add(Me.browser)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.loadingImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.posterCloseButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPACButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DienstleistungenButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FachgebieteButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignaturenButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents browser As Gecko.GeckoWebBrowser
    Friend WithEvents loadingImage As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents posterCloseButton As System.Windows.Forms.PictureBox
    Friend WithEvents OPACButton As System.Windows.Forms.PictureBox
    Friend WithEvents DienstleistungenButton As System.Windows.Forms.PictureBox
    Friend WithEvents FachgebieteButton As System.Windows.Forms.PictureBox
    Friend WithEvents HomeButton As System.Windows.Forms.PictureBox
    Friend WithEvents SignaturenButton As System.Windows.Forms.PictureBox

End Class
