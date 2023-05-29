using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect_Progra1PT1.Vehiculos
{
    internal class SUV : VehiculoBase

    {


        public SUV(string marca, string modelo, string color, int anio, string placa, string tipo, int velocidadMaxima) : base(marca, modelo, color, anio, placa, tipo, velocidadMaxima)
        {
        }

        public bool Levantado { get; set; }

        public void ConducirTerrenosDificiles()
        {
            Console.WriteLine("Conduciendo en terrenos difíciles con la 4x4");
        }
    }
}
   
