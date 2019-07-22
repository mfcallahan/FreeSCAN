Option Strict Off
Option Explicit On
Module API
	
	'For Comm Port Auto Detection
	'// API Declarations
	'UPGRADE_WARNING: Structure SECURITY_ATTRIBUTES may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Public Declare Function CreateFile Lib "kernel32"  Alias "CreateFileA"(ByVal lpFileName As String, ByVal dwDesiredAccess As Integer, ByVal dwShareMode As Integer, ByRef lpSecurityAttributes As SECURITY_ATTRIBUTES, ByVal dwCreationDisposition As Integer, ByVal dwFlagsAndAttributes As Integer, ByVal hTemplateFile As Short) As Integer
	Public Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Short) As Integer
	
	'// API Structures
	Public Structure SECURITY_ATTRIBUTES
		Dim nLength As Integer
		Dim lpSecurityDescriptor As Integer
		Dim bInheritHandle As Integer
	End Structure
	
	'// API constants
	Public Const FILE_SHARE_READ As Short = &H1s
	Public Const FILE_SHARE_WRITE As Short = &H2s
	Public Const OPEN_EXISTING As Short = 3
	Public Const FILE_ATTRIBUTE_NORMAL As Short = &H80s
	
	'// Return TRUE if the COM exists, FALSE if the COM does not exist
	Public Function COMAvailable(ByRef COMNum As Short) As Boolean
		Dim hCOM As Integer
		Dim ret As Integer
		Dim sec As SECURITY_ATTRIBUTES
		
		'// try to open the COM port
		hCOM = CreateFile("\.\COM" & COMNum & "", 0, FILE_SHARE_READ + FILE_SHARE_WRITE, sec, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, 0)
		If hCOM = -1 Then
			COMAvailable = False
		Else
			COMAvailable = True
			'// close the COM port
			ret = CloseHandle(hCOM)
		End If
	End Function
End Module