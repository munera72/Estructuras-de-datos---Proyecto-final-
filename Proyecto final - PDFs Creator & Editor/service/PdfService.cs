using Proyecto_final___PDFs_Creator___Editor.controller;
using Proyecto_final___PDFs_Creator___Editor.model;
using Proyecto_final___PDFs_Creator___Editor.util;
using System.Diagnostics;

namespace Proyecto_final___PDFs_Creator___Editor.service
{
    internal class PdfService
    {

        private static PdfController controller;

        public PdfService() {

        }

        private static PdfController GetController()
        {
            if (controller == null)
            {
                controller = new PdfController();
            }

            return controller;
        }

        public static void AddContentPdfService(string filePath, string fileHeader, string fileContent, List<string> imageFiles)
        {
            PdfUtils.AddContentToExistingPdf(filePath, fileHeader, fileContent, imageFiles);

            try
            {

                Pdf pdf = GetController().get(filePath);
                pdf.OperationPerformed = "EDIT";
                pdf.LastModified = DateOnly.FromDateTime(DateTime.Now);

                GetController().save(pdf);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
        }

        public static void CreatePdfService(string filePath, string fileHeader, string fileContent, List<string> imageFiles)
        {
            PdfUtils.CreatePdfFile(filePath, fileHeader, fileContent, imageFiles);

            try
            {
                Pdf pdf = new Pdf();
                pdf.Name = filePath;
                pdf.OperationPerformed = "CREATE";
                pdf.LastModified = DateOnly.FromDateTime(DateTime.Now);

                GetController().save(pdf);
            }
            catch (Exception ex)
            {
                File.Delete(filePath);

                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);

                throw ex;
            }

        }

        public static void CreatePdfService(string filePath, string htmlContent)
        {

            PdfUtils.CreatePdfFile(filePath, htmlContent);
            try
            {
                Pdf pdf = new Pdf();
                pdf.Name = filePath;
                pdf.OperationPerformed = "CREATE";
                pdf.LastModified = DateOnly.FromDateTime(DateTime.Now);

                GetController().save(pdf);
            }
            catch (Exception ex)
            {
                File.Delete(filePath);

                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);

                throw ex;
            }

        }




    }
}
