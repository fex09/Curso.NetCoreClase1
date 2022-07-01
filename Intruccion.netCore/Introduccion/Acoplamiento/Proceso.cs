using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion.Acoplamiento
{
    public class Proceso
    {
        private readonly EscritorMensajeDebug _escritor = new EscritorMensajeDebug();

        public void Ejecutar()
        {
            while (true)
            {
                _escritor.Escribir($"Proceso en ejecución:{DateTimeOffset.Now}");
                Task.Delay(1000).Wait();
            }                
        }
    }
}
