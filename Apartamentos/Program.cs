using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apartamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            string direccion;
            string color;
            float areadeconstruccion;
            byte parqueos;
            byte habitaciones;
            byte baños;
            int desicion;

            Console.Write("¿Donde está ubicado el apartamento? ");
            direccion = Console.ReadLine();
            Console.Write("¿De color es el apartamento? ");
            color = Console.ReadLine();
            Console.Write("¿Cual es el tamaño de construccion del apartamento? ");
            areadeconstruccion = float.Parse(Console.ReadLine());
            Console.Write("¿Cuantos parqueos tiene el apartamento? ");
            parqueos = byte.Parse(Console.ReadLine());
            Console.Write("¿Cuántas habitaciones tiene el apartamento? ");
            habitaciones = byte.Parse(Console.ReadLine());
            Console.Write("¿Cuántos baños tiene el apartamento? ");
            baños = byte.Parse(Console.ReadLine());

            Console.Write("Presione ´1´ si va vender o ´2´ si va a alquilar: ");
            desicion = int.Parse(Console.ReadLine());           

            Apartamento apartamento=new Apartamento(direccion, color, areadeconstruccion,parqueos,habitaciones,baños);

            switch (desicion)
            {
                case(1):                   
                    apartamento.Vender();
                    break;

                case(2):                                   
                    apartamento.Alquilar();
                    break;

                default:
                    Console.WriteLine("Usted no ha seleccionado las opciones que tiene disponible.");
                    break;

            } Console.ReadKey();
                                   
        }
    }
}
