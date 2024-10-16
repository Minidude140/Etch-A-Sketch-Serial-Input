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
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.EraseButton = New System.Windows.Forms.Button()
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.SerialInpurRadioButton = New System.Windows.Forms.RadioButton()
        Me.SliderInputRadioButton = New System.Windows.Forms.RadioButton()
        Me.XAxisTrackBar = New System.Windows.Forms.TrackBar()
        Me.YAxisTrackBar = New System.Windows.Forms.TrackBar()
        Me.XAxisSliderLabel = New System.Windows.Forms.Label()
        Me.YAxisSliderLabel = New System.Windows.Forms.Label()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XAxisTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YAxisTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuitButton
        '
        Me.QuitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.Location = New System.Drawing.Point(745, 492)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(183, 66)
        Me.QuitButton.TabIndex = 0
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'EraseButton
        '
        Me.EraseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EraseButton.Location = New System.Drawing.Point(540, 492)
        Me.EraseButton.Name = "EraseButton"
        Me.EraseButton.Size = New System.Drawing.Size(183, 66)
        Me.EraseButton.TabIndex = 1
        Me.EraseButton.Text = "Erase"
        Me.EraseButton.UseVisualStyleBackColor = True
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.DrawingPictureBox.Location = New System.Drawing.Point(12, 42)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(930, 411)
        Me.DrawingPictureBox.TabIndex = 2
        Me.DrawingPictureBox.TabStop = False
        '
        'SerialInpurRadioButton
        '
        Me.SerialInpurRadioButton.AutoSize = True
        Me.SerialInpurRadioButton.Location = New System.Drawing.Point(411, 492)
        Me.SerialInpurRadioButton.Name = "SerialInpurRadioButton"
        Me.SerialInpurRadioButton.Size = New System.Drawing.Size(100, 21)
        Me.SerialInpurRadioButton.TabIndex = 3
        Me.SerialInpurRadioButton.TabStop = True
        Me.SerialInpurRadioButton.Text = "Serial Input"
        Me.SerialInpurRadioButton.UseVisualStyleBackColor = True
        '
        'SliderInputRadioButton
        '
        Me.SliderInputRadioButton.AutoSize = True
        Me.SliderInputRadioButton.Location = New System.Drawing.Point(411, 527)
        Me.SliderInputRadioButton.Name = "SliderInputRadioButton"
        Me.SliderInputRadioButton.Size = New System.Drawing.Size(100, 21)
        Me.SliderInputRadioButton.TabIndex = 4
        Me.SliderInputRadioButton.TabStop = True
        Me.SliderInputRadioButton.Text = "Slider Input"
        Me.SliderInputRadioButton.UseVisualStyleBackColor = True
        '
        'XAxisTrackBar
        '
        Me.XAxisTrackBar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.XAxisTrackBar.Location = New System.Drawing.Point(107, 459)
        Me.XAxisTrackBar.Name = "XAxisTrackBar"
        Me.XAxisTrackBar.Size = New System.Drawing.Size(286, 56)
        Me.XAxisTrackBar.TabIndex = 5
        Me.XAxisTrackBar.TickFrequency = 250
        Me.XAxisTrackBar.Value = 5
        '
        'YAxisTrackBar
        '
        Me.YAxisTrackBar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.YAxisTrackBar.Location = New System.Drawing.Point(107, 521)
        Me.YAxisTrackBar.Name = "YAxisTrackBar"
        Me.YAxisTrackBar.Size = New System.Drawing.Size(286, 56)
        Me.YAxisTrackBar.TabIndex = 6
        Me.YAxisTrackBar.Value = 5
        '
        'XAxisSliderLabel
        '
        Me.XAxisSliderLabel.AutoSize = True
        Me.XAxisSliderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XAxisSliderLabel.Location = New System.Drawing.Point(32, 472)
        Me.XAxisSliderLabel.Name = "XAxisSliderLabel"
        Me.XAxisSliderLabel.Size = New System.Drawing.Size(69, 25)
        Me.XAxisSliderLabel.TabIndex = 7
        Me.XAxisSliderLabel.Text = "X Axis"
        '
        'YAxisSliderLabel
        '
        Me.YAxisSliderLabel.AutoSize = True
        Me.YAxisSliderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YAxisSliderLabel.Location = New System.Drawing.Point(32, 523)
        Me.YAxisSliderLabel.Name = "YAxisSliderLabel"
        Me.YAxisSliderLabel.Size = New System.Drawing.Size(68, 25)
        Me.YAxisSliderLabel.TabIndex = 8
        Me.YAxisSliderLabel.Text = "Y Axis"
        '
        'EtchASketchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 579)
        Me.Controls.Add(Me.YAxisSliderLabel)
        Me.Controls.Add(Me.XAxisSliderLabel)
        Me.Controls.Add(Me.YAxisTrackBar)
        Me.Controls.Add(Me.XAxisTrackBar)
        Me.Controls.Add(Me.SliderInputRadioButton)
        Me.Controls.Add(Me.SerialInpurRadioButton)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Controls.Add(Me.EraseButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Name = "EtchASketchForm"
        Me.Text = "Etch-A-Sketch"
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XAxisTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YAxisTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QuitButton As Button
    Friend WithEvents EraseButton As Button
    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents SerialInpurRadioButton As RadioButton
    Friend WithEvents SliderInputRadioButton As RadioButton
    Friend WithEvents XAxisTrackBar As TrackBar
    Friend WithEvents YAxisTrackBar As TrackBar
    Friend WithEvents XAxisSliderLabel As Label
    Friend WithEvents YAxisSliderLabel As Label
End Class
