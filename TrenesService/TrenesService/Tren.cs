using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenesService
{
    public class Tren
    {
        public int NumUnico {  get; set; }

        public EnumTipoCiudadInicio CiudadInicio {  get; set; }

        public EnumTipoCiudadFin CiudadFin {  get; set; }

        public int CapacidadMaxima {  get; set; }


    }
}
