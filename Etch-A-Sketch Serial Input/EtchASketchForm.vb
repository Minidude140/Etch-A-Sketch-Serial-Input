'Zachary Christensen
'RCET Advanced Programming
'10/15/24
'Serial Input Etch-A-Sketch 
'https://github.com/Minidude140/Etch-A-Sketch-Serial-Input
'Reused Code From: https://github.com/Minidude140/Etch-A-Sketch.git

'TODO
'[*]Add Tool Strip For Color Change and Pen Size
'[]Add Menu Strip and about form
'[*]When Serial Input is Selected Prompt user for Com input
'[*]Input Serial Data and Draw with it
'[*]Test Com for QY Board when Com is Selected

Imports System.Threading

Public Class EtchASketchForm
    Dim backGroundColor As Color
    Dim foregroundColor As Color
    Dim PenSize As Integer
    Dim xValue As Integer
    Dim yValue As Integer
    Dim oldXValue As Integer
    Dim oldYValue As Integer

    '*******************Custom Methods*****************************
    ''' <summary>
    ''' Sets the Default Colors and clears picture box
    ''' </summary>
    Sub SetDefaults()
        'Change pen color to black
        Me.foregroundColor = Color.Black
        'Change background color to "Blanched Almond"
        Me.backGroundColor = Color.BlanchedAlmond
        ChangeColor(backGroundColor, False)
        'Set default pen size
        Me.PenSize = 2
        'Rescale old Value X and Y to Screen size (from Slider input)
        DrawFromValue(XAxisTrackBar.Value, YAxisTrackBar.Value, XAxisTrackBar.Maximum)
        'Erase the screen
        DrawingPictureBox.Refresh()
    End Sub

    ''' <summary>
    ''' Change Color of the pen by default.
    ''' Optional Change background color(set second parameter false)
    ''' </summary>
    ''' <param name="newColor"></param>
    ''' <param name="changePenColor"></param>
    Public Sub ChangeColor(newColor As Color, Optional changePenColor As Boolean = True)
        If changePenColor = True Then
            'change pen color
            Me.foregroundColor = newColor
        Else
            'change background color
            Me.backGroundColor = newColor
            DrawingPictureBox.BackColor = newColor
            DrawingPictureBox.Refresh()
            ' System.Threading.Thread.Sleep(1000)
        End If
    End Sub

    ''' <summary>
    ''' Shakes the Form up and down
    ''' </summary>
    Sub ShakeScreen()
        'Define the Distance to Shake
        Dim offset As Integer = 50
        'Shake Back and Forth 10 times
        For i = 1 To 10
            'Shake in Opposite Direction
            offset = offset * -1
            Me.Top += offset
            'Wait 100mS Before Next Shake
            System.Threading.Thread.Sleep(100)
        Next
    End Sub

    ''' <summary>
    ''' Draws line from given fist point(x1,y1) to second point(x2,y2)
    ''' </summary>
    ''' <param name="x1%"></param>
    ''' <param name="y1%"></param>
    ''' <param name="x2%"></param>
    ''' <param name="y2%"></param>
    Sub DrawLine(x1%, y1%, x2%, y2%) 'Denotation of % declares an integer
        'initialize graphics object and set drawing surface to picture box
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        'initialize pen as color black
        Dim pen As New Pen(Me.foregroundColor, Me.PenSize)
        'draws a line from given co-ordinates (x,y) to (x,y); (0,0) in upper left hand corner
        g.DrawLine(pen, x1, y1, x2, y2)
        'dispose of the pen and graphics object to clear memory
        pen.Dispose()
        g.Dispose()
    End Sub

    ''' <summary>
    ''' Scale Input to Picture box from Given Max Input and Draw Line From Old Point to Given New Point
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    Sub DrawFromValue(x As Integer, y As Integer, maxInput As Integer, Optional draw As Boolean = True)
        'Scale Input Value to Picture Box Height and Width
        x = (DrawingPictureBox.Width / maxInput) * x
        y = (DrawingPictureBox.Height / maxInput) * y
        If draw = True Then
            'Draw Line From Old Position to Current Position
            DrawLine(oldXValue, oldYValue, x, y)
        End If
        'Store Current Position as Old Position
        oldXValue = x
            oldYValue = y
    End Sub

    ''' <summary>
    ''' Opens Serial Port selected in the combo box and set 9600 Baud
    ''' </summary>
    Sub OpenComPort()
        'Set up port name and baud rate
        SerialPort1.PortName = ComSelectComboBox.SelectedItem
        SerialPort1.BaudRate = 9600
        'open serial port for data transfer
        SerialPort1.Open()
    End Sub

    ''' <summary>
    ''' Read Analog Input 1 and Return High MSB Byte
    ''' </summary>
    Function Qy_AnalogReadA1() As Integer
        'command to QY board to read analog data
        Dim command(0) As Byte
        command(0) = &B1010001
        SerialPort1.Write(command, 0, 1)
        'Wait for Response
        Thread.Sleep(5)
        'create an array of bytes with the length of input data
        Dim data(SerialPort1.BytesToRead) As Byte
        'Populate array with input data
        SerialPort1.Read(data, 0, SerialPort1.BytesToRead)
        'Return the first Byte (MSB) 
        Return data(0)
    End Function

    ''' <summary>
    ''' Read Analog Input 2 and Return High MSB Byte
    ''' </summary>
    Function Qy_AnalogReadA2() As Integer
        'command to QY board to read analog data
        Dim command(0) As Byte
        command(0) = &B1010010
        SerialPort1.Write(command, 0, 1)
        'Wait for Response
        Thread.Sleep(5)
        'create an array of bytes with the length of input data
        Dim data(SerialPort1.BytesToRead) As Byte
        'Populate array with input data
        SerialPort1.Read(data, 0, SerialPort1.BytesToRead)
        'Return the first Byte (MSB) 
        Return data(0)
    End Function

    ''' <summary>
    ''' Populates Combo Box With Available Com Ports
    ''' </summary>
    Sub GetComPorts()
        For Each portName In SerialPort1.GetPortNames
            'add available Com Ports to combo box
            ComSelectComboBox.Items.Add(portName)
        Next

    End Sub

    ''' <summary>
    ''' Get Settings from Com Return True if Qy@ identifier is found
    ''' </summary>
    ''' <returns></returns>
    Function GetQySettings() As Boolean
        'Boolean Used to Check if COM is a Qy@ Board
        Dim isQY As Boolean = False
        'command QY Board to output settings data
        Dim command(0) As Byte
        command(0) = &B11110000
        SerialPort1.Write(command, 0, 1)
        'Wait for Response
        Thread.Sleep(5)
        'create an array of bytes with the length of given bytes
        Dim data(SerialPort1.BytesToRead) As Byte
        'populates data with incoming port data starting at 0 bit and reading the full bytes
        SerialPort1.Read(data, 0, SerialPort1.BytesToRead)
        'loops through the data array and writes each item to console (converts to hex)
        If data.Length < 61 Then
            'do nothing
        ElseIf data(58) = 81 And data(59) = 121 And data(60) = 64 Then
            'COM Selected is a Qy@ Board
            isQY = True
        End If
        Return isQY
    End Function

    '********************Event Handlers******************************
    Private Sub EtchASketchForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
        'Start In Slider Input Mode
        SliderInputRadioButton.Checked = True
        'Fill Combo Box with Port Names
        GetComPorts()
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    Private Sub EraseButton_Click(sender As Object, e As EventArgs) Handles EraseButton.Click,
                                                                            EraseMenuStrip.Click
        'Erase the current drawings
        DrawingPictureBox.Refresh()
        'Shake the screen up and down
        ShakeScreen()
        'Set Control to Focus on Slider X
        XAxisTrackBar.Focus()
    End Sub

    Private Sub XAxisTrackBar_ValueChanged(sender As Object, e As EventArgs) Handles XAxisTrackBar.ValueChanged
        'Save Current Slider Positions
        xValue = XAxisTrackBar.Value
        yValue = YAxisTrackBar.Value
        'Draw Line To New Points
        DrawFromValue(xValue, yValue, 255)
    End Sub

    Private Sub YAxisTrackBar_ValueChanged(sender As Object, e As EventArgs) Handles YAxisTrackBar.ValueChanged
        'Save Current Slider Positions
        xValue = XAxisTrackBar.Value
        yValue = YAxisTrackBar.Value
        'Draw Line To New Points
        DrawFromValue(xValue, yValue, 255)
    End Sub

    Private Sub SliderInputRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SliderInputRadioButton.CheckedChanged
        'only preform this when slider input button is checked
        If SliderInputRadioButton.Checked = True Then
            'Disable Com Port Timer
            SerialInputTimer.Enabled = False
            'Close Com Port
            SerialPort1.Close()
            'Enable TrackBar Input Sliders
            XAxisTrackBar.Enabled = True
            YAxisTrackBar.Enabled = True
        End If
    End Sub

    Private Sub SerialInputRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SerialInputRadioButton.CheckedChanged
        'Only Preform This when serial input button is checked
        If SerialInputRadioButton.Checked = True Then
            'Disable TrackBar Input Sliders
            XAxisTrackBar.Enabled = False
            YAxisTrackBar.Enabled = False
            Try
                'Open Com Port
                OpenComPort()
                'Enable Com Port Timer
                SerialInputTimer.Enabled = True
                'Reset Cursor to Current Analog input
                oldXValue = Qy_AnalogReadA1()
                oldYValue = Qy_AnalogReadA2()
                'Rescale Old value X and Y to Screen Size (from analog input)
                DrawFromValue(oldXValue, oldYValue, 250, False)
            Catch
                'Com not available Prompt User
                MsgBox("Please Select a COM Port")
                'Reset to SLider mode
                SerialInputRadioButton.Checked = False
                SliderInputRadioButton.Checked = True
            End Try
        End If
    End Sub

    Private Sub SerialInputTimer_Tick(sender As Object, e As EventArgs) Handles SerialInputTimer.Tick
        'Read Com Input Here
        xValue = Qy_AnalogReadA1()
        yValue = Qy_AnalogReadA2()
        'Draw Line From New Input
        DrawFromValue(xValue, yValue, 250)
    End Sub

    Private Sub DrawingPictureBox_SizeChanged(sender As Object, e As EventArgs) Handles DrawingPictureBox.SizeChanged
        'Erase the current drawings
        DrawingPictureBox.Refresh()
        If SliderInputRadioButton.Checked = True Then
            'Rescale old Value X and Y to Screen size (from Slider input)
            DrawFromValue(XAxisTrackBar.Value, YAxisTrackBar.Value, XAxisTrackBar.Maximum)
        ElseIf SerialInputRadioButton.Checked = True Then
            'Rescale Old value X and Y to Screen Size (from analog input)
            DrawFromValue(Qy_AnalogReadA1(), Qy_AnalogReadA2, 250)
        End If
    End Sub

    Private Sub ComSelectComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComSelectComboBox.SelectedIndexChanged
        If ComSelectComboBox.SelectedIndex = -1 Then
        Else
            Try
                OpenComPort()
                If GetQySettings() = True Then
                    MsgBox("Selected COM Port is a QY@ Board")
                    SerialInputRadioButton.Enabled = True
                Else
                    MsgBox("Selected COM Port is not a QY@ Board")
                End If
            Catch ex As Exception
                MsgBox("Sorry We Could Not Connect to Selected COM")
                'ComSelectComboBox.SelectedIndex = -1
                SerialInputRadioButton.Enabled = False
            End Try
            SerialPort1.Close()
        End If
    End Sub

    Private Sub ToolStripChangePenSizeButton_Click(sender As Object, e As EventArgs) Handles ToolStripChangePenSizeButton.Click,
                                                                                             ChangePenSizeMenuStrip.Click
        If PenSize < 30 Then
            PenSize = PenSize * 2
        Else
            PenSize = 2
        End If
    End Sub

    Private Sub ToolStripChangePenColorButton_Click(sender As Object, e As EventArgs) Handles ToolStripChangePenColorButton.Click,
                                                                                              ChangePenColorMenuStrip.Click
        ColorDialog.ShowDialog()
        ChangeColor(ColorDialog.Color)
    End Sub

    Private Sub ToolStripChangeBackColorButton_Click(sender As Object, e As EventArgs) Handles ToolStripChangeBackColorButton.Click,
                                                                                               ChangeBackGroundColorMenuStrip.Click
        ColorDialog.ShowDialog()
        ChangeColor(ColorDialog.Color, False)
    End Sub

    Private Sub ToolStripResetDefaultsButton_Click(sender As Object, e As EventArgs) Handles ToolStripResetDefaultsButton.Click,
                                                                                             ResetDefaultsMenuStrip.Click
        SetDefaults()
    End Sub

    Private Sub AboutMenuStrip_Click(sender As Object, e As EventArgs) Handles AboutMenuStrip.Click
        AboutForm.Show()
    End Sub
End Class
