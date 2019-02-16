Module modKeyControls
    Public Sub NumOnly(e As KeyPressEventArgs)
        If Not Asc(e.KeyChar) = Keys.Back Then
            If Not "1234567890.".Contains(e.KeyChar.ToString) Then
                e.Handled = True
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
    Public Sub CharOnly(e As KeyPressEventArgs)
        If Not Asc(e.KeyChar) = Keys.Back Then
            If Not "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890. ".Contains(e.KeyChar.ToString) Then
                e.Handled = True
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
End Module
