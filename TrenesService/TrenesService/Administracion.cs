namespace TrenesService
{
    public class Administracion
    {
        public List<Viaje> Viajes = new List<Viaje>();
        
        public Administracion()
        {
            Viajes = new List<Viaje>();
        }

        public void AgregarNuevoViaje (int numTren, DateTime salida, int demoras, int importe)
        {
            Viaje viaje = new Viaje
            {
                NumUnicoViaje = Viajes.Count() + 1,
                Tren = numTren,
                Salida = salida,
                Demora = demoras,
                ValorBoleto = importe,
               
                
                
            };

            Viajes.Add(viaje);
            
        }

        public void AgregarPasajero(int dni, string nombre, DateTime nacimiento, int NumViaje)
        {
            Viaje viaje = Viajes.FirstOrDefault(x => x.NumUnicoViaje == NumViaje);
            
            
            Pasajero pasajero = new Pasajero
            {
                DniUser = dni,
                Nombre = nombre,
                FechaNacimiento = nacimiento

            };


            Viajes.FirstOrDefault(x=>x.NumUnicoViaje == NumViaje).TotalRecaudado += (viaje.ValorBoleto * pasajero.CalcularDescuento()) / 100;

                
            viaje.Pasajeros.Add(pasajero);
            
           
        }

        public List<Viaje> ObtenerListaViaje(DateTime fechaDesde, DateTime fechaHasta)
        {
           List<Viaje> lista = Viajes.Where(x => x.Salida >= fechaDesde && x.Salida<= fechaHasta).ToList();


            return lista;

        }





    }
}
