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
        Label1 = New Label()
        txtNum1 = New TextBox()
        txtNum2 = New TextBox()
        Label2 = New Label()
        btnSum = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter Number 1:"
        ' 
        ' txtNum1
        ' 
        txtNum1.BackColor = Color.White
        txtNum1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtNum1.Location = New Point(118, 15)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(97, 33)
        txtNum1.TabIndex = 1
        txtNum1.Text = "15"
        txtNum1.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtNum2
        ' 
        txtNum2.BackColor = Color.White
        txtNum2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtNum2.Location = New Point(118, 63)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(97, 33)
        txtNum2.TabIndex = 3
        txtNum2.Text = "3"
        txtNum2.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 15)
        Label2.TabIndex = 2
        Label2.Text = "Enter Number 2:"
        ' 
        ' btnSum
        ' 
        btnSum.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnSum.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSum.Location = New Point(245, 20)
        btnSum.Name = "btnSum"
        btnSum.Size = New Size(136, 47)
        btnSum.TabIndex = 4
        btnSum.Text = "Get Sum"
        btnSum.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(415, 196)
        Controls.Add(btnSum)
        Controls.Add(txtNum2)
        Controls.Add(Label2)
        Controls.Add(txtNum1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "GitHub Demo"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSum As Button

End Class
