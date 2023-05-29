using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect_Progra1PT1.Vehiculos
{
    internal class PickUp : VehiculoBase
    {
        // Propiedades únicas de PickUp
        public int CapacidadDeCarga { get; set; }
        public bool TieneTraccionEnLasCuatro { get; set; }

        // Constructor de PickUp que llama al constructor de la clase base
        public PickUp(string marca, string modelo, string color, int anio, string placa, string tipo, int velocidadMaxima)
            : base(marca, modelo, color, anio, placa, tipo, velocidadMaxima)
        {
        }

        // Método único de PickUp
        public void CargarObjeto(int peso)
        {
            if (Encendido)
            {
                // Lógica para cargar el objeto
                Estado = $"Cargando objeto de {peso} kg";
            }
            else
            {
                Estado = "El vehículo no está encendido";
            }
        }
    }
}


