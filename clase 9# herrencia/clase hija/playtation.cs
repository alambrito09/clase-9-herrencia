using clase_9__herrencia.clase_base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_9__herrencia.clase_hija
{
    internal class playtation : cls_consola
    {
        public string Modelocontrolador { get; set; }
        public string Mostrardetallesps()
        {
            return $"modelo de controlador:{Modelocontrolador}";

        }
    }
}