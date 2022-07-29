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
        Me.generatebtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'generatebtn
        '
        Me.generatebtn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.generatebtn.Location = New System.Drawing.Point(312, 149)
        Me.generatebtn.Name = "generatebtn"
        Me.generatebtn.Size = New System.Drawing.Size(154, 114)
        Me.generatebtn.TabIndex = 0
        Me.generatebtn.Text = "Generate"
        Me.generatebtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(826, 441)
        Me.Controls.Add(Me.generatebtn)
        Me.Name = "Form1"
        Me.Text = "ResuneGenerator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents generatebtn As Button
End Class
