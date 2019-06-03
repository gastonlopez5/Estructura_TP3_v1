using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class clsAuto
    {
        string placa;
        string propietario;
        DateTime horaDeEntrada;

        public string Placa { get => placa; set => placa = value; }
        public string Propietario { get => propietario; set => propietario = value; }
        public DateTime HoraDeEntrada { get => horaDeEntrada; set => horaDeEntrada = value; }
    }
}
