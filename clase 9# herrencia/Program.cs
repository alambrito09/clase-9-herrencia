using clase_9__herrencia;
using clase_9__herrencia.clase_base;
using clase_9__herrencia.clase_hija;
using System.Globalization;

nintendo sw = new nintendo();
sw.Esportatil = true;
sw.AnioLanzamiento = 2017;
sw.Marca = "nintendo switch";
string resultado = sw.MostrarDetallesnintendo();
Console.WriteLine(resultado);
playtation ps= new playtation();
ps.Modelocontrolador = "hola este el nuevo controlador";

string psi = ps.Mostrardetallesps();
Console.WriteLine(psi);
xbonone xb = new xbonone();
xb.gamepass = true;
string rsult = xb.name();
Console.WriteLine(rsult);
