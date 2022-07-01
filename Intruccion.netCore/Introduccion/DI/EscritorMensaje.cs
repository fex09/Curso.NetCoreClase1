using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion.DI
{
    public class EscritorMensaje:IEscritor
    {
        public void Escribir(string mensaje)
        {
            Console.WriteLine($"EscritorMensaje.Escribir(mensaje:{mensaje})");
        }
    }
}
