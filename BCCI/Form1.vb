Imports System.Text.RegularExpressions

Public Class Form1
    Private shouldHideGenerate As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnterButt.Visible = False
        NoE.Focus()
    End Sub
    Private Sub CheckTextBoxes()
        If Not String.IsNullOrWhiteSpace(NoE.Text) AndAlso
           Not String.IsNullOrWhiteSpace(NoC.Text) AndAlso
           Not String.IsNullOrWhiteSpace(IDN.Text) AndAlso
           Not String.IsNullOrWhiteSpace(Card.Text) AndAlso
           Not String.IsNullOrWhiteSpace(MS.Text) AndAlso
            MS.Text.Replace("₱ ", "").Trim() <> "" Then
            EnterButt.Visible = True
        Else
            EnterButt.Visible = False
        End If
    End Sub
    Private Sub NoE_TextChanged(sender As Object, e As EventArgs) Handles NoE.TextChanged
        CheckTextBoxes()
    End Sub
    Private Sub NoC_TextChanged(sender As Object, e As EventArgs) Handles NoC.TextChanged
        CheckTextBoxes()
    End Sub
    Private Sub IDN_TextChanged(sender As Object, e As EventArgs) Handles IDN.TextChanged
        CheckTextBoxes()
    End Sub
    Private Sub Card_TextChanged(sender As Object, e As EventArgs) Handles Card.TextChanged
        CheckTextBoxes()
        If Not shouldHideGenerate Then
            If Not String.IsNullOrWhiteSpace(Card.Text) Then
                Generate.Visible = False
            Else
                Generate.Visible = True
            End If
        End If
    End Sub
    Public Sub UpdateGenerateButton(shouldHideGenerate As Boolean)
        If Not shouldHideGenerate Then
            ' Logic to hide or show the Generate button
            If Not String.IsNullOrWhiteSpace(Card.Text) Then
                Generate.Visible = False
            Else
                Generate.Visible = True
            End If
        End If
    End Sub
    Private Sub MS_TextChanged(sender As Object, e As EventArgs) Handles MS.TextChanged
        If Not MS.Text.StartsWith("₱ ") AndAlso MS.Text.Trim() <> "" Then
            MS.Text = "₱ " & MS.Text.Replace("₱ ", "").Trim()
            MS.SelectionStart = MS.Text.Length
        End If
        CheckTextBoxes()
    End Sub
    Private Sub EnterButt_Click(sender As Object, e As EventArgs) Handles EnterButt.Click
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(Me.Location.X - 200, Me.Location.Y)
        Dim form2 As New Form2()
        Dim form3 As New Form3(form2, Me)
        form2.CardNumber = Card.Text
        form2.EmployeeName = NoE.Text
        form2.NameOfCompany = NoC.Text
        form2.IdNum = IDN.Text
        form2.Msal = MS.Text
        form3.Owner = form2
        form2.StartPosition = FormStartPosition.Manual
        form2.Location = New Point(Me.Location.X + Me.Width + 5, Me.Location.Y)

        Dim salaryText As String = MS.Text.Replace("₱ ", "").Trim()
        Dim monthlySalary As Double

        If Double.TryParse(salaryText, monthlySalary) Then
            Dim taxResult As Double = CalculateIncomeTax(monthlySalary)
            Dim monthlyTax As String = (taxResult / 12).ToString("F2") ' Format to 2 decimal places
            form2.SetIncomeTax(monthlyTax) ' Set the Income Tax value in Form2

            Dim sssContribution As Integer = GetSSSContribution(monthlySalary)
            form2.SetSSSContribution(sssContribution.ToString())

            Dim pagIbigContribution As Double = GetPagIbig(monthlySalary)
            form2.SetPagIbigContribution(pagIbigContribution.ToString("F2"))

            Dim philHealthContribution As Double = GetPhilHealth(monthlySalary)
            form2.SetPhilHealthContribution(philHealthContribution.ToString("F2"))
        Else
            form2.SetIncomeTax("₱ 0.00") ' Default value if salary is invalid
            form2.SetSSSContribution("₱ 0") ' Default value if salary is invalid
            form2.SetPagIbigContribution("₱ 0.00") ' Default value if salary is invalid
            form2.SetPhilHealthContribution("₱ 0.00") ' Default value if salary is invalid
        End If

        EnterButt.Visible = False
        shouldHideGenerate = True
        Generate.Visible = False
        ClearCreds.Visible = False
        AddHandler form2.FormClosed, AddressOf OnForm2Closed
        form2.Show()
        NoE.Text = ""
        NoC.Text = ""
        IDN.Text = ""
        Card.Text = ""
        MS.Text = ""
        form3.StartPosition = FormStartPosition.Manual
        form3.Location = New Point(Me.Location.X + Me.Width + 390, Me.Location.Y)
        form3.Show()
    End Sub
    Private Sub OnForm2Closed(sender As Object, e As FormClosedEventArgs)
        MS.Text = "₱ "
        If Not String.IsNullOrWhiteSpace(NoE.Text) AndAlso
           Not String.IsNullOrWhiteSpace(NoC.Text) AndAlso
           Not String.IsNullOrWhiteSpace(IDN.Text) AndAlso
           Not String.IsNullOrWhiteSpace(Card.Text) AndAlso
           Not String.IsNullOrWhiteSpace(MS.Text) AndAlso
            MS.Text.Replace("₱ ", "").Trim() <> "" Then
            EnterButt.Visible = True
        Else
            EnterButt.Visible = False
        End If
        Generate.Visible = True
        ClearCreds.Visible = True
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
        NoE.Focus()
    End Sub
    Private Sub Generate_Click(sender As Object, e As EventArgs) Handles Generate.Click
        Dim random As New Random()
        Dim cardNumber As String = ""
        Generate.Visible = False
        AddHandler Form2.FormClosed, AddressOf OnForm2Closed
        For i As Integer = 1 To 12
            cardNumber &= random.Next(0, 10).ToString()
        Next
        Card.Text = cardNumber
        NoE.Focus()
    End Sub
    Public Sub ClearCredentials()
        NoE.Text = ""
        NoC.Text = ""
        IDN.Text = ""
        Card.Text = ""
        MS.Text = ""
        NoE.Focus()
        Generate.Visible = True
    End Sub
    Private Sub ClearCreds_Click(sender As Object, e As EventArgs) Handles ClearCreds.Click
        ClearCredentials()
    End Sub
    Public Sub ReceiveData(CardNumber As String, EmployeeName As String, NameOfCompany As String, IdNum As String, Msal As String)
        Card.Text = CardNumber
        NoE.Text = EmployeeName
        NoC.Text = NameOfCompany
        IDN.Text = IdNum
        MS.Text = Msal
    End Sub
    Private Function CalculateIncomeTax(monthlySalary As Double) As Double
        Dim annualSalary As Double = monthlySalary * 12

        If annualSalary < 250000 Then
            Return 0
        ElseIf annualSalary < 400000 Then
            Return (annualSalary - 250000) * 0.2
        ElseIf annualSalary < 800000 Then
            Return (annualSalary - 400000) * 0.25 + 30000
        ElseIf annualSalary < 2000000 Then
            Return (annualSalary - 800000) * 0.3 + 130000
        ElseIf annualSalary < 8000000 Then
            Return (annualSalary - 2000000) * 0.32 + 490000
        Else
            Return (annualSalary - 8000000) * 0.35 + 2410000
        End If
    End Function
    Private Function GetSSSContribution(monthlySalary As Double) As Integer
        If monthlySalary < 2249.99 Then
            Return 80
        ElseIf monthlySalary > 19750 Then
            Return 800
        Else
            Return 100 + CInt((monthlySalary - 2250) / 500) * 20
        End If
    End Function
    Private Function GetPagIbig(monthlySalary As Double) As Double
        If monthlySalary <= 1500 Then
            Return 0.1 * monthlySalary ' 10% for salary ≤ 1500
        Else
            Return 0.2 * monthlySalary ' 20% for salary > 1500
        End If
    End Function
    Private Function GetPhilHealth(monthlySalary As Double) As Double
        If monthlySalary <= 8999.99 Then
            Return 100.0 ' Fixed contribution for salary ≤ 8999.99
        ElseIf monthlySalary > 35000.0 Then
            Return 437.5 ' Fixed contribution for salary > 35000.00
        End If

        Return 112.5 + (Int((monthlySalary - 9000) / 1000) * 12.5) ' Calculate contribution for other salaries
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
End Class
