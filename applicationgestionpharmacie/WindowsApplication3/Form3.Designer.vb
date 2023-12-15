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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Buttonenregistrement = New System.Windows.Forms.Button()
        Me.Buttonconsultation = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(120, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pharmacie la grace "
        '
        'Buttonenregistrement
        '
        Me.Buttonenregistrement.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Buttonenregistrement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Buttonenregistrement.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Buttonenregistrement.Location = New System.Drawing.Point(200, 124)
        Me.Buttonenregistrement.Name = "Buttonenregistrement"
        Me.Buttonenregistrement.Size = New System.Drawing.Size(151, 43)
        Me.Buttonenregistrement.TabIndex = 1
        Me.Buttonenregistrement.Text = "Enregistrer produit"
        Me.Buttonenregistrement.UseVisualStyleBackColor = False
        '
        'Buttonconsultation
        '
        Me.Buttonconsultation.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Buttonconsultation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Buttonconsultation.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Buttonconsultation.Location = New System.Drawing.Point(200, 189)
        Me.Buttonconsultation.Name = "Buttonconsultation"
        Me.Buttonconsultation.Size = New System.Drawing.Size(151, 43)
        Me.Buttonconsultation.TabIndex = 2
        Me.Buttonconsultation.Text = "consulter stock"
        Me.Buttonconsultation.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(237, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Buttonconsultation)
        Me.Controls.Add(Me.Buttonenregistrement)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Buttonenregistrement As System.Windows.Forms.Button
    Friend WithEvents Buttonconsultation As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
