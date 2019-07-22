Option Explicit On 

Imports System.Diagnostics
Imports System.Text.RegularExpressions

Public Class LameShell
    Private _lameProcess As Process
    Private _lameThread As System.Threading.Thread
    Private _percentDone As Integer
    Private _isRunning As Boolean = False
    Private _startInfo As New ProcessStartInfo

    'The Regular Expression to get the info from Lame.exe StandardError on a line to line basis
    'If suddenly this class stops working with a new version of Lame, thats what is to change
    'this one is tested with 3.94 beta 1 with following data per line:
    'Frame/MaxFrame (PercentDone%) |  CPU time/estim | REAL time/estim | play/CPU |    ETA 

    Private Shared _regLine As Regex = New Regex( _
                "(\d+)/(\d+)\D+(\d+)\D+([\d:]+)\D+([\d:]+)\D+([\d:]+)\D+([\d:]+)\D+([\d\.]+)\D+([\d:]+)", _
                RegexOptions.IgnoreCase _
                Or RegexOptions.CultureInvariant _
                Or RegexOptions.IgnorePatternWhitespace _
                Or RegexOptions.Compiled _
                )


    'vars for commandline
    Private _inFile As String
    Private _outFile As String
    Private _options As String

    'Events
    Public Event Done()
    Public Event Progress(ByRef Progress As LameProgress)
    Public Event IgnoredLine(ByVal Line As String)
    Public Event Canceled()

    Public Sub New()
        DefStartInfo()
        _startInfo.WorkingDirectory = Application.StartupPath
    End Sub
    Public Sub New(ByVal InFile As String, Optional ByVal OutFile As String = "", Optional ByVal Options As String = "", Optional ByVal LamePath As String = Nothing)
        DefStartInfo()
        If LamePath = Nothing Then
            _startInfo.WorkingDirectory = Application.StartupPath
        End If
        _inFile = InFile
        _outFile = OutFile
        _options = Options
    End Sub
    Private Sub DefStartInfo()
        'need this stuff to hide the window and redirect the output
        _startInfo.FileName = "lame.exe"
        _startInfo.UseShellExecute = False
        _startInfo.RedirectStandardOutput = True
        _startInfo.RedirectStandardError = True
        _startInfo.CreateNoWindow = True
    End Sub
    Public Property InFile() As String
        Get
            Return _inFile
        End Get
        Set(ByVal Value As String)
            _inFile = Value
        End Set
    End Property
    Public Property OutFile() As String
        Get
            Return _outFile
        End Get
        Set(ByVal Value As String)
            _outFile = Value
        End Set
    End Property
    Public Property Options() As String
        Get
            Return _options
        End Get
        Set(ByVal Value As String)
            _options = Value
        End Set
    End Property
    Public Property LamePath() As String
        Get
            Return _startInfo.WorkingDirectory
        End Get
        Set(ByVal Value As String)
            _startInfo.WorkingDirectory = Value
        End Set
    End Property
    Private Sub Reset()
        Dim arguments As String = Nothing

        _percentDone = 0
        _lameProcess = New Process

        If _options <> "" Then
            arguments = _options & " "
        End If
        arguments &= """" & _inFile & """ "
        If _outFile <> "" Then
            arguments &= """" & _outFile & """"
        End If

        _startInfo.Arguments = arguments

        _lameProcess.StartInfo = _startInfo
    End Sub
    Public Function Start() As Boolean

        If _isRunning Or _inFile = "-" Or _outFile = "-" Then Return False
        _isRunning = True

        Reset()
        Try
            _lameThread = New System.Threading.Thread(AddressOf LameReader)
            _lameThread.IsBackground = True
            _lameThread.Name = "LameReader"
            _lameThread.Start()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Private Sub LameReader()
        Dim m As Match
        Dim oneLine As String
        Dim sFile As String = LastWavMade
        Try
            _lameProcess.Start()

            oneLine = _lameProcess.StandardError.ReadLine()
            While Not oneLine Is Nothing
                m = _regLine.Match(oneLine)
                If m.Success Then
                    'a line is found thats a lame.exe progress report
                    _percentDone = CType(m.Groups.Item(3).Value, Integer)
                    RaiseEvent Progress(New LameProgress(m))
                Else
                    ' line isnt interesting
                    RaiseEvent IgnoredLine(oneLine)
                End If
                'this call is blocking... thats why we are using a thread
                oneLine = _lameProcess.StandardError.ReadLine()
                ' TempCarrier &= vbCrLf & oneLine
            End While
            'whatever happened .. when we get here we dont need the process anymore
            _lameProcess.Close()
            _lameProcess = Nothing

            If _percentDone = 100 Then
                'if we get here its safe to assume the file written by lame.exe is valid
                RaiseEvent Done()
                'Kill the file
                If FileExists(sFile) Then
                    System.IO.File.Delete(sFile)
                End If

            Else
                'we get here if anything went wrong
                RaiseEvent Canceled()
            End If

                'Catch tex As Threading.ThreadAbortException
                'hrm .. this isnt thrown when the application exits, make sure to call Cancel()

        Catch ex As Exception
            'shouldnt happen
            If Not _lameProcess Is Nothing Then
                _lameProcess.Close()
                _lameProcess = Nothing
            End If
            frmRecord.DisableRec()

            MsgBox(ex.Message & vbNewLine & "FreeSCAN is unable to locate lame.exe. Recording has been disabled. Please make sure it is in the following path:" & vbNewLine & _startInfo.WorkingDirectory)
        Finally
            _isRunning = False
        End Try

    End Sub
    Public Sub Cancel()
        Try
            If Not _lameProcess Is Nothing Then
                _lameProcess.Kill()
            End If
        Catch ex As Exception
            'could happen in rare instances while already cancelling
            'nothing to do here
        End Try
    End Sub

End Class
Public Class LameProgress
    Private _m As Match

    Public ReadOnly Property FrameCurrent() As Integer
        Get
            Return CType(_m.Groups.Item(1).Value, Integer)
        End Get
    End Property
    Public ReadOnly Property FrameMax() As Integer
        Get
            Return CType(_m.Groups.Item(2).Value, Integer)
        End Get
    End Property
    Public ReadOnly Property PercentDone() As Integer
        Get
            Return CType(_m.Groups.Item(3).Value, Integer)
        End Get

    End Property
    Public ReadOnly Property CPUTime() As String
        Get
            Return _m.Groups.Item(4).Value()
        End Get
    End Property
    Public ReadOnly Property CPUEstimate() As String
        Get
            Return _m.Groups.Item(5).Value()
        End Get
    End Property
    Public ReadOnly Property REALTime() As String
        Get
            Return _m.Groups.Item(6).Value()
        End Get
    End Property
    Public ReadOnly Property REALEstimate() As String
        Get
            Return _m.Groups.Item(7).Value()
        End Get
    End Property
    Public ReadOnly Property PlayCPU() As Single
        Get
            Return CType(_m.Groups.Item(8).Value, Single)
        End Get
    End Property
    Public ReadOnly Property ETA() As String
        Get
            Return _m.Groups.Item(9).Value()
        End Get
    End Property

    Public Sub New(ByVal m As Match)
        _m = m
    End Sub
End Class