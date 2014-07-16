<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataCalc))
        Me.lblFromType = New System.Windows.Forms.Label()
        Me.lblToType = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.comboToType = New System.Windows.Forms.ComboBox()
        Me.comboFromType = New System.Windows.Forms.ComboBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.ResultBox = New System.Windows.Forms.TextBox()
        Me.pnlDataCalc = New System.Windows.Forms.Panel()
        Me.rdoData = New System.Windows.Forms.RadioButton()
        Me.rdoText = New System.Windows.Forms.RadioButton()
        Me.pnlRadios = New System.Windows.Forms.Panel()
        Me.pnlDataCalc.SuspendLayout()
        Me.pnlRadios.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFromType
        '
        Me.lblFromType.AutoSize = True
        Me.lblFromType.Location = New System.Drawing.Point(12, 7)
        Me.lblFromType.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFromType.Name = "lblFromType"
        Me.lblFromType.Size = New System.Drawing.Size(99, 16)
        Me.lblFromType.TabIndex = 99
        Me.lblFromType.Text = "From Data Type"
        '
        'lblToType
        '
        Me.lblToType.AutoSize = True
        Me.lblToType.Location = New System.Drawing.Point(153, 7)
        Me.lblToType.Margin = New System.Windows.Forms.Padding(0)
        Me.lblToType.Name = "lblToType"
        Me.lblToType.Size = New System.Drawing.Size(82, 16)
        Me.lblToType.TabIndex = 99
        Me.lblToType.Text = "To Data Type"
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnConvert.Location = New System.Drawing.Point(83, 93)
        Me.btnConvert.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnConvert.Size = New System.Drawing.Size(75, 38)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert!"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'comboToType
        '
        Me.comboToType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboToType.FormattingEnabled = True
        Me.comboToType.Items.AddRange(New Object() {"Binary", "Octal", "Decimal", "Hexadecimal"})
        Me.comboToType.Location = New System.Drawing.Point(133, 23)
        Me.comboToType.Margin = New System.Windows.Forms.Padding(0)
        Me.comboToType.Name = "comboToType"
        Me.comboToType.Size = New System.Drawing.Size(121, 24)
        Me.comboToType.TabIndex = 2
        '
        'comboFromType
        '
        Me.comboFromType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboFromType.FormattingEnabled = True
        Me.comboFromType.Items.AddRange(New Object() {"Binary", "Octal", "Decimal", "Hexadecimal"})
        Me.comboFromType.Location = New System.Drawing.Point(0, 23)
        Me.comboFromType.Margin = New System.Windows.Forms.Padding(0)
        Me.comboFromType.Name = "comboFromType"
        Me.comboFromType.Size = New System.Drawing.Size(121, 24)
        Me.comboFromType.TabIndex = 1
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(99, 143)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(49, 16)
        Me.lblResult.TabIndex = 99
        Me.lblResult.Text = "Result!"
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(108, 51)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(37, 16)
        Me.lblInput.TabIndex = 99
        Me.lblInput.Text = "Input"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(43, 67)
        Me.txtInput.Margin = New System.Windows.Forms.Padding(0)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(156, 23)
        Me.txtInput.TabIndex = 3
        '
        'ResultBox
        '
        Me.ResultBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ResultBox.Location = New System.Drawing.Point(43, 158)
        Me.ResultBox.Margin = New System.Windows.Forms.Padding(0)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.ReadOnly = True
        Me.ResultBox.Size = New System.Drawing.Size(156, 23)
        Me.ResultBox.TabIndex = 5
        Me.ResultBox.TabStop = False
        '
        'pnlDataCalc
        '
        Me.pnlDataCalc.Controls.Add(Me.comboFromType)
        Me.pnlDataCalc.Controls.Add(Me.comboToType)
        Me.pnlDataCalc.Controls.Add(Me.ResultBox)
        Me.pnlDataCalc.Controls.Add(Me.lblResult)
        Me.pnlDataCalc.Controls.Add(Me.lblFromType)
        Me.pnlDataCalc.Controls.Add(Me.btnConvert)
        Me.pnlDataCalc.Controls.Add(Me.txtInput)
        Me.pnlDataCalc.Controls.Add(Me.lblInput)
        Me.pnlDataCalc.Controls.Add(Me.lblToType)
        Me.pnlDataCalc.Location = New System.Drawing.Point(9, 43)
        Me.pnlDataCalc.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlDataCalc.Name = "pnlDataCalc"
        Me.pnlDataCalc.Size = New System.Drawing.Size(255, 241)
        Me.pnlDataCalc.TabIndex = 101
        '
        'rdoData
        '
        Me.rdoData.AutoSize = True
        Me.rdoData.Location = New System.Drawing.Point(3, 7)
        Me.rdoData.Name = "rdoData"
        Me.rdoData.Size = New System.Drawing.Size(115, 20)
        Me.rdoData.TabIndex = 103
        Me.rdoData.TabStop = True
        Me.rdoData.Text = "Data Calculator"
        Me.rdoData.UseVisualStyleBackColor = True
        '
        'rdoText
        '
        Me.rdoText.AutoSize = True
        Me.rdoText.Location = New System.Drawing.Point(113, 9)
        Me.rdoText.Name = "rdoText"
        Me.rdoText.Size = New System.Drawing.Size(109, 20)
        Me.rdoText.TabIndex = 103
        Me.rdoText.TabStop = True
        Me.rdoText.Text = "Text Converter"
        Me.rdoText.UseVisualStyleBackColor = True
        '
        'pnlRadios
        '
        Me.pnlRadios.Controls.Add(Me.rdoText)
        Me.pnlRadios.Controls.Add(Me.rdoData)
        Me.pnlRadios.Location = New System.Drawing.Point(29, 4)
        Me.pnlRadios.Name = "pnlRadios"
        Me.pnlRadios.Size = New System.Drawing.Size(221, 36)
        Me.pnlRadios.TabIndex = 102
        '
        'frmDataCalc
        '
        Me.AcceptButton = Me.btnConvert
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(274, 257)
        Me.Controls.Add(Me.pnlRadios)
        Me.Controls.Add(Me.pnlDataCalc)
        Me.Font = New System.Drawing.Font("Razer Text Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDataCalc"
        Me.Text = "Data Calculator"
        Me.pnlDataCalc.ResumeLayout(False)
        Me.pnlDataCalc.PerformLayout()
        Me.pnlRadios.ResumeLayout(False)
        Me.pnlRadios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFromType As System.Windows.Forms.Label
    Friend WithEvents lblToType As System.Windows.Forms.Label
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents comboToType As System.Windows.Forms.ComboBox
    Friend WithEvents comboFromType As System.Windows.Forms.ComboBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents ResultBox As System.Windows.Forms.TextBox
    Friend WithEvents pnlDataCalc As System.Windows.Forms.Panel
    Friend WithEvents rdoData As System.Windows.Forms.RadioButton
    Friend WithEvents rdoText As System.Windows.Forms.RadioButton
    Friend WithEvents pnlRadios As System.Windows.Forms.Panel

End Class
