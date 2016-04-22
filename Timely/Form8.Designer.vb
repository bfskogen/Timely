<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Request Shift Trade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "(Save Each Day)"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(303, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 28)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "From"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"6:00am", "7:00am", "8:00am", "9:00am", "10:00am", "11:00am", "12:00pm", "1:00pm", "2:00pm", "3:00pm", "4:00pm", "5:00pm", "6:00pm"})
        Me.ComboBox2.Location = New System.Drawing.Point(147, 169)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2.TabIndex = 52
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"6:00am", "7:00am", "8:00am", "9:00am", "10:00am", "11:00am", "12:00pm", "1:00pm", "2:00pm", "3:00pm", "4:00pm", "5:00pm", "6:00pm"})
        Me.ComboBox1.Location = New System.Drawing.Point(17, 169)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 51
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGray
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(303, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 51)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(17, 101)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(251, 22)
        Me.DateTimePicker1.TabIndex = 49
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(445, 337)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label9)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form8"
        Me.Text = "Timely"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
