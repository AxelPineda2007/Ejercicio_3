using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3CS._2003634
{
    internal class Ordenador
    {
        public string Marca { get; set; }
        public string Procesador { get; set; }
        public int Memoria { get; set; } 
        public int DiscoDuro { get; set; } 

        public Ordenador(string marca, string procesador, int memoria, int discoDuro)
        {
            Marca = marca;
            Procesador = procesador;
            Memoria = memoria;
            DiscoDuro = discoDuro;
        }






        //Controlar el acceso a los atributos de una clase
        public void MayorCapacidad()
        {
            DiscoDuro += 100;
            Console.WriteLine($"Capacidad del disco duro aumentada a {DiscoDuro} GB.");
        }

        public void MenorCapacidad()
        {
            if (DiscoDuro >= 100)
            {
                DiscoDuro -= 100;
                Console.WriteLine($"Capacidad del disco duro reducida a {DiscoDuro} GB.");
            }
            else
            {
                Console.WriteLine("No se puede reducir más la capacidad del disco duro.");
            }
        }
    }

}

