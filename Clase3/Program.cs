using Clase3.Ejercicio_1;
using Clase3.Ejercicio_2;

namespace Clase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1


            // Crear clase Vehiculo con las siguientes propiedades: Marca, Modelo
            // Crear clase Moto que herede de Vehiculo  
            // Crear clase Auto que herede de Vehiculo

            //Modificar el metodo "ImprimirDatosVehiculo" para que pueda imprimir los datos del Vehiculo
            //independientemente de que si es una moto o un auto 

            //Uso
            Moto moto = new Moto();
            Auto auto = new Auto();

            //Entiendo que de esta manera puedo mostrar diferentes clases mediante un único método pero quería agregar
            //una linea de comando especificando si es una moto o un auto antes de los datos. Eso debería hacerlo con
            //un veh es un Auto (veh instanceof Auto) o veh es una Moto (veh instanceof Moto) o hay algúna otra manera de hacerlo?
            //Sé que en JAVA se puede pero no sé si en .net también
            ImprimirDatosVehiculo(moto);
            ImprimirDatosVehiculo(auto);
            #endregion


            #region Ejercicio 2
            // Crear una interfaz que se llame IBiblioteca
            // Definir en la interfaz con una sola firma que indique que se va a obtener todos los libros
            // Implementar la interfaz en la clase biblioteca para que devuelva los libros
            // Instanciar y utilizar la clase biblioteca
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.ObtenerLibros();
            #endregion
        }

        static void ImprimirDatosVehiculo(Vehiculo veh) 
        {
            veh.ImprimirDatosVehiculo();
        }


    }
}