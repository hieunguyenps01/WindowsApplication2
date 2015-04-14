<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.txtMa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.drvDS = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnUpD = New System.Windows.Forms.Button()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.cbxSP = New System.Windows.Forms.ComboBox()
        Me.txtSL = New System.Windows.Forms.TextBox()
        Me.txtGia = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.drvDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMa
        '
        Me.txtMa.Location = New System.Drawing.Point(136, 41)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(100, 20)
        Me.txtMa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Loại sản phẩm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Số lượng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Giá"
        '
        'drvDS
        '
        Me.drvDS.AllowUserToAddRows = False
        Me.drvDS.AllowUserToDeleteRows = False
        Me.drvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.drvDS.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.drvDS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.drvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drvDS.GridColor = System.Drawing.Color.Silver
        Me.drvDS.Location = New System.Drawing.Point(46, 247)
        Me.drvDS.Name = "drvDS"
        Me.drvDS.ReadOnly = True
        Me.drvDS.RowHeadersVisible = False
        Me.drvDS.Size = New System.Drawing.Size(624, 150)
        Me.drvDS.TabIndex = 9
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(559, 118)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Thêm"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(559, 186)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 7
        Me.btnDel.Text = "Xoá"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnUpD
        '
        Me.btnUpD.Location = New System.Drawing.Point(559, 153)
        Me.btnUpD.Name = "btnUpD"
        Me.btnUpD.Size = New System.Drawing.Size(75, 23)
        Me.btnUpD.TabIndex = 8
        Me.btnUpD.Text = "Sửa"
        Me.btnUpD.UseVisualStyleBackColor = True
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(136, 74)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(156, 20)
        Me.txtTen.TabIndex = 2
        '
        'cbxSP
        '
        Me.cbxSP.FormattingEnabled = True
        Me.cbxSP.Items.AddRange(New Object() {"ps01", "ps02"})
        Me.cbxSP.Location = New System.Drawing.Point(136, 107)
        Me.cbxSP.Name = "cbxSP"
        Me.cbxSP.Size = New System.Drawing.Size(133, 21)
        Me.cbxSP.TabIndex = 3
        '
        'txtSL
        '
        Me.txtSL.Location = New System.Drawing.Point(136, 141)
        Me.txtSL.Name = "txtSL"
        Me.txtSL.Size = New System.Drawing.Size(100, 20)
        Me.txtSL.TabIndex = 4
        '
        'txtGia
        '
        Me.txtGia.Location = New System.Drawing.Point(136, 174)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(148, 20)
        Me.txtGia.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtGia)
        Me.GroupBox1.Controls.Add(Me.txtMa)
        Me.GroupBox1.Controls.Add(Me.txtSL)
        Me.GroupBox1.Controls.Add(Me.txtTen)
        Me.GroupBox1.Controls.Add(Me.cbxSP)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 406)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnUpD)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.drvDS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "Quản lý sản phẩm"
        CType(Me.drvDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtMa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents drvDS As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnUpD As System.Windows.Forms.Button
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents cbxSP As System.Windows.Forms.ComboBox
    Friend WithEvents txtSL As System.Windows.Forms.TextBox
    Friend WithEvents txtGia As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
