'Zachary Christensen
'RCET Advanced Programming
'10/15/24
'Serial Input Etch-A-Sketch 
'https://github.com/Minidude140/Etch-A-Sketch-Serial-Input
'Reused Code From: https://github.com/Minidude140/Etch-A-Sketch.git



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
        'Erase the screen
        DrawingPictureBox.Refresh()
        'Change pen color to black
        Me.foregroundColor = Color.Black
        'Change background color to "Blanched Almond"
        Me.backGroundColor = Color.BlanchedAlmond
        ChangeColor(backGroundColor, False)
        'Set default pen size
        Me.PenSize = 2
        'Set Drawing Cursor to Center Screen
        oldXValue = DrawingPictureBox.Width / 2
        oldYValue = DrawingPictureBox.Height / 2
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
            'penColor.set = newColor
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
    Sub DrawFromValue(x As Integer, y As Integer, maxInput As Integer)
        'Scale Input Value to Picture Box Height and Width
        x = (DrawingPictureBox.Width / maxInput) * x
        y = (DrawingPictureBox.Height / maxInput) * y
        'Draw Line From Old Position to Current Position
        DrawLine(oldXValue, oldYValue, x, y)
        'Store Current Position as Old Position
        oldXValue = x
        oldYValue = y
    End Sub

    '********************Event Handlers******************************
    Private Sub EtchASketchForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    Private Sub EraseButton_Click(sender As Object, e As EventArgs) Handles EraseButton.Click
        'Erase the current drawings
        DrawingPictureBox.Refresh()
        'Shake the screen up and down
        ShakeScreen()
    End Sub

    Private Sub XAxisTrackBar_ValueChanged(sender As Object, e As EventArgs) Handles XAxisTrackBar.ValueChanged
        'Save Current Slider Positions
        xValue = XAxisTrackBar.Value
        yValue = YAxisTrackBar.Value
        'Draw Line To New Points
        DrawFromValue(xValue, yValue, 10)
    End Sub

    Private Sub YAxisTrackBar_ValueChanged(sender As Object, e As EventArgs) Handles YAxisTrackBar.ValueChanged
        'Save Current Slider Positions
        xValue = XAxisTrackBar.Value
        yValue = YAxisTrackBar.Value
        'Draw Line To New Points
        DrawFromValue(xValue, yValue, 10)
    End Sub
End Class
