Option Strict Off
Option Explicit On
Module ScreenSize
	
	Private Structure RECT
		'UPGRADE_NOTE: left was upgraded to left_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim left_Renamed As Integer
		Dim tOp As Integer
		'UPGRADE_NOTE: Right was upgraded to Right_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Right_Renamed As Integer
		Dim Bottom As Integer
	End Structure
	
	Private Declare Function MoveWindow Lib "user32" (ByVal hwnd As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal bRepaint As Short) As Integer
	
	Private Const SPI_GETWORKAREA As Short = 48
	
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByRef lpvParam As Integer, ByVal fuWinIni As Short) As Integer
	
    '	Sub GetWorkArea(ByRef waLeft As Integer, ByRef waTop As Integer, ByRef waWidth As Integer, ByRef waHeight As Short)
    ' Dim rcWork As RECT'''''

    '	SystemParametersInfo(SPI_GETWORKAREA, 0, rcWork, 0)
    '	With rcWork
    '		waLeft = .left_Renamed
    '		waTop = .tOp
    '	waWidth = (.Right_Renamed - .left_Renamed)
    '		waHeight = (.Bottom - .tOp)
    '	End With
    'End Sub
End Module