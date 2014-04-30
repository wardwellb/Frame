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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBartransfer = New System.Windows.Forms.ProgressBar()
        Me.ListBoxfiles = New System.Windows.Forms.ListBox()
        Me.buttonlocation = New System.Windows.Forms.Button()
        Me.butdestination = New System.Windows.Forms.Button()
        Me.txtboxdestination = New System.Windows.Forms.TextBox()
        Me.txtboxlocation = New System.Windows.Forms.TextBox()
        Me.buttransfer = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Rbuttonsize = New System.Windows.Forms.RadioButton()
        Me.rbuttonphotos = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtboxfill = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(572, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBartransfer
        '
        Me.ProgressBartransfer.Location = New System.Drawing.Point(84, 416)
        Me.ProgressBartransfer.Name = "ProgressBartransfer"
        Me.ProgressBartransfer.Size = New System.Drawing.Size(444, 10)
        Me.ProgressBartransfer.TabIndex = 1
        '
        'ListBoxfiles
        '
        Me.ListBoxfiles.FormattingEnabled = True
        Me.ListBoxfiles.Location = New System.Drawing.Point(84, 276)
        Me.ListBoxfiles.Name = "ListBoxfiles"
        Me.ListBoxfiles.Size = New System.Drawing.Size(444, 134)
        Me.ListBoxfiles.TabIndex = 2
        '
        'buttonlocation
        '
        Me.buttonlocation.Location = New System.Drawing.Point(470, 19)
        Me.buttonlocation.Name = "buttonlocation"
        Me.buttonlocation.Size = New System.Drawing.Size(77, 19)
        Me.buttonlocation.TabIndex = 3
        Me.buttonlocation.Text = "Browse"
        Me.buttonlocation.UseVisualStyleBackColor = True
        '
        'butdestination
        '
        Me.butdestination.Location = New System.Drawing.Point(470, 44)
        Me.butdestination.Name = "butdestination"
        Me.butdestination.Size = New System.Drawing.Size(76, 19)
        Me.butdestination.TabIndex = 4
        Me.butdestination.Text = "Browse"
        Me.butdestination.UseVisualStyleBackColor = True
        '
        'txtboxdestination
        '
        Me.txtboxdestination.Location = New System.Drawing.Point(122, 44)
        Me.txtboxdestination.Name = "txtboxdestination"
        Me.txtboxdestination.Size = New System.Drawing.Size(307, 20)
        Me.txtboxdestination.TabIndex = 5
        Me.txtboxdestination.Text = "Where to transfer the photos to"
        '
        'txtboxlocation
        '
        Me.txtboxlocation.Location = New System.Drawing.Point(122, 19)
        Me.txtboxlocation.Name = "txtboxlocation"
        Me.txtboxlocation.Size = New System.Drawing.Size(307, 20)
        Me.txtboxlocation.TabIndex = 6
        Me.txtboxlocation.Text = "Folder to transfer photos from"
        '
        'buttransfer
        '
        Me.buttransfer.Location = New System.Drawing.Point(572, 276)
        Me.buttransfer.Name = "buttransfer"
        Me.buttransfer.Size = New System.Drawing.Size(75, 20)
        Me.buttransfer.TabIndex = 7
        Me.buttransfer.Text = "Transfer"
        Me.buttransfer.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(572, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 22)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(572, 182)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "size"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Rbuttonsize
        '
        Me.Rbuttonsize.AutoSize = True
        Me.Rbuttonsize.Checked = True
        Me.Rbuttonsize.Location = New System.Drawing.Point(362, 188)
        Me.Rbuttonsize.Name = "Rbuttonsize"
        Me.Rbuttonsize.Size = New System.Drawing.Size(45, 17)
        Me.Rbuttonsize.TabIndex = 10
        Me.Rbuttonsize.TabStop = True
        Me.Rbuttonsize.Text = "Size"
        Me.Rbuttonsize.UseVisualStyleBackColor = True
        '
        'rbuttonphotos
        '
        Me.rbuttonphotos.AutoSize = True
        Me.rbuttonphotos.Location = New System.Drawing.Point(362, 216)
        Me.rbuttonphotos.Name = "rbuttonphotos"
        Me.rbuttonphotos.Size = New System.Drawing.Size(58, 17)
        Me.rbuttonphotos.TabIndex = 11
        Me.rbuttonphotos.Text = "Photos"
        Me.rbuttonphotos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(359, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Fill Desination based on:"
        '
        'Txtboxfill
        '
        Me.Txtboxfill.Location = New System.Drawing.Point(442, 211)
        Me.Txtboxfill.Name = "Txtboxfill"
        Me.Txtboxfill.Size = New System.Drawing.Size(39, 20)
        Me.Txtboxfill.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 476)
        Me.Controls.Add(Me.Txtboxfill)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbuttonphotos)
        Me.Controls.Add(Me.Rbuttonsize)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.buttransfer)
        Me.Controls.Add(Me.txtboxlocation)
        Me.Controls.Add(Me.txtboxdestination)
        Me.Controls.Add(Me.butdestination)
        Me.Controls.Add(Me.buttonlocation)
        Me.Controls.Add(Me.ListBoxfiles)
        Me.Controls.Add(Me.ProgressBartransfer)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBartransfer As System.Windows.Forms.ProgressBar
    Friend WithEvents ListBoxfiles As System.Windows.Forms.ListBox
    Friend WithEvents buttonlocation As System.Windows.Forms.Button
    Friend WithEvents butdestination As System.Windows.Forms.Button
    Friend WithEvents txtboxdestination As System.Windows.Forms.TextBox
    Friend WithEvents txtboxlocation As System.Windows.Forms.TextBox
    Friend WithEvents buttransfer As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Rbuttonsize As System.Windows.Forms.RadioButton
    Friend WithEvents rbuttonphotos As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtboxfill As System.Windows.Forms.TextBox

End Class
