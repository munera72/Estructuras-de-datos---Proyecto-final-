using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final___PDFs_Creator___Editor.repository
{
    internal interface Repository<T>
    {
        List<T> FindAll();
        T Find(int id);
        void Save(T obj);
        void Delete(int id);
    }
}
