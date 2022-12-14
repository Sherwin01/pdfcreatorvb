Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Newtonsoft.Json
Imports iTextSharp.text.pdf.draw
Public Class Form1
    Dim jsonreader As String = File.ReadAllText("test.json")
    Dim jsoninfo As info = JsonConvert.DeserializeObject(Of info)(jsonreader)

    Private Sub generatebtn_Click(sender As Object, e As EventArgs) Handles generatebtn.Click
        Dim createpdf As Document = New Document()
        PdfWriter.GetInstance(createpdf, New FileStream("Lim_Sherwin.pdf", FileMode.Create))
        createpdf.Open()
        Dim fn As Paragraph = New Paragraph(jsoninfo.FullName)
        fn.Font.Size = 28
        createpdf.Add(fn)

        Dim bday As Paragraph = New Paragraph(jsoninfo.Birthday)
        bday.Font.Size = 12
        createpdf.Add(bday)

        Dim ads As Paragraph = New Paragraph(jsoninfo.Address)
        ads.Font.Size = 12
        createpdf.Add(ads)

        Dim cn As Paragraph = New Paragraph(jsoninfo.ContactNumber)
        cn.Font.Size = 12
        createpdf.Add(cn)

        Dim email As Paragraph = New Paragraph(jsoninfo.Email & vbLf & vbLf & vbLf & vbLf & vbLf & vbLf & vbLf & vbLf)
        email.Font.Size = 12
        createpdf.Add(email)

        Dim objtitle As Paragraph = New Paragraph("Objectives" & vbLf & vbLf)
        objtitle.Font.Size = 24
        createpdf.Add(objtitle)

        Dim line As LineSeparator = New LineSeparator(4.0F, 100.0F, BaseColor.CYAN, Element.ALIGN_CENTER, 1)
        createpdf.Add(line)


        Dim obj As Paragraph = New Paragraph(jsoninfo.Objective & vbLf & vbLf & vbLf & vbLf & vbLf)
        obj.Font.Size = 14
        createpdf.Add(obj)

        Dim edutitle As Paragraph = New Paragraph("Educational Background" & vbLf & vbLf)
        edutitle.Font.Size = 24
        createpdf.Add(edutitle)

        Dim eduline As LineSeparator = New LineSeparator(4.0F, 100.0F, BaseColor.CYAN, Element.ALIGN_CENTER, 1)
        createpdf.Add(eduline)

        Dim edu As Paragraph = New Paragraph(jsoninfo.Education & vbLf & vbLf & vbLf & vbLf & vbLf & vbLf & vbLf)
        edu.Font.Size = 14
        createpdf.Add(edu)

        Dim skilltitle As Paragraph = New Paragraph("Skills" & vbLf & vbLf)
        skilltitle.Font.Size = 24
        createpdf.Add(skilltitle)

        Dim skillsline As LineSeparator = New LineSeparator(4.0F, 100.0F, BaseColor.CYAN, Element.ALIGN_CENTER, 1)
        createpdf.Add(skillsline)

        Dim skills As Paragraph = New Paragraph(jsoninfo.Skills)
        skills.Font.Size = 14
        createpdf.Add(skills)

        createpdf.Close()
        MsgBox("Created Successfully")


    End Sub
    Public Class info
        Public FullName As String
        Public Birthday As String
        Public Address As String
        Public ContactNumber As String
        Public Email As String
        Public Objective As String
        Public Education As String
        Public Skills As String
    End Class

End Class
