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
        StartingNumber = New NumericUpDown()
        NumberOfLoops = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        SubmitButton = New Button()
        CType(StartingNumber, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumberOfLoops, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' StartingNumber
        ' 
        StartingNumber.Location = New Point(119, 80)
        StartingNumber.Name = "StartingNumber"
        StartingNumber.Size = New Size(150, 27)
        StartingNumber.TabIndex = 0
        ' 
        ' NumberOfLoops
        ' 
        NumberOfLoops.Location = New Point(119, 143)
        NumberOfLoops.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        NumberOfLoops.Name = "NumberOfLoops"
        NumberOfLoops.Size = New Size(150, 27)
        NumberOfLoops.TabIndex = 1
        NumberOfLoops.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.AliceBlue
        Label1.Location = New Point(61, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 20)
        Label1.TabIndex = 2
        Label1.Text = "Start"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.AliceBlue
        Label2.Location = New Point(55, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 3
        Label2.Text = "loops"
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Location = New Point(148, 209)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(94, 29)
        SubmitButton.TabIndex = 4
        SubmitButton.Text = "Button1"
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        ClientSize = New Size(404, 273)
        Controls.Add(SubmitButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(NumberOfLoops)
        Controls.Add(StartingNumber)
        Name = "Form1"
        Text = "Practical Quiz"
        CType(StartingNumber, ComponentModel.ISupportInitialize).EndInit()
        CType(NumberOfLoops, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StartingNumber As NumericUpDown
    Friend WithEvents NumberOfLoops As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SubmitButton As Button

End Class
