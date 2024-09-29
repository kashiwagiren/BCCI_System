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
        Comp = New TextBox()
        Label4 = New Label()
        Employee = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        IDNumber = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        TimeandDate = New TextBox()
        CDNumber = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        MonthSalary = New TextBox()
        IncomeTax = New TextBox()
        SSSContri = New TextBox()
        PagIbig = New TextBox()
        PhilHealth = New TextBox()
        SuspendLayout()
        ' 
        ' Comp
        ' 
        Comp.Enabled = False
        Comp.Font = New Font("Visitor TT2 BRK", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Comp.Location = New Point(117, 96)
        Comp.Name = "Comp"
        Comp.ReadOnly = True
        Comp.Size = New Size(233, 21)
        Comp.TabIndex = 11
        Comp.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(11, 97)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 19)
        Label4.TabIndex = 10
        Label4.Text = "COMPANY"
        ' 
        ' Employee
        ' 
        Employee.Enabled = False
        Employee.Font = New Font("Visitor TT2 BRK", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Employee.Location = New Point(117, 69)
        Employee.Name = "Employee"
        Employee.ReadOnly = True
        Employee.Size = New Size(233, 21)
        Employee.TabIndex = 9
        Employee.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(11, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 19)
        Label3.TabIndex = 8
        Label3.Text = "NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Visitor TT2 BRK", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(11, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(340, 13)
        Label2.TabIndex = 7
        Label2.Text = "-------------------------------------"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Visitor TT1 BRK", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(73, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 28)
        Label1.TabIndex = 6
        Label1.Text = "BCCI System"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(13, 125)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 19)
        Label5.TabIndex = 12
        Label5.Text = "I.D. No. #"
        ' 
        ' IDNumber
        ' 
        IDNumber.Enabled = False
        IDNumber.Font = New Font("Visitor TT2 BRK", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IDNumber.Location = New Point(131, 126)
        IDNumber.Name = "IDNumber"
        IDNumber.ReadOnly = True
        IDNumber.Size = New Size(220, 21)
        IDNumber.TabIndex = 13
        IDNumber.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(13, 215)
        Label6.Name = "Label6"
        Label6.Size = New Size(152, 19)
        Label6.TabIndex = 14
        Label6.Text = "Card Number"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(12, 156)
        Label7.Name = "Label7"
        Label7.Size = New Size(61, 19)
        Label7.TabIndex = 15
        Label7.Text = "Date"
        ' 
        ' TimeandDate
        ' 
        TimeandDate.Enabled = False
        TimeandDate.Font = New Font("Visitor TT2 BRK", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TimeandDate.Location = New Point(198, 155)
        TimeandDate.Name = "TimeandDate"
        TimeandDate.ReadOnly = True
        TimeandDate.Size = New Size(152, 21)
        TimeandDate.TabIndex = 16
        TimeandDate.TextAlign = HorizontalAlignment.Right
        ' 
        ' CDNumber
        ' 
        CDNumber.Enabled = False
        CDNumber.Font = New Font("Visitor TT2 BRK", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CDNumber.Location = New Point(226, 213)
        CDNumber.Name = "CDNumber"
        CDNumber.ReadOnly = True
        CDNumber.Size = New Size(125, 21)
        CDNumber.TabIndex = 17
        CDNumber.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(13, 335)
        Label8.Name = "Label8"
        Label8.Size = New Size(139, 19)
        Label8.TabIndex = 18
        Label8.Text = "Income Tax"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(13, 364)
        Label9.Name = "Label9"
        Label9.Size = New Size(199, 19)
        Label9.TabIndex = 19
        Label9.Text = "SSS Contribution"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(13, 392)
        Label10.Name = "Label10"
        Label10.Size = New Size(104, 19)
        Label10.TabIndex = 20
        Label10.Text = "Pag-Ibig"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(13, 422)
        Label11.Name = "Label11"
        Label11.Size = New Size(143, 19)
        Label11.TabIndex = 21
        Label11.Text = "Phil-Health"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(13, 270)
        Label12.Name = "Label12"
        Label12.Size = New Size(191, 19)
        Label12.TabIndex = 22
        Label12.Text = "Monthly Salary"
        ' 
        ' MonthSalary
        ' 
        MonthSalary.Enabled = False
        MonthSalary.Font = New Font("Visitor TT2 BRK", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MonthSalary.Location = New Point(251, 268)
        MonthSalary.Name = "MonthSalary"
        MonthSalary.ReadOnly = True
        MonthSalary.Size = New Size(100, 21)
        MonthSalary.TabIndex = 23
        MonthSalary.TextAlign = HorizontalAlignment.Right
        ' 
        ' IncomeTax
        ' 
        IncomeTax.Enabled = False
        IncomeTax.Font = New Font("Visitor TT2 BRK", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IncomeTax.Location = New Point(251, 335)
        IncomeTax.Name = "IncomeTax"
        IncomeTax.ReadOnly = True
        IncomeTax.Size = New Size(100, 21)
        IncomeTax.TabIndex = 24
        IncomeTax.TextAlign = HorizontalAlignment.Right
        ' 
        ' SSSContri
        ' 
        SSSContri.Enabled = False
        SSSContri.Font = New Font("Visitor TT2 BRK", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SSSContri.Location = New Point(250, 360)
        SSSContri.Name = "SSSContri"
        SSSContri.ReadOnly = True
        SSSContri.Size = New Size(100, 21)
        SSSContri.TabIndex = 25
        SSSContri.TextAlign = HorizontalAlignment.Right
        ' 
        ' PagIbig
        ' 
        PagIbig.Enabled = False
        PagIbig.Font = New Font("Visitor TT2 BRK", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PagIbig.Location = New Point(251, 388)
        PagIbig.Name = "PagIbig"
        PagIbig.ReadOnly = True
        PagIbig.Size = New Size(100, 21)
        PagIbig.TabIndex = 26
        PagIbig.TextAlign = HorizontalAlignment.Right
        ' 
        ' PhilHealth
        ' 
        PhilHealth.Enabled = False
        PhilHealth.Font = New Font("Visitor TT2 BRK", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PhilHealth.Location = New Point(250, 418)
        PhilHealth.Name = "PhilHealth"
        PhilHealth.ReadOnly = True
        PhilHealth.Size = New Size(100, 21)
        PhilHealth.TabIndex = 27
        PhilHealth.TextAlign = HorizontalAlignment.Right
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(363, 450)
        Controls.Add(PhilHealth)
        Controls.Add(PagIbig)
        Controls.Add(SSSContri)
        Controls.Add(IncomeTax)
        Controls.Add(MonthSalary)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(CDNumber)
        Controls.Add(TimeandDate)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(IDNumber)
        Controls.Add(Label5)
        Controls.Add(Comp)
        Controls.Add(Label4)
        Controls.Add(Employee)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Generated Receipt"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Comp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Employee As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents IDNumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TimeandDate As TextBox
    Friend WithEvents CDNumber As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents MonthSalary As TextBox
    Friend WithEvents IncomeTax As TextBox
    Friend WithEvents SSSContri As TextBox
    Friend WithEvents PagIbig As TextBox
    Friend WithEvents PhilHealth As TextBox
End Class
