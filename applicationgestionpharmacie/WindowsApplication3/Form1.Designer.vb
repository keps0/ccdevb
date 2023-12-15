<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.nompharmacie = New System.Windows.Forms.Label()
        Me.buttonAdmin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nompharmacie
        '
        Me.nompharmacie.AutoSize = True
        Me.nompharmacie.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!)
        Me.nompharmacie.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.nompharmacie.Location = New System.Drawing.Point(121, 38)
        Me.nompharmacie.Name = "nompharmacie"
        Me.nompharmacie.Size = New System.Drawing.Size(310, 39)
        Me.nompharmacie.TabIndex = 0
        Me.nompharmacie.Text = "Pharmacie la grace"
        '
        'buttonAdmin
        '
        Me.buttonAdmin.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.buttonAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.buttonAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.buttonAdmin.Location = New System.Drawing.Point(166, 156)
        Me.buttonAdmin.Name = "buttonAdmin"
        Me.buttonAdmin.Size = New System.Drawing.Size(228, 60)
        Me.buttonAdmin.TabIndex = 1
        Me.buttonAdmin.Text = "Espace administrateur"
        Me.buttonAdmin.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.buttonAdmin)
        Me.Controls.Add(Me.nompharmacie)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nompharmacie As System.Windows.Forms.Label
    Friend WithEvents buttonAdmin As System.Windows.Forms.Button

End Class
