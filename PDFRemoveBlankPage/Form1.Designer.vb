<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        XuấtBáoCáoToolStripMenuItem = New ToolStripMenuItem()
        CSVToolStripMenuItem = New ToolStripMenuItem()
        Button3 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Button4 = New Button()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripProgressBar1 = New ToolStripProgressBar()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label3 = New Label()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        FolderBrowserDialog2 = New FolderBrowserDialog()
        Label4 = New Label()
        SaveFileDialog2 = New SaveFileDialog()
        Label5 = New Label()
        ContextMenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 89)
        Button1.Name = "Button1"
        Button1.Size = New Size(193, 44)
        Button1.TabIndex = 0
        Button1.Text = "Xóa từng tệp"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.Filter = "PDF File (*.pdf) | *.pdf"
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.Filter = "PDF File (*.pdf) | *.pdf"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        ListView1.ContextMenuStrip = ContextMenuStrip1
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.Location = New Point(12, 139)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(555, 231)
        ListView1.TabIndex = 2
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Tên tệp"
        ColumnHeader1.Width = 150
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Đường dẫn"
        ColumnHeader2.Width = 250
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Kích cỡ"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Trạng thái"
        ColumnHeader4.Width = 90
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {XuấtBáoCáoToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(156, 26)
        ' 
        ' XuấtBáoCáoToolStripMenuItem
        ' 
        XuấtBáoCáoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CSVToolStripMenuItem})
        XuấtBáoCáoToolStripMenuItem.Name = "XuấtBáoCáoToolStripMenuItem"
        XuấtBáoCáoToolStripMenuItem.Size = New Size(155, 22)
        XuấtBáoCáoToolStripMenuItem.Text = "Xuất báo cáo ..."
        ' 
        ' CSVToolStripMenuItem
        ' 
        CSVToolStripMenuItem.Name = "CSVToolStripMenuItem"
        CSVToolStripMenuItem.Size = New Size(95, 22)
        CSVToolStripMenuItem.Text = "CSV"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(211, 89)
        Button3.Name = "Button3"
        Button3.Size = New Size(193, 44)
        Button3.TabIndex = 3
        Button3.Text = "Xóa nhiều tệp"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 15)
        Label1.TabIndex = 4
        Label1.Text = "Chọn thư mục nguồn :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(157, 18)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(299, 23)
        TextBox1.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(462, 17)
        Button2.Name = "Button2"
        Button2.Size = New Size(105, 23)
        Button2.TabIndex = 6
        Button2.Text = "..."
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 15)
        Label2.TabIndex = 7
        Label2.Text = "Chọn thư mục đích :"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(157, 49)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(299, 23)
        TextBox2.TabIndex = 8
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(462, 48)
        Button4.Name = "Button4"
        Button4.Size = New Size(105, 23)
        Button4.TabIndex = 9
        Button4.Text = "..."
        Button4.UseVisualStyleBackColor = True
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripProgressBar1, ToolStripStatusLabel2})
        StatusStrip1.Location = New Point(0, 406)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(579, 22)
        StatusStrip1.TabIndex = 10
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(66, 17)
        ToolStripStatusLabel1.Text = "Tiến trình : "
        ' 
        ' ToolStripProgressBar1
        ' 
        ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        ToolStripProgressBar1.Size = New Size(400, 16)
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(23, 17)
        ToolStripStatusLabel2.Text = "0%"
        ' 
        ' BackgroundWorker1
        ' 
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 382)
        Label3.Name = "Label3"
        Label3.Size = New Size(19, 15)
        Label3.TabIndex = 11
        Label3.Text = " ..."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(415, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 15)
        Label4.TabIndex = 12
        Label4.Text = "Tổng số trang : 0/0 tệp."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(319, 381)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 13
        Label5.Text = "Label5"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(579, 428)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(StatusStrip1)
        Controls.Add(Button4)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(ListView1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PDF RemoveBlankPage V11.04.2024 © 2CongLC.Vn"
        ContextMenuStrip1.ResumeLayout(False)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents XuấtBáoCáoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents Label5 As Label
End Class
