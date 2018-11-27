<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiCourses
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
        Me.rdoHND = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoNatDip = New System.Windows.Forms.RadioButton()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblMark3 = New System.Windows.Forms.Label()
        Me.lblMark2 = New System.Windows.Forms.Label()
        Me.lblMark1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.btnHighest = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.npdIndex = New System.Windows.Forms.NumericUpDown()
        Me.txtMark1 = New System.Windows.Forms.TextBox()
        Me.txtMark2 = New System.Windows.Forms.TextBox()
        Me.txtMark3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.btnGrade = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.npdIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoHND
        '
        Me.rdoHND.AutoSize = True
        Me.rdoHND.Location = New System.Drawing.Point(72, 60)
        Me.rdoHND.Name = "rdoHND"
        Me.rdoHND.Size = New System.Drawing.Size(49, 17)
        Me.rdoHND.TabIndex = 1
        Me.rdoHND.TabStop = True
        Me.rdoHND.Text = "HND"
        Me.rdoHND.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoHND)
        Me.GroupBox2.Controls.Add(Me.rdoNatDip)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 100)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'rdoNatDip
        '
        Me.rdoNatDip.AutoSize = True
        Me.rdoNatDip.Location = New System.Drawing.Point(72, 28)
        Me.rdoNatDip.Name = "rdoNatDip"
        Me.rdoNatDip.Size = New System.Drawing.Size(61, 17)
        Me.rdoNatDip.TabIndex = 0
        Me.rdoNatDip.TabStop = True
        Me.rdoNatDip.Text = "Nat Dip"
        Me.rdoNatDip.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(6, 85)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(86, 43)
        Me.btnFind.TabIndex = 1
        Me.btnFind.Text = "Find Student "
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnTransfer
        '
        Me.btnTransfer.Location = New System.Drawing.Point(387, 53)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(267, 59)
        Me.btnTransfer.TabIndex = 30
        Me.btnTransfer.Text = "Transfer Student "
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(199, 56)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(166, 20)
        Me.txtName.TabIndex = 17
        '
        'lblMark3
        '
        Me.lblMark3.AutoSize = True
        Me.lblMark3.Location = New System.Drawing.Point(481, 115)
        Me.lblMark3.Name = "lblMark3"
        Me.lblMark3.Size = New System.Drawing.Size(43, 13)
        Me.lblMark3.TabIndex = 10
        Me.lblMark3.Text = "Mark 3:"
        '
        'lblMark2
        '
        Me.lblMark2.AutoSize = True
        Me.lblMark2.Location = New System.Drawing.Point(481, 85)
        Me.lblMark2.Name = "lblMark2"
        Me.lblMark2.Size = New System.Drawing.Size(43, 13)
        Me.lblMark2.TabIndex = 11
        Me.lblMark2.Text = "Mark 2:"
        '
        'lblMark1
        '
        Me.lblMark1.AutoSize = True
        Me.lblMark1.Location = New System.Drawing.Point(481, 45)
        Me.lblMark1.Name = "lblMark1"
        Me.lblMark1.Size = New System.Drawing.Size(43, 13)
        Me.lblMark1.TabIndex = 12
        Me.lblMark1.Text = "Mark 1:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(218, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "Name"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(6, 31)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(86, 39)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create Student "
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(716, 386)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(35, 13)
        Me.lblCount.TabIndex = 28
        Me.lblCount.Text = "Count"
        '
        'btnHighest
        '
        Me.btnHighest.Location = New System.Drawing.Point(578, 348)
        Me.btnHighest.Name = "btnHighest"
        Me.btnHighest.Size = New System.Drawing.Size(114, 48)
        Me.btnHighest.TabIndex = 26
        Me.btnHighest.Text = "Highest"
        Me.btnHighest.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(578, 401)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(114, 47)
        Me.btnRemove.TabIndex = 25
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(578, 298)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(114, 48)
        Me.btnAverage.TabIndex = 23
        Me.btnAverage.Text = "Average "
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'npdIndex
        '
        Me.npdIndex.Location = New System.Drawing.Point(271, 314)
        Me.npdIndex.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.npdIndex.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.npdIndex.Name = "npdIndex"
        Me.npdIndex.Size = New System.Drawing.Size(33, 20)
        Me.npdIndex.TabIndex = 22
        Me.npdIndex.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtMark1
        '
        Me.txtMark1.Location = New System.Drawing.Point(543, 45)
        Me.txtMark1.Name = "txtMark1"
        Me.txtMark1.Size = New System.Drawing.Size(100, 20)
        Me.txtMark1.TabIndex = 16
        '
        'txtMark2
        '
        Me.txtMark2.Location = New System.Drawing.Point(543, 78)
        Me.txtMark2.Name = "txtMark2"
        Me.txtMark2.Size = New System.Drawing.Size(100, 20)
        Me.txtMark2.TabIndex = 15
        '
        'txtMark3
        '
        Me.txtMark3.Location = New System.Drawing.Point(543, 112)
        Me.txtMark3.Name = "txtMark3"
        Me.txtMark3.Size = New System.Drawing.Size(100, 20)
        Me.txtMark3.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtMark1)
        Me.GroupBox1.Controls.Add(Me.txtMark2)
        Me.GroupBox1.Controls.Add(Me.txtMark3)
        Me.GroupBox1.Controls.Add(Me.btnFind)
        Me.GroupBox1.Controls.Add(Me.lblMark3)
        Me.GroupBox1.Controls.Add(Me.lblMark2)
        Me.GroupBox1.Controls.Add(Me.lblMark1)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.btnCreate)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(701, 179)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create Students"
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Location = New System.Drawing.Point(22, 377)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(39, 13)
        Me.lblDetails.TabIndex = 27
        Me.lblDetails.Text = "Label5"
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(578, 450)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(114, 48)
        Me.btnList.TabIndex = 24
        Me.btnList.Text = "List"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(25, 303)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(107, 48)
        Me.btnDetails.TabIndex = 20
        Me.btnDetails.Text = "Details"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'btnGrade
        '
        Me.btnGrade.Location = New System.Drawing.Point(140, 303)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.Size = New System.Drawing.Size(107, 48)
        Me.btnGrade.TabIndex = 19
        Me.btnGrade.Text = "Grade"
        Me.btnGrade.UseVisualStyleBackColor = True
        '
        'frmMultiCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 514)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnHighest)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.npdIndex)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.btnGrade)
        Me.Name = "frmMultiCourses"
        Me.Text = "frmMultiCourses"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.npdIndex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoHND As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdoNatDip As RadioButton
    Friend WithEvents btnFind As Button
    Friend WithEvents btnTransfer As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblMark3 As Label
    Friend WithEvents lblMark2 As Label
    Friend WithEvents lblMark1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents btnHighest As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAverage As Button
    Friend WithEvents npdIndex As NumericUpDown
    Friend WithEvents txtMark1 As TextBox
    Friend WithEvents txtMark2 As TextBox
    Friend WithEvents txtMark3 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDetails As Label
    Friend WithEvents btnList As Button
    Friend WithEvents btnDetails As Button
    Friend WithEvents btnGrade As Button
End Class
