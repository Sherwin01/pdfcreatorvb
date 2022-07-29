Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Newtonsoft.Json
Public Class Form1
    Private Sub generatebtn_Click(sender As Object, e As EventArgs) Handles generatebtn.Click
        Dim createpdf As Document = New Document()
        PdfWriter.GetInstance(createpdf, New FileStream("Lim_Sherwin.pdf", FileMode.Create))
        createpdf.Open()
        createpdf.Add(New Paragraph("text"))
        createpdf.Close()
        MsgBox("Created Successfully")


    End Sub


End Class
