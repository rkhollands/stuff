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
        Me.LabelDSTBegins = New System.Windows.Forms.Label()
        Me.CheckBoxAdjustDST = New System.Windows.Forms.CheckBox()
        Me.LabelStartOccurance = New System.Windows.Forms.Label()
        Me.ComboStartOccurance = New System.Windows.Forms.ComboBox()
        Me.LabelStartDay = New System.Windows.Forms.Label()
        Me.ComboStartDay = New System.Windows.Forms.ComboBox()
        Me.ComboStartMonth = New System.Windows.Forms.ComboBox()
        Me.LabelStartMonth = New System.Windows.Forms.Label()
        Me.ComboStartHour = New System.Windows.Forms.ComboBox()
        Me.LabelStartTime = New System.Windows.Forms.Label()
        Me.ComboStartMinutes = New System.Windows.Forms.ComboBox()
        Me.LabelColon = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboEndMinutes = New System.Windows.Forms.ComboBox()
        Me.ComboEndHour = New System.Windows.Forms.ComboBox()
        Me.LabelEndTime = New System.Windows.Forms.Label()
        Me.ComboEndMonth = New System.Windows.Forms.ComboBox()
        Me.LabelEndMonth = New System.Windows.Forms.Label()
        Me.ComboEndDay = New System.Windows.Forms.ComboBox()
        Me.LabelEndDay = New System.Windows.Forms.Label()
        Me.ComboEndOccurance = New System.Windows.Forms.ComboBox()
        Me.LabelEndOccurance = New System.Windows.Forms.Label()
        Me.LabelDSTEnds = New System.Windows.Forms.Label()
        Me.ButtonAccept = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonTest = New System.Windows.Forms.Button()
        Me.LabelGMTAdjustment = New System.Windows.Forms.Label()
        Me.ComboGMTAdjustment = New System.Windows.Forms.ComboBox()
        Me.LabelNote = New System.Windows.Forms.Label()
        Me.ListTest = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LabelDSTBegins
        '
        Me.LabelDSTBegins.AutoSize = True
        Me.LabelDSTBegins.Location = New System.Drawing.Point(82, 122)
        Me.LabelDSTBegins.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LabelDSTBegins.Name = "LabelDSTBegins"
        Me.LabelDSTBegins.Size = New System.Drawing.Size(131, 24)
        Me.LabelDSTBegins.TabIndex = 1
        Me.LabelDSTBegins.Text = "DST BEGINS"
        '
        'CheckBoxAdjustDST
        '
        Me.CheckBoxAdjustDST.AutoSize = True
        Me.CheckBoxAdjustDST.Checked = True
        Me.CheckBoxAdjustDST.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxAdjustDST.Location = New System.Drawing.Point(12, 32)
        Me.CheckBoxAdjustDST.Name = "CheckBoxAdjustDST"
        Me.CheckBoxAdjustDST.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxAdjustDST.Size = New System.Drawing.Size(412, 28)
        Me.CheckBoxAdjustDST.TabIndex = 2
        Me.CheckBoxAdjustDST.Text = "ADJUST FOR DAYLIGHT SAVINGS TIME"
        Me.CheckBoxAdjustDST.UseVisualStyleBackColor = True
        '
        'LabelStartOccurance
        '
        Me.LabelStartOccurance.AutoSize = True
        Me.LabelStartOccurance.Location = New System.Drawing.Point(9, 268)
        Me.LabelStartOccurance.Name = "LabelStartOccurance"
        Me.LabelStartOccurance.Size = New System.Drawing.Size(113, 24)
        Me.LabelStartOccurance.TabIndex = 3
        Me.LabelStartOccurance.Text = "INSTANCE"
        '
        'ComboStartOccurance
        '
        Me.ComboStartOccurance.FormattingEnabled = True
        Me.ComboStartOccurance.Location = New System.Drawing.Point(128, 264)
        Me.ComboStartOccurance.Name = "ComboStartOccurance"
        Me.ComboStartOccurance.Size = New System.Drawing.Size(157, 32)
        Me.ComboStartOccurance.TabIndex = 4
        '
        'LabelStartDay
        '
        Me.LabelStartDay.AutoSize = True
        Me.LabelStartDay.Location = New System.Drawing.Point(12, 220)
        Me.LabelStartDay.Name = "LabelStartDay"
        Me.LabelStartDay.Size = New System.Drawing.Size(51, 24)
        Me.LabelStartDay.TabIndex = 5
        Me.LabelStartDay.Text = "DAY"
        '
        'ComboStartDay
        '
        Me.ComboStartDay.FormattingEnabled = True
        Me.ComboStartDay.Location = New System.Drawing.Point(128, 216)
        Me.ComboStartDay.Name = "ComboStartDay"
        Me.ComboStartDay.Size = New System.Drawing.Size(157, 32)
        Me.ComboStartDay.TabIndex = 6
        '
        'ComboStartMonth
        '
        Me.ComboStartMonth.FormattingEnabled = True
        Me.ComboStartMonth.Location = New System.Drawing.Point(128, 168)
        Me.ComboStartMonth.Name = "ComboStartMonth"
        Me.ComboStartMonth.Size = New System.Drawing.Size(157, 32)
        Me.ComboStartMonth.TabIndex = 8
        '
        'LabelStartMonth
        '
        Me.LabelStartMonth.AutoSize = True
        Me.LabelStartMonth.Location = New System.Drawing.Point(12, 172)
        Me.LabelStartMonth.Name = "LabelStartMonth"
        Me.LabelStartMonth.Size = New System.Drawing.Size(86, 24)
        Me.LabelStartMonth.TabIndex = 7
        Me.LabelStartMonth.Text = "MONTH"
        '
        'ComboStartHour
        '
        Me.ComboStartHour.FormattingEnabled = True
        Me.ComboStartHour.Location = New System.Drawing.Point(823, 210)
        Me.ComboStartHour.Name = "ComboStartHour"
        Me.ComboStartHour.Size = New System.Drawing.Size(58, 32)
        Me.ComboStartHour.TabIndex = 10
        Me.ComboStartHour.Visible = False
        '
        'LabelStartTime
        '
        Me.LabelStartTime.AutoSize = True
        Me.LabelStartTime.Location = New System.Drawing.Point(653, 215)
        Me.LabelStartTime.Name = "LabelStartTime"
        Me.LabelStartTime.Size = New System.Drawing.Size(59, 24)
        Me.LabelStartTime.TabIndex = 9
        Me.LabelStartTime.Text = "TIME"
        Me.LabelStartTime.Visible = False
        '
        'ComboStartMinutes
        '
        Me.ComboStartMinutes.FormattingEnabled = True
        Me.ComboStartMinutes.Location = New System.Drawing.Point(909, 210)
        Me.ComboStartMinutes.Name = "ComboStartMinutes"
        Me.ComboStartMinutes.Size = New System.Drawing.Size(58, 32)
        Me.ComboStartMinutes.TabIndex = 11
        Me.ComboStartMinutes.Visible = False
        '
        'LabelColon
        '
        Me.LabelColon.AutoSize = True
        Me.LabelColon.Location = New System.Drawing.Point(887, 214)
        Me.LabelColon.Name = "LabelColon"
        Me.LabelColon.Size = New System.Drawing.Size(16, 24)
        Me.LabelColon.TabIndex = 12
        Me.LabelColon.Text = ":"
        Me.LabelColon.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1231, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 24)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = ":"
        Me.Label2.Visible = False
        '
        'ComboEndMinutes
        '
        Me.ComboEndMinutes.FormattingEnabled = True
        Me.ComboEndMinutes.Location = New System.Drawing.Point(1253, 206)
        Me.ComboEndMinutes.Name = "ComboEndMinutes"
        Me.ComboEndMinutes.Size = New System.Drawing.Size(58, 32)
        Me.ComboEndMinutes.TabIndex = 22
        Me.ComboEndMinutes.Visible = False
        '
        'ComboEndHour
        '
        Me.ComboEndHour.FormattingEnabled = True
        Me.ComboEndHour.Location = New System.Drawing.Point(1167, 206)
        Me.ComboEndHour.Name = "ComboEndHour"
        Me.ComboEndHour.Size = New System.Drawing.Size(58, 32)
        Me.ComboEndHour.TabIndex = 21
        Me.ComboEndHour.Visible = False
        '
        'LabelEndTime
        '
        Me.LabelEndTime.AutoSize = True
        Me.LabelEndTime.Location = New System.Drawing.Point(1048, 210)
        Me.LabelEndTime.Name = "LabelEndTime"
        Me.LabelEndTime.Size = New System.Drawing.Size(59, 24)
        Me.LabelEndTime.TabIndex = 20
        Me.LabelEndTime.Text = "TIME"
        Me.LabelEndTime.Visible = False
        '
        'ComboEndMonth
        '
        Me.ComboEndMonth.FormattingEnabled = True
        Me.ComboEndMonth.Location = New System.Drawing.Point(472, 164)
        Me.ComboEndMonth.Name = "ComboEndMonth"
        Me.ComboEndMonth.Size = New System.Drawing.Size(157, 32)
        Me.ComboEndMonth.TabIndex = 19
        '
        'LabelEndMonth
        '
        Me.LabelEndMonth.AutoSize = True
        Me.LabelEndMonth.Location = New System.Drawing.Point(356, 168)
        Me.LabelEndMonth.Name = "LabelEndMonth"
        Me.LabelEndMonth.Size = New System.Drawing.Size(86, 24)
        Me.LabelEndMonth.TabIndex = 18
        Me.LabelEndMonth.Text = "MONTH"
        '
        'ComboEndDay
        '
        Me.ComboEndDay.FormattingEnabled = True
        Me.ComboEndDay.Location = New System.Drawing.Point(472, 212)
        Me.ComboEndDay.Name = "ComboEndDay"
        Me.ComboEndDay.Size = New System.Drawing.Size(157, 32)
        Me.ComboEndDay.TabIndex = 17
        '
        'LabelEndDay
        '
        Me.LabelEndDay.AutoSize = True
        Me.LabelEndDay.Location = New System.Drawing.Point(356, 216)
        Me.LabelEndDay.Name = "LabelEndDay"
        Me.LabelEndDay.Size = New System.Drawing.Size(51, 24)
        Me.LabelEndDay.TabIndex = 16
        Me.LabelEndDay.Text = "DAY"
        '
        'ComboEndOccurance
        '
        Me.ComboEndOccurance.FormattingEnabled = True
        Me.ComboEndOccurance.Location = New System.Drawing.Point(472, 260)
        Me.ComboEndOccurance.Name = "ComboEndOccurance"
        Me.ComboEndOccurance.Size = New System.Drawing.Size(157, 32)
        Me.ComboEndOccurance.TabIndex = 15
        '
        'LabelEndOccurance
        '
        Me.LabelEndOccurance.AutoSize = True
        Me.LabelEndOccurance.Location = New System.Drawing.Point(353, 264)
        Me.LabelEndOccurance.Name = "LabelEndOccurance"
        Me.LabelEndOccurance.Size = New System.Drawing.Size(113, 24)
        Me.LabelEndOccurance.TabIndex = 14
        Me.LabelEndOccurance.Text = "INSTANCE"
        '
        'LabelDSTEnds
        '
        Me.LabelDSTEnds.AutoSize = True
        Me.LabelDSTEnds.Location = New System.Drawing.Point(426, 118)
        Me.LabelDSTEnds.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LabelDSTEnds.Name = "LabelDSTEnds"
        Me.LabelDSTEnds.Size = New System.Drawing.Size(112, 24)
        Me.LabelDSTEnds.TabIndex = 13
        Me.LabelDSTEnds.Text = "DST ENDS"
        '
        'ButtonAccept
        '
        Me.ButtonAccept.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonAccept.Location = New System.Drawing.Point(517, 13)
        Me.ButtonAccept.Name = "ButtonAccept"
        Me.ButtonAccept.Size = New System.Drawing.Size(112, 30)
        Me.ButtonAccept.TabIndex = 24
        Me.ButtonAccept.Text = "ACCEPT"
        Me.ButtonAccept.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.ForeColor = System.Drawing.Color.Maroon
        Me.ButtonCancel.Location = New System.Drawing.Point(517, 58)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(112, 30)
        Me.ButtonCancel.TabIndex = 25
        Me.ButtonCancel.Text = "CANCEL"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonTest
        '
        Me.ButtonTest.ForeColor = System.Drawing.Color.Black
        Me.ButtonTest.Location = New System.Drawing.Point(263, 312)
        Me.ButtonTest.Name = "ButtonTest"
        Me.ButtonTest.Size = New System.Drawing.Size(112, 30)
        Me.ButtonTest.TabIndex = 26
        Me.ButtonTest.Text = "TEST"
        Me.ButtonTest.UseVisualStyleBackColor = True
        '
        'LabelGMTAdjustment
        '
        Me.LabelGMTAdjustment.AutoSize = True
        Me.LabelGMTAdjustment.Location = New System.Drawing.Point(12, 69)
        Me.LabelGMTAdjustment.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LabelGMTAdjustment.Name = "LabelGMTAdjustment"
        Me.LabelGMTAdjustment.Size = New System.Drawing.Size(390, 24)
        Me.LabelGMTAdjustment.TabIndex = 28
        Me.LabelGMTAdjustment.Text = "GMT ADJUSTMENT (EAST COAST = -5)"
        '
        'ComboGMTAdjustment
        '
        Me.ComboGMTAdjustment.FormattingEnabled = True
        Me.ComboGMTAdjustment.Location = New System.Drawing.Point(411, 65)
        Me.ComboGMTAdjustment.Name = "ComboGMTAdjustment"
        Me.ComboGMTAdjustment.Size = New System.Drawing.Size(58, 32)
        Me.ComboGMTAdjustment.TabIndex = 29
        '
        'LabelNote
        '
        Me.LabelNote.AutoSize = True
        Me.LabelNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNote.Location = New System.Drawing.Point(60, 528)
        Me.LabelNote.Name = "LabelNote"
        Me.LabelNote.Size = New System.Drawing.Size(521, 24)
        Me.LabelNote.TabIndex = 30
        Me.LabelNote.Text = "CONSULT 'README.TXT' FOR APPLICATION NOTES"
        '
        'ListTest
        '
        Me.ListTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListTest.FormattingEnabled = True
        Me.ListTest.ItemHeight = 16
        Me.ListTest.Location = New System.Drawing.Point(13, 353)
        Me.ListTest.Name = "ListTest"
        Me.ListTest.Size = New System.Drawing.Size(616, 164)
        Me.ListTest.TabIndex = 31
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 561)
        Me.Controls.Add(Me.ListTest)
        Me.Controls.Add(Me.LabelNote)
        Me.Controls.Add(Me.ComboGMTAdjustment)
        Me.Controls.Add(Me.LabelGMTAdjustment)
        Me.Controls.Add(Me.ButtonTest)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonAccept)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboEndMinutes)
        Me.Controls.Add(Me.ComboEndHour)
        Me.Controls.Add(Me.LabelEndTime)
        Me.Controls.Add(Me.ComboEndMonth)
        Me.Controls.Add(Me.LabelEndMonth)
        Me.Controls.Add(Me.ComboEndDay)
        Me.Controls.Add(Me.LabelEndDay)
        Me.Controls.Add(Me.ComboEndOccurance)
        Me.Controls.Add(Me.LabelEndOccurance)
        Me.Controls.Add(Me.LabelDSTEnds)
        Me.Controls.Add(Me.LabelColon)
        Me.Controls.Add(Me.ComboStartMinutes)
        Me.Controls.Add(Me.ComboStartHour)
        Me.Controls.Add(Me.LabelStartTime)
        Me.Controls.Add(Me.ComboStartMonth)
        Me.Controls.Add(Me.LabelStartMonth)
        Me.Controls.Add(Me.ComboStartDay)
        Me.Controls.Add(Me.LabelStartDay)
        Me.Controls.Add(Me.ComboStartOccurance)
        Me.Controls.Add(Me.LabelStartOccurance)
        Me.Controls.Add(Me.CheckBoxAdjustDST)
        Me.Controls.Add(Me.LabelDSTBegins)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Daylight Savings Rules"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelDSTBegins As Label
    Friend WithEvents CheckBoxAdjustDST As CheckBox
    Friend WithEvents LabelStartOccurance As Label
    Friend WithEvents ComboStartOccurance As ComboBox
    Friend WithEvents LabelStartDay As Label
    Friend WithEvents ComboStartDay As ComboBox
    Friend WithEvents ComboStartMonth As ComboBox
    Friend WithEvents LabelStartMonth As Label
    Friend WithEvents ComboStartHour As ComboBox
    Friend WithEvents LabelStartTime As Label
    Friend WithEvents ComboStartMinutes As ComboBox
    Friend WithEvents LabelColon As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboEndMinutes As ComboBox
    Friend WithEvents ComboEndHour As ComboBox
    Friend WithEvents LabelEndTime As Label
    Friend WithEvents ComboEndMonth As ComboBox
    Friend WithEvents LabelEndMonth As Label
    Friend WithEvents ComboEndDay As ComboBox
    Friend WithEvents LabelEndDay As Label
    Friend WithEvents ComboEndOccurance As ComboBox
    Friend WithEvents LabelEndOccurance As Label
    Friend WithEvents LabelDSTEnds As Label
    Friend WithEvents ButtonAccept As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonTest As Button
    Friend WithEvents LabelGMTAdjustment As Label
    Friend WithEvents ComboGMTAdjustment As ComboBox
    Friend WithEvents LabelNote As Label
    Friend WithEvents ListTest As ListBox
End Class
