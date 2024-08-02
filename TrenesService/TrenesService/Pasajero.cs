using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenesService
{
    public class Pasajero
    {
        public int DniUser {  get; set; }

        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public virtual string ObtenerInformacionPasajero() {

            return $"{Nombre} - {DateTime.Now.Year - FechaNacimiento.Year}";
        }

        public virtual int CalcularDescuento()
        {
            int Descuento = 0;
           if ( (DateTime.Now.Year - FechaNacimiento.Year) <= 12)
            {
               Descuento = 10;
                
            }
            
           return Descuento;
        }
    }
}
