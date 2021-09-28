Public Class Form1
  Enum ZoomDirection
    None
    Up
    Down
  End Enum

  Dim CtrlIsDown As Boolean
  Dim ZoomValue As Integer

  Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    ZoomValue = 100
  End Sub

  Private Sub Form1_KeyDown_KeyUp(ByVal sender As Object,
                                  ByVal e As KeyEventArgs) _
              Handles Me.KeyDown, Me.KeyUp

    CtrlIsDown = e.Control
  End Sub

  Private Sub Form1_MouseWheel(ByVal sender As Object,
                               ByVal e As MouseEventArgs) _
              Handles Me.MouseWheel

    'check if control is being held down
    If Control.ModifierKeys = Keys.Control Then
      'evaluate the delta's sign and call the appropriate zoom command
      Select Case Math.Sign(e.Delta)
        Case Is < 0
          Zoom(ZoomDirection.Down)
        Case Is > 0
          Zoom(ZoomDirection.Up)
        Case Else
          Zoom(ZoomDirection.None)
      End Select
      Dim fontsize As Single = Me.Font.Size
      Dim min_size As Single = 8.25
      Dim max_size As Single = 17
      If (e.Delta > 0) Then
        If fontsize < max_size Then
          Me.Font = New Font(Me.Font.FontFamily.ToString, fontsize + 2, Me.Font.Style)
        End If
      Else
        If fontsize > min_size Then
          Me.Font = New Font(Me.Font.FontFamily.ToString, fontsize - 2, Me.Font.Style)
        End If
      End If
    End If
  End Sub

  Private Sub Zoom(ByVal direction As ZoomDirection)
    'change the zoom value based on the direction passed

    Select Case direction
      Case ZoomDirection.Up
        ZoomValue += 1
      Case ZoomDirection.Down
        ZoomValue -= 1
      Case Else
        'do nothing
    End Select

    Me.Text = ZoomValue.ToString()
  End Sub
End Class
