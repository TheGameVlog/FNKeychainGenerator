Imports Json.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.ComponentModel
Imports System.Net
Imports System.IO
Imports System.Collections.Specialized


Public Class Form1

    Dim base64Decoded As String = "base64 encoded string"
    Dim base64Encoded As String
    Dim data As Byte()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtGUID.Text = "" Then
            txtGUID.Focus()
            ErrorProvider1.SetError(txtGUID, "Cannot Be Left Blank")
            Exit Sub
        End If
        If txtAES.Text = "" Then
            txtAES.Focus()
            ErrorProvider1.SetError(txtAES, "Cannot Be Left Blank")
            Exit Sub
        End If
        Try
            txtKeychain.Text = txtGUID.Text & ":" & TheEncoder.HexStringToBase64(IIf(txtAES.Text.StartsWith("0x"), txtAES.Text.Replace("0x", ""), txtAES.Text))
        Catch ex As Exception
            ErrorProvider1.SetError(txtAES, "Invalid AES Key")
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAESGUIDs()
    End Sub

    Dim listAESGuid As New List(Of GUIDAESPAIR)

    Public Sub LoadAESGUIDs()
        Dim fetchAESGuids As New WebClient()
        Dim aesRaw = fetchAESGuids.DownloadString("https://fortnite-api.com/v2/aes")

        Dim rawKeys = JObject.Parse(aesRaw)("data")("dynamicKeys").ToString()

        Dim sColl = JsonConvert.DeserializeObject(Of List(Of GUIDAESPAIR))(rawKeys)

        listAESGuid = sColl

        Dim aesColl As New AutoCompleteStringCollection()

        aesColl.AddRange((From c In listAESGuid Select c.pakGuid).Distinct().ToArray())

        txtGUID.AutoCompleteCustomSource = aesColl

    End Sub

    Public Sub FetchKeychainsFromNiteStats()
        Dim connectNite As New WebClient()
        Dim jData = connectNite.DownloadString("https://api.nitestats.com/v1/epic/keychain")

        Dim jTok As JToken = JToken.Parse(jData)

        RichTextBox1.Text = jTok.ToString(Formatting.Indented)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FetchKeychainsFromNiteStats()
        If RichTextBox1.Text <> "" Then
            btnAdd.Enabled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim sInt As Integer = RichTextBox1.Find(txtKeychain.Text)
        If sInt <> -1 Then
            RichTextBox1.SelectionStart = sInt
            RichTextBox1.SelectionLength = txtKeychain.Text.Length
            RichTextBox1.SelectionBackColor = Color.Red
            RichTextBox1.ScrollToCaret()
        Else
            RichTextBox1.SelectionStart = RichTextBox1.Text.IndexOf("[") + 1
            RichTextBox1.SelectionLength = 1
            RichTextBox1.SelectedText = Environment.NewLine & """" & txtKeychain.Text & """," & Environment.NewLine
            RichTextBox1.SelectionStart = 0
            RichTextBox1.ScrollToCaret()
        End If
    End Sub


    Private Sub txtGUID_Validating(sender As Object, e As CancelEventArgs) Handles txtAES.Validating
        If sender.text <> "" Then
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pasteClient As New WebClient()

        Dim pasteRequest As New NameValueCollection
        pasteRequest.Add("api_dev_key", "") 'Simply login to Pastebin and go to https://pastebin.com/doc_api#1
        pasteRequest.Add("api_option", "paste")
        pasteRequest.Add("api_paste_code", RichTextBox1.Text)

        Dim UploadPasteData = pasteClient.UploadValues("https://pastebin.com/api/api_post.php", pasteRequest)

        Dim responsePasteBin As String = New StreamReader(New MemoryStream(UploadPasteData)).ReadToEnd()

        Dim pasteID = responsePasteBin.Substring(responsePasteBin.LastIndexOf("/") + 1)

        Dim openPage As New ProcessStartInfo
        openPage.UseShellExecute = True
        openPage.FileName = "https://pastebin.com/raw/" & pasteID

        Process.Start(openPage)


    End Sub

    Private Sub txtGUID_Leave(sender As Object, e As EventArgs) Handles txtGUID.Leave
        If txtGUID.Text <> "" Then
            Dim v = From n In listAESGuid Where n.pakGuid = txtGUID.Text
            If v.Any Then
                txtAES.Text = v.First.key
            End If
        End If
    End Sub
End Class

Public Class TheEncoder
    Public Shared Function HexStringToBase64(ByVal AES As String) As String
        Dim data As Byte() = ConvertFromStringToHex(AES)
        Return Convert.ToBase64String(data)
    End Function

    Public Shared Function ConvertFromStringToHex(ByVal AES As String) As Byte()
        AES = AES.Replace("-", "")

        Return Enumerable.Range(0, AES.Length / 2).[Select](Function(x) Convert.ToByte(AES.Substring(x * 2, 2), 16)).ToArray()
    End Function

End Class

Public Class GUIDAESPAIR
    Public Property pakFilename As String
    Public Property pakGuid As String
    Public Property key As String

End Class
