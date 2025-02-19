'Justin Bell
'RCET3371
'S25
'link

Option Compare Text
Option Explicit On
Option Strict On

Public Class MainForm
    Dim _continue As Boolean
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
        VGenAmplitudeLabel.Text = "~Vpp"
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
        CheckValues() 'error handling

        If _continue = False Then
        Else
            CalculateZTotal()
        End If

    End Sub

    Sub CheckValues()
        Dim empty As Integer        'for when a text/combo box is empty
        Dim wrong As Integer        'for when a textbox does not contain a decimal number
        Dim incorrect As Integer   'for when a combobox contains a string outside the selection options
        Dim warning As String       'the message to be displayed if any information is incorrect

        'the following if statements check each textbox for a number
        If String.IsNullOrEmpty(VGenAValueTextBox.Text) Then
            empty += 1
        Else
            If Decimal.TryParse(VGenAValueTextBox.Text, Nothing) Then
            Else
                wrong += 1
            End If
        End If

        If String.IsNullOrEmpty(VGenFValueTextBox.Text) Then
            empty += 1
        Else
            If Decimal.TryParse(VGenFValueTextBox.Text, Nothing) Then
            Else
                wrong += 1
            End If
        End If

        If String.IsNullOrEmpty(RGenValueTextBox.Text) Then
            empty += 1
        Else
            If Decimal.TryParse(RGenValueTextBox.Text, Nothing) Then
            Else
                wrong += 1
            End If
        End If

        If String.IsNullOrEmpty(R1ValueTextBox.Text) Then
            empty += 1
        Else
            If Decimal.TryParse(R1ValueTextBox.Text, Nothing) Then
            Else
                wrong += 1
            End If
        End If

        If String.IsNullOrEmpty(C1ValueTextBox.Text) Then
            empty += 1
        Else
            If Decimal.TryParse(C1ValueTextBox.Text, Nothing) Then
            Else
                wrong += 1
            End If
        End If

        If String.IsNullOrEmpty(C2ValueTextBox.Text) Then
            empty += 1
        Else
            If Decimal.TryParse(C2ValueTextBox.Text, Nothing) Then
            Else
                wrong += 1
            End If
        End If

        If String.IsNullOrEmpty(L1ValueTextBox.Text) Then
            empty += 1
        Else
            If Decimal.TryParse(L1ValueTextBox.Text, Nothing) Then
            Else
                wrong += 1
            End If
        End If

        If String.IsNullOrEmpty(RwValueTextBox.Text) Then
            empty += 1
        Else
            If Decimal.TryParse(RwValueTextBox.Text, Nothing) Then
            Else
                wrong += 1
            End If
        End If

        'the following if statements check the comboboxes for a selected value
        If String.IsNullOrEmpty(VGenANotationComboBox.Text) Then
            empty += 1
        ElseIf Not VGenANotationComboBox.Items.Contains(VGenANotationComboBox.Text) Then
            incorrect += 1
        Else
        End If

        If String.IsNullOrEmpty(VGenFNotationComboBox.Text) Then
            empty += 1
        ElseIf Not VGenFNotationComboBox.Items.Contains(VGenFNotationComboBox.Text) Then
            incorrect += 1
        Else
        End If

        If String.IsNullOrEmpty(RGenNotationComboBox.Text) Then
            empty += 1
        ElseIf Not RGenNotationComboBox.Items.Contains(RGenNotationComboBox.Text) Then
            incorrect += 1
        Else
        End If

        If String.IsNullOrEmpty(R1NotationComboBox.Text) Then
            empty += 1
        ElseIf Not R1NotationComboBox.Items.Contains(R1NotationComboBox.Text) Then
            incorrect += 1
        Else
        End If

        If String.IsNullOrEmpty(C1NotationComboBox.Text) Then
            empty += 1
        ElseIf Not C1NotationComboBox.Items.Contains(C1NotationComboBox.Text) Then
            incorrect += 1
        Else
        End If

        If String.IsNullOrEmpty(C2NotationComboBox.Text) Then
            empty += 1
        ElseIf Not C2NotationComboBox.Items.Contains(C2NotationComboBox.Text) Then
            incorrect += 1
        Else
        End If

        If String.IsNullOrEmpty(L1NotationComboBox.Text) Then
            empty += 1
        ElseIf Not L1NotationComboBox.Items.Contains(L1NotationComboBox.Text) Then
            incorrect += 1
        Else
        End If

        If String.IsNullOrEmpty(RwNotationComboBox.Text) Then
            empty += 1
        ElseIf Not RwNotationComboBox.Items.Contains(RwNotationComboBox.Text) Then
            incorrect += 1
        Else
        End If

        'the following if statements setup the warning message and popup box
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

    Sub CalculateZTotal()
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

        xC1 = CDec(1 / (2 * 3.1415 * CDec(VGenFValueTextBox.Text) * CDec(C1ValueTextBox.Text)))
        xC2 = CDec(1 / (2 * 3.1415 * CDec(VGenFValueTextBox.Text) * CDec(C2ValueTextBox.Text)))
        xL1 = CDec(1 / (2 * 3.1415 * CDec(VGenFValueTextBox.Text) * CDec(L1ValueTextBox.Text)))
        zBX = CDec(RwValueTextBox.Text)
        zBY = xL1
        zSX = CDec(RGenValueTextBox.Text) + CDec(R1ValueTextBox.Text)
        zSY = -1 * xC1              '-1 because it is capacitive
        'zp=((zBX+zBY)^-1 +(0-xC1)^-1)^-1
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
        TestLabel.Text = $"Zparrallel = {zPX}, {zPY}i"
    End Sub

    'display options---------------------------------------
    Private Sub PolarRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PolarRadioButton.CheckedChanged

    End Sub

    Private Sub RectangularRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RectangularRadioButton.CheckedChanged

    End Sub

    Private Sub PeakRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PeakRadioButton.CheckedChanged

    End Sub

    Private Sub RMSRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RMSRadioButton.CheckedChanged

    End Sub

End Class