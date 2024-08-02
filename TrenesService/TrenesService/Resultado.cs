using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenesService
{
    public class Resultado
    {
        public string Message { get; set; }

        public bool Success { get; set; }

        public Resultado(bool success, string message)
        {

            new Resultado(success, message);
        }
    }
}
