<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculadora))
        Me.btnC = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnMultiplicacion = New System.Windows.Forms.Button()
        Me.btnComa = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.Color.OrangeRed
        Me.btnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.ForeColor = System.Drawing.SystemColors.Control
        Me.btnC.Location = New System.Drawing.Point(372, 289)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(93, 65)
        Me.btnC.TabIndex = 57
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'txtResultado
        '
        Me.txtResultado.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(241, 376)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(454, 62)
        Me.txtResultado.TabIndex = 56
        '
        'btnResta
        '
        Me.btnResta.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.Location = New System.Drawing.Point(602, 200)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(93, 65)
        Me.btnResta.TabIndex = 54
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = False
        '
        'btnSuma
        '
        Me.btnSuma.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.Location = New System.Drawing.Point(503, 200)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(93, 65)
        Me.btnSuma.TabIndex = 53
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = False
        '
        'btnDivision
        '
        Me.btnDivision.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.Location = New System.Drawing.Point(602, 289)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(93, 65)
        Me.btnDivision.TabIndex = 52
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = False
        '
        'btnMultiplicacion
        '
        Me.btnMultiplicacion.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnMultiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicacion.Location = New System.Drawing.Point(503, 289)
        Me.btnMultiplicacion.Name = "btnMultiplicacion"
        Me.btnMultiplicacion.Size = New System.Drawing.Size(93, 65)
        Me.btnMultiplicacion.TabIndex = 51
        Me.btnMultiplicacion.Text = "x"
        Me.btnMultiplicacion.UseVisualStyleBackColor = False
        '
        'btnComa
        '
        Me.btnComa.BackColor = System.Drawing.SystemColors.InfoText
        Me.btnComa.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComa.ForeColor = System.Drawing.SystemColors.Control
        Me.btnComa.Location = New System.Drawing.Point(114, 289)
        Me.btnComa.Name = "btnComa"
        Me.btnComa.Size = New System.Drawing.Size(93, 65)
        Me.btnComa.TabIndex = 50
        Me.btnComa.Text = "."
        Me.btnComa.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.SystemColors.InfoText
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.ForeColor = System.Drawing.SystemColors.Control
        Me.btn0.Location = New System.Drawing.Point(241, 289)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(93, 65)
        Me.btn0.TabIndex = 49
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.SystemColors.InfoText
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.SystemColors.Control
        Me.btn9.Location = New System.Drawing.Point(372, 200)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(93, 65)
        Me.btn9.TabIndex = 48
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.SystemColors.InfoText
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.SystemColors.Control
        Me.btn8.Location = New System.Drawing.Point(241, 200)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(93, 65)
        Me.btn8.TabIndex = 47
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.SystemColors.InfoText
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.SystemColors.Control
        Me.btn7.Location = New System.Drawing.Point(114, 200)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(93, 65)
        Me.btn7.TabIndex = 46
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.SystemColors.InfoText
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.SystemColors.Control
        Me.btn6.Location = New System.Drawing.Point(372, 108)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(93, 65)
        Me.btn6.TabIndex = 45
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.SystemColors.InfoText
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.SystemColors.Control
        Me.btn5.Location = New System.Drawing.Point(241, 108)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(93, 65)
        Me.btn5.TabIndex = 44
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.SystemColors.InfoText
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.SystemColors.Control
        Me.btn4.Location = New System.Drawing.Point(114, 108)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(93, 65)
        Me.btn4.TabIndex = 43
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.SystemColors.InfoText
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.SystemColors.Control
        Me.btn3.Location = New System.Drawing.Point(372, 16)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(93, 65)
        Me.btn3.TabIndex = 42
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.SystemColors.InfoText
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.SystemColors.Control
        Me.btn2.Location = New System.Drawing.Point(241, 16)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(93, 65)
        Me.btn2.TabIndex = 41
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.SystemColors.InfoText
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.SystemColors.Control
        Me.btn1.Location = New System.Drawing.Point(114, 16)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(93, 65)
        Me.btn1.TabIndex = 40
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(503, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(114, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 65)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "="
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnMultiplicacion)
        Me.Controls.Add(Me.btnComa)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnC As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnResta As Button
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnMultiplicacion As Button
    Friend WithEvents btnComa As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
