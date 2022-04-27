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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.cbErate = New System.Windows.Forms.ComboBox()
        Me.cbSrate = New System.Windows.Forms.ComboBox()
        Me.cbYears = New System.Windows.Forms.ComboBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listOutput = New System.Windows.Forms.ListBox()
        Me.btnCar = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.18182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car Loan Payment Calculator"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnCalc)
        Me.GroupBox1.Controls.Add(Me.cbErate)
        Me.GroupBox1.Controls.Add(Me.cbSrate)
        Me.GroupBox1.Controls.Add(Me.cbYears)
        Me.GroupBox1.Controls.Add(Me.txtRate)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 173)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loan Calculator"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(468, 135)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 32)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(347, 135)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(103, 32)
        Me.btnCalc.TabIndex = 10
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'cbErate
        '
        Me.cbErate.FormattingEnabled = True
        Me.cbErate.Location = New System.Drawing.Point(505, 63)
        Me.cbErate.Name = "cbErate"
        Me.cbErate.Size = New System.Drawing.Size(66, 31)
        Me.cbErate.TabIndex = 9
        '
        'cbSrate
        '
        Me.cbSrate.FormattingEnabled = True
        Me.cbSrate.Location = New System.Drawing.Point(154, 59)
        Me.cbSrate.Name = "cbSrate"
        Me.cbSrate.Size = New System.Drawing.Size(74, 31)
        Me.cbSrate.TabIndex = 8
        '
        'cbYears
        '
        Me.cbYears.FormattingEnabled = True
        Me.cbYears.Location = New System.Drawing.Point(505, 22)
        Me.cbYears.Name = "cbYears"
        Me.cbYears.Size = New System.Drawing.Size(66, 31)
        Me.cbYears.TabIndex = 7
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(154, 96)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(166, 30)
        Me.txtRate.TabIndex = 6
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(154, 23)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(166, 30)
        Me.txtAmount.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Rate Step Size"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(370, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "End Rate (%)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Start Rate (%)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(401, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Years"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Loan Amount"
        '
        'listOutput
        '
        Me.listOutput.FormattingEnabled = True
        Me.listOutput.ItemHeight = 23
        Me.listOutput.Location = New System.Drawing.Point(36, 252)
        Me.listOutput.Name = "listOutput"
        Me.listOutput.Size = New System.Drawing.Size(618, 188)
        Me.listOutput.TabIndex = 2
        '
        'btnCar
        '
        Me.btnCar.Location = New System.Drawing.Point(551, 452)
        Me.btnCar.Name = "btnCar"
        Me.btnCar.Size = New System.Drawing.Size(103, 32)
        Me.btnCar.TabIndex = 3
        Me.btnCar.Text = "Car List"
        Me.btnCar.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.181818!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(36, 459)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 17)
        Me.lblName.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 496)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnCar)
        Me.Controls.Add(Me.listOutput)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Car Loan Payment Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbYears As ComboBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents cbErate As ComboBox
    Friend WithEvents cbSrate As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents listOutput As ListBox
    Friend WithEvents btnCar As Button
    Friend WithEvents lblName As Label
End Class
