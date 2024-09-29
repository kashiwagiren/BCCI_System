<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Label1 = New Label()
        Yes = New Button()
        No = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Visitor TT1 BRK", 21.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(273, 26)
        Label1.TabIndex = 0
        Label1.Text = "Another Inquiry?"
        ' 
        ' Yes
        ' 
        Yes.Cursor = Cursors.Hand
        Yes.Font = New Font("Visitor TT2 BRK", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Yes.Location = New Point(39, 86)
        Yes.Name = "Yes"
        Yes.Size = New Size(85, 39)
        Yes.TabIndex = 1
        Yes.TabStop = False
        Yes.Text = "Yes"
        Yes.UseVisualStyleBackColor = True
        ' 
        ' No
        ' 
        No.Cursor = Cursors.Hand
        No.Font = New Font("Visitor TT2 BRK", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        No.Location = New Point(178, 86)
        No.Name = "No"
        No.Size = New Size(85, 39)
        No.TabIndex = 2
        No.TabStop = False
        No.Text = "No"
        No.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(301, 163)
        Controls.Add(No)
        Controls.Add(Yes)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Another Inquiry"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Yes As Button
    Friend WithEvents No As Button
End Class
