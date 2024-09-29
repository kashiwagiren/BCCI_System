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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Visitor TT1 BRK", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(74, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 28)
        Label1.TabIndex = 0
        Label1.Text = "BCCI System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Visitor TT2 BRK", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(340, 13)
        Label2.TabIndex = 1
        Label2.Text = "-------------------------------------"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 19)
        Label3.TabIndex = 2
        Label3.Text = "NAME"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(118, 64)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(233, 23)
        TextBox1.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 19)
        Label4.TabIndex = 4
        Label4.Text = "COMPANY"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(118, 118)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(233, 23)
        TextBox2.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(363, 450)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Generated Receipt"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox

End Class
