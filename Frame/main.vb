Imports System.IO

Public Class Form1

    Dim sdriveletter As String
    Dim idrivesize As Integer
    Dim filteredlist As New List(Of String)
    Dim ltotransfer As New List(Of String)


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles buttonlocation.Click
        ' First create a FolderBrowserDialog object
        Dim FolderBrowserDialog1 As New FolderBrowserDialog

        ' Then use the following code to create the Dialog window
        ' Change the .SelectedPath property to the default location
        With FolderBrowserDialog1
            ' Desktop is the root folder in the dialog.
            .RootFolder = Environment.SpecialFolder.Desktop
            ' Select the C:\Windows directory on entry.
            .SelectedPath = "c:\windows"
            ' Prompt the user with a custom message.
            .Description = "Select the source directory"
            If .ShowDialog = DialogResult.OK Then
                ' stores path in text box
                txtboxlocation.Text = .SelectedPath
            End If
        End With
    End Sub

    Private Sub butdestination_Click(sender As System.Object, e As System.EventArgs) Handles butdestination.Click
        ' First create a FolderBrowserDialog object
        Dim FolderBrowserDialog2 As New FolderBrowserDialog

        ' Then use the following code to create the Dialog window
        ' Change the .SelectedPath property to the default location
        With FolderBrowserDialog2
            ' Desktop is the root folder in the dialog.
            .RootFolder = Environment.SpecialFolder.Desktop
            ' Select the C:\Windows directory on entry.
            .SelectedPath = "c:\"
            ' Prompt the user with a custom message.
            .Description = "Select the source directory"
            If .ShowDialog = DialogResult.OK Then
                ' stores path in text box
                txtboxdestination.Text = .SelectedPath
            End If
        End With
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Call cleardisk(txtboxdestination.Text)

    End Sub
    Public Sub Getfiles()
        ' Get recursive List of all files starting in this directory.
        Dim list As List(Of String) = FileHelper.GetFilesRecursive(txtboxlocation.Text)

        Dim ispaceleft As Integer = idrivesize
        'Dim ifilteredlistcount As Integer = 0

        'Dim ifilecount As Integer = 0

        FileHelper.GetFilesRecursive(txtboxlocation.Text)
        ' Loop through and display each path.
        For Each photo In list
            'ListBoxfiles.Items.Add("Test")
            If photo.Trim().EndsWith(".jpg") Or photo.Trim().EndsWith(".JPG") Or photo.Trim().EndsWith(".jpeg") Then
                'ifilecount = ifilecount + 1
                'ListBoxfiles.Items.Add((My.Computer.FileSystem.GetFileInfo(path).Length / 1048576) & " MB")
                'ListBoxfiles.Items.Add(path.Remove(0, (txtboxlocation.TextLength + 1)))
                ' Put files into Dictionary Of String.

                'filteredlist.Add(path.Remove(0, (txtboxlocation.TextLength + 1)))
                filteredlist.Add(photo)

            End If
            'ListBoxfiles.Items.Add(path.ToString())
            'Console.WriteLine(path)
        Next

        Dim irandomint As Integer = 0



        If Rbuttonsize.Checked Then
            Dim ifillsize As Integer = idrivesize - (idrivesize * (Txtboxfill.Text / 100))
            Dim icount As Integer = filteredlist.Count
            'MsgBox("Size")
            While (ispaceleft > ifillsize And filteredlist.Count >= 1)

                'ispaceleft = ispaceleft - My.Computer.FileSystem.GetFileInfo(txtboxlocation.Text & "\" & filteredlist.Item(5).ToString).Length / 1048576
                'icount = icount - 1
                irandomint = randomphoto()
                ispaceleft = ispaceleft - My.Computer.FileSystem.GetFileInfo(filteredlist.Item(irandomint).ToString).Length / 1048576
                'ListBoxfiles.Items.Add("Random Number:" & irandomint)
                'ListBoxfiles.Items.Add(ispaceleft & " MB")
                'ListBoxfiles.Items.Add(filteredlist.Item(icount).ToString)
                ltotransfer.Add(filteredlist.Item(irandomint).ToString)
                filteredlist.RemoveAt(irandomint)
                If filteredlist.Count = 0 Then
                    MsgBox("There was not enough photos to fill the card")
                End If
            End While
        End If

        If rbuttonphotos.Checked Then
            Dim ifillamount As Integer = filteredlist.Count - Txtboxfill.Text
            Dim icount As Integer = filteredlist.Count
            irandomint = randomphoto()
            'MsgBox("Photos")
            While (filteredlist.Count > ifillamount And filteredlist.Count >= 1 And ispaceleft > idrivesize)
                'ispaceleft = ispaceleft - My.Computer.FileSystem.GetFileInfo(txtboxlocation.Text & "\" & filteredlist.Item(5).ToString).Length / 1048576
                'ListBoxfiles.Items.Add(ispaceleft & " MB")
                'icount = icount - 1
                'ListBoxfiles.Items.Add(filteredlist.Count)
                'ListBoxfiles.Items.Add(filteredlist.Item(icount).ToString)
                'ListBoxfiles.Items.Add("Random Number:" & irandomint)
                While (irandomint.Equals(filteredlist.Count))
                    irandomint = randomphoto()
                End While
                ispaceleft = ispaceleft - My.Computer.FileSystem.GetFileInfo(filteredlist.Item(irandomint).ToString).Length / 1048576
                ltotransfer.Add(filteredlist.Item(irandomint).ToString)
                filteredlist.RemoveAt(irandomint)
                If filteredlist.Count = 0 Then
                    MsgBox("There was not enough photos to fill the card")
                End If
            End While
        End If


        For displayfilteredlist = 1 To (ltotransfer.Count)
            'Displays whats in the list.
            'ispaceleft = ispaceleft - My.Computer.FileSystem.GetFileInfo(txtboxlocation.Text & "\" & filteredlist.Item(displayfilteredlist - 1).ToString).Length / 1048576
            'ListBoxfiles.Items.Add(ispaceleft & " MB")
            ListBoxfiles.Items.Add(ltotransfer.Item(displayfilteredlist - 1).Remove(0, (txtboxlocation.TextLength + 1)).ToString)
            ListBoxfiles.Update()
        Next displayfilteredlist

        'Write total number of paths found.
        'ListBoxfiles.Items.Add(list.Count)
        Return
    End Sub

    Public Sub Getfreespace()
        'Dim oDinfo As DriveInfo
        Dim oDrvs() As DriveInfo = DriveInfo.GetDrives

        For Each Drv In oDrvs
            'MsgBox(txtboxdestination.Text.Remove(3))
            If txtboxdestination.Text.Length > 3 Then
                sdriveletter = txtboxdestination.Text.Remove(3)
            Else
                sdriveletter = txtboxdestination.Text
            End If

            If Drv.IsReady And Drv.Name = sdriveletter Then
                idrivesize = Math.Round(Drv.AvailableFreeSpace.ToString / 1048576) - 25
                'MsgBox(Drv.Name & " " & idrivesize & " MB")
            End If
        Next
        Return
    End Sub


    Function randomphoto()
        Dim MinNumber As Integer = 0
        Dim randomnumber As Integer

        'initialize random number generator
        Dim r As New Random(System.DateTime.Now.Millisecond)

        randomnumber = r.Next(MinNumber, filteredlist.Count)

        While (filteredlist.Count = randomnumber)
            'MsgBox("FAIL")
            randomnumber = r.Next(MinNumber, filteredlist.Count)
        End While

        Return randomnumber

    End Function
    Public Sub Transferfiles()
        Dim sfiletocopyfrom As String
        Dim sfiletocopyto As String
        For displayfilteredlist = 0 To (ltotransfer.Count - 1)
            sfiletocopyfrom = ltotransfer.Item(displayfilteredlist).ToString
            sfiletocopyto = txtboxdestination.Text.ToString & getfilename(ltotransfer.Item(displayfilteredlist)).ToString
            File.Copy(sfiletocopyfrom, sfiletocopyto)
            ProgressBartransfer.Value = (displayfilteredlist / (ltotransfer.Count)) * 100
        Next displayfilteredlist

    End Sub

    Public Function getfilename(ByVal sFilelocation As String)
        Dim sfilename As String
        Dim split As String() = sFilelocation.Split("\")
        For Each s As String In split
            If s.Trim.Contains(".jpg") Or s.Trim.Contains(".JPG") Or s.Trim.Contains(".jpeg") Then
                sfilename = s
                'MsgBox(sfilename)
            End If
        Next s

        Return sfilename
    End Function


    Public Function cleardisk(ByVal slocation As String)
        Dim file As String
        ' Initializes variables to pass to the MessageBox.Show method.

        Dim Message As String = "Would you like to delete all photos on the card?"
        Dim Caption As String = "Delete all photos on card"
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo

        Dim Result As DialogResult

        'Displays the MessageBox

        Result = MessageBox.Show(Message, Caption, Buttons)

        ' Gets the result of the MessageBox display.

        If Result = System.Windows.Forms.DialogResult.Yes Then

            ' Deletes the Files.
            For Each file In System.IO.Directory.GetFiles(slocation)
                System.IO.File.Delete(file)
            Next file

        End If

    End Function

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Call Getfreespace()
    End Sub

    Private Sub buttransfer_Click(sender As System.Object, e As System.EventArgs) Handles buttransfer.Click
        If Rbuttonsize.Checked And Txtboxfill.Text > 0 And Txtboxfill.Text <= 100 Or rbuttonphotos.Checked Then
            ListBoxfiles.Items.Clear()
            ltotransfer.Clear()
            filteredlist.Clear()
            Call Getfreespace()
            'ListBoxfiles.Items.Add(idrivesize)
            Call Getfiles()
            Call Transferfiles()
        Else
            MsgBox("Please enter a value between 1 and 100 %")
        End If

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtboxlocation.Text = "C:\Documents and Settings\bwardwell\My Documents\My Pictures\Wallpapers"
        txtboxdestination.Text = "E:\"
        Txtboxfill.Text = "100"
    End Sub

End Class
