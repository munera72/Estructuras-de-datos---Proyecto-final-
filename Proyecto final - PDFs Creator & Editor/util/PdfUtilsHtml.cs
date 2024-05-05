using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using iText.Html2pdf;
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
    internal class PdfUtilsHtml
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


        public static void CreatePdfFile(string filePath, string html)
        {
          try
          {
                PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream(filePath, FileMode.Create, FileAccess.Write)));

            ConverterProperties properties = new ConverterProperties();
            HtmlConverter.ConvertToPdf(html, pdfDocument, properties);

            pdfDocument.Close();

            Console.WriteLine("El PDF se ha creado correctamente: " + filePath);
           }
         catch (Exception ex)
            {
                Console.WriteLine("Error al generar el PDF: " + ex.Message);
            }
         }
    }

}
