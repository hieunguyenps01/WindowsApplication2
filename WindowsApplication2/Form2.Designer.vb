<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChứcNăngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrợGiúpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BảnQuyềnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChứcNăngToolStripMenuItem, Me.TrợGiúpToolStripMenuItem, Me.BảnQuyềnToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(565, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChứcNăngToolStripMenuItem
        '
        Me.ChứcNăngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýSảnPhẩmToolStripMenuItem})
        Me.ChứcNăngToolStripMenuItem.Name = "ChứcNăngToolStripMenuItem"
        Me.ChứcNăngToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.ChứcNăngToolStripMenuItem.Text = "Chức Năng"
        '
        'TrợGiúpToolStripMenuItem
        '
        Me.TrợGiúpToolStripMenuItem.Name = "TrợGiúpToolStripMenuItem"
        Me.TrợGiúpToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.TrợGiúpToolStripMenuItem.Text = "Trợ giúp"
        '
        'BảnQuyềnToolStripMenuItem
        '
        Me.BảnQuyềnToolStripMenuItem.Name = "BảnQuyềnToolStripMenuItem"
        Me.BảnQuyềnToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BảnQuyềnToolStripMenuItem.Text = "Bản quyền"
        '
        'QuảnLýSảnPhẩmToolStripMenuItem
        '
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Name = "QuảnLýSảnPhẩmToolStripMenuItem"
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(204, 125)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(114, 13)
        Me.lbl3.TabIndex = 1
        Me.lbl3.Text = "Welcome administrator"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 321)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "index"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ChứcNăngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrợGiúpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BảnQuyềnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl3 As System.Windows.Forms.Label
End Class
