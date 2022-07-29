Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Newtonsoft.Json
Public Class Form1
    Dim jsonreader As String = File.ReadAllText("test.json")
    Dim jsoninfo As info = JsonConvert.DeserializeObject(Of info)(jsonreader)

    Private Sub generatebtn_Click(sender As Object, e As EventArgs) Handles generatebtn.Click
        Dim createpdf As Document = New Document()
        PdfWriter.GetInstance(createpdf, New FileStream("Lim_Sherwin.pdf", FileMode.Create))
        createpdf.Open()
        Dim fn As Paragraph = New Paragraph(jsoninfo.FullName)
        fn.Font.Size = 16
        createpdf.Add(fn)
        createpdf.Close()
        MsgBox("Created Successfully")


    End Sub
    Public Class info
        Public FullName As String
        Public Age As String
        Public Birthday As String
        Public Address As String
        Public ContactNumber As String
        Public Email As String
        Public objective As String
        Public education As String
        Public skills As String
    End Class

End Class
