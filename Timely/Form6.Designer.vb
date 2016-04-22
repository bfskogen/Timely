<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "name here"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date Requested:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(187, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "name here"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Time Requested:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(187, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "name here"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(241, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 48)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Approve"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGray
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(82, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 48)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Deny"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(445, 337)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timely"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
