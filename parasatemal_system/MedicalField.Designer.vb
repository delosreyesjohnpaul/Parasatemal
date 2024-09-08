<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicalField
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedicalField))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CMBTN = New System.Windows.Forms.Button()
        Me.HomeBTN = New System.Windows.Forms.Button()
        Me.DeleteBTN = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.HotPink
        Me.Button2.Font = New System.Drawing.Font("Cambria", 10.01739!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(365, 361)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(439, 50)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "FORMULARY"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepPink
        Me.Button1.Font = New System.Drawing.Font("Cambria", 10.01739!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(365, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(439, 52)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "NEW MEDICATION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CMBTN
        '
        Me.CMBTN.BackColor = System.Drawing.Color.Magenta
        Me.CMBTN.Font = New System.Drawing.Font("Cambria", 10.01739!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBTN.ForeColor = System.Drawing.Color.Transparent
        Me.CMBTN.Location = New System.Drawing.Point(365, 248)
        Me.CMBTN.Name = "CMBTN"
        Me.CMBTN.Size = New System.Drawing.Size(439, 49)
        Me.CMBTN.TabIndex = 41
        Me.CMBTN.Text = "CURRENT MEDICATION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CMBTN.UseVisualStyleBackColor = False
        '
        'HomeBTN
        '
        Me.HomeBTN.BackColor = System.Drawing.Color.BlueViolet
        Me.HomeBTN.Font = New System.Drawing.Font("Cambria", 11.89565!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBTN.ForeColor = System.Drawing.Color.Transparent
        Me.HomeBTN.Location = New System.Drawing.Point(365, 188)
        Me.HomeBTN.Name = "HomeBTN"
        Me.HomeBTN.Size = New System.Drawing.Size(439, 54)
        Me.HomeBTN.TabIndex = 40
        Me.HomeBTN.Text = "HOME"
        Me.HomeBTN.UseVisualStyleBackColor = False
        '
        'DeleteBTN
        '
        Me.DeleteBTN.BackColor = System.Drawing.Color.Red
        Me.DeleteBTN.Font = New System.Drawing.Font("Cambria", 11.89565!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBTN.ForeColor = System.Drawing.Color.Transparent
        Me.DeleteBTN.Location = New System.Drawing.Point(762, 428)
        Me.DeleteBTN.Name = "DeleteBTN"
        Me.DeleteBTN.Size = New System.Drawing.Size(91, 43)
        Me.DeleteBTN.TabIndex = 39
        Me.DeleteBTN.Text = "EXIT"
        Me.DeleteBTN.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, -6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 99)
        Me.Panel1.TabIndex = 38
        Me.Panel1.TabStop = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 23.7913!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(248, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PARASATEMAL"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.parasatemal_system.My.Resources.Resources._1619448459_62294_gif_url
        Me.PictureBox3.Location = New System.Drawing.Point(35, 142)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(311, 317)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 44
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.parasatemal_system.My.Resources.Resources.pngegg
        Me.PictureBox2.Location = New System.Drawing.Point(120, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(71, 76)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.parasatemal_system.My.Resources.Resources.pngwing_com
        Me.PictureBox1.Location = New System.Drawing.Point(197, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MedicalField
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 489)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CMBTN)
        Me.Controls.Add(Me.HomeBTN)
        Me.Controls.Add(Me.DeleteBTN)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MedicalField"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CMBTN As Button
    Friend WithEvents HomeBTN As Button
    Friend WithEvents DeleteBTN As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
