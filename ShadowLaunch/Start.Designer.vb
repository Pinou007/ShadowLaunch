<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorList = New System.Windows.Forms.TextBox()
        Me.Reloaded = New System.Windows.Forms.Button()
        Me.ClosePopUp = New System.Windows.Forms.Button()
        Me.companyName = New System.Windows.Forms.Label()
        Me.companyPicture = New System.Windows.Forms.PictureBox()
        Me.companyInfo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.companyPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(751, 40)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(143, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "v1.0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ShadowLaunch"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(12, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Oops a problem has occurred"
        '
        'ErrorList
        '
        Me.ErrorList.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ErrorList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ErrorList.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorList.ForeColor = System.Drawing.Color.Silver
        Me.ErrorList.Location = New System.Drawing.Point(16, 73)
        Me.ErrorList.Multiline = True
        Me.ErrorList.Name = "ErrorList"
        Me.ErrorList.ReadOnly = True
        Me.ErrorList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ErrorList.Size = New System.Drawing.Size(723, 274)
        Me.ErrorList.TabIndex = 3
        Me.ErrorList.Text = resources.GetString("ErrorList.Text")
        '
        'Reloaded
        '
        Me.Reloaded.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Reloaded.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Reloaded.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reloaded.ForeColor = System.Drawing.Color.White
        Me.Reloaded.Location = New System.Drawing.Point(653, 354)
        Me.Reloaded.Name = "Reloaded"
        Me.Reloaded.Size = New System.Drawing.Size(86, 29)
        Me.Reloaded.TabIndex = 4
        Me.Reloaded.Text = "Reloaded"
        Me.Reloaded.UseVisualStyleBackColor = False
        '
        'ClosePopUp
        '
        Me.ClosePopUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClosePopUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ClosePopUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClosePopUp.ForeColor = System.Drawing.Color.White
        Me.ClosePopUp.Location = New System.Drawing.Point(561, 354)
        Me.ClosePopUp.Name = "ClosePopUp"
        Me.ClosePopUp.Size = New System.Drawing.Size(86, 29)
        Me.ClosePopUp.TabIndex = 5
        Me.ClosePopUp.Text = "Close"
        Me.ClosePopUp.UseVisualStyleBackColor = False
        '
        'companyName
        '
        Me.companyName.AutoSize = True
        Me.companyName.BackColor = System.Drawing.Color.Transparent
        Me.companyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.companyName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.companyName.Location = New System.Drawing.Point(49, 353)
        Me.companyName.MaximumSize = New System.Drawing.Size(230, 16)
        Me.companyName.Name = "companyName"
        Me.companyName.Size = New System.Drawing.Size(63, 16)
        Me.companyName.TabIndex = 6
        Me.companyName.Text = "Pinou007"
        '
        'companyPicture
        '
        Me.companyPicture.Image = CType(resources.GetObject("companyPicture.Image"), System.Drawing.Image)
        Me.companyPicture.Location = New System.Drawing.Point(13, 353)
        Me.companyPicture.Name = "companyPicture"
        Me.companyPicture.Size = New System.Drawing.Size(30, 30)
        Me.companyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.companyPicture.TabIndex = 7
        Me.companyPicture.TabStop = False
        '
        'companyInfo
        '
        Me.companyInfo.AutoSize = True
        Me.companyInfo.BackColor = System.Drawing.Color.Transparent
        Me.companyInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyInfo.ForeColor = System.Drawing.Color.Gray
        Me.companyInfo.Location = New System.Drawing.Point(49, 370)
        Me.companyInfo.MaximumSize = New System.Drawing.Size(230, 16)
        Me.companyInfo.Name = "companyInfo"
        Me.companyInfo.Size = New System.Drawing.Size(109, 13)
        Me.companyInfo.TabIndex = 8
        Me.companyInfo.Text = "github.com/Pinou007"
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(751, 394)
        Me.Controls.Add(Me.companyInfo)
        Me.Controls.Add(Me.companyPicture)
        Me.Controls.Add(Me.companyName)
        Me.Controls.Add(Me.ClosePopUp)
        Me.Controls.Add(Me.Reloaded)
        Me.Controls.Add(Me.ErrorList)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Start"
        Me.Text = "Start"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.companyPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ErrorList As TextBox
    Friend WithEvents Reloaded As Button
    Friend WithEvents ClosePopUp As Button
    Friend WithEvents companyName As Label
    Friend WithEvents companyPicture As PictureBox
    Friend WithEvents companyInfo As Label
End Class
