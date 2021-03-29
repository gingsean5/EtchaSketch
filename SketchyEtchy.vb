'Sean Gingerich
'RCET0265
'Spring 2021
'Etch a Sketch
'https://github.com/gingsean5/EtchaSketch.git


Option Explicit On
Option Strict On
Imports System.Threading.Thread
Imports System.Math
Public Class SketchyEtchy

    'Global fields for graphics object
    Dim g As Graphics 'instantiated globally, associated with PictureBox control on me.Load event
    Dim mainPen As New Pen(Color.Black)

    'point tracking
    Dim lastPoint As Point




    Sub DrawCircle()
        'constructor for the graphics object
        Dim g As Graphics = DisplayPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Red)
        g.DrawEllipse(pen, 0, 0, 100, 100)
        pen.Dispose()
        g.Dispose()
    End Sub


    Sub MouseDraw(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, penColor As Color)
        'constructor for the graphics object
        Dim g As Graphics = DisplayPictureBox.CreateGraphics
        Dim pen As New Pen(penColor)
        'actually draw the line
        g.DrawLine(pen, x1, y1, x2, y2)
        'free up resources
        pen.Dispose()
        g.Dispose()
    End Sub

    Private Sub DisplayPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DisplayPictureBox.MouseDown, DisplayPictureBox.MouseMove
        Static oldX As Integer
        Static oldY As Integer



        Me.Text = $"({e.X},{e.Y}) Button: {e.Button.ToString} Color: {Me.mainPen.Color.ToString}"
        Select Case e.Button.ToString
            Case "Left"
                MouseDraw(oldX, oldY, e.X, e.Y, Me.mainPen.Color)
            Case "Right"

            Case "Middle"
                MiddleColorDialog.ShowDialog()

                Me.mainPen.Color = MiddleColorDialog.Color
            Case "None"

            Case Else
                MsgBox("It Got Weird")
        End Select
        oldX = e.X
        oldY = e.Y
    End Sub

    Function PenColorFunc() As Color
        Static ColorSelect As Color
        MiddleColorDialog.ShowDialog()
        ColorSelect = MiddleColorDialog.Color
        Return ColorSelect
    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click, ClearTopMenu.Click
        Shake()
        DisplayPictureBox.Refresh()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitTopMenu.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub



    Sub Shake()
        Dim moveAmount = 50

        For i = 1 To 15
            Me.Top += moveAmount
            Me.Left += moveAmount
            Sleep(100)
            moveAmount *= -1
        Next

    End Sub

    Private Sub SketchyEtchy_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.g = Me.DisplayPictureBox.CreateGraphics
    End Sub

    Private Sub ColorSelectButton_Click(sender As Object, e As EventArgs) Handles ColorSelectButton.Click, SelectColorToolStripMenuItem.Click, SelectColorTopMenu.Click
        MiddleColorDialog.ShowDialog()
        Me.mainPen.Color = MiddleColorDialog.Color
    End Sub

    Sub DrawWave()
        Dim wave As Graphics = DisplayPictureBox.CreateGraphics
        Dim _start As Point
        Dim _end As Point

        'offset amount
        Dim yOffset As Single = CSng(DisplayPictureBox.Height / 2)
        wave.TranslateTransform(0, yOffset)

        'Scale 
        'This will be the width of the scaled graphics object 
        Dim xMax As Single = 360
        Dim xScale As Single = CSng(DisplayPictureBox.Width / xMax)
        'This will be the height of the scaled graphics object 
        Dim yMax As Single = 100
        'half the height in pixels is to 100 units
        '100 up, 100 down
        Dim yScale As Single = CSng(((DisplayPictureBox.Height) / 2) / yMax)
        wave.ScaleTransform(xScale, yScale) 'apply scale

        mainPen.Color = Color.Red

        'plot Sin
        _start.X = 0
        _start.Y = 0
        'Vi = Vp * sin(360 * f * t + theta) + DC
        For i = 0 To CInt(xMax)
            _end.X = i
            _end.Y = CInt(yMax * Sin((PI / 180) * _end.X)) * -1
            wave.DrawLine(mainPen, _start, _end)
            _start.X = _end.X
            _start.Y = _end.Y
        Next

        mainPen.Color = Color.Green
        'plot Cos
        _start.X = 0
        _start.Y = 0
        For i = 0 To CInt(xMax)
            _end.X = i
            _end.Y = CInt(yMax * Cos((PI / 180) * _end.X)) * -1
            wave.DrawLine(mainPen, _start, _end)
            _start.X = _end.X
            _start.Y = _end.Y
        Next
        mainPen.Color = Color.Blue
        'plot Tan
        _start.X = 0
        _start.Y = 0
        For i = 0 To CInt(xMax)
            _end.X = i
            Try
                _end.Y = CInt(yMax * Tan((PI / 180) * _end.X)) * -1
            Catch

            End Try

            wave.DrawLine(mainPen, _start, _end)

            _start.X = _end.X
            _start.Y = _end.Y
        Next

        wave.Dispose()
    End Sub
    Private Sub WaveformsButton_Click(sender As Object, e As EventArgs) Handles WaveformsButton.Click, DrawWaveformsToolStripMenuItem.Click, DrawWaveformsTopMenu.Click
        DrawWave()
    End Sub

    Private Sub AboutTopMenu_Click(sender As Object, e As EventArgs) Handles AboutTopMenu.Click
        MsgBox("This was created by Sean Gingerich with the help of his instructor Tim who is a very nice guy that gave him a good grade")
    End Sub
End Class


