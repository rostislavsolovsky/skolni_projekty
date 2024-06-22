<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
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

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.TrackBar4 = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TrackBar5 = New System.Windows.Forms.TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TrackBar6 = New System.Windows.Forms.TrackBar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TrackBar7 = New System.Windows.Forms.TrackBar()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 16)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(249, 126)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button1.Location = New System.Drawing.Point(13, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(252, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Vytvoř a ulož zlomky"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(267, 16)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(277, 126)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(544, 280)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox3.Size = New System.Drawing.Size(577, 128)
        Me.TextBox3.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Celá část je minimálně  0"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(12, 246)
        Me.TrackBar1.Maximum = 5
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(128, 56)
        Me.TrackBar1.TabIndex = 5
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(229, 246)
        Me.TrackBar2.Maximum = 6
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(128, 56)
        Me.TrackBar2.TabIndex = 8
        '
        'TrackBar3
        '
        Me.TrackBar3.Location = New System.Drawing.Point(10, 339)
        Me.TrackBar3.Maximum = 9
        Me.TrackBar3.Minimum = 1
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(128, 56)
        Me.TrackBar3.TabIndex = 13
        Me.TrackBar3.Value = 1
        '
        'TrackBar4
        '
        Me.TrackBar4.Location = New System.Drawing.Point(229, 339)
        Me.TrackBar4.Minimum = 1
        Me.TrackBar4.Name = "TrackBar4"
        Me.TrackBar4.Size = New System.Drawing.Size(128, 56)
        Me.TrackBar4.TabIndex = 10
        Me.TrackBar4.Value = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Celá část je maximálně  0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Čitatel je minimálně 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Čitatel je maximálně 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 409)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Jmenovatel je minimálně 2"
        '
        'TrackBar5
        '
        Me.TrackBar5.Location = New System.Drawing.Point(10, 429)
        Me.TrackBar5.Maximum = 9
        Me.TrackBar5.Minimum = 2
        Me.TrackBar5.Name = "TrackBar5"
        Me.TrackBar5.Size = New System.Drawing.Size(128, 56)
        Me.TrackBar5.TabIndex = 17
        Me.TrackBar5.Value = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 409)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Jmenovatel je maximálně 2"
        '
        'TrackBar6
        '
        Me.TrackBar6.Location = New System.Drawing.Point(232, 429)
        Me.TrackBar6.Minimum = 2
        Me.TrackBar6.Name = "TrackBar6"
        Me.TrackBar6.Size = New System.Drawing.Size(128, 56)
        Me.TrackBar6.TabIndex = 19
        Me.TrackBar6.Value = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button2.Location = New System.Drawing.Point(579, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(268, 52)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Sestav příklady (+-)"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(869, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Počet příkladů je 10"
        '
        'TrackBar7
        '
        Me.TrackBar7.Location = New System.Drawing.Point(872, 42)
        Me.TrackBar7.Maximum = 26
        Me.TrackBar7.Minimum = 1
        Me.TrackBar7.Name = "TrackBar7"
        Me.TrackBar7.Size = New System.Drawing.Size(201, 56)
        Me.TrackBar7.TabIndex = 23
        Me.TrackBar7.Value = 10
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(544, 473)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox4.Size = New System.Drawing.Size(577, 128)
        Me.TextBox4.TabIndex = 24
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button3.Location = New System.Drawing.Point(838, 607)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(283, 53)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Kopíruj do schránky"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Lime
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button4.Location = New System.Drawing.Point(271, 150)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(252, 43)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Vše vymaž"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(544, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 28)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Zadání"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(544, 442)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 28)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Řešení"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button5.Location = New System.Drawing.Point(838, 414)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(283, 53)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Kopíruj do schránky"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button6.Location = New System.Drawing.Point(579, 79)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(268, 47)
        Me.Button6.TabIndex = 30
        Me.Button6.Text = "Sestav příklady (·)"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button7.Location = New System.Drawing.Point(584, 132)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(263, 47)
        Me.Button7.TabIndex = 31
        Me.Button7.Text = "Sestav příklady (·, :)"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button8.Location = New System.Drawing.Point(584, 185)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(263, 47)
        Me.Button8.TabIndex = 32
        Me.Button8.Text = "Sestav příklady mix"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button9.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button9.Location = New System.Drawing.Point(853, 79)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(263, 47)
        Me.Button9.TabIndex = 33
        Me.Button9.Text = "Sestav příklady (:)"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 672)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TrackBar7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TrackBar6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TrackBar5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TrackBar3)
        Me.Controls.Add(Me.TrackBar4)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Generátor příkladů se zlomky pro Open Office"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents TrackBar3 As TrackBar
    Friend WithEvents TrackBar4 As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TrackBar5 As TrackBar
    Friend WithEvents Label6 As Label
    Friend WithEvents TrackBar6 As TrackBar
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TrackBar7 As TrackBar
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
