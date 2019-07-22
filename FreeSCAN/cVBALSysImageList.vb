Option Strict Off
Option Explicit On
Friend Class cVBALSysImageList
	
	
	' =========================================================================
	' vbAccelerator Image List Control Demonstrator
	' Copyright © 1998 Steve McMahon (steve@dogma.demon.co.uk)
	'
	' Implements an Image List control in VB using COMCTL32.DLL
	'
	' Visit vbAccelerator at www.dogma.demon.co.uk
	' =========================================================================
	
	' -----------
	' API
	' -----------
	' General:
	Private Declare Function GetWindowWord Lib "user32" (ByVal hwnd As Integer, ByVal nIndex As Short) As Integer
	Private Const GWW_HINSTANCE As Short = (-6)
	
	' GDI object functions:
	Private Declare Function SelectObject Lib "gdi32" (ByVal hdc As Integer, ByVal hObject As Short) As Integer
	Private Declare Function DeleteObject Lib "gdi32" (ByVal hObject As Short) As Integer
	Private Declare Function DestroyCursor Lib "user32" (ByVal hCursor As Short) As Integer
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Private Declare Function GetObjectAPI Lib "gdi32" Alias "GetObjectA" (ByVal hObject As Integer, ByVal nCount As Integer, ByRef lpObject As Integer) As Integer
	Private Declare Function GetDC Lib "user32" (ByVal hwnd As Short) As Integer
	Private Declare Function DeleteDC Lib "gdi32" (ByVal hdc As Short) As Integer
	Private Declare Function ReleaseDC Lib "user32" (ByVal hwnd As Integer, ByVal hdc As Short) As Integer
	Private Declare Function CreateCompatibleDC Lib "gdi32" (ByVal hdc As Short) As Integer
	Private Declare Function CreateCompatibleBitmap Lib "gdi32" (ByVal hdc As Integer, ByVal nWidth As Integer, ByVal nHeight As Short) As Integer
	Private Declare Function GetDeviceCaps Lib "gdi32" (ByVal hdc As Integer, ByVal nIndex As Short) As Integer
	Private Const BITSPIXEL As Short = 12
	Private Const LOGPIXELSX As Short = 88 '  Logical pixels/inch in X
	Private Const LOGPIXELSY As Short = 90 '  Logical pixels/inch in Y
	' System metrics:
	Private Declare Function GetSystemMetrics Lib "user32" (ByVal nIndex As Short) As Integer
	Private Const SM_CXICON As Short = 11
	Private Const SM_CYICON As Short = 12
	Private Const SM_CXFRAME As Short = 32
	Private Const SM_CYCAPTION As Short = 4
	Private Const SM_CYFRAME As Short = 33
	Private Const SM_CYBORDER As Short = 6
	Private Const SM_CXBORDER As Short = 5
	
	' Region paint and fill functions:
	Private Declare Function PaintRgn Lib "gdi32" (ByVal hdc As Integer, ByVal hRgn As Short) As Integer
	Private Declare Function ExtFloodFill Lib "gdi32" (ByVal hdc As Integer, ByVal x As Integer, ByVal y As Integer, ByVal crColor As Integer, ByVal wFillType As Short) As Integer
	Private Const FLOODFILLBORDER As Short = 0
	Private Const FLOODFILLSURFACE As Short = 1
	Private Declare Function GetPixel Lib "gdi32" (ByVal hdc As Integer, ByVal x As Integer, ByVal y As Short) As Integer
	
	' Pen functions:
	Private Declare Function CreatePen Lib "gdi32" (ByVal nPenStyle As Integer, ByVal nWidth As Integer, ByVal crColor As Short) As Integer
	Private Const PS_DASH As Short = 1
	Private Const PS_DASHDOT As Short = 3
	Private Const PS_DASHDOTDOT As Short = 4
	Private Const PS_DOT As Short = 2
	Private Const PS_SOLID As Short = 0
	Private Const PS_NULL As Short = 5
	
	' Brush functions:
	Private Declare Function CreateSolidBrush Lib "gdi32" (ByVal crColor As Short) As Integer
	Private Declare Function CreatePatternBrush Lib "gdi32" (ByVal hBitmap As Short) As Integer
	
	' Line functions:
	Private Declare Function LineTo Lib "gdi32" (ByVal hdc As Integer, ByVal x As Integer, ByVal y As Short) As Integer
	Private Structure POINTAPI
		Dim x As Integer
		Dim y As Integer
	End Structure
	'UPGRADE_WARNING: Structure POINTAPI may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function MoveToEx Lib "gdi32" (ByVal hdc As Integer, ByVal x As Integer, ByVal y As Integer, ByRef lpPoint As POINTAPI) As Integer
	
	' Colour functions:
	Private Declare Function SetTextColor Lib "gdi32" (ByVal hdc As Integer, ByVal crColor As Short) As Integer
	Private Declare Function SetBkColor Lib "gdi32" (ByVal hdc As Integer, ByVal crColor As Short) As Integer
	Private Declare Function SetBkMode Lib "gdi32" (ByVal hdc As Integer, ByVal nBkMode As Short) As Integer
	Private Const OPAQUE As Short = 2
	Private Const TRANSPARENT As Short = 1
	Private Declare Function GetSysColor Lib "user32" (ByVal nIndex As Short) As Integer
	Private Const COLOR_ACTIVEBORDER As Short = 10
	Private Const COLOR_ACTIVECAPTION As Short = 2
	Private Const COLOR_ADJ_MAX As Short = 100
	Private Const COLOR_ADJ_MIN As Short = -100
	Private Const COLOR_APPWORKSPACE As Short = 12
	Private Const COLOR_BACKGROUND As Short = 1
	Private Const COLOR_BTNFACE As Short = 15
	Private Const COLOR_BTNHIGHLIGHT As Short = 20
	Private Const COLOR_BTNSHADOW As Short = 16
	Private Const COLOR_BTNTEXT As Short = 18
	Private Const COLOR_CAPTIONTEXT As Short = 9
	Private Const COLOR_GRAYTEXT As Short = 17
	Private Const COLOR_HIGHLIGHT As Short = 13
	Private Const COLOR_HIGHLIGHTTEXT As Short = 14
	Private Const COLOR_INACTIVEBORDER As Short = 11
	Private Const COLOR_INACTIVECAPTION As Short = 3
	Private Const COLOR_INACTIVECAPTIONTEXT As Short = 19
	Private Const COLOR_MENU As Short = 4
	Private Const COLOR_MENUTEXT As Short = 7
	Private Const COLOR_SCROLLBAR As Short = 0
	Private Const COLOR_WINDOW As Short = 5
	Private Const COLOR_WINDOWFRAME As Short = 6
	Private Const COLOR_WINDOWTEXT As Short = 8
	Private Const COLORONCOLOR As Short = 3
	
	' Shell Extract icon functions:
	Private Declare Function FindExecutable Lib "shell32.dll"  Alias "FindExecutableA"(ByVal lpFile As String, ByVal lpDirectory As String, ByVal lpResult As String) As Integer
	Private Declare Function ExtractIcon Lib "shell32.dll"  Alias "ExtractIconA"(ByVal hInst As Integer, ByVal lpszExeFileName As String, ByVal nIconIndex As Short) As Integer
	
	' Icon functions:
	Private Declare Function DrawIcon Lib "user32" (ByVal hdc As Integer, ByVal x As Integer, ByVal y As Integer, ByVal hIcon As Short) As Integer
	Private Declare Function DestroyIcon Lib "user32" (ByVal hIcon As Short) As Integer
	Private Declare Function DrawIconEx Lib "user32" (ByVal hdc As Integer, ByVal xLeft As Integer, ByVal yTop As Integer, ByVal hIcon As Integer, ByVal cxWidth As Integer, ByVal cyWidth As Integer, ByVal istepIfAniCur As Integer, ByVal hbrFlickerFreeDraw As Integer, ByVal diFlags As Short) As Boolean
	Private Declare Function LoadImage Lib "user32"  Alias "LoadImageA"(ByVal hInst As Integer, ByVal lpsz As String, ByVal un1 As Integer, ByVal n1 As Integer, ByVal n2 As Integer, ByVal un2 As Short) As Integer
	Private Declare Function LoadImageLong Lib "user32"  Alias "LoadImageA"(ByVal hInst As Integer, ByVal lpsz As Integer, ByVal un1 As Integer, ByVal n1 As Integer, ByVal n2 As Integer, ByVal un2 As Short) As Integer
	Private Const LR_LOADMAP3DCOLORS As Short = &H1000s
	Private Const LR_LOADFROMFILE As Short = &H10s
	Private Const LR_LOADTRANSPARENT As Short = &H20s
	Private Const LR_COPYRETURNORG As Short = &H4s
	
	' Blitting functions
	Private Declare Function BitBlt Lib "gdi32" (ByVal hDestDC As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hSrcDC As Integer, ByVal xSrc As Integer, ByVal ySrc As Integer, ByVal dwRop As Short) As Integer
	Private Const SRCAND As Integer = &H8800C6
	Private Const SRCCOPY As Integer = &HCC0020
	Private Const SRCERASE As Integer = &H440328
	Private Const SRCINVERT As Integer = &H660046
	Private Const SRCPAINT As Integer = &HEE0086
	Private Const BLACKNESS As Short = &H42s
	Private Const WHITENESS As Integer = &HFF0062
	Private Declare Function PatBlt Lib "gdi32" (ByVal hdc As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal dwRop As Short) As Integer
	Private Declare Function LoadBitmapBynum Lib "user32"  Alias "LoadBitmapA"(ByVal hInstance As Integer, ByVal lpBitmapName As Short) As Integer
	Private Structure BITMAP '14 bytes
		Dim bmType As Integer
		Dim bmWidth As Integer
		Dim bmHeight As Integer
		Dim bmWidthBytes As Integer
		Dim bmPlanes As Integer
		Dim bmBitsPixel As Integer
		Dim bmBits As Integer
	End Structure
	'UPGRADE_WARNING: Structure BITMAP may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function CreateBitmapIndirect Lib "gdi32" (ByRef lpBitmap As BITMAP) As Integer
	
	' Text functions:
	Private Structure RECT
		'UPGRADE_NOTE: left was upgraded to left_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim left_Renamed As Integer
		Dim tOp As Integer
		'UPGRADE_NOTE: Right was upgraded to Right_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Right_Renamed As Integer
		Dim Bottom As Integer
	End Structure
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function PtInRect Lib "user32" (ByRef lpRect As RECT, ByVal ptX As Integer, ByVal ptY As Short) As Integer
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function DrawText Lib "user32"  Alias "DrawTextA"(ByVal hdc As Integer, ByVal lpStr As String, ByVal nCount As Integer, ByRef lpRect As RECT, ByVal wFormat As Short) As Integer
	Private Const DT_BOTTOM As Integer = &H8
	Private Const DT_CENTER As Integer = &H1
	Private Const DT_LEFT As Integer = &H0
	Private Const DT_CALCRECT As Integer = &H400
	Private Const DT_WORDBREAK As Integer = &H10
	Private Const DT_VCENTER As Integer = &H4
	Private Const DT_TOP As Integer = &H0
	Private Const DT_TABSTOP As Integer = &H80
	Private Const DT_SINGLELINE As Integer = &H20
	Private Const DT_RIGHT As Integer = &H2
	Private Const DT_NOCLIP As Integer = &H100
	Private Const DT_INTERNAL As Integer = &H1000
	Private Const DT_EXTERNALLEADING As Integer = &H200
	Private Const DT_EXPANDTABS As Integer = &H40
	Private Const DT_CHARSTREAM As Short = 4
	Private Const DT_NOPREFIX As Integer = &H800
	Private Structure DRAWTEXTPARAMS
		Dim cbSize As Integer
		Dim iTabLength As Integer
		Dim iLeftMargin As Integer
		Dim iRightMargin As Integer
		Dim uiLengthDrawn As Integer
	End Structure
	'UPGRADE_WARNING: Structure DRAWTEXTPARAMS may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function DrawTextEx Lib "user32"  Alias "DrawTextExA"(ByVal hdc As Integer, ByVal lpsz As String, ByVal n As Integer, ByRef lpRect As RECT, ByVal un As Integer, ByRef lpDrawTextParams As DRAWTEXTPARAMS) As Integer
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function DrawTextExAsNull Lib "user32"  Alias "DrawTextExA"(ByVal hdc As Integer, ByVal lpsz As String, ByVal n As Integer, ByRef lpRect As RECT, ByVal un As Integer, ByVal lpDrawTextParams As Short) As Integer
	Private Const DT_EDITCONTROL As Integer = &H2000
	Private Const DT_PATH_ELLIPSIS As Integer = &H4000
	Private Const DT_END_ELLIPSIS As Integer = &H8000
	Private Const DT_MODIFYSTRING As Integer = &H10000
	Private Const DT_RTLREADING As Integer = &H20000
	Private Const DT_WORD_ELLIPSIS As Integer = &H40000
	
	Private Structure SIZEAPI
		Dim cX As Integer
		Dim cY As Integer
	End Structure
	'UPGRADE_WARNING: Structure SIZEAPI may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function GetTextExtentPoint32 Lib "gdi32"  Alias "GetTextExtentPoint32A"(ByVal hdc As Integer, ByVal lpsz As String, ByVal cbString As Integer, ByRef lpSize As SIZEAPI) As Integer
	Private Declare Function GetStockObject Lib "gdi32" (ByVal nIndex As Short) As Integer
	Private Const ANSI_FIXED_FONT As Short = 11
	Private Const ANSI_VAR_FONT As Short = 12
	Private Const SYSTEM_FONT As Short = 13
	Private Const DEFAULT_GUI_FONT As Short = 17 'win95 only
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function FillRect Lib "user32" (ByVal hdc As Integer, ByRef lpRect As RECT, ByVal hBrush As Short) As Integer
	Private Declare Function Rectangle Lib "gdi32" (ByVal hdc As Integer, ByVal X1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Short) As Integer
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function DrawEdge Lib "user32" (ByVal hdc As Integer, ByRef qrc As RECT, ByVal edge As Integer, ByVal grfFlags As Short) As Integer
	Private Const BF_LEFT As Short = 1
	Private Const BF_TOP As Short = 2
	Private Const BF_RIGHT As Short = 4
	Private Const BF_BOTTOM As Short = 8
	Private Const BF_RECT As Boolean = BF_LEFT Or BF_TOP Or BF_RIGHT Or BF_BOTTOM
	Private Const BF_MIDDLE As Short = 2048
	Private Const BDR_SUNKENINNER As Short = 8
	Private Const BDR_SUNKENOUTER As Short = 2
	Private Const BDR_RAISEDOUTER As Short = 1
	Private Const BDR_RAISEDINNER As Short = 4
	
	Private Declare Function ShowWindow Lib "user32" (ByVal hwnd As Integer, ByVal nCmdShow As Short) As Integer
	Private Const SW_SHOWNOACTIVATE As Short = 4
	
	' Scrolling and region functions:
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function ScrollDC Lib "user32" (ByVal hdc As Integer, ByVal dx As Integer, ByVal dy As Integer, ByRef lprcScroll As RECT, ByRef lprcClip As RECT, ByVal hrgnUpdate As Integer, ByRef lprcUpdate As RECT) As Integer
	Private Declare Function SetWindowRgn Lib "user32" (ByVal hwnd As Integer, ByVal hRgn As Integer, ByVal bRedraw As Short) As Integer
	Private Declare Function SelectClipRgn Lib "gdi32" (ByVal hdc As Integer, ByVal hRgn As Short) As Integer
	Private Declare Function CreateRectRgn Lib "gdi32" (ByVal X1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Short) As Integer
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function CreateRectRgnIndirect Lib "gdi32" (ByRef lpRect As RECT) As Integer
	'UPGRADE_WARNING: Structure POINTAPI may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function CreatePolyPolygonRgn Lib "gdi32" (ByRef lpPoint As POINTAPI, ByRef lpPolyCounts As Integer, ByVal nCount As Integer, ByVal nPolyFillMode As Short) As Integer
	'UPGRADE_WARNING: Structure POINTAPI may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
    Private Declare Function CreatePolygonRgn Lib "gdi32" (ByRef lpPoint As POINTAPI, ByVal nCount As Integer, ByVal nPolyFillMode As Short)
	Private Declare Function SaveDC Lib "gdi32" (ByVal hdc As Short) As Integer
	Private Declare Function RestoreDC Lib "gdi32" (ByVal hdc As Integer, ByVal hSavedDC As Short) As Integer
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Private Declare Function CreateDCAsNull Lib "gdi32" Alias "CreateDCA" (ByVal lpDriverName As String, ByRef lpDeviceName As String, ByRef lpOutput As String, ByRef lpInitData As String) As Integer
	
	Private Const LF_FACESIZE As Short = 32
	Private Structure LOGFONT
		Dim lfHeight As Integer
		Dim lfWidth As Integer
		Dim lfEscapement As Integer
		Dim lfOrientation As Integer
		Dim lfWeight As Integer
		Dim lfItalic As Byte
		Dim lfUnderline As Byte
		Dim lfStrikeOut As Byte
		Dim lfCharSet As Byte
		Dim lfOutPrecision As Byte
		Dim lfClipPrecision As Byte
		Dim lfQuality As Byte
		Dim lfPitchAndFamily As Byte
		<VBFixedArray(LF_FACESIZE)> Dim lfFaceName() As Byte
		
		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B4BFF9E0-8631-45CF-910E-62AB3970F27B"'
		Public Sub Initialize()
			ReDim lfFaceName(LF_FACESIZE)
		End Sub
	End Structure
	Private Const FW_NORMAL As Short = 400
	Private Const FW_BOLD As Short = 700
	Private Const FF_DONTCARE As Short = 0
	Private Const DEFAULT_QUALITY As Short = 0
	Private Const DEFAULT_PITCH As Short = 0
	Private Const DEFAULT_CHARSET As Short = 1
	'UPGRADE_WARNING: Structure LOGFONT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function CreateFontIndirect Lib "gdi32"  Alias "CreateFontIndirectA"(ByRef lpLogFont As LOGFONT) As Integer
	Private Declare Function MulDiv Lib "kernel32" (ByVal nNumber As Integer, ByVal nNumerator As Integer, ByVal nDenominator As Short) As Integer
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function DrawFocusRect Lib "user32" (ByVal hdc As Integer, ByRef lpRect As RECT) As Integer
	
	Private Declare Function DrawState Lib "user32"  Alias "DrawStateA"(ByVal hdc As Integer, ByVal hBrush As Integer, ByVal lpDrawStateProc As Integer, ByVal lParam As Integer, ByVal wParam As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cX As Integer, ByVal cY As Integer, ByVal fuFlags As Short) As Integer
	
	'/* Image type */
	Private Const DST_COMPLEX As Integer = &H0
	Private Const DST_TEXT As Integer = &H1
	Private Const DST_PREFIXTEXT As Integer = &H2
	Private Const DST_ICON As Integer = &H3
	Private Const DST_BITMAP As Integer = &H4
	
	' /* State type */
	Private Const DSS_NORMAL As Integer = &H0
	Private Const DSS_UNION As Integer = &H10 ' Dither
	Private Const DSS_DISABLED As Integer = &H20
	Private Const DSS_MONO As Integer = &H80 ' Draw in colour of brush specified in hBrush
	Private Const DSS_RIGHT As Integer = &H8000
	
	Private Declare Function OleTranslateColor Lib "olepro32.dll" (ByVal OLE_COLOR As Integer, ByVal HPALETTE As Integer, ByRef pccolorref As Short) As Integer
	Private Const CLR_INVALID As Short = -1
	
	' Shell Functions for SystemImageList
	Private Const MAX_PATH As Short = 260
	Private Structure SHFILEINFO
		Dim hIcon As Integer
		Dim iIcon As Integer
		Dim dwAttributes As Integer
		'UPGRADE_WARNING: Fixed-length string size must fit in the buffer. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="3C1E4426-0B80-443E-B943-0627CD55D48B"'
		<VBFixedString(MAX_PATH),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray,SizeConst:=MAX_PATH)> Public szDisplayName() As Char
		'UPGRADE_WARNING: Fixed-length string size must fit in the buffer. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="3C1E4426-0B80-443E-B943-0627CD55D48B"'
		<VBFixedString(80),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray,SizeConst:=80)> Public szTypeName() As Char
	End Structure
	'UPGRADE_WARNING: Structure SHFILEINFO may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function SHGetFileInfo Lib "shell32.dll"  Alias "SHGetFileInfoA"(ByVal pszPath As String, ByVal dwAttributes As Integer, ByRef psfi As SHFILEINFO, ByVal cbSizeFileInfo As Integer, ByVal uFlags As Short) As Integer
	Private Enum EShellGetFileInfoConstants
		SHGFI_ICON = &H100s ' // get icon
		SHGFI_DISPLAYNAME = &H200s ' // get display name
		SHGFI_TYPENAME = &H400s ' // get type name
		SHGFI_ATTRIBUTES = &H800s ' // get attributes
		SHGFI_ICONLOCATION = &H1000s ' // get icon location
		SHGFI_EXETYPE = &H2000s ' // return exe type
		SHGFI_SYSICONINDEX = &H4000s ' // get system icon index
		SHGFI_LINKOVERLAY = &H8000s ' // put a link overlay on icon
		SHGFI_SELECTED = &H10000 ' // show icon in selected state
		SHGFI_ATTR_SPECIFIED = &H20000 ' // get only specified attributes
		SHGFI_LARGEICON = &H0s ' // get large icon
		SHGFI_SMALLICON = &H1s ' // get small icon
		SHGFI_OPENICON = &H2s ' // get open icon
		SHGFI_SHELLICONSIZE = &H4s ' // get shell size icon
		SHGFI_PIDL = &H8s ' // pszPath is a pidl
		SHGFI_USEFILEATTRIBUTES = &H10s ' // use passed dwFileAttribute
	End Enum
	Private Const FILE_ATTRIBUTE_NORMAL As Short = &H80s
	
	' Image list functions:
	Private Declare Function ImageList_GetBkColor Lib "COMCTL32" (ByVal hImageList As Short) As Integer
	Private Declare Function ImageList_ReplaceIcon Lib "COMCTL32" (ByVal hImageList As Integer, ByVal i As Integer, ByVal hIcon As Short) As Integer
	Private Declare Function ImageList_Convert Lib "COMCTL32"  Alias "ImageList_Draw"(ByVal hImageList As Integer, ByVal ImgIndex As Integer, ByVal hDCDest As Integer, ByVal x As Integer, ByVal y As Integer, ByVal flags As Short) As Integer
	Private Declare Function ImageList_Create Lib "COMCTL32" (ByVal MinCx As Integer, ByVal MinCy As Integer, ByVal flags As Integer, ByVal cInitial As Integer, ByVal cGrow As Short) As Integer
	Private Declare Function ImageList_AddMasked Lib "COMCTL32" (ByVal hImageList As Integer, ByVal hbmImage As Integer, ByVal crMask As Short) As Integer
	Private Declare Function ImageList_Replace Lib "COMCTL32" (ByVal hImageList As Integer, ByVal ImgIndex As Integer, ByVal hbmImage As Integer, ByVal hBmMask As Short) As Integer
	Private Declare Function ImageList_Add Lib "COMCTL32" (ByVal hImageList As Integer, ByVal hbmImage As Integer, ByRef hBmMask As Short) As Integer
	Private Declare Function ImageList_Remove Lib "COMCTL32" (ByVal hImageList As Integer, ByVal ImgIndex As Short) As Integer
	Private Structure IMAGEINFO
		Dim hBitmapImage As Integer
		Dim hBitmapMask As Integer
		Dim cPlanes As Integer
		Dim cBitsPerPixel As Integer
		Dim rcImage As RECT
	End Structure
	'UPGRADE_WARNING: Structure IMAGEINFO may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function ImageList_GetImageInfo Lib "COMCTL32.DLL" (ByVal hIml As Integer, ByVal i As Integer, ByRef pImageInfo As IMAGEINFO) As Integer
	Private Declare Function ImageList_AddIcon Lib "COMCTL32" (ByVal hIml As Integer, ByVal hIcon As Short) As Integer
	Private Declare Function ImageList_GetIcon Lib "COMCTL32" (ByVal hImageList As Integer, ByVal ImgIndex As Integer, ByVal fuFlags As Short) As Integer
    Private Declare Function ImageList_SetImageCount Lib "COMCTL32" (ByVal hImageList As Integer, ByRef uNewCount As Short) As Integer
	Private Declare Function ImageList_GetImageCount Lib "COMCTL32" (ByVal hImageList As Short) As Integer
	Private Declare Function ImageList_Destroy Lib "COMCTL32" (ByVal hImageList As Short) As Integer
	Private Declare Function ImageList_GetIconSize Lib "COMCTL32" (ByVal hImageList As Integer, ByRef cX As Integer, ByRef cY As Short) As Integer
	Private Declare Function ImageList_SetIconSize Lib "COMCTL32" (ByVal hImageList As Integer, ByRef cX As Integer, ByRef cY As Short) As Integer
	
	' ImageList functions:
	' Draw:
	Private Declare Function ImageList_Draw Lib "COMCTL32.DLL" (ByVal hIml As Integer, ByVal i As Integer, ByVal hdcDst As Integer, ByVal x As Integer, ByVal y As Integer, ByVal fStyle As Integer) As Integer
	Private Const ILD_NORMAL As Short = 0
	Private Const ILD_TRANSPARENT As Short = 1
	Private Const ILD_BLEND25 As Short = 2
	Private Const ILD_SELECTED As Short = 4
	Private Const ILD_FOCUS As Short = 4
	Private Const ILD_MASK As Integer = &H10
	Private Const ILD_IMAGE As Integer = &H20
	Private Const ILD_ROP As Integer = &H40
	Private Const ILD_OVERLAYMASK As Short = 3840
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function ImageList_GetImageRect Lib "COMCTL32.DLL" (ByVal hIml As Integer, ByVal i As Integer, ByRef prcImage As RECT) As Integer
	' Messages:
	Private Declare Function ImageList_DrawEx Lib "COMCTL32" (ByVal hIml As Integer, ByVal i As Integer, ByVal hdcDst As Integer, ByVal x As Integer, ByVal y As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal rgbBk As Integer, ByVal rgbFg As Integer, ByVal fStyle As Short) As Integer
    Private Declare Function ImageList_LoadImage Lib "COMCTL32" Alias "ImageList_LoadImageA" (ByVal hInst As Integer, ByVal lpbmp As String, ByVal cX As Integer, ByVal cGrow As Integer, ByVal crMask As Integer, ByVal uType As Integer, ByVal uFlags As Short) As Integer
	Private Declare Function ImageList_SetBkColor Lib "COMCTL32" (ByVal hImageList As Integer, ByVal clrBk As Short) As Integer
	
	Private Const ILC_MASK As Integer = &H1
	
	Private Const CLR_DEFAULT As Integer = -16777216
	Private Const CLR_HILIGHT As Integer = -16777216
	Private Const CLR_NONE As Short = -1
	
	Private Const ILCF_MOVE As Integer = &H0
	Private Const ILCF_SWAP As Integer = &H1
	Private Declare Function ImageList_Copy Lib "COMCTL32" (ByVal himlDst As Integer, ByVal iDst As Integer, ByVal himlSrc As Integer, ByVal iSrc As Integer, ByVal uFlags As Short) As Integer
	
	Private Declare Function GetTempFileName Lib "kernel32"  Alias "GetTempFileNameA"(ByVal lpszPath As String, ByVal lpPrefixString As String, ByVal wUnique As Integer, ByVal lpTempFileName As String) As Integer
	Private Declare Function GetTempPath Lib "kernel32"  Alias "GetTempPathA"(ByVal nBufferLength As Integer, ByVal lpBuffer As String) As Integer
	Private Declare Function lstrlen Lib "kernel32"  Alias "lstrlenA"(ByVal lpString As String) As Integer
	
	Private Structure PictDesc
		Dim cbSizeofStruct As Integer
		Dim picType As Integer
		Dim hImage As Integer
		Dim xExt As Integer
		Dim yExt As Integer
	End Structure
	Private Structure Guid
		Dim Data1 As Integer
		Dim Data2 As Integer
		Dim Data3 As Integer
		<VBFixedArray(7)> Dim Data4() As Byte
		
		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B4BFF9E0-8631-45CF-910E-62AB3970F27B"'
		Public Sub Initialize()
			ReDim Data4(7)
		End Sub
	End Structure
	'UPGRADE_WARNING: Structure IPicture may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	'UPGRADE_WARNING: Structure Guid may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	'UPGRADE_WARNING: Structure PictDesc may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function OleCreatePictureIndirect Lib "olepro32.dll" (ByRef lpPictDesc As PictDesc, ByRef riid As Guid, ByVal fPictureOwnsHandle As Integer, ByRef iPic As System.Drawing.Image) As Integer
	
	' -----------
	' ENUMS
	' -----------
	
	Public Enum esilColourDepth
		ILC_COLOR = &H0s
		ILC_COLOR4 = &H4s
		ILC_COLOR8 = &H8s
		ILC_COLOR16 = &H10s
		ILC_COLOR24 = &H18s
		ILC_COLOR32 = &H20s
	End Enum
	' ------------------
	' Private variables:
	' ------------------
	Private m_hIml As Integer
	Private m_lIconSizeX As Integer
	Private m_lIconSizeY As Integer
	
	Public ReadOnly Property SystemColourDepth() As esilColourDepth
		Get
			Dim lR As Integer
			Dim lHDC As Integer
			lHDC = CreateDCAsNull("DISPLAY", 0, 0, 0)
			lR = GetDeviceCaps(lHDC, BITSPIXEL)
			DeleteDC(lHDC)
			SystemColourDepth = lR
		End Get
	End Property
	
	Public Property IconSizeX() As Integer
		Get
			' Returns the icon width
			IconSizeX = m_lIconSizeX
		End Get
		Set(ByVal Value As Integer)
			' Sets the icon width.  NB no change at runtime unless you
			' call Create and add all the images in again.
			m_lIconSizeX = Value
		End Set
	End Property
	Public Property IconSizeY() As Integer
		Get
			' Returns the icon height:
			IconSizeY = m_lIconSizeY
		End Get
		Set(ByVal Value As Integer)
			' Sets the icon height.  NB no change at runtime unless you
			' call Create and add all the images in again.
			m_lIconSizeY = Value
		End Set
	End Property
    Public ReadOnly Property ItemIndex(ByVal vKey As Integer, Optional ByVal bForceLoadFromDisk As Boolean = True) As Integer
        Get
            Dim lR As Integer
            Dim dwFlags As Integer
            Dim FileInfo As SHFILEINFO
            FileInfo = Nothing
            ' Returns the 0 based Index for the selected
            ' Image list item:
            If (IsNumeric(vKey)) Then
                
                ItemIndex = vKey
            Else

                dwFlags = EShellGetFileInfoConstants.SHGFI_SYSICONINDEX
                If IconSizeX >= 32 Then
                    dwFlags = dwFlags Or EShellGetFileInfoConstants.SHGFI_LARGEICON
                Else
                    dwFlags = dwFlags Or EShellGetFileInfoConstants.SHGFI_SMALLICON
                End If

                ' We choose whether to access the disk or not. If you don't
                ' hit the disk, you may get the wrong icon if the icon is
                ' not cached. But the speed is very good!
                If Not bForceLoadFromDisk Then
                    dwFlags = dwFlags Or EShellGetFileInfoConstants.SHGFI_USEFILEATTRIBUTES
                End If

                ' sFileSpec can be any file. You can specify a
                ' file that does not exist and still get the
                ' icon, for example sFileSpec = "C:\PANTS.DOC"
                'UPGRADE_ISSUE: LenB function is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
                
                lR = SHGetFileInfo(vKey, FILE_ATTRIBUTE_NORMAL, FileInfo, System.Runtime.InteropServices.Marshal.SizeOf(FileInfo), dwFlags)

                If (lR = 0) Then
                    ' Failed
                Else
                    ItemIndex = FileInfo.iIcon
                End If

            End If

        End Get
    End Property
    Public ReadOnly Property ItemPicture(ByVal vKey As Integer) As System.Drawing.Image
        Get
            Dim lIndex As Integer
            Dim hIcon As Integer
            ' Returns a StdPicture for an image in the ImageList:
            lIndex = ItemIndex(vKey)
            If (lIndex > -1) Then
                hIcon = ImageList_GetIcon(m_hIml, lIndex, ILD_TRANSPARENT)
                If (hIcon <> 0) Then
                    ItemPicture = IconToPicture(hIcon)
                    ' Don't destroy the icon - it is now owned by
                    ' the picture object
                End If
            End If

        End Get
    End Property
    Public ReadOnly Property ItemCopyOfIcon(ByVal vKey As Integer) As Integer
        Get
            Dim lIndex As Integer
            ' Returns a hIcon for an image in the ImageList.  User must
            ' call DestroyIcon on the returned handle.
            lIndex = ItemIndex(vKey)
            If (lIndex > -1) Then
                ItemCopyOfIcon = ImageList_GetIcon(m_hIml, lIndex, ILD_TRANSPARENT)
            End If
        End Get
    End Property
	Public ReadOnly Property hIml() As Integer
		Get
			' Returns the ImageList handle:
			hIml = m_hIml
		End Get
	End Property
	
	Public Function Create() As Boolean
		Dim dwFlags As Integer
		Dim hIml As Integer
		Dim FileInfo As SHFILEINFO
        FileInfo = Nothing
		' Do we already have an image list?  Kill it if we have:
		Destroy()
		
		dwFlags = EShellGetFileInfoConstants.SHGFI_USEFILEATTRIBUTES Or EShellGetFileInfoConstants.SHGFI_SYSICONINDEX
		If IconSizeX < 32 Then
			dwFlags = dwFlags Or EShellGetFileInfoConstants.SHGFI_SMALLICON
		End If
		
		'// Load the image list - use an arbitrary file extension for the
		'// call to SHGetFileInfo (we don't want to touch the disk, so use
		'// FILE_ATTRIBUTE_NORMAL && SHGFI_USEFILEATTRIBUTES).
		'UPGRADE_ISSUE: LenB function is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
        hIml = SHGetFileInfo(".txt", FILE_ATTRIBUTE_NORMAL, FileInfo, System.Runtime.InteropServices.Marshal.SizeOf(FileInfo), dwFlags)
		
		'Create the Imagelist:
		If (hIml <> 0) And (hIml <> -1) Then
			' Ok
			m_hIml = hIml
			Create = True
		Else
			m_hIml = 0
		End If
		
	End Function
	Public Sub Destroy()
		' No need to do anything other than clear our
		' handle:
		m_hIml = 0
	End Sub
    Public Sub DrawImage(ByVal vKey As Integer, ByVal hdc As Integer, ByVal xPixels As Integer, ByVal yPixels As Integer, Optional ByVal bSelected As Integer = False, Optional ByVal bCut As Integer = False, Optional ByVal bDisabled As Integer = False, Optional ByVal oCutDitherColour As Integer = 15000, Optional ByVal hExternalIml As Integer = 0)
        If IsNothing(oCutDitherColour) Then
            oCutDitherColour = Val(System.Drawing.SystemColors.Window)
        End If
        Dim hIcon As Integer
        Dim lFlags As Integer
        Dim lhIml As Integer
        Dim lColor As Integer
        Dim iImgIndex As Integer

        ' Draw the image at 1 based index or key supplied in vKey.
        ' on the hDC at xPixels,yPixels with the supplied options.
        ' You can even draw an ImageList from another ImageList control
        ' if you supply the handle to hExternalIml with this function.

        iImgIndex = ItemIndex(vKey)
        If (iImgIndex > -1) Then
            If (hExternalIml <> 0) Then
                lhIml = hExternalIml
            Else
                lhIml = hIml
            End If

            lFlags = ILD_TRANSPARENT
            If (bSelected) Or (bCut) Then
                lFlags = lFlags Or ILD_SELECTED
            End If

            If (bCut) Then
                ' Draw dithered:
                lColor = (oCutDitherColour)
                If (lColor = -1) Then lColor = GetSysColor(COLOR_WINDOW)
                ImageList_DrawEx(lhIml, iImgIndex, hdc, xPixels, yPixels, 0, 0, CLR_NONE, lColor, lFlags)
            ElseIf (bDisabled) Then
                ' extract a copy of the icon:
                hIcon = ImageList_GetIcon(hIml, iImgIndex, 0)
                ' Draw it disabled at x,y:
                DrawState(hdc, 0, 0, hIcon, 0, xPixels, yPixels, m_lIconSizeX, m_lIconSizeY, DST_ICON Or DSS_DISABLED)
                ' Clear up the icon:
                DestroyIcon(hIcon)

            Else
                ' Standard draw:
                ImageList_Draw(lhIml, iImgIndex, hdc, xPixels, yPixels, lFlags)
            End If
        End If
    End Sub
	Public Sub Clear()
		' Recreates the image list.
		Create()
	End Sub
	
    Public Function ImagePictureStrip(ByRef vKeys() As Integer, Optional ByVal oBackColor As Integer = 32768, Optional ByVal bForceLoadFromDisk As Boolean = False) As System.Drawing.Image
        If IsNothing(oBackColor) Then
            oBackColor = Val(System.Drawing.SystemColors.Control)
        End If
        Dim iStart As Integer
        Dim iEnd As Integer
        Dim iImgIndex As Integer
        Dim lHDC As Integer
        Dim lcHDC As Integer
        Dim lParenthDC As Integer
        Dim lhBmp As Integer
        Dim lhBmpOld As Integer
        Dim lSizeX As Integer
        Dim hBr As Integer
        Dim tR As RECT
        Dim lColor As Integer

        If (m_hIml <> 0) Then

            On Error Resume Next
            iStart = LBound(vKeys)
            iEnd = UBound(vKeys)

            On Error GoTo 0
            If (iEnd >= iStart) And Err.Number = 0 Then
                lcHDC = CreateDCAsNull("DISPLAY", 0, 0, 0)
                lHDC = CreateCompatibleDC(lcHDC)
                If (lHDC <> 0) Then
                    lSizeX = (iEnd - iStart + 1) * m_lIconSizeX
                    lhBmp = CreateCompatibleBitmap(lcHDC, lSizeX, m_lIconSizeY)
                    If (lhBmp <> 0) Then
                        lhBmpOld = SelectObject(lHDC, lhBmp)
                        If (lhBmpOld <> 0) Then
                            lColor = 12000
                            tR.Bottom = m_lIconSizeY
                            tR.Right_Renamed = lSizeX
                            hBr = CreateSolidBrush(lColor)
                            FillRect(lHDC, tR, hBr)
                            DeleteObject(hBr)
                            For iImgIndex = iStart To iEnd
                                ImageList_Draw(m_hIml, ItemIndex(vKeys(iImgIndex), bForceLoadFromDisk), lHDC, (iImgIndex - iStart) * m_lIconSizeX, 0, ILD_TRANSPARENT)
                            Next iImgIndex
                            SelectObject(lHDC, lhBmpOld)
                            ImagePictureStrip = BitmapToPicture(lhBmp)
                        Else
                            DeleteObject(lhBmp)
                        End If
                    End If
                    DeleteDC(lHDC)
                    DeleteDC(lcHDC)
                End If
            End If
        End If

    End Function
	
	Public Function IconToPicture(ByVal hIcon As Short) As System.Drawing.Image
		
		If hIcon = 0 Then Exit Function
		
		' This is all magic if you ask me:
		'UPGRADE_WARNING: Arrays in structure IGuid may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim NewPic As System.Drawing.Image
		Dim PicConv As PictDesc
		Dim IGuid As Guid
        NewPic = Nothing
		PicConv.cbSizeofStruct = Len(PicConv)
		'UPGRADE_ISSUE: Constant vbPicTypeIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
        PicConv.picType = 3
		PicConv.hImage = hIcon
		
		' Fill in magic IPicture GUID {7BF80980-BF32-101A-8BBB-00AA00300CAB}
		With IGuid
			.Data1 = &H7BF80980
			.Data2 = &HBF32s
			.Data3 = &H101As
			.Data4(0) = &H8Bs
			.Data4(1) = &HBBs
			.Data4(2) = &H0s
			.Data4(3) = &HAAs
			.Data4(4) = &H0s
			.Data4(5) = &H30s
			.Data4(6) = &HCs
			.Data4(7) = &HABs
		End With
		OleCreatePictureIndirect(PicConv, IGuid, True, NewPic)
		
		IconToPicture = NewPic
		
	End Function
	
	Public Function BitmapToPicture(ByVal hBmp As Short) As System.Drawing.Image

		If (hBmp = 0) Then Exit Function
		
		'UPGRADE_WARNING: Arrays in structure IGuid may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim NewPic As System.Drawing.Image
		Dim tPicConv As PictDesc
		Dim IGuid As Guid
        NewPic = Nothing

		' Fill PictDesc structure with necessary parts:
		With tPicConv
			.cbSizeofStruct = Len(tPicConv)
			'UPGRADE_ISSUE: Constant vbPicTypeBitmap was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
            .picType = 1
			.hImage = hBmp
		End With
		
        ' Fill in IDispatch Interface ID

		With IGuid
            .Data4(0) = Nothing
            .Data1 = &H20400
			.Data4(0) = &HC0s
			.Data4(7) = &H46s
		End With
		
		' Create a picture object:
		OleCreatePictureIndirect(tPicConv, IGuid, True, NewPic)
		
		' Return it:
		BitmapToPicture = NewPic
		
		
	End Function
	
	Public Function TranslateColor(ByVal clr As System.Drawing.Color, Optional ByRef hPal As Integer = 0) As Short
		If OleTranslateColor(System.Drawing.ColorTranslator.ToOle(clr), hPal, TranslateColor) Then
			TranslateColor = CLR_INVALID
		End If
	End Function
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
		m_lIconSizeX = 16
		m_lIconSizeY = 16
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
	
	'UPGRADE_NOTE: Class_Terminate was upgraded to Class_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Terminate_Renamed()
		Destroy()
	End Sub
	Protected Overrides Sub Finalize()
		Class_Terminate_Renamed()
		MyBase.Finalize()
	End Sub
End Class