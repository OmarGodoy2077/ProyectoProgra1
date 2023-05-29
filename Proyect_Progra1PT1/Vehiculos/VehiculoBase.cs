using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect_Progra1PT1.Vehiculos
{
    internal class VehiculoBase : IVehiculo
    {

        public string Estado { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public int VelocidadMaxima { get; }
        public int VelocidadActual { get; private set; }

        // Esta es la propiedad de 'Encendido'
        public bool Encendido { get; private set; }

        // Constructor de VehiculoBase
        public VehiculoBase(string marca, string modelo, string color, int anio, string placa, string tipo, int velocidadMaxima)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Anio = anio;
            Placa = placa;
            Tipo = tipo;
            VelocidadMaxima = velocidadMaxima;
            VelocidadActual = 0;
            Encendido = false;
        }

        public void Bocina()
        {
            Console.WriteLine("¡Bocina!");
        }

        public void Acelerar(int incrementoVelocidad)
        {
            if (!Encendido)
            {
                throw new Exception("No puedes acelerar si el vehículo no está encendido");
            }

            VelocidadActual += incrementoVelocidad;
        }

        public void Encender()
        {
            if (!Encendido)
            {
                Encendido = true;
            }
            else
            {
                throw new Exception("El vehículo ya está encendido.");
            }
        }

        public void Apagar()
        {
            if (Encendido)
            {
                Encendido = false;
                VelocidadActual = 0;
            }
            else
            {
                throw new Exception("El vehículo ya está apagado.");
            }
        }

        public void Frenar(int decrementoVelocidad)
        {
            if (!Encendido)
            {
                throw new Exception("No puedes frenar si el vehículo no está encendido");
            }

            VelocidadActual = Math.Max(0, VelocidadActual - decrementoVelocidad); // Asegura que la velocidad no sea negativa
        }
    }
}