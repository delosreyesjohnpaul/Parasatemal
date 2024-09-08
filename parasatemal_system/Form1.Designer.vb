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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.sortasddesc = New System.Windows.Forms.Button()
        Me.ExitBTN = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MedictionfBTN = New System.Windows.Forms.Button()
        Me.HomeBTN = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SearchBTN = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sortasddesc
        '
        Me.sortasddesc.BackColor = System.Drawing.Color.DodgerBlue
        Me.sortasddesc.Font = New System.Drawing.Font("Cambria", 11.89565!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sortasddesc.ForeColor = System.Drawing.Color.Transparent
        Me.sortasddesc.Location = New System.Drawing.Point(36, 330)
        Me.sortasddesc.Name = "sortasddesc"
        Me.sortasddesc.Size = New System.Drawing.Size(168, 50)
        Me.sortasddesc.TabIndex = 40
        Me.sortasddesc.Text = "SORT "
        Me.sortasddesc.UseVisualStyleBackColor = False
        '
        'ExitBTN
        '
        Me.ExitBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExitBTN.Font = New System.Drawing.Font("Cambria", 11.89565!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBTN.ForeColor = System.Drawing.Color.Transparent
        Me.ExitBTN.Location = New System.Drawing.Point(36, 386)
        Me.ExitBTN.Name = "ExitBTN"
        Me.ExitBTN.Size = New System.Drawing.Size(168, 51)
        Me.ExitBTN.TabIndex = 39
        Me.ExitBTN.Text = "EXIT"
        Me.ExitBTN.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(220, 159)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 49
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(778, 342)
        Me.DataGridView1.TabIndex = 35
        '
        'MedictionfBTN
        '
        Me.MedictionfBTN.BackColor = System.Drawing.Color.DarkOrchid
        Me.MedictionfBTN.Font = New System.Drawing.Font("Cambria", 10.01739!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedictionfBTN.ForeColor = System.Drawing.Color.Transparent
        Me.MedictionfBTN.Location = New System.Drawing.Point(36, 271)
        Me.MedictionfBTN.Name = "MedictionfBTN"
        Me.MedictionfBTN.Size = New System.Drawing.Size(168, 53)
        Me.MedictionfBTN.TabIndex = 34
        Me.MedictionfBTN.Text = "MEDICATION FIELD"
        Me.MedictionfBTN.UseVisualStyleBackColor = False
        '
        'HomeBTN
        '
        Me.HomeBTN.BackColor = System.Drawing.Color.BlueViolet
        Me.HomeBTN.Font = New System.Drawing.Font("Cambria", 11.89565!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBTN.ForeColor = System.Drawing.Color.Transparent
        Me.HomeBTN.Location = New System.Drawing.Point(36, 212)
        Me.HomeBTN.Name = "HomeBTN"
        Me.HomeBTN.Size = New System.Drawing.Size(168, 53)
        Me.HomeBTN.TabIndex = 33
        Me.HomeBTN.Text = "HOME"
        Me.HomeBTN.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1025, 90)
        Me.Panel1.TabIndex = 32
        Me.Panel1.TabStop = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 23.7913!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(314, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PARASATEMAL"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.parasatemal_system.My.Resources.Resources.pngegg
        Me.PictureBox2.Location = New System.Drawing.Point(186, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(71, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.parasatemal_system.My.Resources.Resources.pngwing_com
        Me.PictureBox1.Location = New System.Drawing.Point(263, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'SearchBTN
        '
        Me.SearchBTN.BackColor = System.Drawing.Color.Lime
        Me.SearchBTN.Font = New System.Drawing.Font("Cambria", 11.89565!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBTN.ForeColor = System.Drawing.Color.Transparent
        Me.SearchBTN.Location = New System.Drawing.Point(308, 111)
        Me.SearchBTN.Name = "SearchBTN"
        Me.SearchBTN.Size = New System.Drawing.Size(115, 42)
        Me.SearchBTN.TabIndex = 37
        Me.SearchBTN.Text = "SEARCH"
        Me.SearchBTN.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.Honeydew
        Me.txtSearch.Font = New System.Drawing.Font("Cambria", 15.02609!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(429, 113)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(569, 36)
        Me.txtSearch.TabIndex = 38
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 524)
        Me.Controls.Add(Me.sortasddesc)
        Me.Controls.Add(Me.ExitBTN)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.SearchBTN)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MedictionfBTN)
        Me.Controls.Add(Me.HomeBTN)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sortasddesc As Button
    Friend WithEvents ExitBTN As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MedictionfBTN As Button
    Friend WithEvents HomeBTN As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchBTN As Button
    Friend WithEvents txtSearch As TextBox
End Class
