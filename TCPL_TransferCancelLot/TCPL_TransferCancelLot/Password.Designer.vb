<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Password
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
        Me.AscThemeContainer1 = New TCPL_TransferCancelLot.ascThemeContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AscThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AscThemeContainer1
        '
        Me.AscThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.AscThemeContainer1.Controls.Add(Me.Button1)
        Me.AscThemeContainer1.Controls.Add(Me.TextBox1)
        Me.AscThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AscThemeContainer1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.AscThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.AscThemeContainer1.Name = "AscThemeContainer1"
        Me.AscThemeContainer1.Size = New System.Drawing.Size(290, 153)
        Me.AscThemeContainer1.TabIndex = 0
        Me.AscThemeContainer1.Text = "Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Remove from cart"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(48, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 26)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 153)
        Me.Controls.Add(Me.AscThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.AscThemeContainer1.ResumeLayout(False)
        Me.AscThemeContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AscThemeContainer1 As ascThemeContainer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
