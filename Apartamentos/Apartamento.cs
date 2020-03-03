using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apartamentos
{
    class Apartamento
    {
        private string _Direccion;
        private string _Color;
        private float _AreaConstruccion;
        private byte _Parqueos;
        private byte _Habitaciones;
        private byte _Baños;

       
        public Apartamento(string direccion, string color, float areaconstruccion, byte parqueos, byte habitaciones, byte baños) 
        {
            _Direccion = direccion;
            _Color = color;
            _AreaConstruccion = areaconstruccion;
            _Parqueos = parqueos;
            _Habitaciones = habitaciones;
            _Baños = baños; 
        }
        

        public void Vender() 
        {
            Console.WriteLine();
            Console.WriteLine("Se vende apartamento con las siguientes caracteristicas.");
            Console.WriteLine("Direccion: "+_Direccion);
            Console.WriteLine("Color: " + _Color);
            Console.WriteLine("Tiene " + _AreaConstruccion+" metros cuadrados");
            Console.WriteLine("Parqueos: " + _Parqueos);
            Console.WriteLine("Habitaciones: " + _Habitaciones);
            Console.WriteLine("Baños: " + _Baños);
        }

        public void Alquilar() 
        {
            Console.WriteLine();
            Console.WriteLine("Se alquila apartamento con las siguientes caracteristicas.");
            Console.WriteLine("Direccion: " + _Direccion);
            Console.WriteLine("Color: " + _Color);
            Console.WriteLine("Tiene " + _AreaConstruccion + " metros cuadrados");
            Console.WriteLine("Parqueos: " + _Parqueos);
            Console.WriteLine("Habitaciones: " + _Habitaciones);
            Console.WriteLine("Baños: " + _Baños);
        }
    }
}
