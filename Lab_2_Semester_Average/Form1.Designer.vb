<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterAverage
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
        Me.components = New System.ComponentModel.Container()
        Me.lblCourse1 = New System.Windows.Forms.Label()
        Me.lblCourse3 = New System.Windows.Forms.Label()
        Me.lblCourse2 = New System.Windows.Forms.Label()
        Me.lblCourse6 = New System.Windows.Forms.Label()
        Me.lblCourse5 = New System.Windows.Forms.Label()
        Me.lblCourse4 = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.txtCourse6 = New System.Windows.Forms.TextBox()
        Me.txtCourse5 = New System.Windows.Forms.TextBox()
        Me.txtCourse4 = New System.Windows.Forms.TextBox()
        Me.txtCourse3 = New System.Windows.Forms.TextBox()
        Me.txtCourse2 = New System.Windows.Forms.TextBox()
        Me.txtCourse1 = New System.Windows.Forms.TextBox()
        Me.lblSemesterAverage = New System.Windows.Forms.Label()
        Me.lblDisplayGrade2 = New System.Windows.Forms.Label()
        Me.lblDisplayGrade6 = New System.Windows.Forms.Label()
        Me.lblDisplayGrade5 = New System.Windows.Forms.Label()
        Me.lblDisplayGrade4 = New System.Windows.Forms.Label()
        Me.lblDisplayGrade3 = New System.Windows.Forms.Label()
        Me.lblDisplaySemesterGrade = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SemesterGradeTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblDisplayGrade1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCourse1
        '
        Me.lblCourse1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCourse1.Location = New System.Drawing.Point(17, 8)
        Me.lblCourse1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCourse1.Name = "lblCourse1"
        Me.lblCourse1.Size = New System.Drawing.Size(109, 32)
        Me.lblCourse1.TabIndex = 0
        Me.lblCourse1.Text = "Course &1:"
        Me.lblCourse1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourse3
        '
        Me.lblCourse3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCourse3.Location = New System.Drawing.Point(17, 90)
        Me.lblCourse3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCourse3.Name = "lblCourse3"
        Me.lblCourse3.Size = New System.Drawing.Size(109, 32)
        Me.lblCourse3.TabIndex = 6
        Me.lblCourse3.Text = "Course &3:"
        Me.lblCourse3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourse2
        '
        Me.lblCourse2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCourse2.Location = New System.Drawing.Point(17, 49)
        Me.lblCourse2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCourse2.Name = "lblCourse2"
        Me.lblCourse2.Size = New System.Drawing.Size(109, 32)
        Me.lblCourse2.TabIndex = 3
        Me.lblCourse2.Text = "Course &2:"
        Me.lblCourse2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourse6
        '
        Me.lblCourse6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCourse6.Location = New System.Drawing.Point(17, 213)
        Me.lblCourse6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCourse6.Name = "lblCourse6"
        Me.lblCourse6.Size = New System.Drawing.Size(109, 32)
        Me.lblCourse6.TabIndex = 15
        Me.lblCourse6.Text = "Course &6:"
        Me.lblCourse6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourse5
        '
        Me.lblCourse5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCourse5.Location = New System.Drawing.Point(17, 172)
        Me.lblCourse5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCourse5.Name = "lblCourse5"
        Me.lblCourse5.Size = New System.Drawing.Size(109, 32)
        Me.lblCourse5.TabIndex = 12
        Me.lblCourse5.Text = "Course &5:"
        Me.lblCourse5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourse4
        '
        Me.lblCourse4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCourse4.Location = New System.Drawing.Point(17, 131)
        Me.lblCourse4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCourse4.Name = "lblCourse4"
        Me.lblCourse4.Size = New System.Drawing.Size(109, 32)
        Me.lblCourse4.TabIndex = 9
        Me.lblCourse4.Text = "Course &4:"
        Me.lblCourse4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSemester
        '
        Me.lblSemester.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSemester.Location = New System.Drawing.Point(17, 252)
        Me.lblSemester.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(109, 32)
        Me.lblSemester.TabIndex = 18
        Me.lblSemester.Text = "Semester:"
        Me.lblSemester.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCourse6
        '
        Me.txtCourse6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCourse6.Location = New System.Drawing.Point(133, 213)
        Me.txtCourse6.Name = "txtCourse6"
        Me.txtCourse6.Size = New System.Drawing.Size(127, 28)
        Me.txtCourse6.TabIndex = 16
        Me.txtCourse6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradeTips.SetToolTip(Me.txtCourse6, "Enter a grade for Course 6")
        '
        'txtCourse5
        '
        Me.txtCourse5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCourse5.Location = New System.Drawing.Point(133, 172)
        Me.txtCourse5.Name = "txtCourse5"
        Me.txtCourse5.Size = New System.Drawing.Size(127, 28)
        Me.txtCourse5.TabIndex = 13
        Me.txtCourse5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradeTips.SetToolTip(Me.txtCourse5, "Enter a grade for Course 5")
        '
        'txtCourse4
        '
        Me.txtCourse4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCourse4.Location = New System.Drawing.Point(133, 131)
        Me.txtCourse4.Name = "txtCourse4"
        Me.txtCourse4.Size = New System.Drawing.Size(127, 28)
        Me.txtCourse4.TabIndex = 10
        Me.txtCourse4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradeTips.SetToolTip(Me.txtCourse4, "Enter a grade for Course 4")
        '
        'txtCourse3
        '
        Me.txtCourse3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCourse3.Location = New System.Drawing.Point(133, 90)
        Me.txtCourse3.Name = "txtCourse3"
        Me.txtCourse3.Size = New System.Drawing.Size(127, 28)
        Me.txtCourse3.TabIndex = 7
        Me.txtCourse3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradeTips.SetToolTip(Me.txtCourse3, "Enter a grade for Course 3")
        '
        'txtCourse2
        '
        Me.txtCourse2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCourse2.Location = New System.Drawing.Point(133, 49)
        Me.txtCourse2.Name = "txtCourse2"
        Me.txtCourse2.Size = New System.Drawing.Size(127, 28)
        Me.txtCourse2.TabIndex = 4
        Me.txtCourse2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradeTips.SetToolTip(Me.txtCourse2, "Enter a grade for Course 2")
        '
        'txtCourse1
        '
        Me.txtCourse1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCourse1.Location = New System.Drawing.Point(133, 8)
        Me.txtCourse1.Name = "txtCourse1"
        Me.txtCourse1.Size = New System.Drawing.Size(127, 28)
        Me.txtCourse1.TabIndex = 1
        Me.txtCourse1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradeTips.SetToolTip(Me.txtCourse1, "Enter a grade for Course 1")
        '
        'lblSemesterAverage
        '
        Me.lblSemesterAverage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSemesterAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterAverage.Location = New System.Drawing.Point(133, 254)
        Me.lblSemesterAverage.Name = "lblSemesterAverage"
        Me.lblSemesterAverage.Size = New System.Drawing.Size(127, 28)
        Me.lblSemesterAverage.TabIndex = 19
        Me.lblSemesterAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterGradeTips.SetToolTip(Me.lblSemesterAverage, "Displays semester average")
        '
        'lblDisplayGrade2
        '
        Me.lblDisplayGrade2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDisplayGrade2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayGrade2.Location = New System.Drawing.Point(266, 49)
        Me.lblDisplayGrade2.Name = "lblDisplayGrade2"
        Me.lblDisplayGrade2.Size = New System.Drawing.Size(127, 28)
        Me.lblDisplayGrade2.TabIndex = 5
        Me.lblDisplayGrade2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterGradeTips.SetToolTip(Me.lblDisplayGrade2, "Displays a course letter grade")
        '
        'lblDisplayGrade6
        '
        Me.lblDisplayGrade6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDisplayGrade6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayGrade6.Location = New System.Drawing.Point(266, 213)
        Me.lblDisplayGrade6.Name = "lblDisplayGrade6"
        Me.lblDisplayGrade6.Size = New System.Drawing.Size(127, 28)
        Me.lblDisplayGrade6.TabIndex = 17
        Me.lblDisplayGrade6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterGradeTips.SetToolTip(Me.lblDisplayGrade6, "Displays a course letter grade")
        '
        'lblDisplayGrade5
        '
        Me.lblDisplayGrade5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDisplayGrade5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayGrade5.Location = New System.Drawing.Point(266, 172)
        Me.lblDisplayGrade5.Name = "lblDisplayGrade5"
        Me.lblDisplayGrade5.Size = New System.Drawing.Size(127, 28)
        Me.lblDisplayGrade5.TabIndex = 14
        Me.lblDisplayGrade5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterGradeTips.SetToolTip(Me.lblDisplayGrade5, "Displays a course letter grade")
        '
        'lblDisplayGrade4
        '
        Me.lblDisplayGrade4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDisplayGrade4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayGrade4.Location = New System.Drawing.Point(266, 131)
        Me.lblDisplayGrade4.Name = "lblDisplayGrade4"
        Me.lblDisplayGrade4.Size = New System.Drawing.Size(127, 28)
        Me.lblDisplayGrade4.TabIndex = 11
        Me.lblDisplayGrade4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterGradeTips.SetToolTip(Me.lblDisplayGrade4, "Displays a course letter grade")
        '
        'lblDisplayGrade3
        '
        Me.lblDisplayGrade3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDisplayGrade3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayGrade3.Location = New System.Drawing.Point(266, 90)
        Me.lblDisplayGrade3.Name = "lblDisplayGrade3"
        Me.lblDisplayGrade3.Size = New System.Drawing.Size(127, 28)
        Me.lblDisplayGrade3.TabIndex = 8
        Me.lblDisplayGrade3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterGradeTips.SetToolTip(Me.lblDisplayGrade3, "Displays a course letter grade")
        '
        'lblDisplaySemesterGrade
        '
        Me.lblDisplaySemesterGrade.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDisplaySemesterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplaySemesterGrade.Location = New System.Drawing.Point(266, 254)
        Me.lblDisplaySemesterGrade.Name = "lblDisplaySemesterGrade"
        Me.lblDisplaySemesterGrade.Size = New System.Drawing.Size(127, 28)
        Me.lblDisplaySemesterGrade.TabIndex = 20
        Me.lblDisplaySemesterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterGradeTips.SetToolTip(Me.lblDisplaySemesterGrade, "Displays a semester letter grade")
        '
        'lblError
        '
        Me.lblError.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblError.Location = New System.Drawing.Point(35, 298)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(358, 240)
        Me.lblError.TabIndex = 21
        Me.SemesterGradeTips.SetToolTip(Me.lblError, "Displays error messages")
        '
        'btnCalculate
        '
        Me.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCalculate.Location = New System.Drawing.Point(14, 557)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(121, 33)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "&Calculate"
        Me.SemesterGradeTips.SetToolTip(Me.btnCalculate, "Click to Calculate grades")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(155, 557)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(121, 33)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.SemesterGradeTips.SetToolTip(Me.btnReset, "Click to Reset the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.Location = New System.Drawing.Point(297, 557)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 33)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "E&xit"
        Me.SemesterGradeTips.SetToolTip(Me.btnExit, "Click to Exit the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDisplayGrade1
        '
        Me.lblDisplayGrade1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDisplayGrade1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayGrade1.Location = New System.Drawing.Point(266, 8)
        Me.lblDisplayGrade1.Name = "lblDisplayGrade1"
        Me.lblDisplayGrade1.Size = New System.Drawing.Size(127, 28)
        Me.lblDisplayGrade1.TabIndex = 2
        Me.lblDisplayGrade1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SemesterGradeTips.SetToolTip(Me.lblDisplayGrade1, "Displays a course letter grade")
        '
        'frmSemesterAverage
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(433, 606)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCourse1)
        Me.Controls.Add(Me.lblDisplayGrade1)
        Me.Controls.Add(Me.txtCourse2)
        Me.Controls.Add(Me.lblDisplayGrade2)
        Me.Controls.Add(Me.txtCourse3)
        Me.Controls.Add(Me.lblDisplayGrade3)
        Me.Controls.Add(Me.txtCourse4)
        Me.Controls.Add(Me.lblDisplayGrade4)
        Me.Controls.Add(Me.txtCourse5)
        Me.Controls.Add(Me.lblDisplayGrade5)
        Me.Controls.Add(Me.txtCourse6)
        Me.Controls.Add(Me.lblDisplayGrade6)
        Me.Controls.Add(Me.lblSemesterAverage)
        Me.Controls.Add(Me.lblDisplaySemesterGrade)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblCourse4)
        Me.Controls.Add(Me.lblCourse5)
        Me.Controls.Add(Me.lblCourse6)
        Me.Controls.Add(Me.lblCourse2)
        Me.Controls.Add(Me.lblCourse3)
        Me.Controls.Add(Me.lblCourse1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(451, 653)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(451, 653)
        Me.Name = "frmSemesterAverage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCourse1 As Label
    Friend WithEvents lblCourse3 As Label
    Friend WithEvents lblCourse2 As Label
    Friend WithEvents lblCourse6 As Label
    Friend WithEvents lblCourse5 As Label
    Friend WithEvents lblCourse4 As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents txtCourse6 As TextBox
    Friend WithEvents txtCourse5 As TextBox
    Friend WithEvents txtCourse4 As TextBox
    Friend WithEvents txtCourse3 As TextBox
    Friend WithEvents txtCourse2 As TextBox
    Friend WithEvents txtCourse1 As TextBox
    Friend WithEvents lblSemesterAverage As Label
    Friend WithEvents lblDisplayGrade2 As Label
    Friend WithEvents lblDisplayGrade6 As Label
    Friend WithEvents lblDisplayGrade5 As Label
    Friend WithEvents lblDisplayGrade4 As Label
    Friend WithEvents lblDisplayGrade3 As Label
    Friend WithEvents lblDisplaySemesterGrade As Label
    Friend WithEvents lblError As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents SemesterGradeTips As ToolTip
    Friend WithEvents lblDisplayGrade1 As Label
End Class
