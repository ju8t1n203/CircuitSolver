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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ComponentValuesGroupBox = New System.Windows.Forms.GroupBox()
        Me.VGenAValueLabel = New System.Windows.Forms.Label()
        Me.VGenAValueTextBox = New System.Windows.Forms.TextBox()
        Me.RGenValueLabel = New System.Windows.Forms.Label()
        Me.RGenValueTextBox = New System.Windows.Forms.TextBox()
        Me.R1ValueLabel = New System.Windows.Forms.Label()
        Me.R1ValueTextBox = New System.Windows.Forms.TextBox()
        Me.C1ValueLabel = New System.Windows.Forms.Label()
        Me.C1ValueTextBox = New System.Windows.Forms.TextBox()
        Me.L1ValueLabel = New System.Windows.Forms.Label()
        Me.L1ValueTextBox = New System.Windows.Forms.TextBox()
        Me.C2ValueLabel = New System.Windows.Forms.Label()
        Me.RwValueLabel = New System.Windows.Forms.Label()
        Me.C2ValueTextBox = New System.Windows.Forms.TextBox()
        Me.RwValueTextBox = New System.Windows.Forms.TextBox()
        Me.VGenANotationComboBox = New System.Windows.Forms.ComboBox()
        Me.RGenNotationComboBox = New System.Windows.Forms.ComboBox()
        Me.R1NotationComboBox = New System.Windows.Forms.ComboBox()
        Me.RwNotationComboBox = New System.Windows.Forms.ComboBox()
        Me.C1NotationComboBox = New System.Windows.Forms.ComboBox()
        Me.C2NotationComboBox = New System.Windows.Forms.ComboBox()
        Me.L1NotationComboBox = New System.Windows.Forms.ComboBox()
        Me.ValueLabel = New System.Windows.Forms.Label()
        Me.PowerLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VGenFrequencyLabel = New System.Windows.Forms.Label()
        Me.VGenAmplitudeLabel = New System.Windows.Forms.Label()
        Me.RGenSchematicLabel = New System.Windows.Forms.Label()
        Me.RwSchematicLabel = New System.Windows.Forms.Label()
        Me.C1SchematicLabel = New System.Windows.Forms.Label()
        Me.C2SchematicLabel = New System.Windows.Forms.Label()
        Me.R1SchematicLabel = New System.Windows.Forms.Label()
        Me.L1SchematicLabel = New System.Windows.Forms.Label()
        Me.VGenFValueLabel = New System.Windows.Forms.Label()
        Me.VGenFValueTextBox = New System.Windows.Forms.TextBox()
        Me.VGenFNotationComboBox = New System.Windows.Forms.ComboBox()
        Me.ComponentValuesGroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(483, 582)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(92, 53)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ComponentValuesGroupBox
        '
        Me.ComponentValuesGroupBox.Controls.Add(Me.PowerLabel)
        Me.ComponentValuesGroupBox.Controls.Add(Me.ValueLabel)
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
        Me.ComponentValuesGroupBox.Location = New System.Drawing.Point(12, 338)
        Me.ComponentValuesGroupBox.Name = "ComponentValuesGroupBox"
        Me.ComponentValuesGroupBox.Size = New System.Drawing.Size(206, 238)
        Me.ComponentValuesGroupBox.TabIndex = 0
        Me.ComponentValuesGroupBox.TabStop = False
        Me.ComponentValuesGroupBox.Text = "Component Values"
        '
        'VGenAValueLabel
        '
        Me.VGenAValueLabel.AutoSize = True
        Me.VGenAValueLabel.Location = New System.Drawing.Point(15, 32)
        Me.VGenAValueLabel.Name = "VGenAValueLabel"
        Me.VGenAValueLabel.Size = New System.Drawing.Size(41, 13)
        Me.VGenAValueLabel.TabIndex = 0
        Me.VGenAValueLabel.Text = "VGenA"
        '
        'VGenAValueTextBox
        '
        Me.VGenAValueTextBox.Location = New System.Drawing.Point(55, 29)
        Me.VGenAValueTextBox.Name = "VGenAValueTextBox"
        Me.VGenAValueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.VGenAValueTextBox.TabIndex = 0
        '
        'RGenValueLabel
        '
        Me.RGenValueLabel.AutoSize = True
        Me.RGenValueLabel.Location = New System.Drawing.Point(15, 84)
        Me.RGenValueLabel.Name = "RGenValueLabel"
        Me.RGenValueLabel.Size = New System.Drawing.Size(35, 13)
        Me.RGenValueLabel.TabIndex = 0
        Me.RGenValueLabel.Text = "RGen"
        '
        'RGenValueTextBox
        '
        Me.RGenValueTextBox.Location = New System.Drawing.Point(55, 81)
        Me.RGenValueTextBox.Name = "RGenValueTextBox"
        Me.RGenValueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.RGenValueTextBox.TabIndex = 4
        '
        'R1ValueLabel
        '
        Me.R1ValueLabel.AutoSize = True
        Me.R1ValueLabel.Location = New System.Drawing.Point(15, 110)
        Me.R1ValueLabel.Name = "R1ValueLabel"
        Me.R1ValueLabel.Size = New System.Drawing.Size(21, 13)
        Me.R1ValueLabel.TabIndex = 0
        Me.R1ValueLabel.Text = "R1"
        '
        'R1ValueTextBox
        '
        Me.R1ValueTextBox.Location = New System.Drawing.Point(55, 107)
        Me.R1ValueTextBox.Name = "R1ValueTextBox"
        Me.R1ValueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.R1ValueTextBox.TabIndex = 6
        '
        'C1ValueLabel
        '
        Me.C1ValueLabel.AutoSize = True
        Me.C1ValueLabel.Location = New System.Drawing.Point(15, 136)
        Me.C1ValueLabel.Name = "C1ValueLabel"
        Me.C1ValueLabel.Size = New System.Drawing.Size(20, 13)
        Me.C1ValueLabel.TabIndex = 0
        Me.C1ValueLabel.Text = "C1"
        '
        'C1ValueTextBox
        '
        Me.C1ValueTextBox.Location = New System.Drawing.Point(55, 133)
        Me.C1ValueTextBox.Name = "C1ValueTextBox"
        Me.C1ValueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.C1ValueTextBox.TabIndex = 8
        '
        'L1ValueLabel
        '
        Me.L1ValueLabel.AutoSize = True
        Me.L1ValueLabel.Location = New System.Drawing.Point(15, 188)
        Me.L1ValueLabel.Name = "L1ValueLabel"
        Me.L1ValueLabel.Size = New System.Drawing.Size(19, 13)
        Me.L1ValueLabel.TabIndex = 0
        Me.L1ValueLabel.Text = "L1"
        '
        'L1ValueTextBox
        '
        Me.L1ValueTextBox.Location = New System.Drawing.Point(55, 185)
        Me.L1ValueTextBox.Name = "L1ValueTextBox"
        Me.L1ValueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.L1ValueTextBox.TabIndex = 12
        '
        'C2ValueLabel
        '
        Me.C2ValueLabel.AutoSize = True
        Me.C2ValueLabel.Location = New System.Drawing.Point(15, 162)
        Me.C2ValueLabel.Name = "C2ValueLabel"
        Me.C2ValueLabel.Size = New System.Drawing.Size(20, 13)
        Me.C2ValueLabel.TabIndex = 0
        Me.C2ValueLabel.Text = "C2"
        '
        'RwValueLabel
        '
        Me.RwValueLabel.AutoSize = True
        Me.RwValueLabel.Location = New System.Drawing.Point(15, 214)
        Me.RwValueLabel.Name = "RwValueLabel"
        Me.RwValueLabel.Size = New System.Drawing.Size(23, 13)
        Me.RwValueLabel.TabIndex = 0
        Me.RwValueLabel.Text = "Rw"
        '
        'C2ValueTextBox
        '
        Me.C2ValueTextBox.Location = New System.Drawing.Point(55, 159)
        Me.C2ValueTextBox.Name = "C2ValueTextBox"
        Me.C2ValueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.C2ValueTextBox.TabIndex = 10
        '
        'RwValueTextBox
        '
        Me.RwValueTextBox.Location = New System.Drawing.Point(55, 211)
        Me.RwValueTextBox.Name = "RwValueTextBox"
        Me.RwValueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.RwValueTextBox.TabIndex = 14
        '
        'VGenANotationComboBox
        '
        Me.VGenANotationComboBox.FormattingEnabled = True
        Me.VGenANotationComboBox.Items.AddRange(New Object() {"x10^0", "x10^-3"})
        Me.VGenANotationComboBox.Location = New System.Drawing.Point(145, 30)
        Me.VGenANotationComboBox.Name = "VGenANotationComboBox"
        Me.VGenANotationComboBox.Size = New System.Drawing.Size(51, 21)
        Me.VGenANotationComboBox.TabIndex = 1
        '
        'RGenNotationComboBox
        '
        Me.RGenNotationComboBox.FormattingEnabled = True
        Me.RGenNotationComboBox.Items.AddRange(New Object() {"x10^0", "x10^-3"})
        Me.RGenNotationComboBox.Location = New System.Drawing.Point(145, 80)
        Me.RGenNotationComboBox.Name = "RGenNotationComboBox"
        Me.RGenNotationComboBox.Size = New System.Drawing.Size(51, 21)
        Me.RGenNotationComboBox.TabIndex = 5
        '
        'R1NotationComboBox
        '
        Me.R1NotationComboBox.FormattingEnabled = True
        Me.R1NotationComboBox.Items.AddRange(New Object() {"x10^6", "x10^3", "x10^0", "x10^-3"})
        Me.R1NotationComboBox.Location = New System.Drawing.Point(145, 106)
        Me.R1NotationComboBox.Name = "R1NotationComboBox"
        Me.R1NotationComboBox.Size = New System.Drawing.Size(51, 21)
        Me.R1NotationComboBox.TabIndex = 7
        '
        'RwNotationComboBox
        '
        Me.RwNotationComboBox.FormattingEnabled = True
        Me.RwNotationComboBox.Items.AddRange(New Object() {"x10^6", "x10^3", "x10^0", "x10^-3"})
        Me.RwNotationComboBox.Location = New System.Drawing.Point(145, 211)
        Me.RwNotationComboBox.Name = "RwNotationComboBox"
        Me.RwNotationComboBox.Size = New System.Drawing.Size(51, 21)
        Me.RwNotationComboBox.TabIndex = 15
        '
        'C1NotationComboBox
        '
        Me.C1NotationComboBox.FormattingEnabled = True
        Me.C1NotationComboBox.Items.AddRange(New Object() {"x10^0", "x10^-3", "x10^-6", "x10^-9", "x10^-12"})
        Me.C1NotationComboBox.Location = New System.Drawing.Point(145, 133)
        Me.C1NotationComboBox.Name = "C1NotationComboBox"
        Me.C1NotationComboBox.Size = New System.Drawing.Size(51, 21)
        Me.C1NotationComboBox.TabIndex = 9
        '
        'C2NotationComboBox
        '
        Me.C2NotationComboBox.FormattingEnabled = True
        Me.C2NotationComboBox.Items.AddRange(New Object() {"x10^0", "x10^-3", "x10^-6", "x10^-9", "x10^-12"})
        Me.C2NotationComboBox.Location = New System.Drawing.Point(145, 159)
        Me.C2NotationComboBox.Name = "C2NotationComboBox"
        Me.C2NotationComboBox.Size = New System.Drawing.Size(51, 21)
        Me.C2NotationComboBox.TabIndex = 11
        '
        'L1NotationComboBox
        '
        Me.L1NotationComboBox.FormattingEnabled = True
        Me.L1NotationComboBox.Items.AddRange(New Object() {"x10^0", "x10^-3", "x10^-6", "x10^-9", "x10^-12"})
        Me.L1NotationComboBox.Location = New System.Drawing.Point(145, 184)
        Me.L1NotationComboBox.Name = "L1NotationComboBox"
        Me.L1NotationComboBox.Size = New System.Drawing.Size(51, 21)
        Me.L1NotationComboBox.TabIndex = 13
        '
        'ValueLabel
        '
        Me.ValueLabel.AutoSize = True
        Me.ValueLabel.Location = New System.Drawing.Point(78, 13)
        Me.ValueLabel.Name = "ValueLabel"
        Me.ValueLabel.Size = New System.Drawing.Size(34, 13)
        Me.ValueLabel.TabIndex = 14
        Me.ValueLabel.Text = "Value"
        '
        'PowerLabel
        '
        Me.PowerLabel.AutoSize = True
        Me.PowerLabel.Location = New System.Drawing.Point(152, 14)
        Me.PowerLabel.Name = "PowerLabel"
        Me.PowerLabel.Size = New System.Drawing.Size(37, 13)
        Me.PowerLabel.TabIndex = 14
        Me.PowerLabel.Text = "Power"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(12, 582)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(206, 53)
        Me.CalculateButton.TabIndex = 1
        Me.CalculateButton.Text = "C&alculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.CircuitSolver.My.Resources.Resources.Screenshot_2025_02_14_0928181
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(563, 302)
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
        Me.VGenAmplitudeLabel.Size = New System.Drawing.Size(33, 13)
        Me.VGenAmplitudeLabel.TabIndex = 3
        Me.VGenAmplitudeLabel.Text = "~Vpp"
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
        'VGenFValueLabel
        '
        Me.VGenFValueLabel.AutoSize = True
        Me.VGenFValueLabel.Location = New System.Drawing.Point(15, 58)
        Me.VGenFValueLabel.Name = "VGenFValueLabel"
        Me.VGenFValueLabel.Size = New System.Drawing.Size(40, 13)
        Me.VGenFValueLabel.TabIndex = 0
        Me.VGenFValueLabel.Text = "VGenF"
        '
        'VGenFValueTextBox
        '
        Me.VGenFValueTextBox.Location = New System.Drawing.Point(55, 55)
        Me.VGenFValueTextBox.Name = "VGenFValueTextBox"
        Me.VGenFValueTextBox.Size = New System.Drawing.Size(84, 20)
        Me.VGenFValueTextBox.TabIndex = 2
        '
        'VGenFNotationComboBox
        '
        Me.VGenFNotationComboBox.FormattingEnabled = True
        Me.VGenFNotationComboBox.Items.AddRange(New Object() {"x10^-3", "x10^0", "x10^3", "x10^6", "x10^9"})
        Me.VGenFNotationComboBox.Location = New System.Drawing.Point(145, 56)
        Me.VGenFNotationComboBox.Name = "VGenFNotationComboBox"
        Me.VGenFNotationComboBox.Size = New System.Drawing.Size(51, 21)
        Me.VGenFNotationComboBox.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 643)
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
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Circuit Solver"
        Me.ComponentValuesGroupBox.ResumeLayout(False)
        Me.ComponentValuesGroupBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PowerLabel As Label
    Friend WithEvents ValueLabel As Label
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
End Class
