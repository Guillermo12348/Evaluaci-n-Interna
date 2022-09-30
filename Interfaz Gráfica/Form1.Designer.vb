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
        Me.components = New System.ComponentModel.Container()
        Me.Lsa = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.SuspendLayout()
        '
        'Lsa
        '
        Me.Lsa.AutoSize = True
        Me.Lsa.Font = New System.Drawing.Font("Californian FB", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lsa.Location = New System.Drawing.Point(355, 42)
        Me.Lsa.Name = "Lsa"
        Me.Lsa.Size = New System.Drawing.Size(502, 51)
        Me.Lsa.TabIndex = 0
        Me.Lsa.Text = "Administrador de trabajo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(465, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(443, 193)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 40)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(448, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 44)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(443, 322)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 40)
        Me.TextBox2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Elephant", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(408, 407)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(383, 62)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PPG-COMEX"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1013, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 6
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(956, 11)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 7
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 10
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1080, 620)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lsa)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lsa As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
