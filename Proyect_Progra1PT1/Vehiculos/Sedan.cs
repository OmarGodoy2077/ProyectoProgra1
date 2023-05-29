using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect_Progra1PT1.Vehiculos
{
    internal class Sedan : VehiculoBase
    {
        public Sedan(string marca, string modelo, string color, int anio, string placa, string tipo, int velocidadMaxima) : base(marca, modelo, color, anio, placa, tipo, velocidadMaxima)
        {
        }

        public int NumeroPuertas { get; set; }

        public void Estacionar()
        {
            Console.WriteLine("Estacionando el sedán");
        }
    }
}
