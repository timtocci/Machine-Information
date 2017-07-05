Imports System.Threading

Public Class Output
    Dim retText As String = ""
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' add some custom query as a default
        txtCustom.Text = "SELECT Caption, SerialNumber FROM Win32_OperatingSystem"
    End Sub


    Private Sub getProduct()
        retText = ""
        ' ContextSwitchDeadlock Exception
        retText &= "MachineInfo.getProduct" & vbCrLf
        retText &= "SELECT * FROM Win32_Product" & vbCrLf & vbCrLf
        Dim productList As List(Of Dictionary(Of String, String)) = MachineInfo.getProduct
        For i As Integer = 0 To productList.Count - 1
            Dim dic As Dictionary(Of String, String) = productList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next
    End Sub

    Private Sub getInfo()
        retText = ""
        retText &= "MachineInfo.getOperatingSystem" & vbCrLf
        retText &= "SELECT * FROM Win32_OperatingSystem" & vbCrLf & vbCrLf
        Dim operatingSystemList As List(Of Dictionary(Of String, String)) = MachineInfo.getOperatingSystem
        For i As Integer = 0 To operatingSystemList.Count - 1
            Dim dic As Dictionary(Of String, String) = operatingSystemList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getComputerSystem" & vbCrLf
        retText &= "SELECT * FROM Win32_ComputerSystem" & vbCrLf & vbCrLf
        Dim computerSystemList As List(Of Dictionary(Of String, String)) = MachineInfo.getComputerSystem
        For i As Integer = 0 To computerSystemList.Count - 1
            Dim dic As Dictionary(Of String, String) = computerSystemList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getBootConfiguration" & vbCrLf
        retText &= "SELECT * FROM Win32_BootConfiguration" & vbCrLf & vbCrLf
        Dim bootConfigurationList As List(Of Dictionary(Of String, String)) = MachineInfo.getBootConfiguration
        For i As Integer = 0 To bootConfigurationList.Count - 1
            Dim dic As Dictionary(Of String, String) = bootConfigurationList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getLocalTime" & vbCrLf
        retText &= "SELECT * FROM Win32_LocalTime" & vbCrLf & vbCrLf
        Dim localTimeList As List(Of Dictionary(Of String, String)) = MachineInfo.getLocalTime
        For i As Integer = 0 To localTimeList.Count - 1
            Dim dic As Dictionary(Of String, String) = localTimeList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getTimeZone" & vbCrLf
        retText &= "SELECT * FROM Win32_TimeZone" & vbCrLf & vbCrLf
        Dim timeZoneList As List(Of Dictionary(Of String, String)) = MachineInfo.getTimeZone
        For i As Integer = 0 To timeZoneList.Count - 1
            Dim dic As Dictionary(Of String, String) = timeZoneList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getLogonSession" & vbCrLf
        retText &= "SELECT * FROM Win32_LogonSession" & vbCrLf & vbCrLf
        Dim logonSessionList As List(Of Dictionary(Of String, String)) = MachineInfo.getLogonSession
        For i As Integer = 0 To logonSessionList.Count - 1
            Dim dic As Dictionary(Of String, String) = logonSessionList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getNetworkLoginProfile" & vbCrLf
        retText &= "SELECT * FROM Win32_NetworkLoginProfile" & vbCrLf & vbCrLf
        Dim networkLoginProfileList As List(Of Dictionary(Of String, String)) = MachineInfo.getNetworkLoginProfile
        For i As Integer = 0 To networkLoginProfileList.Count - 1
            Dim dic As Dictionary(Of String, String) = networkLoginProfileList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next


        retText &= vbCrLf & vbCrLf & "MachineInfo.getUserAccount" & vbCrLf
        retText &= "SELECT * FROM Win32_UserAccount" & vbCrLf & vbCrLf
        Dim userAccountList As List(Of Dictionary(Of String, String)) = MachineInfo.getUserAccount
        For i As Integer = 0 To userAccountList.Count - 1
            Dim dic As Dictionary(Of String, String) = userAccountList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getGroup" & vbCrLf
        retText &= "SELECT * FROM Win32_Group" & vbCrLf & vbCrLf
        Dim groupList As List(Of Dictionary(Of String, String)) = MachineInfo.getGroup
        For i As Integer = 0 To groupList.Count - 1
            Dim dic As Dictionary(Of String, String) = groupList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next



        retText &= vbCrLf & vbCrLf & "MachineInfo.getCodecFile" & vbCrLf
        retText &= "SELECT * FROM Win32_CodecFile" & vbCrLf & vbCrLf
        Dim codecFileList As List(Of Dictionary(Of String, String)) = MachineInfo.getCodecFile
        For i As Integer = 0 To codecFileList.Count - 1
            Dim dic As Dictionary(Of String, String) = codecFileList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getBaseBoard" & vbCrLf
        retText &= "SELECT * FROM Win32_BaseBoard" & vbCrLf & vbCrLf
        Dim baseBoardList As List(Of Dictionary(Of String, String)) = MachineInfo.getBaseBoard
        For i As Integer = 0 To baseBoardList.Count - 1
            Dim dic As Dictionary(Of String, String) = baseBoardList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getBIOS" & vbCrLf
        retText &= "SELECT * FROM Win32_BIOS" & vbCrLf & vbCrLf
        Dim BIOSList As List(Of Dictionary(Of String, String)) = MachineInfo.getBIOS
        For i As Integer = 0 To BIOSList.Count - 1
            Dim dic As Dictionary(Of String, String) = BIOSList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getProcessor" & vbCrLf
        retText &= "SELECT * FROM Win32_Processor" & vbCrLf & vbCrLf
        Dim processorList As List(Of Dictionary(Of String, String)) = MachineInfo.getProcessor
        For i As Integer = 0 To processorList.Count - 1
            Dim dic As Dictionary(Of String, String) = processorList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getDesktopMonitor" & vbCrLf
        retText &= "SELECT * FROM Win32_DesktopMonitor" & vbCrLf & vbCrLf
        Dim desktopMonitorList As List(Of Dictionary(Of String, String)) = MachineInfo.getDesktopMonitor
        For i As Integer = 0 To desktopMonitorList.Count - 1
            Dim dic As Dictionary(Of String, String) = desktopMonitorList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getVideoController" & vbCrLf
        retText &= "SELECT * FROM Win32_VideoController" & vbCrLf & vbCrLf
        Dim videoControllerList As List(Of Dictionary(Of String, String)) = MachineInfo.getVideoController
        For i As Integer = 0 To videoControllerList.Count - 1
            Dim dic As Dictionary(Of String, String) = videoControllerList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getKeyboard" & vbCrLf
        retText &= "SELECT * FROM Win32_Keyboard" & vbCrLf & vbCrLf
        Dim keyboardList As List(Of Dictionary(Of String, String)) = MachineInfo.getKeyboard
        For i As Integer = 0 To keyboardList.Count - 1
            Dim dic As Dictionary(Of String, String) = keyboardList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getPointingDevice" & vbCrLf
        retText &= "SELECT * FROM Win32_PointingDevice" & vbCrLf & vbCrLf
        Dim pointingDeviceList As List(Of Dictionary(Of String, String)) = MachineInfo.getPointingDevice
        For i As Integer = 0 To pointingDeviceList.Count - 1
            Dim dic As Dictionary(Of String, String) = pointingDeviceList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.get1394Controller" & vbCrLf
        retText &= "SELECT * FROM Win32_1394Controller" & vbCrLf & vbCrLf
        Dim controller1394List As List(Of Dictionary(Of String, String)) = MachineInfo.get1394Controller
        For i As Integer = 0 To controller1394List.Count - 1
            Dim dic As Dictionary(Of String, String) = controller1394List(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getParallelPort" & vbCrLf
        retText &= "SELECT * FROM Win32_ParallelPort" & vbCrLf & vbCrLf
        Dim parallelPortList As List(Of Dictionary(Of String, String)) = MachineInfo.getParallelPort
        For i As Integer = 0 To parallelPortList.Count - 1
            Dim dic As Dictionary(Of String, String) = parallelPortList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getPCMCIAController" & vbCrLf
        retText &= "SELECT * FROM Win32_PCMCIAController" & vbCrLf & vbCrLf
        Dim PCMCIAControllerList As List(Of Dictionary(Of String, String)) = MachineInfo.getPCMCIAController
        For i As Integer = 0 To PCMCIAControllerList.Count - 1
            Dim dic As Dictionary(Of String, String) = PCMCIAControllerList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getIDEControllerDevice" & vbCrLf
        retText &= "SELECT * FROM Win32_IDEControllerDevice" & vbCrLf & vbCrLf
        Dim IDEControllerList As List(Of Dictionary(Of String, String)) = MachineInfo.getIDEControllerDevice
        For i As Integer = 0 To IDEControllerList.Count - 1
            Dim dic As Dictionary(Of String, String) = IDEControllerList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getSCSIController" & vbCrLf
        retText &= "SELECT * FROM Win32_SCSIController" & vbCrLf & vbCrLf
        Dim SCSIControllerList As List(Of Dictionary(Of String, String)) = MachineInfo.getSCSIController
        For i As Integer = 0 To SCSIControllerList.Count - 1
            Dim dic As Dictionary(Of String, String) = SCSIControllerList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getSerialPort" & vbCrLf
        retText &= "SELECT * FROM Win32_SerialPort" & vbCrLf & vbCrLf
        Dim serialPortList As List(Of Dictionary(Of String, String)) = MachineInfo.getSerialPort
        For i As Integer = 0 To serialPortList.Count - 1
            Dim dic As Dictionary(Of String, String) = serialPortList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getUSBHub" & vbCrLf
        retText &= "SELECT * FROM Win32_USBHub" & vbCrLf & vbCrLf
        Dim USBHubList As List(Of Dictionary(Of String, String)) = MachineInfo.getUSBHub
        For i As Integer = 0 To USBHubList.Count - 1
            Dim dic As Dictionary(Of String, String) = USBHubList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next

        retText &= vbCrLf & vbCrLf & "MachineInfo.getSoundDevice" & vbCrLf
        retText &= "SELECT * FROM Win32_SoundDevice" & vbCrLf & vbCrLf
        Dim soundDeviceList As List(Of Dictionary(Of String, String)) = MachineInfo.getSoundDevice
        For i As Integer = 0 To soundDeviceList.Count - 1
            Dim dic As Dictionary(Of String, String) = soundDeviceList(i)
            For Each keyvalpair As KeyValuePair(Of String, String) In dic
                retText &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
            Next
            retText &= "*******************************" & vbCrLf
        Next
    End Sub

    Private Sub btnServices_Click(sender As Object, e As EventArgs) Handles btnServices.Click
        btnServices.Enabled = False
        txtOut.WordWrap = True
        Dim servicesThread As Thread
        servicesThread = New Thread(AddressOf getServices)
        servicesThread.Start()
        Do Until servicesThread.ThreadState = ThreadState.Stopped
        Loop
        txtOut.Text = retText
        retText = ""
        btnServices.Enabled = True
    End Sub
    Private Sub getServices()
        retText = ""
        retText &= "MachineInfo.getRunningServices" & vbCrLf & vbCrLf
        Dim rServList As List(Of RunningServiceStructure)
        rServList = MachineInfo.getRunningServices()
        For Each service As RunningServiceStructure In rServList
            retText &= service.Name & vbCrLf
            retText &= service.DisplayName & vbCrLf
            retText &= service.Description & vbCrLf
            retText &= vbCrLf
        Next
    End Sub

    Private Sub btnProcesses_Click(sender As Object, e As EventArgs) Handles btnProcesses.Click
        btnProcesses.Enabled = False
        txtOut.WordWrap = False
        txtOut.Text = ""
        txtOut.Text &= "MachineInfo.getProcess" & vbCrLf & vbCrLf
        Dim processArr As Array = MachineInfo.getProcess
        For Each p As Process In processArr
            txtOut.Text &= p.ProcessName & ": " & p.Id.ToString() & vbCrLf
        Next
        btnProcesses.Enabled = True
    End Sub

    Private Sub btnCustom_Click(sender As Object, e As EventArgs) Handles btnCustom.Click
        btnCustom.Enabled = False
        txtOut.WordWrap = False
        Try
            txtOut.Text = ""
            txtOut.Text = "MachineInfo.queryWMI('" & txtCustom.Text & "')" & vbCrLf & vbCrLf
            Dim queryList As List(Of Dictionary(Of String, String)) = MachineInfo.queryWMI(txtCustom.Text)
            For i As Integer = 0 To queryList.Count - 1
                Dim dic As Dictionary(Of String, String) = queryList(i)
                For Each keyvalpair As KeyValuePair(Of String, String) In dic
                    txtOut.Text &= keyvalpair.Key & ": " & keyvalpair.Value & vbCrLf
                Next
            Next
        Catch smex As Management.ManagementException
            txtCustom.Text = smex.Message
        End Try
        btnCustom.Enabled = True
    End Sub

    Private Sub btnGetInfo_Click(sender As Object, e As EventArgs) Handles btnGetInfo.Click
        btnGetInfo.Enabled = False
        txtOut.WordWrap = False
        Dim infoThread As Thread
        infoThread = New Thread(AddressOf getInfo)
        infoThread.Start()
        Do Until infoThread.ThreadState = ThreadState.Stopped
        Loop
        txtOut.Text = retText
        retText = ""
        btnGetInfo.Enabled = True
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        btnProducts.Enabled = False
        Dim productThread As Thread
        productThread = New Thread(AddressOf getProduct)
        productThread.Start()
        Do Until productThread.ThreadState = ThreadState.Stopped
        Loop
        txtOut.Text = retText
        retText = ""
        btnProducts.Enabled = True
    End Sub
End Class
