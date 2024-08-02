using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenesService
{
    public class Viaje
    {
        public int NumUnicoViaje { get; set; }

        public int Tren { get; set; }

        public DateTime Salida { get; set; }

        public int Demora { get; set; }

        public int TotalRecaudado { get; set; }

        public int ValorBoleto { get; set; }

        public List<Pasajero> Pasajeros {  get; set; }

            public Viaje()
        {
            Pasajeros = new List<Pasajero>();
        }
        

    }
}
