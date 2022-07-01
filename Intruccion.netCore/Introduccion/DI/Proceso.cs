using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion.DI
{
    public class Proceso
    {
        private readonly IEscritor _escritor;

        public Proceso(IEscritor escritor)
        {
            _escritor = escritor;
        }

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
