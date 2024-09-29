Public Class Form3
    Private _form2 As Form2
    Private _form1 As Form1
    Public Sub New(form2 As Form2, form1 As Form1)
        InitializeComponent()
        _form2 = form2
        _form1 = form1
    End Sub
    Private Sub Yes_Click(sender As Object, e As EventArgs) Handles Yes.Click
        _form2?.Close()
        _form1.ClearCredentials()

        Me.Close()
    End Sub
    Private Sub No_Click(sender As Object, e As EventArgs) Handles No.Click
        _form2?.Close()

        If _form1 IsNot Nothing Then
            _form1.ReceiveData(_form2.CardNumber, _form2.EmployeeName, _form2.NameOfCompany, _form2.IdNum, _form2.Msal)

            _form1.UpdateGenerateButton(False)
        End If

        Me.Close()
    End Sub
End Class