Public Class main
    Dim estTime As String
    'Delegate Sub SetTextCallback([text] As String)
    'Delegate Sub TextCallback([text] As String)
    'Delegate Sub ProBar([val] As Integer)
    'Dim procentfinished As Integer = 0
    Dim mainexedir As IO.DirectoryInfo = New IO.DirectoryInfo("C:\ViruScan")
    Dim mainupdtdir As IO.DirectoryInfo = New IO.DirectoryInfo("C:\ViruScan\Updates")
    Dim mainupdtlist As IO.FileInfo = New IO.FileInfo("C:\ViruScan\Updates\updt-latest.txt")
    '///////////////
    Dim status As String
    '////////////////
    Dim scanthread As New Threading.Thread(AddressOf scan)
    '//////////////
    Dim processes() As String
    Dim processesmwtitle() As String
    Dim processnum, scannedfiles As Integer
    Dim viruses() As String
    Dim virusfiles() As IO.FileInfo
    '///////////////
    Dim itemsscanned As Integer
    Dim susfound As Integer
    Dim virusesfound As Integer
    '///////////////
    Dim ProBarVal As Integer

    Private Sub StartStopButton_Click(sender As System.Object, e As System.EventArgs) Handles StartStopButton.Click
        Try
            scanthread.Start()
            scanthread.IsBackground = True
            StartStopButton.Enabled = False
            MainLabel.Text = "Scan running..."
        Catch ex As Exception
            MsgBox("ERROR: " + ex.Message)
        End Try
    End Sub
    Public Sub CheckProcesses()
        status = "Listing running processes"
        'RefreshStatus()
        For Each p As Process In Process.GetProcesses
            ReDim Preserve processes(processnum)
            processes(processnum) = p.ProcessName
            ReDim Preserve processesmwtitle(processnum)
            processesmwtitle(processnum) = p.MainWindowTitle
            processnum += 1
        Next
    End Sub

    'Public Sub RefreshStatus()
    'setstatustext(status)
    'End Sub

    'Public Sub RefreshScannedFiles()
    'setsftext(scannedfiles + " Files Scanned")
    'End Sub

    Public Sub SetProBar(ByVal value As Integer)
        'changeval(value)
        ProBarVal = value
    End Sub

    'Public Sub setstatustext(ByVal [text] As String)
    'If Me.LabelStatus.InvokeRequired Then
    'Dim d As New SetTextCallback(AddressOf setstatustext)
    'Me.Invoke(d, New Object() {[text]})
    'Else
    'Me.LabelStatus.Text = [text]
    'End If
    'End Sub

    'Public Sub setsftext(ByVal [text] As String)
    'If Me.ItemsScannedLabel.InvokeRequired Then
    'Dim d As New TextCallback(AddressOf setsftext)
    'Me.Invoke(d, New Object() {[text]})
    'Else
    'Me.ItemsScannedLabel.Text = [text]
    'End If
    'End Sub

    'Public Sub changeval(ByVal [val] As Integer)
    'If Me.MainProgressBar.InvokeRequired Then
    'Dim d As New ProBar(AddressOf changeval)
    'Me.Invoke(d, New Object() {[val]})
    'Else
    'Me.MainProgressBar.Value = [val]
    'End If
    'End Sub
    Private Sub CancelButton_Click(sender As System.Object, e As System.EventArgs) Handles CancelButton.Click
        scanthread.Abort()
        scanthread.Join()
        status = "Scan aborted - Restart program to try again"
        'RefreshStatus()
    End Sub
    Public Sub scan()
        SetProBar(1)
        status = "Checking Main Files"
        'RefreshStatus()
        If Not mainexedir.Exists Then mainexedir.Create()
        If Not mainupdtdir.Exists Then mainupdtdir.Create()
        'UpdateNow()
        SetProBar(10)
        CheckProcesses()
        status = "Scanning System Directory"
        'RefreshStatus()
        ScanDir(New IO.DirectoryInfo("C:\Windows\System32"))
        SetProBar(20)
        ScanDir(New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup)))
        SetProBar(40)
        ScanDir(New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)))
        SetProBar(50)
        ScanDir(New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)))
        SetProBar(70)
        ScanDir(New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)))
        SetProBar(80)
        ScanDir(New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Favorites)))
        status = "Finished scanning!"
        'RefreshStatus()
        SetProBar(0)
    End Sub
    Public Sub ScanDir(ByVal dir As IO.DirectoryInfo)
        Try
            Dim subdir As IO.DirectoryInfo
            Dim file As IO.FileInfo
            For Each file In dir.GetFiles
                ScanFile(file)
            Next
            For Each subdir In dir.GetDirectories
                ScanDir(subdir)
            Next
        Catch ex As Exception

        End Try
    End Sub
    Public Sub ScanFile(ByVal file As IO.FileInfo)
        Try
            'Dim viruses(5) As String
            'viruses(0) = "virus.exe"
            'viruses(1) = "autorun.inf"
            'viruses(2) = "autorun.exe"
            'viruses(3) = "c.exe"
            'viruses(4) = "a.exe"
            status = "Scanning file: " + file.Name
            itemsscanned += 1
            If (file.Attributes And IO.FileAttributes.Hidden) <> 0 Then
                addsuspfile(file)
            End If
            If file.Extension = ".bat" Then
                addsuspfile(file)
            End If
            If file.Extension = ".exe" Then
                addsuspfile(file)
            End If
            ' Dim item As String
            'For Each item In viruses
            'If file.FullName = item Then
            'addsuspfile(file)
            'End If
            'Next
            For i = 0 To viruses.GetUpperBound(0)
                If file.Name = viruses(i) Then
                    addsuspfile(file)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Public Sub addsuspfile(ByVal file As IO.FileInfo)
        susfound += 1
        'ReDim Preserve virusfiles(susfound)
        'virusfiles(susfound) = file
    End Sub

    Private Sub MainTimer_Tick(sender As System.Object, e As System.EventArgs) Handles MainTimer.Tick
        ItemsScannedLabel.Text = itemsscanned.ToString + " items scanned"
        SuspFilesFoundLabel.Text = susfound.ToString + " suspicious files found"
        LabelStatus.Text = status
        MainProgressBar.Value = ProBarVal
    End Sub

    Private Sub main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub
End Class
