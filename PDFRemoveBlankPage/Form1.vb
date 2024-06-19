Imports System
Imports System.ComponentModel
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports Spire
Imports Spire.License
Imports Spire.Pdf
Imports Spire.Pdf.Exporting.Text
Imports Spire.Pdf.General
Imports Spire.Pdf.Graphics


Public Class Form1
    Private IsRun As Boolean
    Private TotalPage As Integer = 0
    Private CountBlank As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Spire.License.LicenseProvider.SetLicenseKey("CtOzJs2BlzPokWgBAKMfmNxjRwLa3eqzrAvKtn54UDB/dWjIyGokcs+UQuYuvMY03wX56Ox75KV+U1r5H0PR++c1zc6i8e0QIOVuhMp9Qbg5A9bJJA7e7KvC4KMINTr4jnJy/yTGFwT1aEusw144kml/6oAttwEUoXBkDPLWGOsvNgH1iTYkTGWMXEV8Or4p4t4doNsl0Z7V5qWDKwB6sD/ZiH7l/Jum27FWevOlKIa2VG1rEKjtURYukbWXeSH54IKtmn7nmr0wKwnRgdu3q60aC/PdkxC0zX75EnbU5M6fa3pplU40f3LGOWcgZ2f+8oI7qpPXJ8/s7LrsxBqpQ2YGKfKuqx5ex9ALrXgjnwjcslmXPYun7flHGIkbvBsCjCpo4Ed+M658sZTGATak6gLmftEqhJ1ZZJJKFgXE5qa/TyCY7wIq1ll+z1VNhnSBZUc1RA4TwSBcFKvrZEHlj9o1WFZ1+QqNAcnzh/n+tG48B0wHLCl6D4hroCfWMoaw/23DRxx1WuWqfkazuz2H8ga1RC2XPs83nB7CHPFNs0sT5lsKbfA3P9jgtza5CEhfjAN/3TiwEP/tvnTZY+VABK97veB77h4LEiVMfQXzKfhm9cNW4ft/ofVU2OfqZ8GjtntoZdPxp1bIwTvI98SnQi/H81w19aHwUqNECTeJBjqqHMxdVKVSBAKJL0TM7RyzoOPKS19OfURAxlEgRUqJF/BM8eU0R+UicIM2h36sTuBKO4g3H6woDMlnx0QG0nqthauTB7oK6QFTwk44UQ1kTAu8LeOJwM2xNu5MLsPmoWwDvmIaTuZIW6VUX8C285c9KkrYAf79YKA3e3yxx6SSQdN/jLbtR7MaeGpxRzX0iEbqL9sG1m5USuYVByvVKQ4ntvfCMlLmUN9UCvJ/m63K27Z2dm6fTXIe/g0smYmnvEQ3JQVnldWOi1TKOMK8RbuU5un5mQZ96pLq0Q7g0NLQZh50UMT+OjAzXHPxmXfV6/deHeE8Gbb3ZYJSg7UXW2sty86uXwkj89x5yJTaMNtm6Kh2QQugn/Vd9n8C8QReNewYxjF827FBpMp9yf+vLf2FSyA50wiA9o9luoXYgRmGuUh+g9+KMWgMK5fxQ2h3cHqADzPcwsDhVfG6HuAgt81vH/M5hFLdQztXdvRKVuYOyyTOnQz9K93LZ2EvbeWz0YByRkGxnve+K8UNo3pyNgaPGRQWr5RbeURNJ4PhmM3dB2oMkwE//+s39ccgADdEJS8s35cjRrVEGs8JicRu6mDNqJfdHUNfLmiySMjG/ePwhYkiB2WhJ9AqpY9N7eQ3TBsAMkr34olS6eSNpaE1BjgJsljB27GDnmMAXNZeifyIYpBcqu6H9SLN5pGBF9WHcPVivjdNpMUrKQ==")
            Spire.License.LicenseProvider.SetLicenseKey("CtOzJs2BlzPokWgBAKMfmNxjRwLa3eqzrAvKtn54UDB/dWjIyGokcs+UQuYuvMY03wX56Ox75KV+U1r5H0PR++c1zc6i8e0QIOVuhMp9Qbg5A9bJJA7e7KvC4KMINTr4jnJy/yTGFwT1aEusw144kml/6oAttwEUoXBkDPLWGOsvNgH1iTYkTGWMXEV8Or4p4t4doNsl0Z7V5qWDKwB6sD/ZiH7l/Jum27FWevOlKIa2VG1rEKjtURYukbWXeSH54IKtmn7nmr0wKwnRgdu3q60aC/PdkxC0zX75EnbU5M6fa3pplU40f3LGOWcgZ2f+8oI7qpPXJ8/s7LrsxBqpQ2YGKfKuqx5ex9ALrXgjnwjcslmXPYun7flHGIkbvBsCjCpo4Ed+M658sZTGATak6gLmftEqhJ1ZZJJKFgXE5qa/TyCY7wIq1ll+z1VNhnSBZUc1RA4TwSBcFKvrZEHlj9o1WFZ1+QqNAcnzh/n+tG48B0wHLCl6D4hroCfWMoaw/23DRxx1WuWqfkazuz2H8ga1RC2XPs83nB7CHPFNs0sT5lsKbfA3P9jgtza5CEhfjAN/3TiwEP/tvnTZY+VABK97veB77h4LEiVMfQXzKfhm9cNW4ft/ofVU2OfqZ8GjtntoZdPxp1bIwTvI98SnQi/H81w19aHwUqNECTeJBjqqHMxdVKVSBAKJL0TM7RyzoOPKS19OfURAxlEgRUqJF/BM8eU0R+UicIM2h36sTuBKO4g3H6woDMlnx0QG0nqthauTB7oK6QFTwk44UQ1kTAu8LeOJwM2xNu5MLsPmoWwDvmIaTuZIW6VUX8C285c9KkrYAf79YKA3e3yxx6SSQdN/jLbtR7MaeGpxRzX0iEbqL9sG1m5USuYVByvVKQ4ntvfCMlLmUN9UCvJ/m63K27Z2dm6fTXIe/g0smYmnvEQ3JQVnldWOi1TKOMK8RbuU5un5mQZ96pLq0Q7g0NLQZh50UMT+OjAzXHPxmXfV6/deHeE8Gbb3ZYJSg7UXW2sty86uXwkj89x5yJTaMNtm6Kh2QQugn/Vd9n8C8QReNewYxjF827FBpMp9yf+vLf2FSyA50wiA9o9luoXYgRmGuUh+g9+KMWgMK5fxQ2h3cHqADzPcwsDhVfG6HuAgt81vH/M5hFLdQztXdvRKVuYOyyTOnQz9K93LZ2EvbeWz0YByRkGxnve+K8UNo3pyNgaPGRQWr5RbeURNJ4PhmM3dB2oMkwE//+s39ccgADdEJS8s35cjRrVEGs8JicRu6mDNqJfdHUNfLmiySMjG/ePwhYkiB2WhJ9AqpY9N7eQ3TBsAMkr34olS6eSNpaE1BjgJsljB27GDnmMAXNZeifyIYpBcqu6H9SLN5pGBF9WHcPVivjdNpMUrKQ==")
            Spire.License.LicenseProvider.LoadLicense()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog2.ShowDialog = DialogResult.OK Then
            DelPageEmpty(OpenFileDialog1.FileName, SaveFileDialog2.FileName)
            MessageBox.Show("Đã xóa trang trắng !")
        End If
    End Sub
    Public Sub DelPageBlank(ByVal infile As String, ByVal outfile As String)
        Try
            Dim document As PdfDocument = New PdfDocument()
            document.LoadFromFile(infile)
            Dim i As Integer = (document.Pages.Count - 1)
            Do While (i >= 0)
                Dim pg As PdfPageBase = document.Pages(i)
                Dim str As SimpleTextExtractionStrategy = New SimpleTextExtractionStrategy()
                Dim txt As String = pg.ExtractText(str)
                Dim img As Image = document.SaveAsImage(i, PdfImageType.Bitmap)
                If IsImageBlank(img) AndAlso txt.Trim().Length = 0 Then
                    document.Pages.Remove(pg)
                End If
                i = (i - 1)
            Loop
            document.SaveToFile(outfile, FileFormat.PDF)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub DelPageEmpty(ByVal infile As String, ByVal outfile As String)
        Try
            Dim document As PdfDocument = New PdfDocument()
            document.LoadFromFile(infile)
            For i As Integer = document.Pages.Count - 1 To 0 Step -1
                If document.Pages(i).IsBlank() Then
                    document.Pages.RemoveAt(i)

                Else
                    Dim image As Image = document.SaveAsImage(i, PdfImageType.Bitmap)
                    If IsImageBlank(image) Then
                        document.Pages.RemoveAt(i)

                    End If
                End If
            Next
            document.SaveToFile(outfile, FileFormat.PDF)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub


    Public Shared Function IsImageBlank(ByVal img As Image) As Boolean
        Dim bmp As Bitmap = New Bitmap(img)
        Dim i As Integer = 0
        Do While (i < bmp.Width)
            Dim j As Integer = 0
            Do While (j < bmp.Height)
                Dim pixel As Color = bmp.GetPixel(i, j)
                If ((pixel.R < 240) OrElse ((pixel.G < 240) OrElse (pixel.B < 240))) Then
                    Return False
                End If
                j = (j + 1)
            Loop
            i = (i + 1)
        Loop
        Return True
    End Function




    Public Function ScanDirectory(ByVal dt As String, ByVal searchPattern As String) As List(Of String)
        Dim list As New List(Of String)
        If Directory.Exists(dt) AndAlso searchPattern <> "" Then
            Dim list2 As List(Of String) = Enumerable.ToList(Of String)(Directory.GetFiles(dt, searchPattern, SearchOption.AllDirectories))
            Dim num As Integer = 1
            Dim i As Integer
            For i = 0 To list2.Count - 1
                Application.DoEvents()
                Dim info As New FileInfo(list2(i))
                list.Add(list2(i))
                num += 1
            Next i
        End If
        Return list
    End Function
    Private Sub AddToListView(ByVal file As String)

        Dim finfo As FileInfo = New FileInfo(file)

        Dim item As ListViewItem = New ListViewItem(finfo.Name)

        item.SubItems.Add(finfo.DirectoryName)
        item.SubItems.Add(Math.Ceiling(finfo.Length / 1024.0F).ToString("0 KB"))
        item.SubItems.Add("Đã xóa")

        Try
            Dim document As PdfDocument = New PdfDocument()
            document.LoadFromFile(finfo.FullName)
            For i As Integer = document.Pages.Count - 1 To 0 Step -1
                If document.Pages(i).IsBlank() Then
                    document.Pages.RemoveAt(i)
                    item.SubItems.Add("Đã xóa")
                Else
                    Dim image As Image = document.SaveAsImage(i, PdfImageType.Bitmap)
                    If IsImageBlank(image) Then
                        document.Pages.RemoveAt(i)
                        item.SubItems.Add("Đã xóa")
                    End If
                End If
            Next
            document.SaveToFile(TextBox2.Text & "\" & finfo.Name, FileFormat.PDF)
        Catch ex As Exception

        End Try


        ListView1.Invoke(CType((Sub()
                                    ListView1.BeginUpdate()
                                    ListView1.Items.Add(item)
                                    ListView1.EndUpdate()
                                End Sub), Action))
        TotalPage = TotalPage + 1
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If Directory.Exists(TextBox1.Text) AndAlso Directory.Exists(TextBox2.Text) Then
            Dim dirs As New List(Of String)
            dirs = ScanDirectory(TextBox1.Text, "*.pdf")
            Dim count As Integer = dirs.Count
            Dim i As Integer
            TotalPage = 0
            ListView1.Items.Clear()
            For i = 0 To count - 1
                'Tham chiếu tiến trình progressbar
                BackgroundWorker1.ReportProgress(CInt(i / count * 100))
                'Tham chiếu tệp đang trong quá trình sử lý
                Label3.Invoke(CType((Sub()
                                         Label3.Text = String.Format("Đang xóa trang : {0}", dirs(i))
                                     End Sub), Action))
                'Thêm tệp tin vào danh sách listview1
                AddToListView(dirs(i))
                'Tiến trình đếm trang          
                Label4.Invoke(CType(Sub()
                                        Label4.Text = "Tổng số trang : " & TotalPage & "/" & ListView1.Items.Count & " Tệp."
                                    End Sub, Action))

            Next
            BackgroundWorker1.ReportProgress(100)

        Else
            MessageBox.Show("Please, Select Input and Output Directory !")
        End If
    End Sub
    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        If Not BackgroundWorker1.CancellationPending Then
            ToolStripStatusLabel2.Text = e.ProgressPercentage & "%"
            ToolStripProgressBar1.PerformStep()
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If FolderBrowserDialog2.ShowDialog = DialogResult.OK Then
            TextBox2.Text = FolderBrowserDialog2.SelectedPath
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If BackgroundWorker1.IsBusy AndAlso IsRun = True Then
            BackgroundWorker1.CancelAsync()
            IsRun = False

        Else
            If Directory.Exists(TextBox1.Text) AndAlso Directory.Exists(TextBox2.Text) Then
                ToolStripProgressBar1.Value = ToolStripProgressBar1.Minimum

                ListView1.Items.Clear()
                BackgroundWorker1.RunWorkerAsync()
                IsRun = True
            Else
                MessageBox.Show("Please, Select Input and Output Directory !")
            End If
        End If
    End Sub

#Region "Context Menu"


    Private Shared Sub WriteCSVRow(ByVal result As StringBuilder, ByVal itemsCount As Integer, ByVal isColumnNeeded As Func(Of Integer, Boolean), ByVal columnValue As Func(Of Integer, String))
        Dim isFirstTime As Boolean = True

        For i As Integer = 0 To itemsCount - 1
            If Not isColumnNeeded(i) Then Continue For
            If Not isFirstTime Then result.Append(",")
            isFirstTime = False
            result.Append(String.Format("""{0}""", columnValue(i)))
        Next

        result.AppendLine()
    End Sub
    Public Shared Sub ListViewToCSV(ByVal listView As ListView, ByVal filePath As String, ByVal includeHidden As Boolean)
        'make header string
        Dim result As StringBuilder = New StringBuilder()
        WriteCSVRow(result, listView.Columns.Count, Function(i) includeHidden OrElse listView.Columns(i).Width > 0, Function(i) listView.Columns(i).Text)

        'export data rows
        For Each listItem As ListViewItem In listView.Items
            WriteCSVRow(result, listView.Columns.Count, Function(i) includeHidden OrElse listView.Columns(i).Width > 0, Function(i) listItem.SubItems(i).Text)
        Next

        File.WriteAllText(filePath, result.ToString(), Encoding.UTF8)
    End Sub

    Private Sub CSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CSVToolStripMenuItem.Click
        Try
            SaveFileDialog2.Filter = "CSV File (*.csv) | *.csv"
            If SaveFileDialog2.ShowDialog = DialogResult.OK Then
                ListViewToCSV(ListView1, SaveFileDialog2.FileName, True)
                MessageBox.Show("Done !")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

#End Region

End Class
