<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AscThemeContainer1 = New TCPL_TransferCancelLot.ascThemeContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AscButton1 = New TCPL_TransferCancelLot.ascButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.APCSStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LotNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotStartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotEndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CbCartNo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AscThemeContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AscThemeContainer1
        '
        Me.AscThemeContainer1.BackColor = System.Drawing.Color.Black
        Me.AscThemeContainer1.Controls.Add(Me.Panel1)
        Me.AscThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AscThemeContainer1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.AscThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.AscThemeContainer1.Name = "AscThemeContainer1"
        Me.AscThemeContainer1.Size = New System.Drawing.Size(708, 469)
        Me.AscThemeContainer1.TabIndex = 0
        Me.AscThemeContainer1.Text = "TC PL Transfer"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.AscButton1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.CbCartNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(21, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 396)
        Me.Panel1.TabIndex = 290
        '
        'AscButton1
        '
        Me.AscButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.AscButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AscButton1.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.AscButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AscButton1.GlowColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.AscButton1.Location = New System.Drawing.Point(481, 360)
        Me.AscButton1.Name = "AscButton1"
        Me.AscButton1.Size = New System.Drawing.Size(153, 26)
        Me.AscButton1.TabIndex = 0
        Me.AscButton1.Text = "Remove from cart"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DimGray
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.APCSStaffToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(663, 33)
        Me.MenuStrip1.TabIndex = 289
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'APCSStaffToolStripMenuItem
        '
        Me.APCSStaffToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.APCSStaffToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.APCSStaffToolStripMenuItem.Name = "APCSStaffToolStripMenuItem"
        Me.APCSStaffToolStripMenuItem.Size = New System.Drawing.Size(115, 29)
        Me.APCSStaffToolStripMenuItem.Text = "APCS_Staff"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LotNo, Me.CartNo, Me.LotStartTime, Me.LotEndTime})
        Me.DataGridView1.Location = New System.Drawing.Point(19, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(616, 284)
        Me.DataGridView1.TabIndex = 4
        '
        'LotNo
        '
        Me.LotNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LotNo.DataPropertyName = "LotNo"
        Me.LotNo.HeaderText = "LotNo"
        Me.LotNo.Name = "LotNo"
        Me.LotNo.ReadOnly = True
        '
        'CartNo
        '
        Me.CartNo.DataPropertyName = "CartNo"
        Me.CartNo.HeaderText = "CartNo"
        Me.CartNo.Name = "CartNo"
        Me.CartNo.ReadOnly = True
        '
        'LotStartTime
        '
        Me.LotStartTime.DataPropertyName = "LotStartTime"
        Me.LotStartTime.HeaderText = "LotStartTime"
        Me.LotStartTime.Name = "LotStartTime"
        Me.LotStartTime.ReadOnly = True
        Me.LotStartTime.Width = 150
        '
        'LotEndTime
        '
        Me.LotEndTime.DataPropertyName = "LotEndTime"
        Me.LotEndTime.HeaderText = "LotEndTime"
        Me.LotEndTime.Name = "LotEndTime"
        Me.LotEndTime.ReadOnly = True
        Me.LotEndTime.Width = 150
        '
        'CbCartNo
        '
        Me.CbCartNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCartNo.FormattingEnabled = True
        Me.CbCartNo.Location = New System.Drawing.Point(97, 40)
        Me.CbCartNo.Name = "CbCartNo"
        Me.CbCartNo.Size = New System.Drawing.Size(121, 26)
        Me.CbCartNo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cart No :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 469)
        Me.Controls.Add(Me.AscThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.AscThemeContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AscThemeContainer1 As ascThemeContainer
    Friend WithEvents CbCartNo As ComboBox
    Friend WithEvents AscButton1 As ascButton
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LotNo As DataGridViewTextBoxColumn
    Friend WithEvents CartNo As DataGridViewTextBoxColumn
    Friend WithEvents LotStartTime As DataGridViewTextBoxColumn
    Friend WithEvents LotEndTime As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents APCSStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
End Class
