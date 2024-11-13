Declare Module x1
Declare Module x2
Declare Module y1
Declare Module y2
Declare Module z1
Declare Module z2
Function hwd
        char height = h
        char width = w
        char depth = d
End Function
            
Sub XYZ
  If x1 = 0 Then height + 1
  Else x2 = 0 Then height - 1
  Else y1 = 0 Then width + 1
  Else y2 = 0 Then width - 1
  Else z1 = 0 Then depth + 1
  Else z2 = 0 Then depth - 1
End Sub
              
    Dim x1 As Integer
    Dim y1 As Float
    Dim z1 As Double
Next
    ReDim x2 As Integer
    ReDim y2 As Float
    ReDim z2 As Double
Const (x1 - x2)^2 + (y1 - y2)^2 + (z1 - z2)^2 = 1
