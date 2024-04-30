using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using Proyecto_final___PDFs_Creator___Editor.controller;
using Proyecto_final___PDFs_Creator___Editor.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            document.SetMargins(70, 50, 40, 70);
            document.SetFontSize(12);
            document.SetTextAlignment(TextAlignment.LEFT);

            String header = fileHeader;
            document.Add(new Paragraph(header).SetFontSize(26).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
            String content = fileContent;
            document.Add(new Paragraph(content));
            document.Close();

            PdfController controller = new PdfController();
            Pdf pdf = new Pdf();
            pdf.Name=filePath;
            pdf.OperationPerformed = "CREATE";
            pdf.LastModified = DateOnly.FromDateTime(DateTime.Now);
            
            controller.save(pdf);
        }

        public static void AddContentToExistingPdf(string filePath, string fileHeader, string fileContent, List<string> imagesList)
        {

            PdfDocument pdf = new PdfDocument(new PdfWriter("C:\\Users\\emanu\\Documents\\newPdf.pdf"));
            PdfMerger merger = new PdfMerger(pdf);

            //Add pages from the first document
            PdfDocument firstSourcePdf = new PdfDocument(new PdfReader(filePath));
            merger.Merge(firstSourcePdf, 1, firstSourcePdf.GetNumberOfPages());

            //Add pages from the second pdf document
            string tempPdf = "C:\\Users\\emanu\\Documents\\temp.pdf";
            CreatePdfFile(tempPdf, fileHeader, fileContent, imagesList);

            PdfDocument secondSourcePdf = new PdfDocument(new PdfReader(tempPdf));
            merger.Merge(secondSourcePdf, 1, secondSourcePdf.GetNumberOfPages());

            firstSourcePdf.Close();
            secondSourcePdf.Close();
            pdf.Close();
        }

    }

}
