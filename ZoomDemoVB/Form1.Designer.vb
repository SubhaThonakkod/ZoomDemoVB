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
    Me.lblZoom = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'lblZoom
    '
    Me.lblZoom.AutoSize = True
    Me.lblZoom.Location = New System.Drawing.Point(201, 112)
    Me.lblZoom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
    Me.lblZoom.Name = "lblZoom"
    Me.lblZoom.Size = New System.Drawing.Size(34, 13)
    Me.lblZoom.TabIndex = 0
    Me.lblZoom.Text = "Zoom"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(600, 366)
    Me.Controls.Add(Me.lblZoom)
    Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents lblZoom As Label
End Class
