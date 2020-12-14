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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NuiPanel1 = New Nevron.UI.WinForm.Controls.NUIPanel()
        Me.NuiPanel2 = New Nevron.UI.WinForm.Controls.NUIPanel()
        Me.NButton1 = New Nevron.UI.WinForm.Controls.NButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordBox = New Nevron.UI.WinForm.Controls.NMaskedTextBox()
        Me.NButton2 = New Nevron.UI.WinForm.Controls.NButton()
        Me.NPopup1 = New Nevron.UI.WinForm.Controls.NPopup()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NuiPanel1.SuspendLayout()
        Me.NuiPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Athatech___Cheque_Printing_System.My.Resources.Resources.iconfinder_checkin_key_65860
        Me.PictureBox1.Location = New System.Drawing.Point(14, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'NuiPanel1
        '
        Me.NuiPanel1.Controls.Add(Me.PictureBox1)
        Me.NuiPanel1.Location = New System.Drawing.Point(12, 12)
        Me.NuiPanel1.Name = "NuiPanel1"
        Me.NuiPanel1.Size = New System.Drawing.Size(158, 229)
        Me.NuiPanel1.TabIndex = 4
        Me.NuiPanel1.Text = "NuiPanel1"
        Me.NuiPanel1.UseCustomScrollBars = True
        '
        'NuiPanel2
        '
        Me.NuiPanel2.Controls.Add(Me.NButton2)
        Me.NuiPanel2.Controls.Add(Me.NButton1)
        Me.NuiPanel2.Controls.Add(Me.Label1)
        Me.NuiPanel2.Controls.Add(Me.PasswordBox)
        Me.NuiPanel2.Location = New System.Drawing.Point(176, 12)
        Me.NuiPanel2.Name = "NuiPanel2"
        Me.NuiPanel2.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Office2007Blue
        Me.NuiPanel2.Size = New System.Drawing.Size(317, 229)
        Me.NuiPanel2.TabIndex = 5
        Me.NuiPanel2.Text = "NuiPanel2"
        Me.NuiPanel2.UseCustomScrollBars = True
        '
        'NButton1
        '
        Me.NButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NButton1.Location = New System.Drawing.Point(11, 156)
        Me.NButton1.Name = "NButton1"
        Me.NButton1.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Carrotine
        Me.NButton1.Size = New System.Drawing.Size(175, 55)
        Me.NButton1.TabIndex = 6
        Me.NButton1.Text = "الدخول"
        Me.NButton1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(218, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "كلمة المرور"
        '
        'PasswordBox
        '
        Me.PasswordBox.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordBox.Location = New System.Drawing.Point(11, 69)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Office2007Blue
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.PasswordBox.Size = New System.Drawing.Size(293, 31)
        Me.PasswordBox.TabIndex = 4
        '
        'NButton2
        '
        Me.NButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NButton2.Location = New System.Drawing.Point(192, 156)
        Me.NButton2.Name = "NButton2"
        Me.NButton2.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Carrotine
        Me.NButton2.Size = New System.Drawing.Size(112, 55)
        Me.NButton2.TabIndex = 7
        Me.NButton2.Text = "الخروج"
        Me.NButton2.UseVisualStyleBackColor = False
        '
        'NPopup1
        '
        Me.NPopup1.Location = New System.Drawing.Point(0, 0)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 253)
        Me.Controls.Add(Me.NuiPanel2)
        Me.Controls.Add(Me.NuiPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تسجيل الدخول"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NuiPanel1.ResumeLayout(False)
        Me.NuiPanel1.PerformLayout()
        Me.NuiPanel2.ResumeLayout(False)
        Me.NuiPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NuiPanel1 As Nevron.UI.WinForm.Controls.NUIPanel
    Friend WithEvents NuiPanel2 As Nevron.UI.WinForm.Controls.NUIPanel
    Friend WithEvents NButton2 As Nevron.UI.WinForm.Controls.NButton
    Friend WithEvents NButton1 As Nevron.UI.WinForm.Controls.NButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordBox As Nevron.UI.WinForm.Controls.NMaskedTextBox
    Friend WithEvents NPopup1 As Nevron.UI.WinForm.Controls.NPopup
End Class
