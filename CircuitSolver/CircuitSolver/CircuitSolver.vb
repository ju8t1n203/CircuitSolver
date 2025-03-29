'Justin Bell
'RCET3371
'S25
'https://github.com/ju8t1n203/CircuitSolver

Option Compare Text
Option Explicit On
Option Strict On

Imports System.Globalization
Imports System.Math

'TODO
' [ ] calculate voltages
' [ ] calculate powers
' [ ] coordinate radio button functionality
' [ ] denotation radio button functionality

Public Class MainForm
    Private _continue As Boolean
    Private values(11, 10) As String      'refer to the "About" in the menu strip for array content layout

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'button event handlers----------------------------
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'user inputs----------------------------------------------
        VGenAValueTextBox.ResetText()
        VGenANotationComboBox.ResetText()
        VGenFValueTextBox.ResetText()
        VGenFNotationComboBox.ResetText()
        RGenValueTextBox.ResetText()
        RGenNotationComboBox.ResetText()
        R1ValueTextBox.ResetText()
        R1NotationComboBox.ResetText()
        C1ValueTextBox.ResetText()
        C1NotationComboBox.ResetText()
        C2ValueTextBox.ResetText()
        C2NotationComboBox.ResetText()
        L1ValueTextBox.ResetText()
        L1NotationComboBox.ResetText()
        RwValueTextBox.ResetText()
        RwNotationComboBox.ResetText()
        'schematic labels---------------------------------------
        VGenAmplitudeLabel.Text = "~Vp"
        VGenFrequencyLabel.Text = "~Hz"
        RGenSchematicLabel.Text = "~Ω"
        R1SchematicLabel.Text = "~Ω"
        C1SchematicLabel.Text = "~F"
        C2SchematicLabel.Text = "~F"
        L1SchematicLabel.Text = "~L"
        RwSchematicLabel.Text = "~Ω"
        'calculation labels-------------------------------------
        CalculatedVinLabel.Text = "Vin:"
        CalculatedVoutLabel.Text = "Vout:"
        CalculatedRGenLabel.Text = "RGen:"
        CalculatedR1Label.Text = "R1:"
        CalculatedC1Label.Text = "C1:"
        CalculatedC2Label.Text = "C2:"
        CalculatedL1Label.Text = "L1:"
        CalculatedRwLabel.Text = "Rw:"
        'radio buttons-------------------------------------------
        PolarRadioButton.Checked = True
        RectangularRadioButton.Checked = False
        PeakRadioButton.Checked = True
        RMSRadioButton.Checked = False
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        _continue = False
        values(9, 5) = "0"
        values(9, 6) = "0"
        values(9, 7) = "0"
        CheckValues() 'error handling
        MakeMsg() 'if any errors are present they will be displayed to the user
        If _continue = False Then
            'check failed message displays
        Else
            'check passed start calculations
            ActualValue()
            SetSchematicLabels()
            CalculateZTotal()
            CalculateVoltages()
        End If

    End Sub

    'calculation subroutines ---------------------------

    Sub MakeMsg()

        'the following if statements setup the warning message and popup box
        Dim empty As Integer = CInt(values(9, 5))             'for when a text/combo box is empty
        Dim wrong As Integer = CInt(values(9, 6))             'for when a textbox does not contain a decimal number
        Dim incorrect As Integer = CInt(values(9, 7))        'for when a combobox contains a string outside the selection options
        Dim warning As String = ""                                    'the message to be displayed if any information is incorrect

        If empty > 0 Then
            warning = $"{empty} fields are empty, ensure all fields are full."
        End If

        If wrong > 0 Then
            If warning <> "" Then
                warning &= Environment.NewLine
            End If
            warning &= $"{wrong} values contain letters, ensure all values are numbers."
        End If

        If incorrect > 0 Then
            If warning <> "" Then
                warning &= Environment.NewLine
            End If
            warning &= $"{incorrect} magnitudes are incorrect, please choose a value from the drop-down."
        End If

        If warning <> "" Then
            MsgBox(warning)
        Else
            _continue = True
        End If
    End Sub

    Sub VerifyStrings(_string As String)
        Dim empty As Integer = CInt(values(9, 5))        'for when a textbox is empty
        Dim wrong As Integer = CInt(values(9, 6))        'for when a textbox does not contain a decimal number

        If String.IsNullOrEmpty(_string) Then
            empty += 1
        Else
            If Decimal.TryParse(_string, Nothing) Then
            Else
                wrong += 1
            End If
        End If

        values(9, 5) = CStr(empty)
        values(9, 6) = CStr(wrong)

    End Sub

    Sub VerifyCombos(combo As ComboBox)
        Dim empty As Integer = CInt(values(9, 5))               'for when a combobox is empty
        Dim incorrect As Integer = CInt(values(9, 7))          'for when a combobox contains a string outside the selection options

        If String.IsNullOrEmpty(combo.Text) Then
            empty += 1
        ElseIf Not combo.Items.Contains(combo.Text) Then
            incorrect += 1
        Else
        End If

        values(9, 5) = CStr(empty)
        values(9, 7) = CStr(incorrect)

    End Sub

    Sub CheckValues()

        'the following if statements check the textboxes for valid data
        VerifyStrings(VGenAValueTextBox.Text)
        values(0, 0) = VGenAValueTextBox.Text

        VerifyStrings(VGenFValueTextBox.Text)
        values(1, 0) = VGenFValueTextBox.Text

        VerifyStrings(RGenValueTextBox.Text)
        values(2, 0) = RGenValueTextBox.Text

        VerifyStrings(R1ValueTextBox.Text)
        values(3, 0) = R1ValueTextBox.Text

        VerifyStrings(C1ValueTextBox.Text)
        values(4, 0) = C1ValueTextBox.Text

        VerifyStrings(C2ValueTextBox.Text)
        values(5, 0) = C2ValueTextBox.Text

        VerifyStrings(L1ValueTextBox.Text)
        values(6, 0) = L1ValueTextBox.Text

        VerifyStrings(RwValueTextBox.Text)
        values(7, 0) = RwValueTextBox.Text

        'the following if statements check the comboboxes for a selected value
        VerifyCombos(VGenANotationComboBox)
        values(0, 1) = CStr(VGenANotationComboBox.SelectedItem)

        VerifyCombos(VGenFNotationComboBox)
        values(1, 1) = CStr(VGenFNotationComboBox.SelectedItem)

        VerifyCombos(RGenNotationComboBox)
        values(2, 1) = CStr(RGenNotationComboBox.SelectedItem)

        VerifyCombos(R1NotationComboBox)
        values(3, 1) = CStr(R1NotationComboBox.SelectedItem)

        VerifyCombos(C1NotationComboBox)
        values(4, 1) = CStr(C1NotationComboBox.SelectedItem)

        VerifyCombos(C2NotationComboBox)
        values(5, 1) = CStr(C2NotationComboBox.SelectedItem)

        VerifyCombos(L1NotationComboBox)
        values(6, 1) = CStr(L1NotationComboBox.SelectedItem)

        VerifyCombos(RwNotationComboBox)
        values(7, 1) = CStr(RwNotationComboBox.SelectedItem)

    End Sub

    Function CalculateReal(base As TextBox, tothe As ComboBox) As String
        Dim _real As String = ""
        Dim exponentString As String = ""
        Dim exponent As Integer = 0

        'makes the combobox value usable
        exponentString = tothe.SelectedItem.ToString.Substring(4)
        Integer.TryParse(exponentString, exponent)

        'calculates the actual value
        _real = CStr(CDec(base.Text) * Math.Pow(10, exponent))
        Return _real
    End Function

    Sub ActualValue()

        values(0, 2) = CalculateReal(VGenAValueTextBox, VGenANotationComboBox)
        values(1, 2) = CalculateReal(VGenFValueTextBox, VGenFNotationComboBox)
        values(2, 2) = CalculateReal(RGenValueTextBox, RGenNotationComboBox)
        values(3, 2) = CalculateReal(R1ValueTextBox, R1NotationComboBox)
        values(4, 2) = CalculateReal(C1ValueTextBox, C1NotationComboBox)
        values(5, 2) = CalculateReal(C2ValueTextBox, C2NotationComboBox)
        values(6, 2) = CalculateReal(L1ValueTextBox, L1NotationComboBox)
        values(7, 2) = CalculateReal(RwValueTextBox, RwNotationComboBox)

    End Sub

    Sub CalculateZTotal()
        'dimensions for specs needed for calculations
        Dim xC1 As Decimal
        Dim xC2 As Decimal
        Dim xL1 As Decimal
        Dim zBX As Decimal       'zb is the impedance of L1 + Rw
        Dim zBY As Decimal
        Dim zSX As Decimal      'zs is the impedance of RGen + R1 + C1
        Dim zSY As Decimal
        Dim zPX As Decimal       'zp is the impedance of zb//c1
        Dim zPY As Decimal
        Dim zTX As Decimal      'total circiut impedance
        Dim zTY As Decimal

        xC1 = CDec(1 / (2 * 3.1415 * CDec(values(1, 2)) * CDec(values(4, 2))))
        xC2 = CDec(1 / (2 * 3.1415 * CDec(values(1, 2)) * CDec(values(5, 2))))
        xL1 = CDec(2 * 3.1415 * CDec(values(1, 2)) * CDec(values(6, 2)))
        zBX = CDec(values(7, 2))
        zBY = xL1
        zSX = CDec(values(2, 2)) + CDec(values(3, 2))
        zSY = -1 * xC1              '-1 because it is capacitive

        Dim Z1_real As Decimal = zBX
        Dim Z1_imag As Decimal = zBY
        Dim Z2_real As Decimal = 0
        Dim Z2_imag As Decimal = -xC2

        Dim denom_real As Decimal = CDec((Z1_real / (Z1_real ^ 2 + Z1_imag ^ 2)) + (Z2_real / (Z2_real ^ 2 + Z2_imag ^ 2)))
        Dim denom_imag As Decimal = CDec((-Z1_imag / (Z1_real ^ 2 + Z1_imag ^ 2)) + (-Z2_imag / (Z2_real ^ 2 + Z2_imag ^ 2)))

        Dim denom_mag As Decimal = CDec(denom_real ^ 2 + denom_imag ^ 2)
        zPX = denom_real / denom_mag
        zPY = -denom_imag / denom_mag
        zTX = zPX + zSX
        zTY = zPY + zSY
        values(8, 2) = CStr(zTX)
        values(8, 3) = CStr(zTY)
        Rect2Pol(zTX, zTY)
        values(8, 0) = values(9, 0)
        values(8, 1) = values(9, 1)
    End Sub

    Sub CalculateVoltages()

        If PeakRadioButton.Checked = True Then
            'peak current in polar
            values(8, 7) = CStr(CDbl(values(0, 2)) / CDbl(values(8, 0)))
            values(8, 8) = CStr(CDbl(values(8, 1)) * -1)
        Else
            'rms current in polar
            values(8, 7) = CStr(0.707 * CDbl(values(0, 2)) / CDbl(values(8, 0)))
            values(8, 8) = CStr(CDbl(values(8, 1)) * -1)
        End If
        'total power in polar
        values(0, 9) = CStr(CDbl(values(8, 7)) * CDbl(values(0, 2)))
        values(0, 10) = values(8, 8)
        'voltage of vin
        Rect2Pol((CDec(values(8, 2)) - CDec(values(2, 2))), (CDec(values(8, 3))))

        values(10, 3) = CStr(CDbl(values(9, 0)) * CDbl(values(8, 7)))
        values(10, 4) = CStr(CDbl(values(9, 1)) + CDbl(values(8, 8)))

        Pol2Rect(CDec(values(10, 3)), CDec(values(10, 4)))
        values(10, 5) = values(9, 2)
        values(10, 6) = values(9, 3)

        'power of vin
        values(10, 7) = CStr(CDbl(values(10, 3)) * CDbl(values(8, 7)))
        values(10, 8) = CStr(CDbl(values(10, 4)) + CDbl(values(8, 8)))

        Pol2Rect((CDec(values(10, 7))), (CDec(values(10, 8))))
        values(10, 9) = values(9, 2)
        values(10, 10) = values(9, 3)


        CalculatedVinLabel.Text = $"Vin: Voltage: {FormatEngineering(CDbl(values(10, 3)))}Vp ∟ {FormatEngineering(CDbl(values(10, 4)))} ° | Power: {FormatEngineering(CDbl(values(10, 7)))} Wp ∟ {FormatEngineering(CDbl(values(10, 8)))} °"

    End Sub

    'conversions-------------------------------------------
    Sub Rect2Pol(x As Decimal, y As Decimal)
        'calculate the radius
        Dim radius As Decimal = CDec(Sqrt(x * x + y * y))
        'calculates the angle in radians
        Dim degree As Decimal = CDec(Atan2(y, x) * (180 / PI))

        'save results
        values(9, 0) = CStr(radius)
        values(9, 1) = CStr(degree)
    End Sub

    Sub Pol2Rect(radius As Decimal, degree As Decimal)
        'converts degrees to radians
        Dim radian As Decimal = CDec(degree * (PI / 180))

        'calculates x and y
        Dim x As Decimal = radius * CDec(Cos(radian))
        Dim y As Decimal = radius * CDec(Sin(radian))

        'save results
        values(9, 2) = CStr(x)
        values(9, 3) = CStr(y)

    End Sub

    Function FormatEngineering(value As Double) As String
        Dim exponent As Double = Math.Floor(Math.Log10(Math.Abs(value)) / 3) * 3
        Dim mantissa As Double = value / Math.Pow(10, exponent)
        Return String.Format("{0:0.###}E{1}", mantissa, exponent)
    End Function

    'display options---------------------------------------
    Private Sub PolarRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PolarRadioButton.CheckedChanged
        TestLabel.Text = $"ZTotal = {FormatEngineering(CDbl(values(8, 0)))} ∟ {FormatEngineering(CDbl(values(8, 1)))} °"
    End Sub

    Private Sub RectangularRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RectangularRadioButton.CheckedChanged
        TestLabel.Text = $"ZTotal = {FormatEngineering(CDbl(values(8, 2)))} + {FormatEngineering(CDbl(values(8, 3)))} i"
    End Sub

    Private Sub PeakRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PeakRadioButton.CheckedChanged

    End Sub

    Private Sub RMSRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RMSRadioButton.CheckedChanged

    End Sub

    'extra subroutines----------------------------------
    Sub SetSchematicLabels()
        VGenAmplitudeLabel.Text = $"{FormatEngineering(CDbl(values(0, 2)))} Vp"
        VGenFrequencyLabel.Text = $"{FormatEngineering(CDbl(values(1, 2)))} Hz"
        RGenSchematicLabel.Text = $"{FormatEngineering(CDbl(values(2, 2)))} Ω"
        R1SchematicLabel.Text = $"{FormatEngineering(CDbl(values(3, 2)))} Ω"
        C1SchematicLabel.Text = $"{FormatEngineering(CDbl(values(4, 2)))} F"
        C2SchematicLabel.Text = $"{FormatEngineering(CDbl(values(5, 2)))} F"
        L1SchematicLabel.Text = $"{FormatEngineering(CDbl(values(6, 2)))} H"
        RwSchematicLabel.Text = $"{FormatEngineering(CDbl(values(7, 2)))} Ω"
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click

    End Sub

    'menu event handlers------------------------------
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'opens the about text file
        Dim filePath As String = IO.Path.Combine(Application.StartupPath, "..\About.txt")
        Process.Start(filePath)
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Dim filePath As String = IO.Path.Combine(Application.StartupPath, "..\Help.txt")
        Process.Start(filePath)
    End Sub

End Class