<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.NuiPanel1 = New Nevron.UI.WinForm.Controls.NUIPanel()
        Me.NuiPanel2 = New Nevron.UI.WinForm.Controls.NUIPanel()
        Me.NButton3 = New Nevron.UI.WinForm.Controls.NButton()
        Me.NButton1 = New Nevron.UI.WinForm.Controls.NButton()
        Me.NButton2 = New Nevron.UI.WinForm.Controls.NButton()
        Me.NuiPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NuiPanel1
        '
        Me.NuiPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NuiPanel1.Location = New System.Drawing.Point(604, 12)
        Me.NuiPanel1.Name = "NuiPanel1"
        Me.NuiPanel1.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.LunaBlue
        Me.NuiPanel1.Size = New System.Drawing.Size(192, 79)
        Me.NuiPanel1.TabIndex = 0
        Me.NuiPanel1.Text = "NuiPanel1"
        Me.NuiPanel1.UseCustomScrollBars = True
        '
        'NuiPanel2
        '
        Me.NuiPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NuiPanel2.Controls.Add(Me.NButton3)
        Me.NuiPanel2.Controls.Add(Me.NButton1)
        Me.NuiPanel2.Controls.Add(Me.NButton2)
        Me.NuiPanel2.Location = New System.Drawing.Point(604, 97)
        Me.NuiPanel2.Name = "NuiPanel2"
        Me.NuiPanel2.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Office2007Blue
        Me.NuiPanel2.Size = New System.Drawing.Size(192, 425)
        Me.NuiPanel2.TabIndex = 1
        Me.NuiPanel2.Text = "NuiPanel2"
        Me.NuiPanel2.UseCustomScrollBars = True
        '
        'NButton3
        '
        Me.NButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NButton3.Location = New System.Drawing.Point(10, 122)
        Me.NButton3.Name = "NButton3"
        Me.NButton3.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Office2007Blue
        Me.NButton3.Size = New System.Drawing.Size(171, 50)
        Me.NButton3.TabIndex = 3
        Me.NButton3.Text = "طباعة شيك"
        Me.NButton3.UseVisualStyleBackColor = False
        '
        'NButton1
        '
        Me.NButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NButton1.Location = New System.Drawing.Point(10, 66)
        Me.NButton1.Name = "NButton1"
        Me.NButton1.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Sunset
        Me.NButton1.PaletteInheritance = CType(Nevron.UI.WinForm.Controls.PaletteInheritance.None, Nevron.UI.WinForm.Controls.PaletteInheritance)
        Me.NButton1.Size = New System.Drawing.Size(171, 50)
        Me.NButton1.TabIndex = 2
        Me.NButton1.Text = "استعلام وتعديل"
        Me.NButton1.UseVisualStyleBackColor = False
        '
        'NButton2
        '
        Me.NButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NButton2.Location = New System.Drawing.Point(10, 10)
        Me.NButton2.Name = "NButton2"
        Me.NButton2.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Office2007Blue
        Me.NButton2.Size = New System.Drawing.Size(171, 50)
        Me.NButton2.TabIndex = 1
        Me.NButton2.Text = "ادخال شيك"
        Me.NButton2.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 534)
        Me.Controls.Add(Me.NuiPanel2)
        Me.Controls.Add(Me.NuiPanel1)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.NuiPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NuiPanel1 As Nevron.UI.WinForm.Controls.NUIPanel
    Friend WithEvents NuiPanel2 As Nevron.UI.WinForm.Controls.NUIPanel
    Friend WithEvents NButton2 As Nevron.UI.WinForm.Controls.NButton
    Friend WithEvents NButton1 As Nevron.UI.WinForm.Controls.NButton
    Friend WithEvents NButton3 As Nevron.UI.WinForm.Controls.NButton
End Class
