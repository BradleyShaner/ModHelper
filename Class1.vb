Imports Microsoft.Win32
Imports System
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.IO.File

    Public Class ConnectionManager
        ' Methods
        Private Shared Function GetEditText(ByVal hwnd As IntPtr) As String
            Dim capacity As Integer = ConnectionManager.SendMessage(hwnd, 14, 0, DirectCast(Nothing, StringBuilder))
            Dim lParam As New StringBuilder(capacity)
            ConnectionManager.SendMessage(hwnd, 13, CInt((capacity + 1)), lParam)
            Return lParam.ToString
        End Function

        Private Shared Function GetLogContent() As String
            Return ConnectionManager.GetEditText(ConnectionManager._hwndLog)
        End Function
    Public Shared Function CheckProcess() As Boolean
        If (Process.GetProcessesByName("iw4mp_server").Length > 1) Then
            Return True
        ElseIf (Process.GetProcessesByName("iw4mp_server.exe").Length > 0) Then
            Return True
        End If

        Return False
    End Function

    Public Shared Function StartMW2(Optional ByVal strFile As String = "iw4mp_server.exe") As Boolean
        If CheckProcess() = False Then
            'Console.WriteLine("Dir:" & Environment.CurrentDirectory())
            If Exists(Environment.CurrentDirectory() & "/" & strFile) Then
                If Form1.chkStart.Checked = False Then
                    Form1.Log("MW2 not found running!")
                Else
                    Form1.Log("MW2 not found, starting it..")
                    Application.DoEvents()
                    Try
                        Dim nProcess As New Process
                        With nProcess
                            .StartInfo.UseShellExecute = False
                            .StartInfo.FileName = strFile
                            .Start()
                        End With
                    Catch e As Exception
                        Form1.Log((e.Message))
                        Return False
                    End Try
                    Return True
                End If
            Else
                Form1.Log("MW2 was not found or could not be started.")
            End If
            'If Shell("iw4mp_server.exe", AppWinStyle.NormalFocus, False) > 0 Then StartMW2 = True
        Else
            'Console.WriteLine("iw4mp_server.exe does not exist.")
            Return True
        End If

        Return False
    End Function

    Public Shared Sub Handle(ByVal strString As String, ByVal isInitial As Boolean)
        If StartMW2() = False Then
            'Console.WriteLine()
            'Form1.Log("MW2 was not found or could not be started.")
            'End
        Else
            Application.DoEvents()
            ConnectionManager.PerformConnect(strString, isInitial)
        End If
    End Sub

    Private Shared Function OpenIW4Process() As IntPtr
        Dim processesByName As Process() = Process.GetProcessesByName("iw4mp_server.exe")
        Dim processArray2 As Process() = processesByName
        Dim index As Integer = 0
        Application.DoEvents()
        'Form1.Log("Waiting for MW2 to be ready..")
        Do While (index < processArray2.Length)
            Application.DoEvents()
            Dim process As Process = processArray2(index)
            Return process.Handle
        Loop
        Return IntPtr.Zero
    End Function

    Private Shared Sub PerformConnect(ByVal strString As String, ByVal isInitial As Boolean)
        Dim ptr As IntPtr = ConnectionManager.OpenIW4Process
        If (ptr <> IntPtr.Zero) Then

            ConnectionManager._process = ptr
            If ConnectionManager.WaitForConsole() = False Then Form1.Log("Timed out, please try again.")

            If Not isInitial Then
                If ConnectionManager.WaitForLog("LSPXUID") = False Then Form1.Log("Timed out, please try again.")
            End If
            ConnectionManager.SendToInput((strString))
            Form1.Log("Commands sent successfully!")
        Else
            Form1.Log("Error locating MW2's process!")
            End
        End If
    End Sub

    Private Shared Sub ReadInputHwnd()
        ConnectionManager._hwndInput = ConnectionManager.ReadIntPtr(ConnectionManager._hwndConsoleInpEditLoc)
    End Sub

    Private Shared Function ReadInt32(ByVal location As Integer) As Integer
        Dim num As Integer
        Dim lpBuffer As Byte() = New Byte(4 - 1) {}
        ConnectionManager.ReadProcessMemory(ConnectionManager._process, New IntPtr(location), lpBuffer, 4, num)
        Return BitConverter.ToInt32(lpBuffer, 0)
    End Function

    Private Shared Function ReadIntPtr(ByVal location As Integer) As IntPtr
        Return New IntPtr(ConnectionManager.ReadInt32(location))
    End Function

    Private Shared Sub ReadLogHwnd()
        ConnectionManager._hwndLog = ConnectionManager.ReadIntPtr(ConnectionManager._hwndConsoleLogEditLoc)
    End Sub

    <DllImport("kernel32.dll", SetLastError:=True)> _
    Private Shared Function ReadProcessMemory(ByVal hProcess As IntPtr, ByVal lpBaseAddress As IntPtr, <Out()> ByVal lpBuffer As Byte(), ByVal dwSize As Integer, <Out()> ByRef lpNumberOfBytesRead As Integer) As Boolean
    End Function

    <DllImport("user32.dll")> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInt32, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInt32, ByVal wParam As Integer, ByVal lParam As StringBuilder) As Integer
    End Function

    <DllImport("user32.dll")> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInt32, ByVal wParam As IntPtr, <MarshalAs(UnmanagedType.LPStr)> ByVal lParam As String) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInt32, ByVal wParam As IntPtr, ByVal lParam As StringBuilder) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As HandleRef, ByVal Msg As UInt32, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll")> _
    Private Shared Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As UInt32, ByVal wParam As IntPtr, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As IntPtr
    End Function

    Private Shared Sub SendToInput(ByVal [text] As String)
        ConnectionManager.SendMessage(ConnectionManager._hwndInput, 12, IntPtr.Zero, [text])
        ConnectionManager.SendMessage(ConnectionManager._hwndInput, &H102, 13, 0)
    End Sub

    Private Shared Function WaitForConsole() As Boolean
        'Form1.Log("Waiting for console")
        For i = 1 To 60
            ConnectionManager.ReadInputHwnd()
            ConnectionManager.ReadLogHwnd()
            If ((ConnectionManager._hwndInput <> IntPtr.Zero) AndAlso (ConnectionManager._hwndLog <> IntPtr.Zero)) Then
                Return True
            End If
            Application.DoEvents()
            Thread.Sleep(500)
            If IsEven(i) Then Form1.Log(".", True)
        Next
        Form1.Log("Timed out, please try again")
        Return False
    End Function

    Private Shared Function WaitForLog(ByVal contains As String) As Boolean
        'Form1.Log("Waiting for log")
        For i = 1 To 60
            Application.DoEvents()
            If IsEven(i) Then Form1.Log(".", True)
            If ConnectionManager.GetLogContent.Contains(contains) Then
                Return True
            End If

            Thread.Sleep(500)
        Next
        Form1.Log("Timed out, please try again")
        Return False
    End Function

    Public Shared Function IsEven(ByVal Number As Long) As Boolean
        IsEven = (Number Mod 2 = 0)
    End Function

    ' Fields
    Private Shared ReadOnly _hwndConsoleInpEditLoc As Integer = &H64FEEA8
    Private Shared ReadOnly _hwndConsoleLogEditLoc As Integer = &H64FEE9C
    Private Shared _hwndInput As IntPtr
    Private Shared _hwndLog As IntPtr
    Private Shared _process As IntPtr
    Public Const WM_CHAR As UInt32 = &H102
    Public Const WM_GETTEXT As UInt32 = 13
    Public Const WM_GETTEXTLENGTH As UInt32 = 14
    Public Const WM_SETTEXT As UInt32 = 12
End Class
