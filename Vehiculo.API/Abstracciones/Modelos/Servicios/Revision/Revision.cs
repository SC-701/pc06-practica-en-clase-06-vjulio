using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Modelos.Servicios.Revision
{
    public class Revision
    {
        public string Placa { get; set; } = string.Empty;
        public IEnumerable<Falta> Faltas { get; set; }
        public string Periodo { get; set; } = string.Empty;
        public string Resultado { get; set; } = string.Empty;

    }
}
