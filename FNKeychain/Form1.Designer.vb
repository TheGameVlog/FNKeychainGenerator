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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAES = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtKeychain = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtPakName = New System.Windows.Forms.Label()
        Me.txtGUID = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(198, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fortnite Keychain Generator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter AES :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter GUID :"
        '
        'txtAES
        '
        Me.txtAES.Location = New System.Drawing.Point(104, 93)
        Me.txtAES.Name = "txtAES"
        Me.txtAES.Size = New System.Drawing.Size(419, 23)
        Me.txtAES.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(237, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 25)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtKeychain
        '
        Me.txtKeychain.BackColor = System.Drawing.Color.White
        Me.txtKeychain.Location = New System.Drawing.Point(34, 225)
        Me.txtKeychain.Name = "txtKeychain"
        Me.txtKeychain.ReadOnly = True
        Me.txtKeychain.Size = New System.Drawing.Size(489, 23)
        Me.txtKeychain.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(234, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "New Keychain"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(163, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Currently available Keychains in Nitestats"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(33, 361)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(489, 437)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(208, 295)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 25)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Load NiteStats Keychains"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(34, 254)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(127, 25)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add to List"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(208, 808)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 25)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Send to Pastebin"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtPakName
        '
        Me.txtPakName.Location = New System.Drawing.Point(230, 132)
        Me.txtPakName.Name = "txtPakName"
        Me.txtPakName.Size = New System.Drawing.Size(82, 15)
        Me.txtPakName.TabIndex = 13
        '
        'txtGUID
        '
        Me.txtGUID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtGUID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtGUID.Location = New System.Drawing.Point(103, 64)
        Me.txtGUID.Name = "txtGUID"
        Me.txtGUID.Size = New System.Drawing.Size(419, 23)
        Me.txtGUID.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 850)
        Me.Controls.Add(Me.txtGUID)
        Me.Controls.Add(Me.txtPakName)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKeychain)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtAES)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "FN Keychain Updater"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAES As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtKeychain As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label5 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtPakName As Label
    Friend WithEvents txtGUID As TextBox
End Class
