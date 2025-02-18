using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3CS._2003634
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ordenador miOrdenador = new Ordenador("Dell", "Intel i7", 16, 500);
            Console.WriteLine($"Ordenador: {miOrdenador.Marca}, {miOrdenador.Procesador}, Memoria: {miOrdenador.Memoria}GB, Disco Duro: {miOrdenador.DiscoDuro}GB");

            miOrdenador.MayorCapacidad();
            miOrdenador.MenorCapacidad();
            miOrdenador.MenorCapacidad();
        }
    }
}
