Imports System.Runtime.InteropServices
Module modVariables
    Public fromTypeBase As Integer
    Public toTypeBase As Integer
    Public fromType As String
    Public toType As String
    Public validInputs() As String
End Module

Public Class frmDataCalc
    Private Sub Form_Loaded(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Preselect the Data Calculator Radio button
        rdoData.Checked = True
        'Radio Panel Configuration
        rdoData.Location = New Point(0, 0)
        rdoText.Location = New Point(rdoData.Width + 5, 0)
        pnlRadios.Size = New Size(rdoData.Width + rdoText.Width + 5, rdoData.Height)
        'Center Objects
        CenterPanels()
        lblInput.Location = New Point((pnlDataCalc.Width - lblInput.Width) / 2, 50)
        txtInput.Location = New Point((pnlDataCalc.Width - txtInput.Width) / 2, 65)
        btnConvert.Location = New Point((pnlDataCalc.Width - btnConvert.Width) / 2, 95)
        lblResult.Location = New Point((pnlDataCalc.Width - lblResult.Width) / 2, 150)
        ResultBox.Location = New Point((pnlDataCalc.Width - ResultBox.Width) / 2, 165)
    End Sub
    Private Sub CenterPanels()
        pnlRadios.Location = New Point((Me.DisplayRectangle.Width - pnlRadios.Width) / 2, 5)
        pnlDataCalc.Location = New Point((Me.DisplayRectangle.Width - pnlDataCalc.Width) / 2, 40)
    End Sub
    Private Sub Form_Resized(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        CenterPanels()
    End Sub
    Private Sub ResultBox_GotFocus(sender As Object, e As EventArgs) Handles ResultBox.GotFocus
        HideCaret(ResultBox.Handle)
    End Sub
    <DllImport("user32.dll")> _
    Private Shared Function HideCaret(hWnd As IntPtr) As Boolean
    End Function
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If toType = fromType Then
            ResultBox.Text = "INVALID SELECTION"
        ElseIf Not isValidInput(txtInput.Text) Then
            ResultBox.Text = "INVALID INPUT"
        ElseIf toType = fromType Then
            ResultBox.Text = "INVALID SELECTION"
        ElseIf fromType = "Decimal" Then
            ResultBox.Text = ConvertFromDecimal(txtInput.Text)
        ElseIf toType = "Decimal" Then
            ResultBox.Text = ConvertToDecimal(txtInput.Text)
        Else
            ResultBox.Text = ConvertFromDecimal(ConvertToDecimal(txtInput.Text))
        End If
    End Sub
    Private Sub comboToType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboToType.SelectedIndexChanged
        Select Case comboToType.SelectedItem
            Case "Binary"
                toType = "Binary"
                toTypeBase = 2
            Case "Octal"
                toType = "Octal"
                toTypeBase = 8
            Case "Decimal"
                toType = "Decimal"
                toTypeBase = 10
            Case "Hexadecimal"
                toType = "Hexadecimal"
                toTypeBase = 16
        End Select
    End Sub
    Private Sub comboFromType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboFromType.SelectedIndexChanged
        Select Case comboFromType.SelectedItem
            Case "Binary"
                fromTypeBase = 2
                fromType = "Binary"
                validInputs = {"0", "1"}
            Case "Octal"
                fromTypeBase = 8
                fromType = "Octal"
                validInputs = {"0", "1", "2", "3", "4", "5", "6", "7"}
            Case "Decimal"
                fromTypeBase = 10
                fromType = "Decimal"
                validInputs = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
            Case "Hexadecimal"
                fromTypeBase = 16
                fromType = "Hexadecimal"
                validInputs = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "A", "b", "B", "c", "C", "d", "D", "e", "E", "f", "F"}
        End Select
    End Sub
    Private Sub rdoData_CheckedChanged(sender As Object, e As EventArgs) Handles rdoData.CheckedChanged

    End Sub
    Private Sub rdoText_CheckedChanged(sender As Object, e As EventArgs) Handles rdoText.CheckedChanged

    End Sub
End Class
Module modFunctions
    Function isValidInput(ByVal strInput As String) As Boolean

        For Each e In strInput
            If validInputs.Contains(e) Then
            Else
                Return False
            End If
        Next
        Return True
    End Function
    Function ConvertStringtoNumber(ByVal strInput As String) As Array
        Dim arrArrayofInputValues(strInput.Length - 1) As Long
        Dim Counter As Integer = 0

        For Each e As Char In strInput.ToLower
            Select Case e
                Case "0"
                    arrArrayofInputValues(Counter) = 0
                Case "1"
                    arrArrayofInputValues(Counter) = 1
                Case "2"
                    arrArrayofInputValues(Counter) = 2
                Case "3"
                    arrArrayofInputValues(Counter) = 3
                Case "4"
                    arrArrayofInputValues(Counter) = 4
                Case "5"
                    arrArrayofInputValues(Counter) = 5
                Case "6"
                    arrArrayofInputValues(Counter) = 6
                Case "7"
                    arrArrayofInputValues(Counter) = 7
                Case "8"
                    arrArrayofInputValues(Counter) = 8
                Case "9"
                    arrArrayofInputValues(Counter) = 9
                Case "a"
                    arrArrayofInputValues(Counter) = 10
                Case "b"
                    arrArrayofInputValues(Counter) = 11
                Case "c"
                    arrArrayofInputValues(Counter) = 12
                Case "d"
                    arrArrayofInputValues(Counter) = 13
                Case "e"
                    arrArrayofInputValues(Counter) = 14
                Case "f"
                    arrArrayofInputValues(Counter) = 15
            End Select
            Counter = Counter + 1
        Next

        Return arrArrayofInputValues
    End Function
    Function ConvertNumberToString(ByVal intInput As Array) As String
        Dim arrArrayofOutputChars(intInput.Length - 1) As Char
        Dim Counter As Integer = 0

        For Each e In intInput
            Select Case e
                Case "0"
                    arrArrayofOutputChars(Counter) = "0"
                Case "1"
                    arrArrayofOutputChars(Counter) = "1"
                Case "2"
                    arrArrayofOutputChars(Counter) = "2"
                Case "3"
                    arrArrayofOutputChars(Counter) = "3"
                Case "4"
                    arrArrayofOutputChars(Counter) = "4"
                Case "5"
                    arrArrayofOutputChars(Counter) = "5"
                Case "6"
                    arrArrayofOutputChars(Counter) = "6"
                Case "7"
                    arrArrayofOutputChars(Counter) = "7"
                Case "8"
                    arrArrayofOutputChars(Counter) = "8"
                Case "9"
                    arrArrayofOutputChars(Counter) = "9"
                Case "10"
                    arrArrayofOutputChars(Counter) = "A"
                Case "11"
                    arrArrayofOutputChars(Counter) = "B"
                Case "12"
                    arrArrayofOutputChars(Counter) = "C"
                Case "13"
                    arrArrayofOutputChars(Counter) = "D"
                Case "14"
                    arrArrayofOutputChars(Counter) = "E"
                Case "15"
                    arrArrayofOutputChars(Counter) = "F"
            End Select
            Counter = Counter + 1
        Next

        Return arrArrayofOutputChars
    End Function
    Function ConvertToDecimal(ByVal strInput As String) As String
        Dim arrArrayOfInputValues() As Long = ConvertStringtoNumber(strInput)
        Dim ReverseCounter As Integer = arrArrayOfInputValues.Length
        Dim Result As Long

        For Each e As Integer In arrArrayOfInputValues
            ReverseCounter = ReverseCounter - 1
            Result = Result + (e * fromTypeBase ^ ReverseCounter)
        Next

        Return Result
    End Function
    Function ConvertFromDecimal(ByVal intInput As Long) As String

        Dim Remainder As Long
        Dim intLooper As Decimal
        Dim intLooper2 As Long = intInput
        Dim wholePart As Long
        Dim Counter As Integer = 0
        Dim digitCount As Integer = 0

        Do
            intLooper = intLooper2 / toTypeBase
            intLooper = Math.Truncate(intLooper)
            intLooper2 = intLooper
            digitCount = digitCount + 1
        Loop While intLooper > 0

        Dim arrArrayOfValues(digitCount - 1) As Integer

        Do
            intLooper = intInput / toTypeBase
            wholePart = Math.Truncate(intLooper)
            Remainder = intInput - (wholePart * toTypeBase)
            intInput = wholePart
            arrArrayOfValues(Counter) = Remainder
            Counter = Counter + 1
        Loop While wholePart > 0

        Array.Reverse(arrArrayOfValues)

        Dim Result As String = ConvertNumberToString(arrArrayOfValues)
        Return Result
    End Function
End Module