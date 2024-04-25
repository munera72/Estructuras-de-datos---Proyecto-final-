using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final___PDFs_Creator___Editor.model
{
    internal class Pdf
    {
       
        private int _id { get; }
        private string _name { get; set; }
        private DateOnly _lastModified {  get; set; }
        private string _operationPerformed { get; set; };


        public Pdf() { }


    }
}
