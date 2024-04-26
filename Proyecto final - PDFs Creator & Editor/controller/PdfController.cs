using Proyecto_final___PDFs_Creator___Editor.model;
using Proyecto_final___PDFs_Creator___Editor.repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final___PDFs_Creator___Editor.controller
{
    internal class PdfController
    {

        private PdfRepository repository;

        public PdfController()
        {

            repository = new PdfRepository();

        }


        public List<Pdf> getAll()
        {
            return repository.FindAll();

        }


        public Pdf get(int id)
        {

            return repository.Find(id);

        }


        public void save(Pdf pdf)
        {
            repository.Save(pdf);
        }


        public void delete(int id)
        {
            repository.Delete(id);
        }


    }
}
