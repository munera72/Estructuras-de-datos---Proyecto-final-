using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final___PDFs_Creator___Editor.model
{
    internal class Pdf
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly LastModified {  get; set; }
        public string OperationPerformed { get; set; }


        public Pdf() { }


    }
}
