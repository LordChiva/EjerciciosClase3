using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio_1
{
    internal class Vehiculo
    {
        private string Marca;
        private string Modelo;

        public Vehiculo()
        {
            SetMarca("marca");
            SetModelo("modelo");
        }

        public void ImprimirDatosVehiculo()
        {
            Console.WriteLine($"La Marca es {GetMarca()}");
            Console.WriteLine($"El Modelo es {GetModelo()}");
        }

        public string GetMarca() { return this.Marca; }

        protected void SetMarca(string marca)
        {
            this.Marca = marca;
        }

        public string GetModelo() { return this.Modelo; }

        protected void SetModelo(string modelo)
        {
            this.Modelo = modelo;
        }
    }
}
