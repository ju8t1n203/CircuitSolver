<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ComponentValuesGroupBox = New System.Windows.Forms.GroupBox()
        Me.RGenNotationComboBox = New System.Windows.Forms.ComboBox()
        Me.RwNotationComboBox = New System.Windows.Forms.ComboBox()
        Me.R1NotationComboBox = New System.Windows.Forms.ComboBox()
        Me.L1NotationComboBox = New System.Windows.Forms.ComboBox()
        Me.C2NotationComboBox = New System.Windows.Forms.ComboBox()
        Me.C1NotationComboBox = New System.Windows.Forms.ComboBox()
        Me.VGenFNotationComboBox = New System.Windows.Forms.ComboBox()
        Me.VGenANotationComboBox = New System.Windows.Forms.ComboBox()
        Me.RwValueTextBox = New System.Windows.Forms.TextBox()
        Me.C1ValueTextBox = New System.Windows.Forms.TextBox()
        Me.C2ValueTextBox = New System.Windows.Forms.TextBox()
        Me.RwValueLabel = New System.Windows.Forms.Label()
        Me.RGenValueTextBox = New System.Windows.Forms.TextBox()
        Me.C2ValueLabel = New System.Windows.Forms.Label()
        Me.C1ValueLabel = New System.Windows.Forms.Label()
        Me.L1ValueTextBox = New System.Windows.Forms.TextBox()
        Me.RGenValueLabel = New System.Windows.Forms.Label()
        Me.L1ValueLabel = New System.Windows.Forms.Label()
        Me.R1ValueTextBox = New System.Windows.Forms.TextBox()
        Me.R1ValueLabel = New System.Windows.Forms.Label()
        Me.VGenFValueTextBox = New System.Windows.Forms.TextBox()
        Me.VGenFValueLabel = New System.Windows.Forms.Label()
        Me.VGenAValueTextBox = New System.Windows.Forms.TextBox()
        Me.VGenAValueLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.CalculationsGroupBox = New System.Windows.Forms.GroupBox()
        Me.CalculatedRwLabel = New System.Windows.Forms.Label()
        Me.CalculatedL1Label = New System.Windows.Forms.Label()
        Me.CalculatedC2Label = New System.Windows.Forms.Label()
        Me.CalculatedC1Label = New System.Windows.Forms.Label()
        Me.CalculatedR1Label = New System.Windows.Forms.Label()
        Me.CalculatedRGenLabel = New System.Windows.Forms.Label()
        Me.CalculatedVoutLabel = New System.Windows.Forms.Label()
        Me.CalculatedVinLabel = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VGenFrequencyLabel = New System.Windows.Forms.Label()
        Me.VGenAmplitudeLabel = New System.Windows.Forms.Label()
        Me.RGenSchematicLabel = New System.Windows.Forms.Label()
        Me.RwSchematicLabel = New System.Windows.Forms.Label()
        Me.C1SchematicLabel = New System.Windows.Forms.Label()
        Me.C2SchematicLabel = New System.Windows.Forms.Label()
        Me.R1SchematicLabel = New System.Windows.Forms.Label()
        Me.L1SchematicLabel = New System.Windows.Forms.Label()
        Me.CoordinatesGroupBox = New System.Windows.Forms.GroupBox()
        Me.PolarRadioButton = New System.Windows.Forms.RadioButton()
        Me.RectangularRadioButton = New System.Windows.Forms.RadioButton()
        Me.DenotationGroupBox = New System.Windows.Forms.GroupBox()
        Me.RMSRadioButton = New System.Windows.Forms.RadioButton()
        Me.PeakRadioButton = New System.Windows.Forms.RadioButton()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.LogButton = New System.Windows.Forms.Button()
        Me.TestLabel = New System.Windows.Forms.Label()
        Me.ComponentValuesGroupBox.SuspendLayout()
        Me.CalculationsGroupBox.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CoordinatesGroupBox.SuspendLayout()
        Me.DenotationGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(581, 440)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(216, 53)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Closes the application")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ComponentValuesGroupBox
        '
        Me.ComponentValuesGroupBox.Controls.Add(Me.RGenNotationComboBox)
        Me.ComponentValuesGroupBox.Controls.Add(Me.RwNotationComboBox)
        Me.ComponentValuesGroupBox.Controls.Add(Me.R1NotationComboBox)
        Me.ComponentValuesGroupBox.Controls.Add(Me.L1NotationComboBox)
        Me.ComponentValuesGroupBox.Controls.Add(Me.C2NotationComboBox)
        Me.ComponentValuesGroupBox.Controls.Add(Me.C1NotationComboBox)
        Me.ComponentValuesGroupBox.Controls.Add(Me.VGenFNotationComboBox)
        Me.ComponentValuesGroupBox.Controls.Add(Me.VGenANotationComboBox)
        Me.ComponentValuesGroupBox.Controls.Add(Me.RwValueTextBox)
        Me.ComponentValuesGroupBox.Controls.Add(Me.C1ValueTextBox)
        Me.ComponentValuesGroupBox.Controls.Add(Me.C2ValueTextBox)
        Me.ComponentValuesGroupBox.Controls.Add(Me.RwValueLabel)
        Me.ComponentValuesGroupBox.Controls.Add(Me.RGenValueTextBox)
        Me.ComponentValuesGroupBox.Controls.Add(Me.C2ValueLabel)
        Me.ComponentValuesGroupBox.Controls.Add(Me.C1ValueLabel)
        Me.ComponentValuesGroupBox.Controls.Add(Me.L1ValueTextBox)
        Me.ComponentValuesGroupBox.Controls.Add(Me.RGenValueLabel)
        Me.ComponentValuesGroupBox.Controls.Add(Me.L1ValueLabel)
        Me.ComponentValuesGroupBox.Controls.Add(Me.R1ValueTextBox)
        Me.ComponentValuesGroupBox.Controls.Add(Me.R1ValueLabel)
        Me.ComponentValuesGroupBox.Controls.Add(Me.VGenFValueTextBox)
        Me.ComponentValuesGroupBox.Controls.Add(Me.VGenFValueLabel)
        Me.ComponentValuesGroupBox.Controls.Add(Me.VGenAValueTextBox)
        Me.ComponentValuesGroupBox.Controls.Add(Me.VGenAValueLabel)
        Me.ComponentValuesGroupBox.Location = New System.Drawing.Point(581, 27)
        Me.ComponentValuesGroupBox.Name = "ComponentValuesGroupBox"
        Me.ComponentValuesGroupBox.Size = New System.Drawing.Size(214, 238)
        Me.ComponentValuesGroupBox.TabIndex = 0
        Me.ComponentValuesGroupBox.TabStop = False
        Me.ComponentValuesGroupBox.Text = "Component Values"
        Me.ToolTip.SetToolTip(Me.ComponentValuesGroupBox, "Input the value of each varible and select a magnitude." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The component value can " &
        "be no greater than 999.999")
        '
        'RGenNotationComboBox
        '
        Me.RGenNotationComboBox.FormattingEnabled = True
        Me.RGenNotationComboBox.Items.AddRange(New Object() {"x10^0", "x10^-3"})
        Me.RGenNotationComboBox.Location = New System.Drawing.Point(145, 76)
        Me.RGenNotationComboBox.Name = "RGenNotationComboBox"
        Me.RGenNotationComboBox.Size = New System.Drawing.Size(61, 21)
        Me.RGenNotationComboBox.TabIndex = 5
        '
        'RwNotationComboBox
        '
        Me.RwNotationComboBox.FormattingEnabled = True
        Me.RwNotationComboBox.Items.AddRange(New Object() {"x10^0", "x10^-3"})
        Me.RwNotationComboBox.Location = New System.Drawing.Point(145, 207)
        Me.RwNotationComboBox.Name = "RwNotationComboBox"
        Me.RwNotationComboBox.Size = New System.Drawing.Size(61, 21)
        Me.RwNotationComboBox.TabIndex = 15
        '
        'R1NotationComboBox
        '
        Me.R1NotationComboBox.FormattingEnabled = True
        Me.R1NotationComboBox.Items.AddRange(New Object() {"x10^6", "x10^3", "x10^0"})
        Me.R1NotationComboBox.Location = New System.Drawing.Point(145, 102)
        Me.R1NotationComboBox.Name = "R1NotationComboBox"
        Me.R1NotationComboBox.Size = New System.Drawing.Size(61, 21)
        Me.R1NotationComboBox.TabIndex = 7
        '
        'L1NotationComboBox
        '
        Me.L1NotationComboBox.FormattingEnabled = True
        Me.L1NotationComboBox.Items.AddRange(New Object() {"x10^0", "x10^-3", "x10^-6", "x10^-9", "x10^-12"})
        Me.L1NotationComboBox.Location = New System.Drawing.Point(145, 180)
        Me.L1NotationComboBox.Name = "L1NotationComboBox"
        Me.L1NotationComboBox.Size = New System.Drawing.Size(61, 21)
        Me.L1NotationComboBox.TabIndex = 13
        '
        'C2NotationComboBox
        '
        Me.C2NotationComboBox.FormattingEnabled = True
        Me.C2NotationComboBox.Items.AddRange(New Object() {"x10^0", "x10^-3", "x10^-6", "x10^-9", "x10^-12"})
        Me.C2NotationComboBox.Location = New System.Drawing.Point(145, 155)
        Me.C2NotationComboBox.Name = "C2NotationComboBox"
        Me.C2NotationComboBox.Size = New System.Drawing.Size(61, 21)
        Me.C2NotationComboBox.TabIndex = 11
        '
        'C1NotationComboBox
        '
        Me.C1NotationComboBox.FormattingEnabled = True
        Me.C1NotationComboBox.Items.AddRange(New Object() {"x10^0", "x10^-3", "x10^-6", "x10^-9", "x10^-12"})
        Me.C1NotationComboBox.Location = New System.Drawing.Point(145, 129)
        Me.C1NotationComboBox.Name = "C1NotationComboBox"
        Me.C1NotationComboBox.Size = New System.Drawing.Size(61, 21)
        Me.C1NotationComboBox.TabIndex = 9
        '
        'VGenFNotationComboBox
        '
        Me.VGenFNotationComboBox.FormattingEnabled = True
        Me.VGenFNotationComboBox.Items.AddRange(New Object() {"x10^9", "x10^6", "x10^3", "x10^0", "x10^-3"})
        Me.VGenFNotationComboBox.Location = New System.Drawing.Point(145, 52)
        Me.VGenFNotationComboBox.Name = "VGenFNotationComboBox"
        Me.VGenFNotationComboBox.Size = New System.Drawing.Size(61, 21)
        Me.VGenFNotationComboBox.TabIndex = 3
        '
        'VGenANotationComboBox
        '
        Me.VGenANotationComboBox.FormattingEnabled = True
        Me.VGenANotationComboBox.Items.AddRange(New Object() {"x10^0", "x10^-3"})
        Me.VGenANotationComboBox.Location = New System.Drawing.Point(145, 26)
        Me.VGenANotationComboBox.Name = "VGenANotationComboBox"
        Me.VGenANotationComboBox.Size = New System.Drawing.Size(61, 21)
        Me.VGenANotationComboBox.TabIndex = 1
        '
        'RwValueTextBox
        '
        Me.RwValueTextBox.Location = New System.Drawing.Point(55, 207)
        Me.RwValueTextBox.Name = "RwValueTextBox"
        Me.RwValueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.RwValueTextBox.TabIndex = 14
        '
        'C1ValueTextBox
        '
        Me.C1ValueTextBox.Location = New System.Drawing.Point(55, 129)
        Me.C1ValueTextBox.Name = "C1ValueTextBox"
        Me.C1ValueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.C1ValueTextBox.TabIndex = 8
        '
        'C2ValueTextBox
        '
        Me.C2ValueTextBox.Location = New System.Drawing.Point(55, 155)
        Me.C2ValueTextBox.Name = "C2ValueTextBox"
        Me.C2ValueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.C2ValueTextBox.TabIndex = 10
        '
        'RwValueLabel
        '
        Me.RwValueLabel.AutoSize = True
        Me.RwValueLabel.Location = New System.Drawing.Point(15, 210)
        Me.RwValueLabel.Name = "RwValueLabel"
        Me.RwValueLabel.Size = New System.Drawing.Size(23, 13)
        Me.RwValueLabel.TabIndex = 0
        Me.RwValueLabel.Text = "Rw"
        '
        'RGenValueTextBox
        '
        Me.RGenValueTextBox.Location = New System.Drawing.Point(55, 77)
        Me.RGenValueTextBox.Name = "RGenValueTextBox"
        Me.RGenValueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.RGenValueTextBox.TabIndex = 4
        '
        'C2ValueLabel
        '
        Me.C2ValueLabel.AutoSize = True
        Me.C2ValueLabel.Location = New System.Drawing.Point(15, 158)
        Me.C2ValueLabel.Name = "C2ValueLabel"
        Me.C2ValueLabel.Size = New System.Drawing.Size(20, 13)
        Me.C2ValueLabel.TabIndex = 0
        Me.C2ValueLabel.Text = "C2"
        '
        'C1ValueLabel
        '
        Me.C1ValueLabel.AutoSize = True
        Me.C1ValueLabel.Location = New System.Drawing.Point(15, 132)
        Me.C1ValueLabel.Name = "C1ValueLabel"
        Me.C1ValueLabel.Size = New System.Drawing.Size(20, 13)
        Me.C1ValueLabel.TabIndex = 0
        Me.C1ValueLabel.Text = "C1"
        '
        'L1ValueTextBox
        '
        Me.L1ValueTextBox.Location = New System.Drawing.Point(55, 181)
        Me.L1ValueTextBox.Name = "L1ValueTextBox"
        Me.L1ValueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.L1ValueTextBox.TabIndex = 12
        '
        'RGenValueLabel
        '
        Me.RGenValueLabel.AutoSize = True
        Me.RGenValueLabel.Location = New System.Drawing.Point(15, 80)
        Me.RGenValueLabel.Name = "RGenValueLabel"
        Me.RGenValueLabel.Size = New System.Drawing.Size(35, 13)
        Me.RGenValueLabel.TabIndex = 0
        Me.RGenValueLabel.Text = "RGen"
        '
        'L1ValueLabel
        '
        Me.L1ValueLabel.AutoSize = True
        Me.L1ValueLabel.Location = New System.Drawing.Point(15, 184)
        Me.L1ValueLabel.Name = "L1ValueLabel"
        Me.L1ValueLabel.Size = New System.Drawing.Size(19, 13)
        Me.L1ValueLabel.TabIndex = 0
        Me.L1ValueLabel.Text = "L1"
        '
        'R1ValueTextBox
        '
        Me.R1ValueTextBox.Location = New System.Drawing.Point(55, 103)
        Me.R1ValueTextBox.Name = "R1ValueTextBox"
        Me.R1ValueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.R1ValueTextBox.TabIndex = 6
        '
        'R1ValueLabel
        '
        Me.R1ValueLabel.AutoSize = True
        Me.R1ValueLabel.Location = New System.Drawing.Point(15, 106)
        Me.R1ValueLabel.Name = "R1ValueLabel"
        Me.R1ValueLabel.Size = New System.Drawing.Size(21, 13)
        Me.R1ValueLabel.TabIndex = 0
        Me.R1ValueLabel.Text = "R1"
        '
        'VGenFValueTextBox
        '
        Me.VGenFValueTextBox.Location = New System.Drawing.Point(55, 51)
        Me.VGenFValueTextBox.Name = "VGenFValueTextBox"
        Me.VGenFValueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.VGenFValueTextBox.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.VGenFValueTextBox, "The frequency of VGen")
        '
        'VGenFValueLabel
        '
        Me.VGenFValueLabel.AutoSize = True
        Me.VGenFValueLabel.Location = New System.Drawing.Point(15, 54)
        Me.VGenFValueLabel.Name = "VGenFValueLabel"
        Me.VGenFValueLabel.Size = New System.Drawing.Size(40, 13)
        Me.VGenFValueLabel.TabIndex = 0
        Me.VGenFValueLabel.Text = "VGenF"
        '
        'VGenAValueTextBox
        '
        Me.VGenAValueTextBox.Location = New System.Drawing.Point(55, 25)
        Me.VGenAValueTextBox.Name = "VGenAValueTextBox"
        Me.VGenAValueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.VGenAValueTextBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.VGenAValueTextBox, "The amplitude of VGen")
        '
        'VGenAValueLabel
        '
        Me.VGenAValueLabel.AutoSize = True
        Me.VGenAValueLabel.Location = New System.Drawing.Point(15, 28)
        Me.VGenAValueLabel.Name = "VGenAValueLabel"
        Me.VGenAValueLabel.Size = New System.Drawing.Size(41, 13)
        Me.VGenAValueLabel.TabIndex = 0
        Me.VGenAValueLabel.Text = "VGenA"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(581, 271)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(216, 53)
        Me.CalculateButton.TabIndex = 1
        Me.CalculateButton.Text = "C&alculate"
        Me.ToolTip.SetToolTip(Me.CalculateButton, "Calculates the voltage, current and power of each component." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All fields must be " &
        "filled to calculate.")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'CalculationsGroupBox
        '
        Me.CalculationsGroupBox.Controls.Add(Me.CalculatedRwLabel)
        Me.CalculationsGroupBox.Controls.Add(Me.CalculatedL1Label)
        Me.CalculationsGroupBox.Controls.Add(Me.CalculatedC2Label)
        Me.CalculationsGroupBox.Controls.Add(Me.CalculatedC1Label)
        Me.CalculationsGroupBox.Controls.Add(Me.CalculatedR1Label)
        Me.CalculationsGroupBox.Controls.Add(Me.CalculatedRGenLabel)
        Me.CalculationsGroupBox.Controls.Add(Me.CalculatedVoutLabel)
        Me.CalculationsGroupBox.Controls.Add(Me.CalculatedVinLabel)
        Me.CalculationsGroupBox.Location = New System.Drawing.Point(12, 330)
        Me.CalculationsGroupBox.Name = "CalculationsGroupBox"
        Me.CalculationsGroupBox.Size = New System.Drawing.Size(447, 163)
        Me.CalculationsGroupBox.TabIndex = 2
        Me.CalculationsGroupBox.TabStop = False
        Me.CalculationsGroupBox.Text = "Calculated Values"
        Me.ToolTip.SetToolTip(Me.CalculationsGroupBox, "These are the calculated values based off the inputs." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The labels will display as" &
        ": Component: Voltage | Current | Power")
        '
        'CalculatedRwLabel
        '
        Me.CalculatedRwLabel.AutoSize = True
        Me.CalculatedRwLabel.Location = New System.Drawing.Point(6, 142)
        Me.CalculatedRwLabel.Name = "CalculatedRwLabel"
        Me.CalculatedRwLabel.Size = New System.Drawing.Size(26, 13)
        Me.CalculatedRwLabel.TabIndex = 7
        Me.CalculatedRwLabel.Text = "Rw:"
        '
        'CalculatedL1Label
        '
        Me.CalculatedL1Label.AutoSize = True
        Me.CalculatedL1Label.Location = New System.Drawing.Point(6, 124)
        Me.CalculatedL1Label.Name = "CalculatedL1Label"
        Me.CalculatedL1Label.Size = New System.Drawing.Size(22, 13)
        Me.CalculatedL1Label.TabIndex = 6
        Me.CalculatedL1Label.Text = "L1:"
        '
        'CalculatedC2Label
        '
        Me.CalculatedC2Label.AutoSize = True
        Me.CalculatedC2Label.Location = New System.Drawing.Point(6, 106)
        Me.CalculatedC2Label.Name = "CalculatedC2Label"
        Me.CalculatedC2Label.Size = New System.Drawing.Size(23, 13)
        Me.CalculatedC2Label.TabIndex = 5
        Me.CalculatedC2Label.Text = "C2:"
        '
        'CalculatedC1Label
        '
        Me.CalculatedC1Label.AutoSize = True
        Me.CalculatedC1Label.Location = New System.Drawing.Point(6, 88)
        Me.CalculatedC1Label.Name = "CalculatedC1Label"
        Me.CalculatedC1Label.Size = New System.Drawing.Size(23, 13)
        Me.CalculatedC1Label.TabIndex = 4
        Me.CalculatedC1Label.Text = "C1:"
        '
        'CalculatedR1Label
        '
        Me.CalculatedR1Label.AutoSize = True
        Me.CalculatedR1Label.Location = New System.Drawing.Point(6, 70)
        Me.CalculatedR1Label.Name = "CalculatedR1Label"
        Me.CalculatedR1Label.Size = New System.Drawing.Size(24, 13)
        Me.CalculatedR1Label.TabIndex = 3
        Me.CalculatedR1Label.Text = "R1:"
        '
        'CalculatedRGenLabel
        '
        Me.CalculatedRGenLabel.AutoSize = True
        Me.CalculatedRGenLabel.Location = New System.Drawing.Point(6, 52)
        Me.CalculatedRGenLabel.Name = "CalculatedRGenLabel"
        Me.CalculatedRGenLabel.Size = New System.Drawing.Size(38, 13)
        Me.CalculatedRGenLabel.TabIndex = 2
        Me.CalculatedRGenLabel.Text = "RGen:"
        '
        'CalculatedVoutLabel
        '
        Me.CalculatedVoutLabel.AutoSize = True
        Me.CalculatedVoutLabel.Location = New System.Drawing.Point(6, 34)
        Me.CalculatedVoutLabel.Name = "CalculatedVoutLabel"
        Me.CalculatedVoutLabel.Size = New System.Drawing.Size(32, 13)
        Me.CalculatedVoutLabel.TabIndex = 1
        Me.CalculatedVoutLabel.Text = "Vout:"
        '
        'CalculatedVinLabel
        '
        Me.CalculatedVinLabel.AutoSize = True
        Me.CalculatedVinLabel.Location = New System.Drawing.Point(6, 16)
        Me.CalculatedVinLabel.Name = "CalculatedVinLabel"
        Me.CalculatedVinLabel.Size = New System.Drawing.Size(25, 13)
        Me.CalculatedVinLabel.TabIndex = 0
        Me.CalculatedVinLabel.Text = "Vin:"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(807, 25)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.TestToolStripMenuItem.Text = "test"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(45, 21)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 21)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.CircuitSolver.My.Resources.Resources.Screenshot_2025_02_14_0928181
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(563, 297)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'VGenFrequencyLabel
        '
        Me.VGenFrequencyLabel.AutoSize = True
        Me.VGenFrequencyLabel.Location = New System.Drawing.Point(27, 201)
        Me.VGenFrequencyLabel.Name = "VGenFrequencyLabel"
        Me.VGenFrequencyLabel.Size = New System.Drawing.Size(27, 13)
        Me.VGenFrequencyLabel.TabIndex = 3
        Me.VGenFrequencyLabel.Text = "~Hz"
        '
        'VGenAmplitudeLabel
        '
        Me.VGenAmplitudeLabel.AutoSize = True
        Me.VGenAmplitudeLabel.Location = New System.Drawing.Point(27, 185)
        Me.VGenAmplitudeLabel.Name = "VGenAmplitudeLabel"
        Me.VGenAmplitudeLabel.Size = New System.Drawing.Size(27, 13)
        Me.VGenAmplitudeLabel.TabIndex = 3
        Me.VGenAmplitudeLabel.Text = "~Vp"
        '
        'RGenSchematicLabel
        '
        Me.RGenSchematicLabel.AutoSize = True
        Me.RGenSchematicLabel.Location = New System.Drawing.Point(133, 161)
        Me.RGenSchematicLabel.Name = "RGenSchematicLabel"
        Me.RGenSchematicLabel.Size = New System.Drawing.Size(23, 13)
        Me.RGenSchematicLabel.TabIndex = 3
        Me.RGenSchematicLabel.Text = "~Ω"
        '
        'RwSchematicLabel
        '
        Me.RwSchematicLabel.AutoSize = True
        Me.RwSchematicLabel.Location = New System.Drawing.Point(452, 280)
        Me.RwSchematicLabel.Name = "RwSchematicLabel"
        Me.RwSchematicLabel.Size = New System.Drawing.Size(23, 13)
        Me.RwSchematicLabel.TabIndex = 3
        Me.RwSchematicLabel.Text = "~Ω"
        '
        'C1SchematicLabel
        '
        Me.C1SchematicLabel.AutoSize = True
        Me.C1SchematicLabel.Location = New System.Drawing.Point(288, 161)
        Me.C1SchematicLabel.Name = "C1SchematicLabel"
        Me.C1SchematicLabel.Size = New System.Drawing.Size(20, 13)
        Me.C1SchematicLabel.TabIndex = 3
        Me.C1SchematicLabel.Text = "~F"
        '
        'C2SchematicLabel
        '
        Me.C2SchematicLabel.AutoSize = True
        Me.C2SchematicLabel.Location = New System.Drawing.Point(359, 242)
        Me.C2SchematicLabel.Name = "C2SchematicLabel"
        Me.C2SchematicLabel.Size = New System.Drawing.Size(20, 13)
        Me.C2SchematicLabel.TabIndex = 3
        Me.C2SchematicLabel.Text = "~F"
        '
        'R1SchematicLabel
        '
        Me.R1SchematicLabel.AutoSize = True
        Me.R1SchematicLabel.Location = New System.Drawing.Point(215, 161)
        Me.R1SchematicLabel.Name = "R1SchematicLabel"
        Me.R1SchematicLabel.Size = New System.Drawing.Size(23, 13)
        Me.R1SchematicLabel.TabIndex = 4
        Me.R1SchematicLabel.Text = "~Ω"
        '
        'L1SchematicLabel
        '
        Me.L1SchematicLabel.AutoSize = True
        Me.L1SchematicLabel.Location = New System.Drawing.Point(442, 226)
        Me.L1SchematicLabel.Name = "L1SchematicLabel"
        Me.L1SchematicLabel.Size = New System.Drawing.Size(20, 13)
        Me.L1SchematicLabel.TabIndex = 5
        Me.L1SchematicLabel.Text = "~L"
        '
        'CoordinatesGroupBox
        '
        Me.CoordinatesGroupBox.Controls.Add(Me.PolarRadioButton)
        Me.CoordinatesGroupBox.Controls.Add(Me.RectangularRadioButton)
        Me.CoordinatesGroupBox.Location = New System.Drawing.Point(465, 330)
        Me.CoordinatesGroupBox.Name = "CoordinatesGroupBox"
        Me.CoordinatesGroupBox.Size = New System.Drawing.Size(109, 82)
        Me.CoordinatesGroupBox.TabIndex = 3
        Me.CoordinatesGroupBox.TabStop = False
        Me.CoordinatesGroupBox.Text = "Coordinate Type"
        '
        'PolarRadioButton
        '
        Me.PolarRadioButton.AutoSize = True
        Me.PolarRadioButton.Checked = True
        Me.PolarRadioButton.Location = New System.Drawing.Point(7, 24)
        Me.PolarRadioButton.Name = "PolarRadioButton"
        Me.PolarRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.PolarRadioButton.TabIndex = 1
        Me.PolarRadioButton.TabStop = True
        Me.PolarRadioButton.Text = "Polar"
        Me.PolarRadioButton.UseVisualStyleBackColor = True
        '
        'RectangularRadioButton
        '
        Me.RectangularRadioButton.AutoSize = True
        Me.RectangularRadioButton.Location = New System.Drawing.Point(7, 46)
        Me.RectangularRadioButton.Name = "RectangularRadioButton"
        Me.RectangularRadioButton.Size = New System.Drawing.Size(83, 17)
        Me.RectangularRadioButton.TabIndex = 0
        Me.RectangularRadioButton.Text = "Rectangular"
        Me.RectangularRadioButton.UseVisualStyleBackColor = True
        '
        'DenotationGroupBox
        '
        Me.DenotationGroupBox.Controls.Add(Me.RMSRadioButton)
        Me.DenotationGroupBox.Controls.Add(Me.PeakRadioButton)
        Me.DenotationGroupBox.Location = New System.Drawing.Point(465, 418)
        Me.DenotationGroupBox.Name = "DenotationGroupBox"
        Me.DenotationGroupBox.Size = New System.Drawing.Size(109, 75)
        Me.DenotationGroupBox.TabIndex = 4
        Me.DenotationGroupBox.TabStop = False
        Me.DenotationGroupBox.Text = "Denotation"
        '
        'RMSRadioButton
        '
        Me.RMSRadioButton.AutoSize = True
        Me.RMSRadioButton.Location = New System.Drawing.Point(6, 45)
        Me.RMSRadioButton.Name = "RMSRadioButton"
        Me.RMSRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.RMSRadioButton.TabIndex = 1
        Me.RMSRadioButton.Text = "RMS"
        Me.RMSRadioButton.UseVisualStyleBackColor = True
        '
        'PeakRadioButton
        '
        Me.PeakRadioButton.AutoSize = True
        Me.PeakRadioButton.Checked = True
        Me.PeakRadioButton.Location = New System.Drawing.Point(6, 23)
        Me.PeakRadioButton.Name = "PeakRadioButton"
        Me.PeakRadioButton.Size = New System.Drawing.Size(50, 17)
        Me.PeakRadioButton.TabIndex = 0
        Me.PeakRadioButton.TabStop = True
        Me.PeakRadioButton.Text = "Peak"
        Me.PeakRadioButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(581, 327)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(216, 53)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'LogButton
        '
        Me.LogButton.Location = New System.Drawing.Point(581, 383)
        Me.LogButton.Name = "LogButton"
        Me.LogButton.Size = New System.Drawing.Size(216, 53)
        Me.LogButton.TabIndex = 6
        Me.LogButton.Text = "&View Log"
        Me.LogButton.UseVisualStyleBackColor = True
        '
        'TestLabel
        '
        Me.TestLabel.AutoSize = True
        Me.TestLabel.Location = New System.Drawing.Point(27, 52)
        Me.TestLabel.Name = "TestLabel"
        Me.TestLabel.Size = New System.Drawing.Size(39, 13)
        Me.TestLabel.TabIndex = 8
        Me.TestLabel.Text = "Label1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 501)
        Me.Controls.Add(Me.TestLabel)
        Me.Controls.Add(Me.LogButton)
        Me.Controls.Add(Me.DenotationGroupBox)
        Me.Controls.Add(Me.CoordinatesGroupBox)
        Me.Controls.Add(Me.CalculationsGroupBox)
        Me.Controls.Add(Me.L1SchematicLabel)
        Me.Controls.Add(Me.R1SchematicLabel)
        Me.Controls.Add(Me.C2SchematicLabel)
        Me.Controls.Add(Me.C1SchematicLabel)
        Me.Controls.Add(Me.RwSchematicLabel)
        Me.Controls.Add(Me.RGenSchematicLabel)
        Me.Controls.Add(Me.VGenAmplitudeLabel)
        Me.Controls.Add(Me.VGenFrequencyLabel)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.ComponentValuesGroupBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Circuit Solver"
        Me.ComponentValuesGroupBox.ResumeLayout(False)
        Me.ComponentValuesGroupBox.PerformLayout()
        Me.CalculationsGroupBox.ResumeLayout(False)
        Me.CalculationsGroupBox.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CoordinatesGroupBox.ResumeLayout(False)
        Me.CoordinatesGroupBox.PerformLayout()
        Me.DenotationGroupBox.ResumeLayout(False)
        Me.DenotationGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComponentValuesGroupBox As GroupBox
    Friend WithEvents VGenAValueLabel As Label
    Friend WithEvents RwValueTextBox As TextBox
    Friend WithEvents C1ValueTextBox As TextBox
    Friend WithEvents C2ValueTextBox As TextBox
    Friend WithEvents RwValueLabel As Label
    Friend WithEvents RGenValueTextBox As TextBox
    Friend WithEvents C2ValueLabel As Label
    Friend WithEvents C1ValueLabel As Label
    Friend WithEvents L1ValueTextBox As TextBox
    Friend WithEvents RGenValueLabel As Label
    Friend WithEvents L1ValueLabel As Label
    Friend WithEvents R1ValueTextBox As TextBox
    Friend WithEvents R1ValueLabel As Label
    Friend WithEvents VGenAValueTextBox As TextBox
    Friend WithEvents VGenANotationComboBox As ComboBox
    Friend WithEvents RGenNotationComboBox As ComboBox
    Friend WithEvents RwNotationComboBox As ComboBox
    Friend WithEvents R1NotationComboBox As ComboBox
    Friend WithEvents C1NotationComboBox As ComboBox
    Friend WithEvents L1NotationComboBox As ComboBox
    Friend WithEvents C2NotationComboBox As ComboBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents VGenFrequencyLabel As Label
    Friend WithEvents VGenAmplitudeLabel As Label
    Friend WithEvents RGenSchematicLabel As Label
    Friend WithEvents RwSchematicLabel As Label
    Friend WithEvents C1SchematicLabel As Label
    Friend WithEvents C2SchematicLabel As Label
    Friend WithEvents R1SchematicLabel As Label
    Friend WithEvents L1SchematicLabel As Label
    Friend WithEvents VGenFNotationComboBox As ComboBox
    Friend WithEvents VGenFValueTextBox As TextBox
    Friend WithEvents VGenFValueLabel As Label
    Friend WithEvents CalculationsGroupBox As GroupBox
    Friend WithEvents CalculatedR1Label As Label
    Friend WithEvents CalculatedRGenLabel As Label
    Friend WithEvents CalculatedVoutLabel As Label
    Friend WithEvents CalculatedVinLabel As Label
    Friend WithEvents CalculatedRwLabel As Label
    Friend WithEvents CalculatedL1Label As Label
    Friend WithEvents CalculatedC2Label As Label
    Friend WithEvents CalculatedC1Label As Label
    Friend WithEvents CoordinatesGroupBox As GroupBox
    Friend WithEvents RectangularRadioButton As RadioButton
    Friend WithEvents PolarRadioButton As RadioButton
    Friend WithEvents DenotationGroupBox As GroupBox
    Friend WithEvents RMSRadioButton As RadioButton
    Friend WithEvents PeakRadioButton As RadioButton
    Friend WithEvents ClearButton As Button
    Friend WithEvents LogButton As Button
    Friend WithEvents TestLabel As Label
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
