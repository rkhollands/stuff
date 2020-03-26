
Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports MVB = Microsoft.VisualBasic

Public Class Form1
    Private Declare Function SetLocalTime Lib "kernel32" (ByRef lpSystemTime As SYSTEMTIME) As Boolean

    Private StartOccurance As Byte
    Private StartDay As Byte
    Private StartMonth As Byte
    'Private StartHour As Byte
    'Private StartMinute As Byte

    Private EndOccurance As Byte
    Private EndDay As Byte
    Private EndMonth As Byte
    'Private EndHour As Byte
    'Private EndMinute As Byte

    Private AdjustDST As Boolean
    Private GMTAdjustment As SByte 'Number of hours east or west of Greenwich
    Private DSTYear 'current year

    Private Structure SYSTEMTIME
        Public year As Short
        Public month As Short
        Public dayOfWeek As Short
        Public day As Short
        Public hour As Short
        Public minute As Short
        Public second As Short
        Public milliseconds As Short
    End Structure

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim GMT As Date
        Dim NewDate As Date
        Dim arguments() As String
        Dim SetTime As Boolean

        GetSettings()

        If AdjustDST = True Then
            arguments = Environment.GetCommandLineArgs()

            If arguments.Length > 1 Then
                If UCase(arguments(1)) = "R" Then SetTime = True
            End If
        End If

        If SetTime = True Then
            GMT = GetInternetTime()
            NewDate = GetLocalTime(GMT)
            ChangeDate(NewDate)
            Me.Close()
        End If

        SetUpForm()
        PopulateForm()
    End Sub

    Sub AcceptDates()
        GetDSTDates()

        WriteToFile("Adjust DST:" & AdjustDST)
        WriteToFile("GMT Adjustment:" & GMTAdjustment, True)

        WriteToFile("Start Month:" & StartMonth, True)
        WriteToFile("Start Day:" & StartDay, True)
        WriteToFile("Start Occurance:" & StartOccurance, True)
        ' WriteToFile("Start Hour:" & StartHour, True)
        'WriteToFile("Start Minute:" & StartMinute, True)

        WriteToFile("End Month:" & EndMonth, True)
        WriteToFile("End Day:" & EndDay, True)
        WriteToFile("End Occurance:" & EndOccurance, True)
        'WriteToFile("End Hour:" & EndHour, True)
        'WriteToFile("End Minute:" & EndMinute, True)

    End Sub

    Sub GetSettings()
        Dim TextBlock As String()
        Dim TextLabel As String
        Dim TextValue As String
        Dim Pos As Int16

        'initialize variables
        AdjustDST = True
        GMTAdjustment = -5
        StartMonth = 1
        StartDay = 1
        StartOccurance = 1
        'StartHour = 0
        'StartMinute = 0
        EndMonth = 1
        EndDay = 1
        EndOccurance = 1
        'EndHour = 0
        'EndMinute = 0

        'then read the "Settings" file and assign if possible
        TextBlock = ReadFile()

        If TextBlock Is Nothing Then Exit Sub

        For x = 0 To UBound(TextBlock)
            Pos = InStr(TextBlock(x), ":")

            If Pos > 0 Then
                TextLabel = UCase(MVB.Left(TextBlock(x), Pos - 1))
                TextValue = Trim(MVB.Right(TextBlock(x), Len(TextBlock(x)) - Pos))

                If IsNumeric(TextValue) = False Then
                    If TextLabel = "ADJUST DST" Then AdjustDST = TextValue
                Else
                    If TextLabel = "GMT ADJUSTMENT" Then GMTAdjustment = Val(TextValue)

                    If TextLabel = "START MONTH" Then StartMonth = Val(TextValue)
                    If TextLabel = "START DAY" Then StartDay = Val(TextValue)
                    If TextLabel = "START OCCURANCE" Then StartOccurance = Val(TextValue)
                    'If TextLabel = "START HOUR" Then StartHour = Val(TextValue)
                    'If TextLabel = "START MINUTE" Then StartMinute = Val(TextValue)

                    If TextLabel = "END MONTH" Then EndMonth = Val(TextValue)
                    If TextLabel = "END DAY" Then EndDay = Val(TextValue)
                    If TextLabel = "END OCCURANCE" Then EndOccurance = Val(TextValue)
                    'If TextLabel = "END HOUR" Then EndHour = Val(TextValue)
                    'If TextLabel = "END MINUTE" Then EndMinute = Val(TextValue)
                End If
            End If
        Next x
    End Sub

    Private Sub SetUpForm()
        Dim ComboGMTSource As New Dictionary(Of SByte, String)
        Dim ComboOccuranceSource As New Dictionary(Of Byte, String)
        Dim ComboDaySource As New Dictionary(Of Byte, String)
        Dim ComboMonthSource As New Dictionary(Of Byte, String)
        'Dim ComboHourSource As New Dictionary(Of Byte, String)
        'Dim ComboMinuteSource As New Dictionary(Of Byte, String)
        Dim FirstDate As Date

        'Add GMT adjustment values
        For x = 12 To -12 Step -1
            If x <> 0 Then ComboGMTSource.Add(x, x)
        Next

        ComboGMTAdjustment.DataSource = New BindingSource(ComboGMTSource, Nothing)
        ComboGMTAdjustment.DisplayMember = "Value"
        ComboGMTAdjustment.ValueMember = "Key"

        ComboOccuranceSource.Add(1, "FIRST")
        ComboOccuranceSource.Add(2, "SECOND")
        ComboOccuranceSource.Add(3, "THIRD")
        ComboOccuranceSource.Add(4, "FOURTH")
        ComboOccuranceSource.Add(5, "LAST")

        ComboStartOccurance.DataSource = New BindingSource(ComboOccuranceSource, Nothing)
        ComboStartOccurance.DisplayMember = "Value"
        ComboStartOccurance.ValueMember = "Key"

        ComboEndOccurance.DataSource = New BindingSource(ComboOccuranceSource, Nothing)
        ComboEndOccurance.DisplayMember = "Value"
        ComboEndOccurance.ValueMember = "Key"

        For x = 1 To 7
            FirstDate = DateAdd("d", -MVB.DateAndTime.Weekday(Now()) + x, Now())
            ComboDaySource.Add(x, FirstDate.ToString("dddd").ToUpper)
        Next x

        ComboStartDay.DataSource = New BindingSource(ComboDaySource, Nothing)
        ComboStartDay.DisplayMember = "Value"
        ComboStartDay.ValueMember = "Key"

        ComboEndDay.DataSource = New BindingSource(ComboDaySource, Nothing)
        ComboEndDay.DisplayMember = "Value"
        ComboEndDay.ValueMember = "Key"

        For x = 1 To 12
            ComboMonthSource.Add(x, MonthName(x).ToUpper)
        Next x

        ComboStartMonth.DataSource = New BindingSource(ComboMonthSource, Nothing)
        ComboStartMonth.DisplayMember = "Value"
        ComboStartMonth.ValueMember = "Key"

        ComboEndMonth.DataSource = New BindingSource(ComboMonthSource, Nothing)
        ComboEndMonth.DisplayMember = "Value"
        ComboEndMonth.ValueMember = "Key"

        'For x = 0 To 23
        'ComboHourSource.Add(x, Format(x, "00"))
        'Next

        'ComboStartHour.DataSource = New BindingSource(ComboHourSource, Nothing)
        'ComboStartHour.DisplayMember = "Value"
        'ComboStartHour.ValueMember = "Key"

        'ComboEndHour.DataSource = New BindingSource(ComboHourSource, Nothing)
        'ComboEndHour.DisplayMember = "Value"
        'ComboEndHour.ValueMember = "Key"

        'For x = 0 To 60 Step 5
        'ComboMinuteSource.Add(x, Format(x, "00"))
        'Next

        'ComboStartMinutes.DataSource = New BindingSource(ComboMinuteSource, Nothing)
        'ComboStartMinutes.DisplayMember = "Value"
        'ComboStartMinutes.ValueMember = "Key"

        'ComboEndMinutes.DataSource = New BindingSource(ComboMinuteSource, Nothing)
        'ComboEndMinutes.DisplayMember = "Value"
        'ComboEndMinutes.ValueMember = "Key"
    End Sub

    Private Sub TestApp()
        Dim InternetTime As Date
        Dim IsDST As Boolean
        Dim NewDate As Date
        Dim LocalDate As Date
        Dim TimeChanged As Boolean
        Dim Message As String
        Dim DSTState As Boolean

        GetDSTDates()
        ListTest.Items.Clear()

        InternetTime = GetInternetTime()

        ListTest.Items.Add("GMT TIME = " & InternetTime)

        NewDate = GetLocalTime(InternetTime)
        IsDST = IsDaylightSavings(NewDate)

        Message = "RESTAURANT TIME =  " & NewDate & " (TIME ZONE ADJ: " & GMTAdjustment

        If AdjustDST = False Then
            Message = Message & ", DST ADJUSTMENT DISABLED)"
        Else
            Message = Message & ", DST = " & UCase(IsDST.ToString) & ")"
        End If

        ListTest.Items.Add(Message)

        'next, change computer clock. Set back 5 minutes to test.
        LocalDate = DateAdd("s", -300, NewDate)

        ChangeDate(LocalDate)

        If DateDiff("s", Now(), NewDate) > 240 Then
            TimeChanged = True
        End If

        If TimeChanged Then
            'Then set to new time
            ChangeDate(NewDate)
        End If

        If Math.Abs(DateDiff("s", Now(), NewDate)) > 10 Then
            TimeChanged = False
        End If

        ListTest.Items.Add("")

        If TimeChanged Then
            ListTest.Items.Add("TIME CHANGED SUCCESSFULLY")
        Else
            ListTest.Items.Add("TIME NOT CHANGED. MAKE SURE TO RUN WITH ADMIN PRIVILEGES")
        End If

        'go through each day for the next five years and list DST start & end dates
        ListTest.Items.Add("")

        DSTState = IsDST
        DSTYear = Year(Now())

        Do While DSTYear < Year(Now()) + 10
            NewDate = DateAdd("d", 1, NewDate)

            IsDST = IsDaylightSavings(NewDate)

            If DSTYear <> Year(NewDate) Then
                ListTest.Items.Add("")
                DSTYear = Year(NewDate)
            End If

            If IsDST <> DSTState Then
                If IsDST Then
                    ListTest.Items.Add("DST BEGINS " & UCase(Format(NewDate, "dddd MMMM dd, yyyy")).ToString())
                Else
                    ListTest.Items.Add("DST ENDS " & UCase(Format(NewDate, "dddd MMMM dd, yyyy")).ToString())
                End If

                DSTState = IsDST
            End If
        Loop

        MsgBox("TEST COMPLETE")
    End Sub
    Private Function GetInternetTime() As Date
        Const ntpServer As String = "pool.ntp.org"
        Dim ntpData = New Byte(47) {}
        ntpData(0) = &H1B 'LeapIndicator = 0 (no warning), VersionNum = 3 (IPv4 only), Mode = 3 (Client Mode)

        Dim addresses = Dns.GetHostEntry(ntpServer).AddressList
        Dim ipEndPoint = New IPEndPoint(addresses(0), 123)
        Dim socket = New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)

        socket.Connect(ipEndPoint)
        socket.Send(ntpData)
        socket.Receive(ntpData)
        socket.Close()

        Dim intPart As ULong = CULng(ntpData(40)) << 24 Or CULng(ntpData(41)) << 16 Or CULng(ntpData(42)) << 8 Or CULng(ntpData(43))
        Dim fractPart As ULong = CULng(ntpData(44)) << 24 Or CULng(ntpData(45)) << 16 Or CULng(ntpData(46)) << 8 Or CULng(ntpData(47))

        Dim milliseconds = (intPart * 1000) + ((fractPart * 1000) \ &H100000000L)
        Dim networkDateTime = (New Date(1900, 1, 1)).AddMilliseconds(CLng(milliseconds))

        Return networkDateTime
    End Function

    Private Function GetLocalTime(GMTTime As Date) As Date
        Dim NewDate

        NewDate = DateAdd("h", GMTAdjustment, GMTTime)

        If AdjustDST And IsDaylightSavings(NewDate) Then
            NewDate = DateAdd("h", 1, NewDate)
        End If

        GetLocalTime = NewDate
    End Function

    Private Sub ChangeDate(NewDate As Date)
        Dim st As SYSTEMTIME

        st.year = NewDate.Year
        st.month = NewDate.Month
        st.dayOfWeek = NewDate.DayOfWeek
        st.day = NewDate.Day
        st.hour = NewDate.Hour
        st.minute = NewDate.Minute
        st.second = NewDate.Second
        st.milliseconds = NewDate.Millisecond

        'Set the new time...
        SetLocalTime(st)
    End Sub

    Private Sub ChangeDateOld(NewUTCDate As Date)
        Dim st As SYSTEMTIME
        Dim localZone As TimeZoneInfo
        Dim NewDate As Date
        Dim DateAdjString As String
        Dim DateAdj As Double

        localZone = TimeZoneInfo.Local

        DateAdjString = localZone.BaseUtcOffset.ToString

        DateAdj = CDbl(Val(DateAdjString))

        NewDate = DateAdd("h", DateAdj, NewUTCDate)

        st.year = NewDate.Year
        st.month = NewDate.Month
        st.dayOfWeek = NewDate.DayOfWeek
        st.day = NewDate.Day
        st.hour = NewDate.Hour
        st.minute = NewDate.Minute
        st.second = NewDate.Second
        st.milliseconds = NewDate.Millisecond

        'Set the new time...
        SetLocalTime(st)
    End Sub

    Sub PopulateForm()
        CheckBoxAdjustDST.Checked = AdjustDST
        ComboGMTAdjustment.SelectedValue = GMTAdjustment

        ComboStartMonth.SelectedValue = StartMonth
        ComboStartDay.SelectedValue = StartDay
        ComboStartOccurance.SelectedValue = StartOccurance
        'ComboStartHour.SelectedValue = StartHour
        'ComboStartMinutes.SelectedValue = StartMinute

        ComboEndMonth.SelectedValue = EndMonth
        ComboEndDay.SelectedValue = EndDay
        ComboEndOccurance.SelectedValue = EndOccurance
        'ComboEndHour.SelectedValue = EndHour
        'ComboEndMinutes.SelectedValue = EndMinute

    End Sub
    Private Function IsDaylightSavings(ThisDate As Date) As Boolean
        Dim OnAfterStartDate As Boolean
        Dim OnAfterEndDate As Boolean

        OnAfterStartDate = OnAfterTargetDate(ThisDate, StartMonth, StartOccurance, StartDay)
        OnAfterEndDate = OnAfterTargetDate(ThisDate, EndMonth, EndOccurance, EndDay)

        If OnAfterStartDate = True And OnAfterEndDate = False Then Return True
    End Function

    Private Function OnAfterTargetDate(ThisDate, TargetMonth, TargetOccurance, TargetDay) As Boolean
        Dim Occ
        Dim EOM
        Dim DSTDate As Date
        Dim DaysToTarget

        DSTDate = DateSerial(Year(ThisDate), TargetMonth, 1)

        EOM = DateAdd("m", 1, DSTDate)
        EOM = DateAdd("d", -MVB.DateAndTime.Day(EOM), EOM)

        Occ = TargetOccurance 'initialize
        If Weekday(DSTDate) = TargetDay Then Occ = Occ - 1

        DaysToTarget = Occ * 7 + 1

        DSTDate = DateAdd("d", DaysToTarget - Weekday(DSTDate), DSTDate)
        If Month(DSTDate) <> TargetMonth Then DSTDate = DateAdd("d", -7, DSTDate)

        'MsgBox(DSTDate)

        If DateDiff("s", DSTDate, ThisDate) >= 0 Then Return True

    End Function

    Private Sub GetDSTDates()
        AdjustDST = CheckBoxAdjustDST.Checked
        GMTAdjustment = DirectCast(ComboGMTAdjustment.SelectedItem, KeyValuePair(Of SByte, String)).Key

        StartMonth = DirectCast(ComboStartMonth.SelectedItem, KeyValuePair(Of Byte, String)).Key
        StartDay = DirectCast(ComboStartDay.SelectedItem, KeyValuePair(Of Byte, String)).Key
        StartOccurance = DirectCast(ComboStartOccurance.SelectedItem, KeyValuePair(Of Byte, String)).Key
        'StartHour = DirectCast(ComboStartHour.SelectedItem, KeyValuePair(Of Byte, String)).Key
        'StartMinute = DirectCast(ComboStartMinutes.SelectedItem, KeyValuePair(Of Byte, String)).Key

        EndMonth = DirectCast(ComboEndMonth.SelectedItem, KeyValuePair(Of Byte, String)).Key
        EndDay = DirectCast(ComboEndDay.SelectedItem, KeyValuePair(Of Byte, String)).Key
        EndOccurance = DirectCast(ComboEndOccurance.SelectedItem, KeyValuePair(Of Byte, String)).Key
        'EndHour = DirectCast(ComboEndHour.SelectedItem, KeyValuePair(Of Byte, String)).Key
        'EndMinute = DirectCast(ComboEndMinutes.SelectedItem, KeyValuePair(Of Byte, String)).Key
    End Sub

    Private Sub WriteToFile(Text As String, Optional Append As Boolean = False)
        Dim FilePath = Application.ExecutablePath
        Dim FileName = Path.GetFileName(FilePath)

        FilePath = MVB.Left(FilePath, Len(FilePath) - Len(FileName)) & "Settings.txt"

        Dim Writer = New StreamWriter(FilePath, Append)

        If Append = True Then Text = vbCr & Text

        Writer.Write(Text)
        Writer.Close()
    End Sub

    Private Function ReadFile() As String()
        Dim FilePath = Application.ExecutablePath
        Dim FileName = Path.GetFileName(FilePath)
        Dim FileText
        Dim TextLines() As String
        Dim c As Int32 = -1

        FilePath = MVB.Left(FilePath, Len(FilePath) - Len(FileName)) & "Settings.txt"

        If My.Computer.FileSystem.FileExists(FilePath) = False Then
            Exit Function
        End If

        Dim Reader = New StreamReader(FilePath)

        Do While Reader.EndOfStream = False
            c = c + 1
            FileText = Reader.ReadLine()
            ReDim Preserve TextLines(c)
            TextLines(c) = FileText
        Loop

        Reader.Close()
        ReadFile = TextLines
    End Function

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub ButtonTest_Click(sender As Object, e As EventArgs) Handles ButtonTest.Click
        TestApp()
    End Sub

    Private Sub ButtonAccept_Click(sender As Object, e As EventArgs) Handles ButtonAccept.Click
        AcceptDates()
        Me.Close()
    End Sub
End Class
