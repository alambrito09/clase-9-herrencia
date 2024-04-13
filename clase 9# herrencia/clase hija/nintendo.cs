using clase_9__herrencia.clase_base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_9__herrencia.clase_hija
{
    internal class nintendo:cls_consola
    {
       public bool Esportatil {  get; set; }
        public string MostrarDetallesnintendo()
        {
            MostrarDetalles();
            return $"es portatil: {Esportatil}";
        }
    }
}
