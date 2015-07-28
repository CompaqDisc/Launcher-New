Imports System.IO

Public Class Form1
    Dim SL As String = ".\Settings.ini"

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowManager()
        CheckConfig()
    End Sub

    Private Sub WindowManager()
        Size = SystemInformation.PrimaryMonitorSize
        Location = New Point(0, 0)
        TopMost = True
        'TransparencyKey = Color.Transparent
        'SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        'BackColor = Color.Transparent
    End Sub

    Private Sub CheckConfig()
        Dim SLF As String = ".\SettingsLocation.txt"
        If (File.Exists(SLF)) Then
            Using sr As StreamReader = File.OpenText(SLF)
                SL = sr.ReadLine()
                Console.WriteLine("Settings file is reported at: " & SL)
            End Using
        Else
            Using sw As StreamWriter = File.CreateText(SLF)
                sw.WriteLine(SL)
                sw.Close()
            End Using
        End If
        If File.Exists(SL) Then
            ReadSettings()
        Else
            WriteInitialSettings()
            ReadSettings()
        End If
    End Sub

    Private Sub ReadSettings()
        Dim sf As IniFile
        sf.Load(SL)
    End Sub

    Private Sub WriteInitialSettings()
        Dim sf As New IniFile
        sf.AddSection("BOX_SETTINGS").AddKey("HBoxes").Value = "8"
        sf.AddSection("BOX_SETTINGS").AddKey("VBoxes").Value = "4"
        sf.AddSection("BOX_SETTINGS").AddKey("BoxIsSquare").Value = "true"
        sf.Save(SL)
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles TempCloseBtn.Click
        Application.Exit()
        End
    End Sub
End Class
