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
        Me.lnome = New System.Windows.Forms.Label()
        Me.m1c1 = New System.Windows.Forms.Label()
        Me.m1c2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.m2c2 = New System.Windows.Forms.Label()
        Me.m2c1 = New System.Windows.Forms.Label()
        Me.lnome2 = New System.Windows.Forms.Label()
        Me.lbresultado = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lnome
        '
        Me.lnome.AutoSize = True
        Me.lnome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnome.ForeColor = System.Drawing.Color.Blue
        Me.lnome.Location = New System.Drawing.Point(71, 267)
        Me.lnome.Name = "lnome"
        Me.lnome.Size = New System.Drawing.Size(0, 18)
        Me.lnome.TabIndex = 0
        '
        'm1c1
        '
        Me.m1c1.Location = New System.Drawing.Point(52, 309)
        Me.m1c1.Name = "m1c1"
        Me.m1c1.Size = New System.Drawing.Size(48, 76)
        Me.m1c1.TabIndex = 1
        '
        'm1c2
        '
        Me.m1c2.Location = New System.Drawing.Point(127, 309)
        Me.m1c2.Name = "m1c2"
        Me.m1c2.Size = New System.Drawing.Size(48, 76)
        Me.m1c2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(259, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Random Enemy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'm2c2
        '
        Me.m2c2.Location = New System.Drawing.Point(548, 309)
        Me.m2c2.Name = "m2c2"
        Me.m2c2.Size = New System.Drawing.Size(48, 76)
        Me.m2c2.TabIndex = 6
        '
        'm2c1
        '
        Me.m2c1.Location = New System.Drawing.Point(465, 309)
        Me.m2c1.Name = "m2c1"
        Me.m2c1.Size = New System.Drawing.Size(48, 76)
        Me.m2c1.TabIndex = 5
        '
        'lnome2
        '
        Me.lnome2.AutoSize = True
        Me.lnome2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnome2.ForeColor = System.Drawing.Color.Blue
        Me.lnome2.Location = New System.Drawing.Point(453, 267)
        Me.lnome2.Name = "lnome2"
        Me.lnome2.Size = New System.Drawing.Size(0, 18)
        Me.lnome2.TabIndex = 4
        '
        'lbresultado
        '
        Me.lbresultado.AutoSize = True
        Me.lbresultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbresultado.ForeColor = System.Drawing.Color.Red
        Me.lbresultado.Location = New System.Drawing.Point(163, 43)
        Me.lbresultado.Name = "lbresultado"
        Me.lbresultado.Size = New System.Drawing.Size(0, 18)
        Me.lbresultado.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(259, 362)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Comparar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(681, 429)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lbresultado)
        Me.Controls.Add(Me.m2c2)
        Me.Controls.Add(Me.m2c1)
        Me.Controls.Add(Me.lnome2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.m1c2)
        Me.Controls.Add(Me.m1c1)
        Me.Controls.Add(Me.lnome)
        Me.Name = "Form1"
        Me.Text = "TictacKode - Monster Poker V0.1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lnome As System.Windows.Forms.Label
    Friend WithEvents m1c1 As System.Windows.Forms.Label
    Friend WithEvents m1c2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents m2c2 As System.Windows.Forms.Label
    Friend WithEvents m2c1 As System.Windows.Forms.Label
    Friend WithEvents lnome2 As System.Windows.Forms.Label
    Friend WithEvents lbresultado As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
