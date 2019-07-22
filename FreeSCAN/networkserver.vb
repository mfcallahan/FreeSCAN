Imports System.Net
Imports System.Security.Permissions

Public Class networkserver

    Dim sBroadcastMsg As String = Nothing
    Dim waveAddress As String = Nothing
    Dim m_WebServer As HttpListener
    Const MaxUsers As Integer = 50
    Dim protoVersion As String = "100"
    Dim AuthCodes() As String
    Dim logData As String

    Structure userData
        Public userName As String
        Public Password As String
        Public NoControl As Boolean
    End Structure

    Dim userDB() As userData

    Private Sub HTTPRequestReceived(ByVal e As HttpListenerContext)

        Try

            Dim fileName As String = e.Request.Url.AbsolutePath
            'Dim xx() As String = e.Request.QueryString.AllKeys
            e.Response.ContentEncoding = System.Text.Encoding.UTF8
            ' Handle HTTP Request in this Procedure
            Dim sResponse As String = "(null)"
            Dim noReturn As Boolean = False


            'All the freq jump variable
            Dim dblFreq As Double, toneMode As String, modulation As String
            Dim strBuff As String
            Dim isLoginRequest As Boolean = False
            Console.WriteLine(fileName)


            Select Case fileName
                Case "/display"
                    sResponse = PreProcessData()
                Case "/command"
                    noReturn = True

                Case "/", "/Index.htm", "Default.htm"
                    sResponse = "No access"
                Case "/login" 'Other Urls

                    sResponse = processLogin((e.Request.QueryString.Item(0).ToString & "," & e.Request.RemoteEndPoint.Address.ToString))


                Case Else
                    sResponse = "Unknown request"
            End Select
            'Console.WriteLine(xx.ToString)
            Dim intVal As Integer

            'Process any incoming requests
            If e.Request.QueryString.Count = 1 And Not isLoginRequest Then
                '  Console.WriteLine(e.Request.QueryString.Keys.Item(0).ToString)
                If e.Request.QueryString.Item(0) = "CLEARMSG" Then
                    sBroadcastMsg = Nothing
                    waveAddress = Nothing
                ElseIf e.Request.QueryString.Keys.Item(0) = "VOL" Then
                    intVal = CInt(Val(e.Request.QueryString.Item(0)))
                    If frmCtlSetup.BaseStation(strMDL) = False Then
                        intVal = CInt(intVal / 2)
                    End If
                    strUserCMD = "VOL," & CStr(intVal)
                ElseIf e.Request.QueryString.Keys.Item(0) = "SQL" Then
                    intVal = CInt(Val(e.Request.QueryString.Item(0)))
                    If frmCtlSetup.BaseStation(strMDL) = False Then
                        intVal = CInt(intVal / 1.26)
                    End If
                    strUserCMD = "SQL," & CStr(intVal)

                ElseIf e.Request.QueryString.Item(0) = "SERIAL" Then
                    If Form1.msc.IsOpen Then
                        Call frmCtlSetup.StopCOMMS()
                    Else
                        Call frmCtlSetup.StartCOMMS()
                    End If
                    noReturn = True

                ElseIf e.Request.QueryString.Keys.Item(0) = "PUSH" Then
                    strUserCMD = e.Request.QueryString.Item(0)
                    Console.WriteLine(strUserCMD)

                ElseIf e.Request.QueryString.Keys.Item(0) = "JUMPFREQ" Then
                    Dim CommandArray()
                    CommandArray = Split(e.Request.QueryString.Item(0), ",", -1, CompareMethod.Text)

                    strUserCMD = e.Request.QueryString.Item(0)
                    Console.WriteLine(strUserCMD)
                    dblFreq = Val(CommandArray(0))
                    modulation = CommandArray(1)
                    toneMode = CommandArray(2)

                    If frmCtlSetup.IsXTScanner(ScannerModel) = False Then
                        strBuff = "QSH," & CStr(dblFreq) & ",AUTO," & modulation & ",0,2,0,"
                        strBuff &= toneMode & ",,"
                        strUserCMD = strBuff
                    Else
                        strUserCMD = "QSH," & CStr(dblFreq) & ",," & modulation & ",0,2,,"
                        strUserCMD &= toneMode & ",,,,,,"
                    End If


                End If

            End If

            ' Dim QueryString As String = e.Request.QueryString("q") ' IF Any QueryString Supplied
            Dim arrBytes() As Byte
            Dim SmallResponse(0) As Byte
            SmallResponse(0) = Microsoft.VisualBasic.AscW(" ")
            If noReturn Then
                arrBytes = SmallResponse
                e.Response.Close()
                Return
            Else
                arrBytes = System.Text.Encoding.ASCII.GetBytes(sResponse)
            End If
            e.Response.ContentLength64 = arrBytes.Length
            e.Response.OutputStream.Write(arrBytes, 0, arrBytes.Length)
            e.Response.OutputStream.Flush()
            e.Response.Close()
        Catch ex As Exception
            Console.WriteLine("networkserver:HTTPRequestReceived:" & ex.Message)
        End Try
    End Sub

    Function PreProcessData() As String
        'Gets everything cleaned up from str display and returns it


        Dim strBuff As String
        Dim iosDisplay(SafeUBound(strDisplay)) As String
        Dim frequency As Double
        Dim x As Integer
        Try
            For x = 0 To SafeUBound(strDisplay)
                iosDisplay(x) = strDisplay(x)
            Next

            Dim intCtl1, intCtl, intCnt As Integer

            Dim blnTGID As Boolean

            For intCtl = 0 To 5
                If strDisplay(32) = "1" And intCtl = 1 And InStr(strDisplay(1), "PRI") = 0 Then 'global pri mode on
                    iosDisplay(1) = iosDisplay(1) & "PRI "
                End If
                If intCtl = 4 And strDisplay(30) = "1" Then 'channel pri mode
                    iosDisplay(4) = iosDisplay(4) & " PRI"
                End If
                If intCtl < 3 Then
                    strBuff = ""
                End If
            Next intCtl
            intCnt = CInt(strDisplay(49))

            strBuff = strRxSta(1)

            If InStr(strBuff, ".") <> 0 Then
                blnTGID = False
            Else
                blnTGID = True
            End If

            If blnTGID = False Then

                If Val(strBuff) > 1200 Then

                    strBuff = CStr(Val(strBuff) / 10000)
                End If

                If Val(strBuff) > 0 And Val(strBuff) < 1 Then

                    strBuff = CStr(Val(strBuff) * 10000)
                End If
                frequency = Val(strBuff)

                strBuff = frequency.ToString("###0.0000")

                iosDisplay(6) = strBuff

            ElseIf strBuff <> "" Then
                iosDisplay(6) = "ID: " & strBuff
            Else
                'iosDisplay(6) = ""
            End If
            'setup squelch
            strDisplay(38) = CStr(Val(strDisplay(38)))

            iosDisplay(38) = Val(strDisplay(38)).ToString("#0.0") & " V"
            'Function
            If strDisplay(28) = "1" Then
                If iosDisplay(8) IsNot "FUNC" Then
                    iosDisplay(8) = "FUNC"
                End If

            Else
                iosDisplay(8) = ""
            End If

            'Negative delay
            strBuff = Nothing
            For x = 0 To SafeUBound(iosDisplay)
                strBuff &= iosDisplay(x) & ","
            Next
            'Add more stuff, like the broadcast message, file to download and play
            strBuff &= sBroadcastMsg & "," & waveAddress

        Catch ex As Exception

            If blnDebug Then
                MessageBox.Show("networkserver:PreProcessData:" & ex.Message)
            End If

        End Try
        Return strBuff
    End Function

    Public Function StartWebServer() As Boolean
        If Not HttpListener.IsSupported Then
            MessageBox.Show("Operating System does not Support HTTP Server Registration.")
            Return False
        End If

        cmdStopServer.Enabled = True
        Dim portNum, targetPrefix As String
        portNum = Str(Val(Trim(txtPort.Text)))
        If Val(portNum) < 1 Or Val(portNum) > 65535 Then
            MsgBox("Invalid port number. Must be between 1 and 65535 and be a whole number.", MsgBoxStyle.Critical, "Cannot start")
            Exit Function
        End If
        If Val(portNum) <> Int(Val(portNum)) Then
            MsgBox("Invalid port number. Must be a whole number.", MsgBoxStyle.Critical, "Cannot start")
            Exit Function
        End If
        AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal)
        '  Dim adminPerm As New PrincipalPermission(SecurityAction.Demand, "BUILTIN\Administrators")
        ' adminPerm.Demand()
        m_WebServer = New HttpListener()
        m_WebServer.Prefixes.Clear()
        m_WebServer.AuthenticationSchemes = AuthenticationSchemes.Anonymous

        portNum = Trim(portNum)

        targetPrefix = "http://*:" & portNum & "/"
        log("Server started")
        Console.WriteLine("networkserver: listening on " & targetPrefix)
        m_WebServer.Prefixes.Add(targetPrefix)

        If m_WebServer.Prefixes.Count = 0 Then
            MessageBox.Show("Could not Bind to Port, Possibly Used by other Application.")
            Return False
        End If

        Try
            m_WebServer.Start()
        Catch ex As Exception
            log("Error starting server: " & ex.Message)
            log("Confirm FreeSCAN is running with administrator permissions and try again.")
            cmdStopServer.Enabled = False
            Return False
        End Try
        cmdStartServer.Enabled = False
        DumpIP()
        Dim ir As IAsyncResult
        ir = m_WebServer.BeginGetContext(AddressOf HTTPListenerContextAvailable, Me.m_WebServer)
        Return True
    End Function

    Sub log(logText As String)
        Dim line As String = DateTime.Now & " " & logText & vbCrLf

        logData += line
    End Sub

    Private Sub HTTPListenerContextAvailable(ByVal ar As IAsyncResult)
        Dim context As HttpListenerContext
        Try
            context = m_WebServer.EndGetContext(ar)
            m_WebServer.BeginGetContext(AddressOf Me.HTTPListenerContextAvailable, m_WebServer)

            context.Response.SendChunked = False

            '    context.Response.AddHeader("Cache-Control", "no-cache")

            HTTPRequestReceived(context)
        Catch ex As Exception
            Console.WriteLine("Error: HTTPListenerContextAvailable:" & ex.Message)
            log("Server error: " & ex.Message)
            '   MessageBox.Show("HTTP Listener ContestAvailable/networkserver.vb:" & ex.Message)
        End Try
    End Sub

    Public Sub stopWebServer()
        If Not IsNothing(m_WebServer) Then
            Try
                m_WebServer.Stop()
                m_WebServer = Nothing
                log("Shutting down webserver")
            Catch ex As Exception
                log("Server shut down error - " & ex.Message)
                Console.WriteLine("stopWebServer: " & ex.Message)
            End Try
        End If
        cmdStopServer.Enabled = False
        cmdStartServer.Enabled = True
    End Sub

    Function processLogin(ByVal AuthInfo As String)
        ''Generates login tokens
        'verify the protocol version is compatible
        'It is up to the client to authenticate itself
        Console.WriteLine("Process login start with " & AuthInfo)

        Dim userInfo As userData
        Dim rawData() As String = Split(AuthInfo, ",", -1)
        Dim clientVersion As String
        If SafeUBound(rawData) <> 3 Then
            Return "LOGONBAD"
        End If
        Dim user As String = rawData(0)
        Dim Pass As String = rawData(1)
        Dim userSource As String = rawData(3)
        log("User '" & user & "' attempting to log in from " & userSource)
        clientVersion = rawData(2)
        If clientVersion <> protoVersion Then
            log("User client not compatible version, rejecting")
            Return "BADVER"
        End If
        'verify the user name exists
        log("Open mode, login OK")
        If btnAnyUser.Checked Then Return "LOGONOK"


        Dim i As Integer
        For i = 0 To SafeUBound(userDB)
            userInfo = userDB(i)
            If (Strings.StrComp(userInfo.userName, user, CompareMethod.Text)) = 0 Then
                If Strings.StrComp(userInfo.Password, Pass, CompareMethod.Text) = 0 Then
                    log("User " & user & " logged in successfully")
                    Return "LOGONOK"
                End If
            End If
        Next
        Console.WriteLine("Login failed no auth")
        Return "LOGONBAD"
    End Function

    Private Sub DumpIP()
        log("Local host name:" & System.Net.Dns.GetHostName)
        For Each ip As Net.IPAddress In System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList
            log("Listening on:" & ip.ToString)
        Next
    End Sub


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadUserLogonData()
        DisplayUserDB()
        Dim OpMode As String = GetSetting("FreeSCAN", "Settings", "SecureMode", "0")
        If OpMode = "0" Then '
            btnAnyUser.Checked = True
        Else
            RadioButton2.Checked = True
        End If
    End Sub

    Private Sub cmdStartServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStartServer.Click

        StartWebServer()

    End Sub

    Private Sub cmdStopServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStopServer.Click
        stopWebServer()
    End Sub

    Private Sub cmdBroadcastMsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sBroadcastMsg = txtLog.Text

    End Sub

    Private Sub Userlist_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
    Sub AddUser(ByRef Userinfo As userData)
        'Adds a user to the db
        Dim newSize As Integer
        If IsNothing(userDB) Then
            ReDim userDB(0)
            newSize = 0
        Else
            newSize = userDB.GetUpperBound(0) + 1
            ReDim Preserve userDB(newSize)
        End If
        userDB(newSize) = Userinfo
        ' LoadUserLogonData()
        DisplayUserDB()
    End Sub
    Function MakeUser(ByRef Username As String, ByRef Password As String, ByVal NoWrite As String)
        Dim newUser As userData
        newUser.userName = Username
        newUser.Password = Password
        If NoWrite = "1" Then
            newUser.NoControl = True
        Else
            newUser.NoControl = False
        End If
        Return newUser
    End Function
    Sub SaveUserLogonData()

        Dim dbPath As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
        dbPath += "users.txt"
        Dim fileContents As String
        Dim delimit As String = "!@!@!@!"
        Dim userInfo As userData
        Dim i As Integer
        Try

            If SafeUBound(userDB) >= 0 Then
                For i = 0 To UBound(userDB)
                    userInfo = userDB(i)
                    fileContents += userInfo.userName & delimit & userInfo.Password & delimit & userInfo.NoControl & vbCrLf
                Next
            End If

            My.Computer.FileSystem.WriteAllText(dbPath, fileContents, False)
        Catch ex As Exception
            Console.WriteLine("Error saving user data " & ex.Message)
        End Try

    End Sub
    Sub LoadUserLogonData()
        ''


        Dim dbPath As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
        dbPath += "users.txt"
        Dim currentRow As String()
        Dim userInfo As userData
        Try
            If FileExists(dbPath) Then
                Using myReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(dbPath)
                    myReader.TextFieldType = FileIO.FieldType.Delimited
                    myReader.SetDelimiters("!@!@!@!")

                    While Not myReader.EndOfData
                        currentRow = myReader.ReadFields()
                        If SafeUBound(currentRow) = 2 Then
                            userInfo = MakeUser(currentRow(0), currentRow(1), currentRow(2))
                            AddUser(userInfo)
                        End If

                    End While
                End Using
            End If

        Catch ex As Exception
            Console.WriteLine("Error loading user data " & ex.Message)
        End Try

    End Sub
    Sub DisplayUserDB()
        lstUsers.Items.Clear()
        If IsNothing(userDB) Then
            GBUserInfo.Enabled = False
            Exit Sub
        End If
        Dim Cnt As Integer = userDB.GetUpperBound(0)
        Dim Row As Integer
        For Row = 0 To Cnt
            lstUsers.Items.Add(userDB(Row).userName)
        Next
    End Sub

    Private Sub Userlist_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        Call SaveUserLogonData()
    End Sub

    Function Encrypt(clrtxt)
        'Encrypts passwords using ROT13 encryption
        If Strings.Len(clrtxt) = 0 Then
            Return Nothing
        End If

        Dim Pos As Integer = 0
        Dim enctxt, buffer As String
        For Pos = 0 To Strings.Len(clrtxt) - 1
            buffer = OldMid(clrtxt, Pos, 1)
            buffer = Chr((Asc(buffer) + 13))
            enctxt &= buffer
        Next
        Return enctxt

    End Function
    Function Decrypt(enctxt)
        'Decrypts passwords using ROT13 encryption
        If Strings.Len(enctxt) = 0 Then
            Return Nothing
        End If

        Dim Pos As Integer = 0
        Dim clrtxt, buffer As String
        For Pos = 0 To Strings.Len(enctxt) - 1
            buffer = OldMid(enctxt, Pos, 1)
            buffer = Chr((Asc(enctxt) - 13))
            clrtxt &= buffer
        Next
        Return clrtxt
    End Function

    Private Sub cmdAddNewUser_Click(sender As System.Object, e As System.EventArgs) Handles cmdAddNewUser.Click
        ''Adds a new user to the system
        Dim newUser As userData
        Dim userCnt As Integer
        If IsNothing(userDB) Then
            userCnt = 0
        Else
            userCnt = userDB.GetUpperBound(0)
            userCnt += 1
        End If

        newUser.userName = "User" & userCnt
        newUser.Password = ""
        newUser.NoControl = False
        AddUser(newUser)
        DisplayUserDB()
        lstUsers.SelectedIndex = userCnt
        SaveUserLogonData()
    End Sub

    Private Sub lstUsers_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles lstUsers.SelectedIndexChanged
        ''A different selection has been made in the list box, update display
        Dim selIdx = lstUsers.SelectedIndex
        If selIdx = -1 Then
            GBUserInfo.Enabled = False
            txtUsername.Text = Nothing
            txtPassword.Text = Nothing
            Exit Sub
        End If
        If selIdx > (userDB.GetUpperBound(0)) Then
            Console.WriteLine("networkserver.vb:lstuser_selindexchange:selection exceeds userdb bounds")
            Return
        End If
        txtUsername.Text = userDB(selIdx).userName
        txtPassword.Text = userDB(selIdx).Password
        chkNoWrite.Checked = userDB(selIdx).NoControl
        GBUserInfo.Enabled = True
    End Sub

    Private Sub txtPassword_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub cmdSaveUserInfo_Click(sender As System.Object, e As System.EventArgs) Handles cmdSaveUserInfo.Click
        ''Saves user info into current db

        Dim selIdx = lstUsers.SelectedIndex
        If selIdx = -1 Then
            Console.WriteLine("Cannot save - nothing selected.")
            Return

        End If
        If IsNothing(userDB) Then
            Console.WriteLine("Cannot save - no entries in user db")
            Return
        End If
        If selIdx > (userDB.GetUpperBound(0)) Then
            Console.WriteLine("Cannot save - user array exceeds userdb")
            Return
        End If

        If txtUsername.TextLength = 0 Then
            MsgBox("Please enter a username.", MsgBoxStyle.Exclamation, "Cannot save")
            Return
        End If
        'Do some input checking over here!!!!!!!!!!!!!!
        If txtUsername.TextLength < 2 Or txtUsername.TextLength > 16 Then
            MessageBox.Show("Username is too or too short.")
            Exit Sub
        End If
        If txtPassword.TextLength < 2 Or txtPassword.TextLength > 16 Then
            MessageBox.Show("Password is too or too short.")
            Exit Sub
        End If
        If InStr(txtUsername.Text, ",") > 0 Or InStr(txtPassword.Text, ",") > 0 Then
            MessageBox.Show("Username and passwords should not contain commas or other special characters.")
            Exit Sub
        End If

        userDB(selIdx).userName = txtUsername.Text
        userDB(selIdx).Password = txtPassword.Text
        userDB(selIdx).NoControl = chkNoWrite.Checked
        DisplayUserDB()
        lstUsers.SelectedIndex = selIdx
        SaveUserLogonData()
    End Sub

    Private Sub cmdDelUser_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelUser.Click
        ''Deletes the selected (l)user
        Dim NukeIDX As Integer
        Dim selIdx = lstUsers.SelectedIndex
        If selIdx = -1 Then
            Console.WriteLine("Cannot delete - nothing selected.")
            Return

        End If
        If IsNothing(userDB) Then
            Console.WriteLine("Cannot delete - no entries in user db")
            Return
        End If
        If selIdx > (userDB.GetUpperBound(0)) Then
            Console.WriteLine("Cannot delete - user array exceeds userdb")
            Return
        End If
        Dim response As MsgBoxResult
        response = MsgBox("Are you sure you want to delete the user " & userDB(selIdx).userName & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Delete user?")
        If response = MsgBoxResult.No Then
            Return
        End If
        NukeIDX = selIdx
        'is there only one record? then delete array and quit
        Dim userCnt As Integer = userDB.GetUpperBound(0)
        If userCnt = 0 Then
            Erase userDB
            DisplayUserDB()
            Return
        End If
        'otherwise delete specific record
        Dim newData(userCnt - 1) As userData
        Dim newIdx As Integer = 0
        For selIdx = 0 To userDB.GetUpperBound(0)
            If selIdx <> NukeIDX Then
                newData(newIdx) = userDB(selIdx)
                newIdx += 1
            End If
        Next
        Erase userDB
        userDB = newData.Clone
        DisplayUserDB()
    End Sub

    Private Sub timerTxt_Tick(sender As System.Object, e As System.EventArgs) Handles timerTxt.Tick
        If Not (IsNothing(logData)) Then
            txtLog.AppendText(logData)
            logData = Nothing
        End If

    End Sub

    Private Sub btnAnyUser_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles btnAnyUser.CheckedChanged
        SaveSetting("FreeSCAN", "Settings", "SecureMode", "0")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        SaveSetting("FreeSCAN", "Settings", "SecureMode", "1")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ShellCode, strSite As String
        strSite = "https://itunes.apple.com/WebObjects/MZStore.woa/wa/viewSoftware?id=844590973&mt=8"

        ShellCode = CStr(ShellExecute(Me.Handle.ToInt32, "open", strSite, "", "", 1))

        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim ShellCode, strSite As String
        strSite = "https://www.sixspotsoftware.com"

        ShellCode = CStr(ShellExecute(Me.Handle.ToInt32, "open", strSite, "", "", 1))

        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
End Class


