<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_person_form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.txt_nickname = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_add = New FontAwesome.Sharp.IconButton()
        Me.btn_update = New FontAwesome.Sharp.IconButton()
        Me.btn_delete = New FontAwesome.Sharp.IconButton()
        Me.txt_address = New System.Windows.Forms.RichTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_show = New FontAwesome.Sharp.IconButton()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_types = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number:"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(140, 82)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(170, 20)
        Me.txt_name.TabIndex = 2
        '
        'txt_number
        '
        Me.txt_number.Location = New System.Drawing.Point(140, 108)
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(170, 20)
        Me.txt_number.TabIndex = 3
        '
        'txt_nickname
        '
        Me.txt_nickname.Location = New System.Drawing.Point(140, 134)
        Me.txt_nickname.Name = "txt_nickname"
        Me.txt_nickname.Size = New System.Drawing.Size(170, 20)
        Me.txt_nickname.TabIndex = 4
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(140, 160)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(170, 20)
        Me.txt_email.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nickname:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(528, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 27)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "CONTACTS"
        '
        'btn_add
        '
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.IconChar = FontAwesome.Sharp.IconChar.CircleUser
        Me.btn_add.IconColor = System.Drawing.Color.Black
        Me.btn_add.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_add.IconSize = 30
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(30, 369)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(91, 45)
        Me.btn_add.TabIndex = 13
        Me.btn_add.Text = "ADD>"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.btn_update.IconColor = System.Drawing.Color.Black
        Me.btn_update.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_update.IconSize = 30
        Me.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_update.Location = New System.Drawing.Point(127, 369)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(109, 45)
        Me.btn_update.TabIndex = 14
        Me.btn_update.Text = "UPDATE>"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.btn_delete.IconColor = System.Drawing.Color.Black
        Me.btn_delete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_delete.IconSize = 30
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Location = New System.Drawing.Point(242, 369)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(109, 45)
        Me.btn_delete.TabIndex = 15
        Me.btn_delete.Text = "DELETE>"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(140, 213)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(170, 103)
        Me.txt_address.TabIndex = 16
        Me.txt_address.Text = ""
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(356, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(444, 275)
        Me.DataGridView1.TabIndex = 17
        '
        'btn_show
        '
        Me.btn_show.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_show.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_show.IconChar = FontAwesome.Sharp.IconChar.Forward
        Me.btn_show.IconColor = System.Drawing.Color.Black
        Me.btn_show.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_show.IconSize = 30
        Me.btn_show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_show.Location = New System.Drawing.Point(703, 31)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(97, 45)
        Me.btn_show.TabIndex = 18
        Me.btn_show.Text = "SHOW>"
        Me.btn_show.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_show.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_show.UseVisualStyleBackColor = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(365, 85)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(13, 13)
        Me.lbl_id.TabIndex = 19
        Me.lbl_id.Text = "0"
        '
        'cmb_type
        '
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Items.AddRange(New Object() {"Employee", "Admin", "User"})
        Me.cmb_type.Location = New System.Drawing.Point(140, 186)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(170, 21)
        Me.cmb_type.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Type:"
        '
        'cmb_types
        '
        Me.cmb_types.FormattingEnabled = True
        Me.cmb_types.Location = New System.Drawing.Point(238, 36)
        Me.cmb_types.Name = "cmb_types"
        Me.cmb_types.Size = New System.Drawing.Size(140, 21)
        Me.cmb_types.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(55, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 20)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "SELECT TYPE TO DISPLAY:"
        '
        'add_person_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(829, 428)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmb_types)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.btn_show)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_nickname)
        Me.Controls.Add(Me.txt_number)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_id)
        Me.Name = "add_person_form"
        Me.Text = "addperson"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_number As TextBox
    Friend WithEvents txt_nickname As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_add As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_update As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_delete As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_address As RichTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_show As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_id As Label
    Friend WithEvents cmb_type As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_types As ComboBox
    Friend WithEvents Label8 As Label
End Class
