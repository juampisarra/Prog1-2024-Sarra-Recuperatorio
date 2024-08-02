using TrenesService;

namespace TrenesServiceTest
{
    public class Tests
    {
        Administracion llamada = new Administracion();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AgregarViaje()
        {
            //Arrange
            Viaje Viaje = new Viaje
            {
                NumUnicoViaje = 1,
                Tren = 1,
                Salida = DateTime.Now,
                Demora = 40,
                ValorBoleto = 40
            };

            //Act
            llamada.AgregarNuevoViaje(1, DateTime.Now, 40, 40);

            //Assert
            Assert.That(llamada.Viajes.Count(), Is.EqualTo(1));
        }

        [Test]
        public void AgregarPasajeros()
        {
            //Arrange
            Viaje Viaje = new Viaje
            {
                NumUnicoViaje = 1,
                Tren = 1,
                Salida = DateTime.Now,
                Demora = 40,
                ValorBoleto = 40
            };

            //Act
            llamada.AgregarNuevoViaje(1, DateTime.Now, 40, 40);

            
            Pasajero pasajero = new Pasajero { 
            
                DniUser = 45,
                Nombre= "cc",
                FechaNacimiento = DateTime.Now,
                
            };

            Pasajero pasajero2 = new Pasajero
            {

                DniUser = 44,
                Nombre = "cc",
                FechaNacimiento = DateTime.Now,

            };

            //Act
            llamada.AgregarPasajero(45, "cc", DateTime.Now, 1);
            llamada.AgregarPasajero(44, "cc", DateTime.Now, 1);

            //Assesrt
            //Assert.That( 1);


        }
    }
}