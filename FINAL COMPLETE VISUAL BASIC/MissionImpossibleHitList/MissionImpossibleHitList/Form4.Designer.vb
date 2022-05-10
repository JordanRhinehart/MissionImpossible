<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnTime = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DimGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(590, 311)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(47, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(599, 155)
        Me.Label1.TabIndex = 4
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.Black
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPay.ForeColor = System.Drawing.Color.Lime
        Me.btnPay.Location = New System.Drawing.Point(84, 161)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(115, 23)
        Me.btnPay.TabIndex = 0
        Me.btnPay.Text = "Pay Money"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'btnTime
        '
        Me.btnTime.BackColor = System.Drawing.Color.Black
        Me.btnTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTime.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btnTime.Location = New System.Drawing.Point(296, 161)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(115, 23)
        Me.btnTime.TabIndex = 1
        Me.btnTime.Text = "Request More Time"
        Me.btnTime.UseVisualStyleBackColor = False
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.Black
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFind.ForeColor = System.Drawing.Color.Red
        Me.btnFind.Location = New System.Drawing.Point(499, 161)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(115, 23)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "Try to Find"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Lime
        Me.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.ForeColor = System.Drawing.Color.Black
        Me.btnEnd.Location = New System.Drawing.Point(214, 278)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(272, 47)
        Me.btnEnd.TabIndex = 5
        Me.btnEnd.Text = "MAKE THE TRADE"
        Me.btnEnd.UseVisualStyleBackColor = False
        Me.btnEnd.Visible = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(709, 360)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnTime)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents btnTime As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents btnEnd As Button
End Class
