using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_9__herrencia.clase_base
{
    internal class cls_consola
    {
        public string Marca { get; set; }
        public int AnioLanzamiento { get; set; }
        public void MostrarDetalles() {
            Console.WriteLine($" algo nuevo Marca:{ Marca} Dia lanzamiento:{ AnioLanzamiento }");

        
        }

    }
}
