Public Class Form2
    Public Property CardNumber As String
    Public Property EmployeeName As String
    Public Property NameOfCompany As String
    Public Property IdNum As String
    Public Property Msal As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Employee.Text = EmployeeName
        Comp.Text = NameOfCompany
        IDNumber.Text = IdNum
        TimeandDate.Text = DateTime.Now.ToString("hh:mm MM/dd/yyyy")
        CDNumber.Text = CardNumber
        MonthSalary.Text = Msal
    End Sub
    Public Sub SetIncomeTax(value As String)
        IncomeTax.Text = value
    End Sub
    Public Sub SetSSSContribution(value As String)
        SSSContri.Text = value
    End Sub
    Public Sub SetPagIbigContribution(value As String)
        PagIbig.Text = value
    End Sub
    Public Sub SetPhilHealthContribution(value As String)
        PhilHealth.Text = value
    End Sub
End Class