using iText.Html2pdf;
using iText.IO.Image;
using iText.Kernel.Geom;
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

            
            try
            {
                foreach (string rutaImagen in imagesList)
                {
                    iText.Layout.Element.Image imagen = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create(rutaImagen));

                    document.Add(imagen);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar imágenes al PDF: " + ex.Message);
            }

            document.Close();

            
        }

        public static void CreatePdfFile(string filepath, string htmlContent)
        {
            // Ruta del archivo PDF de salida
            string rutaPDF = filepath;

            try
            {
                // Leer el contenido del archivo HTML
                string html = htmlContent;

                // Crear un nuevo archivo PDF
                PdfDocument pdfDoc = new PdfDocument(new PdfWriter(rutaPDF));

                // Convertir HTML a PDF
                ConverterProperties properties = new ConverterProperties();
                HtmlConverter.ConvertToPdf(html, pdfDoc, properties);

                // Cerrar el documento
                pdfDoc.Close();

                Console.WriteLine("El PDF se ha creado correctamente: " + rutaPDF);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al generar el PDF: " + ex.Message);
            }
        }

        public static void AddContentToExistingPdf(string filePath, string fileHeader, string fileContent, List<string> imagesList)
        {

            PdfDocument pdf = new PdfDocument(new PdfWriter(filePath + "New.pdf"));
            PdfMerger merger = new PdfMerger(pdf);

            //Add pages from the first document
            PdfDocument firstSourcePdf = new PdfDocument(new PdfReader(filePath));
            merger.Merge(firstSourcePdf, 1, firstSourcePdf.GetNumberOfPages());

            //Add pages from the second pdf document
            string tempPdf = filePath + "TempSource.pdf";
            CreatePdfFile(tempPdf, fileHeader, fileContent, imagesList);

            PdfDocument secondSourcePdf = new PdfDocument(new PdfReader(tempPdf));
            merger.Merge(secondSourcePdf, 1, secondSourcePdf.GetNumberOfPages());

            firstSourcePdf.Close();
            secondSourcePdf.Close();
            pdf.Close();

            File.Delete(filePath + "TempSource.pdf");
            File.Delete(filePath);
            File.Copy(filePath + "New.pdf", filePath);
            File.Delete(filePath + "New.pdf");

        }

    }

}
