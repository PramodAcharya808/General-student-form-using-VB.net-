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
        Me.Label1head = New System.Windows.Forms.Label()
        Me.Label2name = New System.Windows.Forms.Label()
        Me.Label3dept = New System.Windows.Forms.Label()
        Me.Label4sem = New System.Windows.Forms.Label()
        Me.namebox = New System.Windows.Forms.TextBox()
        Me.deptbox = New System.Windows.Forms.ComboBox()
        Me.sembox = New System.Windows.Forms.ComboBox()
        Me.Label5marks = New System.Windows.Forms.Label()
        Me.marksbox = New System.Windows.Forms.TextBox()
        Me.display = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.bold = New System.Windows.Forms.CheckBox()
        Me.italic = New System.Windows.Forms.CheckBox()
        Me.underline = New System.Windows.Forms.CheckBox()
        Me.checkv = New System.Windows.Forms.Button()
        Me.vowles = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.result = New System.Windows.Forms.Button()
        Me.resultbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1head
        '
        Me.Label1head.AutoSize = True
        Me.Label1head.BackColor = System.Drawing.Color.Black
        Me.Label1head.Font = New System.Drawing.Font("Segoe UI", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1head.ForeColor = System.Drawing.Color.White
        Me.Label1head.Location = New System.Drawing.Point(49, 9)
        Me.Label1head.Name = "Label1head"
        Me.Label1head.Size = New System.Drawing.Size(321, 37)
        Me.Label1head.TabIndex = 0
        Me.Label1head.Text = "STUDENT DETAIL FORM"
        '
        'Label2name
        '
        Me.Label2name.AutoSize = True
        Me.Label2name.BackColor = System.Drawing.Color.Black
        Me.Label2name.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2name.ForeColor = System.Drawing.Color.White
        Me.Label2name.Location = New System.Drawing.Point(51, 104)
        Me.Label2name.Name = "Label2name"
        Me.Label2name.Size = New System.Drawing.Size(50, 19)
        Me.Label2name.TabIndex = 1
        Me.Label2name.Text = "NAME"
        '
        'Label3dept
        '
        Me.Label3dept.AutoSize = True
        Me.Label3dept.BackColor = System.Drawing.Color.Black
        Me.Label3dept.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3dept.ForeColor = System.Drawing.Color.White
        Me.Label3dept.Location = New System.Drawing.Point(51, 165)
        Me.Label3dept.Name = "Label3dept"
        Me.Label3dept.Size = New System.Drawing.Size(100, 19)
        Me.Label3dept.TabIndex = 2
        Me.Label3dept.Text = "DEPARTMENT"
        '
        'Label4sem
        '
        Me.Label4sem.AutoSize = True
        Me.Label4sem.BackColor = System.Drawing.Color.Black
        Me.Label4sem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4sem.ForeColor = System.Drawing.Color.White
        Me.Label4sem.Location = New System.Drawing.Point(51, 226)
        Me.Label4sem.Name = "Label4sem"
        Me.Label4sem.Size = New System.Drawing.Size(76, 19)
        Me.Label4sem.TabIndex = 3
        Me.Label4sem.Text = "SEMESTER"
        '
        'namebox
        '
        Me.namebox.Location = New System.Drawing.Point(189, 100)
        Me.namebox.Name = "namebox"
        Me.namebox.Size = New System.Drawing.Size(225, 23)
        Me.namebox.TabIndex = 4
        '
        'deptbox
        '
        Me.deptbox.FormattingEnabled = True
        Me.deptbox.Items.AddRange(New Object() {"BCA", "BHM", "BCOM", "BBA", "MTTM", "MBA", "MCOM"})
        Me.deptbox.Location = New System.Drawing.Point(189, 161)
        Me.deptbox.Name = "deptbox"
        Me.deptbox.Size = New System.Drawing.Size(225, 23)
        Me.deptbox.TabIndex = 5
        '
        'sembox
        '
        Me.sembox.FormattingEnabled = True
        Me.sembox.Items.AddRange(New Object() {"I", "II", "III", "IV", "V", "VI", "VII", "VIII"})
        Me.sembox.Location = New System.Drawing.Point(189, 222)
        Me.sembox.Name = "sembox"
        Me.sembox.Size = New System.Drawing.Size(225, 23)
        Me.sembox.TabIndex = 6
        '
        'Label5marks
        '
        Me.Label5marks.AutoSize = True
        Me.Label5marks.BackColor = System.Drawing.Color.Black
        Me.Label5marks.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5marks.ForeColor = System.Drawing.Color.White
        Me.Label5marks.Location = New System.Drawing.Point(51, 292)
        Me.Label5marks.Name = "Label5marks"
        Me.Label5marks.Size = New System.Drawing.Size(58, 19)
        Me.Label5marks.TabIndex = 7
        Me.Label5marks.Text = "MARKS"
        '
        'marksbox
        '
        Me.marksbox.Location = New System.Drawing.Point(189, 288)
        Me.marksbox.Name = "marksbox"
        Me.marksbox.Size = New System.Drawing.Size(225, 23)
        Me.marksbox.TabIndex = 8
        '
        'display
        '
        Me.display.Location = New System.Drawing.Point(189, 347)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(75, 24)
        Me.display.TabIndex = 9
        Me.display.Text = "DISPLAY"
        Me.display.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.reset.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.reset.Location = New System.Drawing.Point(157, 534)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(139, 34)
        Me.reset.TabIndex = 10
        Me.reset.Text = "RESET"
        Me.reset.UseVisualStyleBackColor = False
        '
        'bold
        '
        Me.bold.AutoSize = True
        Me.bold.ForeColor = System.Drawing.Color.White
        Me.bold.Location = New System.Drawing.Point(456, 102)
        Me.bold.Name = "bold"
        Me.bold.Size = New System.Drawing.Size(56, 19)
        Me.bold.TabIndex = 11
        Me.bold.Text = "BOLD"
        Me.bold.UseVisualStyleBackColor = True
        '
        'italic
        '
        Me.italic.AutoSize = True
        Me.italic.ForeColor = System.Drawing.Color.White
        Me.italic.Location = New System.Drawing.Point(456, 127)
        Me.italic.Name = "italic"
        Me.italic.Size = New System.Drawing.Size(59, 19)
        Me.italic.TabIndex = 12
        Me.italic.Text = "ITALIC"
        Me.italic.UseVisualStyleBackColor = True
        '
        'underline
        '
        Me.underline.AutoSize = True
        Me.underline.ForeColor = System.Drawing.Color.White
        Me.underline.Location = New System.Drawing.Point(456, 152)
        Me.underline.Name = "underline"
        Me.underline.Size = New System.Drawing.Size(88, 19)
        Me.underline.TabIndex = 13
        Me.underline.Text = "UNDERLINE"
        Me.underline.UseVisualStyleBackColor = True
        '
        'checkv
        '
        Me.checkv.Location = New System.Drawing.Point(270, 347)
        Me.checkv.Name = "checkv"
        Me.checkv.Size = New System.Drawing.Size(106, 24)
        Me.checkv.TabIndex = 14
        Me.checkv.Text = "CHECK VOWELS"
        Me.checkv.UseVisualStyleBackColor = True
        '
        'vowles
        '
        Me.vowles.Location = New System.Drawing.Point(382, 347)
        Me.vowles.Name = "vowles"
        Me.vowles.Size = New System.Drawing.Size(32, 23)
        Me.vowles.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(12, 534)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 34)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "SAFE EXIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'result
        '
        Me.result.Location = New System.Drawing.Point(52, 389)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(75, 23)
        Me.result.TabIndex = 17
        Me.result.Text = "RESULT"
        Me.result.UseVisualStyleBackColor = True
        '
        'resultbox
        '
        Me.resultbox.BackColor = System.Drawing.SystemColors.InfoText
        Me.resultbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.resultbox.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.resultbox.ForeColor = System.Drawing.Color.White
        Me.resultbox.Location = New System.Drawing.Point(189, 389)
        Me.resultbox.Name = "resultbox"
        Me.resultbox.Size = New System.Drawing.Size(225, 27)
        Me.resultbox.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(588, 586)
        Me.Controls.Add(Me.resultbox)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.vowles)
        Me.Controls.Add(Me.checkv)
        Me.Controls.Add(Me.underline)
        Me.Controls.Add(Me.italic)
        Me.Controls.Add(Me.bold)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.display)
        Me.Controls.Add(Me.marksbox)
        Me.Controls.Add(Me.Label5marks)
        Me.Controls.Add(Me.sembox)
        Me.Controls.Add(Me.deptbox)
        Me.Controls.Add(Me.namebox)
        Me.Controls.Add(Me.Label4sem)
        Me.Controls.Add(Me.Label3dept)
        Me.Controls.Add(Me.Label2name)
        Me.Controls.Add(Me.Label1head)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1head As Label
    Friend WithEvents Label2name As Label
    Friend WithEvents Label3dept As Label
    Friend WithEvents Label4sem As Label
    Friend WithEvents namebox As TextBox
    Friend WithEvents deptbox As ComboBox
    Friend WithEvents sembox As ComboBox
    Friend WithEvents Label5marks As Label
    Friend WithEvents marksbox As TextBox
    Friend WithEvents display As Button
    Friend WithEvents reset As Button
    Friend WithEvents bold As CheckBox
    Friend WithEvents italic As CheckBox
    Friend WithEvents underline As CheckBox
    Friend WithEvents checkv As Button
    Friend WithEvents vowles As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents result As Button
    Friend WithEvents resultbox As TextBox
End Class
