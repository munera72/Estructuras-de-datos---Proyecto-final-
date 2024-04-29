using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Proyecto_final___PDFs_Creator___Editor.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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
            PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream(filePath, FileMode.Create, FileAccess.Write)));
            Document document = new Document(pdfDocument);

            document.SetMargins(70, 50, 40, 70); // Set margins (left, right, top, bottom)
            document.SetFontSize(12); // Set default font size
            document.SetTextAlignment(TextAlignment.LEFT); // Set default text alignment

            String header = fileHeader;
            document.Add(new Paragraph(header).SetFontSize(26).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
            String content = fileContent;
            document.Add(new Paragraph(content));
            document.Close();
            Debug.WriteLine("Awesome PDF just got created.");
        }

        public static void AddContentToExistingPdf(string filePath, string fileHeader, string fileContent, List<string> imagesList)
        {

            //TO DO

            //// Paths to the existing PDF and the new PDF with additional content
            //string existingPdfPath = filePath;
            //string newPdfPath = "C:\\Users\\emanu\\Documents\\newpdf.pdf";

            //// Create a PdfWriter for the new PDF
            //PdfWriter writer = new PdfWriter(newPdfPath);
            //PdfDocument newPdf = new PdfDocument(writer);

            //// Create a Document to add content to the new PDF
            //Document document = new Document(newPdf);
            //document.SetMargins(70, 50, 40, 70); // Set margins (left, right, top, bottom)
            //document.SetFontSize(12); // Set default font size
            //document.SetTextAlignment(TextAlignment.LEFT); // Set default text alignment

            //// Add your new content to the document
            //String header = fileHeader;
            //document.Add(new Paragraph(header).SetFontSize(26).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
            //String content = fileContent;
            //document.Add(new Paragraph(content));

            //// Close the document

            //// Open the existing PDF document
            //PdfDocument existingPdf = new PdfDocument(new PdfWriter(new FileStream(existingPdfPath, FileMode.Append, FileAccess.Write)));

            //// Merge the new PDF with the existing one
            //newPdf.CopyPagesTo(1, newPdf.GetNumberOfPages(), existingPdf);

            //// Close the existing PDF
            //existingPdf.Close();

            //document.Close();

            //// Close the new PDF
            //newPdf.Close();

            //Console.WriteLine("PDFs merged successfully.");
        }

    }

}
