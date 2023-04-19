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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtRadius = New TextBox()
        txtHeight = New TextBox()
        txtVolume = New TextBox()
        btnCalculate = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(175, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 26)
        Label1.TabIndex = 0
        Label1.Text = "Cone Volume Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(100, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 24)
        Label2.TabIndex = 1
        Label2.Text = "Radius"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(100, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 24)
        Label3.TabIndex = 2
        Label3.Text = "Height"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(100, 225)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 24)
        Label4.TabIndex = 3
        Label4.Text = "Volume"
        ' 
        ' txtRadius
        ' 
        txtRadius.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtRadius.Location = New Point(200, 125)
        txtRadius.Name = "txtRadius"
        txtRadius.Size = New Size(224, 29)
        txtRadius.TabIndex = 4
        ' 
        ' txtHeight
        ' 
        txtHeight.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtHeight.Location = New Point(200, 175)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(224, 29)
        txtHeight.TabIndex = 5
        ' 
        ' txtVolume
        ' 
        txtVolume.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtVolume.Location = New Point(200, 225)
        txtVolume.Name = "txtVolume"
        txtVolume.ReadOnly = True
        txtVolume.Size = New Size(224, 29)
        txtVolume.TabIndex = 6
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnCalculate.Location = New Point(125, 300)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(100, 35)
        btnCalculate.TabIndex = 7
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(325, 300)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 35)
        Button1.TabIndex = 8
        Button1.Text = "Clear"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 361)
        Controls.Add(Button1)
        Controls.Add(btnCalculate)
        Controls.Add(txtVolume)
        Controls.Add(txtHeight)
        Controls.Add(txtRadius)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Cone Volume Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Button1 As Button
End Class
