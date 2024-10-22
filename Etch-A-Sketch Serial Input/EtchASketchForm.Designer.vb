<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtchASketchForm
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
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.EraseButton = New System.Windows.Forms.Button()
        Me.SerialInputRadioButton = New System.Windows.Forms.RadioButton()
        Me.SliderInputRadioButton = New System.Windows.Forms.RadioButton()
        Me.XAxisTrackBar = New System.Windows.Forms.TrackBar()
        Me.YAxisTrackBar = New System.Windows.Forms.TrackBar()
        Me.XAxisSliderLabel = New System.Windows.Forms.Label()
        Me.YAxisSliderLabel = New System.Windows.Forms.Label()
        Me.SerialInputTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ComSelectComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripChangeBackColorButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripChangePenColorButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripChangePenSizeButton = New System.Windows.Forms.ToolStripButton()
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        CType(Me.XAxisTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YAxisTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuitButton
        '
        Me.QuitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.Location = New System.Drawing.Point(745, 498)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(183, 66)
        Me.QuitButton.TabIndex = 0
        Me.QuitButton.TabStop = False
        Me.QuitButton.Text = "&Quit"
        Me.ToolTip1.SetToolTip(Me.QuitButton, "Exit The Program")
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'EraseButton
        '
        Me.EraseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EraseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EraseButton.Location = New System.Drawing.Point(540, 498)
        Me.EraseButton.Name = "EraseButton"
        Me.EraseButton.Size = New System.Drawing.Size(183, 66)
        Me.EraseButton.TabIndex = 2
        Me.EraseButton.Text = "&Erase"
        Me.ToolTip1.SetToolTip(Me.EraseButton, "Erase Current Drawing")
        Me.EraseButton.UseVisualStyleBackColor = True
        '
        'SerialInputRadioButton
        '
        Me.SerialInputRadioButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SerialInputRadioButton.AutoSize = True
        Me.SerialInputRadioButton.Location = New System.Drawing.Point(411, 498)
        Me.SerialInputRadioButton.Name = "SerialInputRadioButton"
        Me.SerialInputRadioButton.Size = New System.Drawing.Size(100, 21)
        Me.SerialInputRadioButton.TabIndex = 3
        Me.SerialInputRadioButton.Text = "Serial Input"
        Me.ToolTip1.SetToolTip(Me.SerialInputRadioButton, "Change to Serial Input Mode")
        Me.SerialInputRadioButton.UseVisualStyleBackColor = True
        '
        'SliderInputRadioButton
        '
        Me.SliderInputRadioButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SliderInputRadioButton.AutoSize = True
        Me.SliderInputRadioButton.Location = New System.Drawing.Point(411, 533)
        Me.SliderInputRadioButton.Name = "SliderInputRadioButton"
        Me.SliderInputRadioButton.Size = New System.Drawing.Size(100, 21)
        Me.SliderInputRadioButton.TabIndex = 4
        Me.SliderInputRadioButton.Text = "Slider Input"
        Me.ToolTip1.SetToolTip(Me.SliderInputRadioButton, "Change To Slider Input Mode")
        Me.SliderInputRadioButton.UseVisualStyleBackColor = True
        '
        'XAxisTrackBar
        '
        Me.XAxisTrackBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.XAxisTrackBar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.XAxisTrackBar.Location = New System.Drawing.Point(107, 472)
        Me.XAxisTrackBar.Maximum = 255
        Me.XAxisTrackBar.Name = "XAxisTrackBar"
        Me.XAxisTrackBar.Size = New System.Drawing.Size(286, 56)
        Me.XAxisTrackBar.TabIndex = 0
        Me.XAxisTrackBar.TickFrequency = 0
        Me.XAxisTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.ToolTip1.SetToolTip(Me.XAxisTrackBar, "Draw On X Axis")
        Me.XAxisTrackBar.Value = 128
        '
        'YAxisTrackBar
        '
        Me.YAxisTrackBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.YAxisTrackBar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.YAxisTrackBar.Location = New System.Drawing.Point(107, 534)
        Me.YAxisTrackBar.Maximum = 255
        Me.YAxisTrackBar.Name = "YAxisTrackBar"
        Me.YAxisTrackBar.Size = New System.Drawing.Size(286, 56)
        Me.YAxisTrackBar.TabIndex = 1
        Me.YAxisTrackBar.TickFrequency = 0
        Me.YAxisTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.ToolTip1.SetToolTip(Me.YAxisTrackBar, "Draw On Y Axis")
        Me.YAxisTrackBar.Value = 128
        '
        'XAxisSliderLabel
        '
        Me.XAxisSliderLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.XAxisSliderLabel.AutoSize = True
        Me.XAxisSliderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XAxisSliderLabel.Location = New System.Drawing.Point(32, 485)
        Me.XAxisSliderLabel.Name = "XAxisSliderLabel"
        Me.XAxisSliderLabel.Size = New System.Drawing.Size(69, 25)
        Me.XAxisSliderLabel.TabIndex = 7
        Me.XAxisSliderLabel.Text = "X Axis"
        '
        'YAxisSliderLabel
        '
        Me.YAxisSliderLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.YAxisSliderLabel.AutoSize = True
        Me.YAxisSliderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YAxisSliderLabel.Location = New System.Drawing.Point(32, 536)
        Me.YAxisSliderLabel.Name = "YAxisSliderLabel"
        Me.YAxisSliderLabel.Size = New System.Drawing.Size(68, 25)
        Me.YAxisSliderLabel.TabIndex = 8
        Me.YAxisSliderLabel.Text = "Y Axis"
        '
        'SerialInputTimer
        '
        '
        'SerialPort1
        '
        Me.SerialPort1.ReadTimeout = 100
        Me.SerialPort1.WriteTimeout = 100
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripChangeBackColorButton, Me.ToolStripChangePenColorButton, Me.ToolStripChangePenSizeButton, Me.ComSelectComboBox})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(954, 28)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ComSelectComboBox
        '
        Me.ComSelectComboBox.Name = "ComSelectComboBox"
        Me.ComSelectComboBox.Size = New System.Drawing.Size(121, 28)
        Me.ComSelectComboBox.ToolTipText = "Select COM Port"
        '
        'ToolStripChangeBackColorButton
        '
        Me.ToolStripChangeBackColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripChangeBackColorButton.Image = Global.Etch_A_Sketch_Serial_Input.My.Resources.Resources.icons8_color_swatch_48
        Me.ToolStripChangeBackColorButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripChangeBackColorButton.Name = "ToolStripChangeBackColorButton"
        Me.ToolStripChangeBackColorButton.Size = New System.Drawing.Size(29, 25)
        Me.ToolStripChangeBackColorButton.Text = "ToolStripButton2"
        Me.ToolStripChangeBackColorButton.ToolTipText = "Change BackGround Color"
        '
        'ToolStripChangePenColorButton
        '
        Me.ToolStripChangePenColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripChangePenColorButton.Image = Global.Etch_A_Sketch_Serial_Input.My.Resources.Resources.icons8_color_dropper_48
        Me.ToolStripChangePenColorButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripChangePenColorButton.Name = "ToolStripChangePenColorButton"
        Me.ToolStripChangePenColorButton.Size = New System.Drawing.Size(29, 25)
        Me.ToolStripChangePenColorButton.Text = "ToolStripButton1"
        Me.ToolStripChangePenColorButton.ToolTipText = "Change Pen Color"
        '
        'ToolStripChangePenSizeButton
        '
        Me.ToolStripChangePenSizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripChangePenSizeButton.Image = Global.Etch_A_Sketch_Serial_Input.My.Resources.Resources.icons8_edit_48
        Me.ToolStripChangePenSizeButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripChangePenSizeButton.Name = "ToolStripChangePenSizeButton"
        Me.ToolStripChangePenSizeButton.Size = New System.Drawing.Size(29, 25)
        Me.ToolStripChangePenSizeButton.Text = "ToolStripButton1"
        Me.ToolStripChangePenSizeButton.ToolTipText = "Change Pen Size"
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawingPictureBox.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.DrawingPictureBox.Location = New System.Drawing.Point(12, 42)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(930, 424)
        Me.DrawingPictureBox.TabIndex = 2
        Me.DrawingPictureBox.TabStop = False
        '
        'EtchASketchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(954, 592)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.YAxisSliderLabel)
        Me.Controls.Add(Me.XAxisSliderLabel)
        Me.Controls.Add(Me.YAxisTrackBar)
        Me.Controls.Add(Me.XAxisTrackBar)
        Me.Controls.Add(Me.SliderInputRadioButton)
        Me.Controls.Add(Me.SerialInputRadioButton)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Controls.Add(Me.EraseButton)
        Me.Controls.Add(Me.QuitButton)
        Me.MinimumSize = New System.Drawing.Size(972, 280)
        Me.Name = "EtchASketchForm"
        Me.Text = "Etch-A-Sketch"
        CType(Me.XAxisTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YAxisTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QuitButton As Button
    Friend WithEvents EraseButton As Button
    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents SerialInputRadioButton As RadioButton
    Friend WithEvents SliderInputRadioButton As RadioButton
    Friend WithEvents XAxisTrackBar As TrackBar
    Friend WithEvents YAxisTrackBar As TrackBar
    Friend WithEvents XAxisSliderLabel As Label
    Friend WithEvents YAxisSliderLabel As Label
    Friend WithEvents SerialInputTimer As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ComSelectComboBox As ToolStripComboBox
    Friend WithEvents ToolStripChangePenColorButton As ToolStripButton
    Friend WithEvents ToolStripChangeBackColorButton As ToolStripButton
    Friend WithEvents ToolStripChangePenSizeButton As ToolStripButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ColorDialog As ColorDialog
End Class
