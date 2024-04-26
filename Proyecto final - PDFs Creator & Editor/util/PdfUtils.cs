using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Proyecto_final___PDFs_Creator___Editor.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final___PDFs_Creator___Editor.util
{
    internal class PdfUtils
    {
        public static Pdf CreatePdfObject(SqlDataReader reader)
        {
            Pdf pdf = new Pdf();

            pdf.Id = reader.GetInt32(0);
            pdf.Name = reader.GetString(1);
            pdf.LastModified = DateOnly.FromDateTime(reader.GetDateTime(2));
            pdf.OperationPerformed = reader.GetString(3);

            return pdf;

        }


        public static void CreatePdfFile(string filePath, string fileHeader, string fileContent, List<string> imagesList)
        {
            PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream("/Users/emanu/Documents/helloworld.pdf", FileMode.Create, FileAccess.Write)));
            Document document = new Document(pdfDocument);

            String line = "Hello! Welcome to iTextPdf";
            document.Add(new Paragraph(line));
            document.Close();
            Console.WriteLine("Awesome PDF just got created.");
        }

    }



}
