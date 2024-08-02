using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenesService
{
    public class PasajeroVIP : Pasajero
    {
       public List<string> CiudadesFavoritas = new List<string>();

        public int NivelUsuario { get; set; }

        public PasajeroVIP()
        {
            CiudadesFavoritas = new List<string>();
        }

        public override string ObtenerInformacionPasajero()
        {
            return base.ObtenerInformacionPasajero() + CiudadesFavoritas.FirstOrDefault();
        }

        public override int CalcularDescuento()
        {
            int Descuento = 0;
            if (NivelUsuario == 1)
            {
                Descuento = 12;
            } else if (NivelUsuario == 2)
            {
                Descuento = 15;
            } else
            {
                Descuento = 17;
            }

            return Descuento;
        }
    }
}
