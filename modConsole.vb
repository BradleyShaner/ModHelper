Module modConsole
    Public Silent As Boolean = False

    Sub Main()
        Dim bHelp As Boolean
        Console.Title = "LANConnecter"
        If My.Application.CommandLineArgs.Count > 0 Then
            'Call ShowFolders() : Console.ReadKey()
            Environment.CurrentDirectory = System.AppDomain.CurrentDomain.BaseDirectory()
            'Console.WriteLine("Original code and concept by NTAuthority of alterIW.net")
            'Console.WriteLine()
            Select Case Trim(LCase(My.Application.CommandLineArgs(0)))

                Case Else
                    Dim Temp As String
                    Dim strArray() As String
                    Temp = Replace(LCase(My.Application.CommandLineArgs(0)), "aiw://", "")
                    Temp = Replace(Temp, "lan://", "")

                    strArray = Split(Temp, "/")

                    For i = LBound(strArray) To UBound(strArray)

                        Select Case (strArray(i))

                            Case Is = "connect"
                                Dim strArgs As String
                                If i + 1 <= UBound(strArray) Then
                                    strArgs = "lan://connect/" & strArray(i + 1)
                                    i += 1
                                    If ConnectionManager.CheckProcess = True Then
                                        ConnectionManager.Handle(strArgs, True)
                                    Else
                                        ConnectionManager.Handle(strArgs, False)
                                    End If
                                End If

                            Case Is = "start"
                                If ConnectionManager.StartMW2() = False Then
                                    Console.WriteLine("MW2 could not be started!")
                                    Console.ReadKey(True)
                                End If

                            Case Is = "uninstall"
                                ConnectionManager.UnInstall()

                            Case Is = "suninstall"
                                Silent = True
                                ConnectionManager.UnInstall()

                            Case Is = "sinstall"
                                Silent = True
                                ConnectionManager.Install()

                            Case Is = "install"
                                ConnectionManager.Install()

                            Case Is = "pause"
                                Console.ReadKey()

                            Case Is = "help"
                                PrintHelp()
                                End

                            Case Else
                                If Len(strArray(i)) > 1 Then Console.WriteLine("Unknown command: " & strArray(i)) : bHelp = True
                        End Select

                    Next

            End Select

        Else
            bHelp = True
        End If
        If bHelp = True Then Console.Clear() : PrintHelp()
        End

    End Sub

    'Public Sub ShowFolders()
    '    Console.WriteLine("1 " & System.AppDomain.CurrentDomain.BaseDirectory()) : Console.WriteLine()
    '    Console.WriteLine("2 " & System.Reflection.Assembly.GetExecutingAssembly.Location.ToString) : Console.WriteLine()
    '    Console.WriteLine("CurrDir: " & Environment.CurrentDirectory) : Console.WriteLine()
    '    Console.WriteLine("Initial: " & Environment.CurrentDirectory) : Console.WriteLine()
    'End Sub

    Public Sub PrintHelp()
        On Error GoTo err
        Dim cki As ConsoleKeyInfo
        Dim temp As String

        'Console.Clear()
        Console.WriteLine("Original code and concept by NTAuthority of alterIW.net")
        Console.WriteLine()
        If My.Application.CommandLineArgs.Count > 0 Then Console.WriteLine("Your incorrect arguments: " & My.Application.CommandLineArgs(0)) : Console.WriteLine()

        Console.WriteLine("Correct Command Line Usage:")
        Console.WriteLine("To connect to a server: lan://connect/[IP/Hostname]:[PORT] (Default port: 28960)")
        Console.WriteLine("To install the lan:// protocol: /install")
        Console.WriteLine("to uninstall the lan:// protocol: /uninstall")
        Console.WriteLine("To just launch MW2: /start (lan://start in RUN.)")
        Console.WriteLine()
        Console.WriteLine("From RUN box: lan://<command>/<command>/")
        Console.WriteLine("RUN Example: lan://connect/192.168.1.100:28960")
        Console.WriteLine("From Command Prompt: LanConnecter.exe /<command>/<command>")
        Console.WriteLine("Command Prompt example: LanConnecter.exe /connect/192.168.1.100:28960")
        Console.WriteLine()


Start:

        Console.WriteLine("")
        Console.WriteLine("Enter the number to select an option:")
        Console.WriteLine("1. Install LANConnector's lan:// protocol.")
        Console.WriteLine("2. Install LANConnector as aiw:// protocol.")
        Console.WriteLine("3. Uninstall LANConnector's lan:// protocol.")
        Console.WriteLine("4. Start MW2 and connect to an IP and port")



        cki = Console.ReadKey(True)

        Select Case cki.KeyChar
            Case Is = "1"
                ConnectionManager.Install()
            Case Is = "2"
                ConnectionManager.Install(True)
            Case Is = "3"
                ConnectionManager.UnInstall()
            Case Is = "4"

                'Console.Clear()
repeat:         Console.WriteLine()
                Console.WriteLine("Please type the IP with the PORT you would like to connect to.")
                Console.WriteLine("(Or leave empty to return to menu)")
                Console.WriteLine("Example: 192.168.1.100:28960")
                Console.WriteLine()
                temp = Console.ReadLine

                If Len(temp) = 0 Then GoTo Start
                If Not InStr(temp, ":") > 0 Then Console.WriteLine("Error: No PORT specified. You must include the port after the colon.") : GoTo repeat
                If InStr(temp, "/") > 0 Then Console.WriteLine("Error: No slashes of any sort allowed. IP:Port only.") : GoTo repeat
                If InStr(temp, "\") > 0 Then Console.WriteLine("Error: No slashes of any sort allowed. IP:Port only.") : GoTo repeat

                If ConnectionManager.CheckProcess = True Then
                    Console.WriteLine("MW2 process detected, attempting to connect to server..")
                    ConnectionManager.Handle("lan://connect/" & temp, True)
                Else
                    ConnectionManager.Handle("lan://connect/" & temp, False)
                End If

        End Select

        End

err:
        Console.WriteLine()
        Console.WriteLine("Error: " & Err.Number & " - " & Err.Description)


    End Sub

End Module
