using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Introduccion.Acoplamiento
{
    public class EscritorMensajeDebug
    {
        private readonly ILogger<EscritorMensajeDebug> _logger;

        public EscritorMensajeDebug()
        {
            var loggerFactory = LoggerFactory.Create(builder => builder.AddDebug());
            _logger = loggerFactory.CreateLogger<EscritorMensajeDebug>();
        }

        public void Escribir()
        {

        }
    }
}
