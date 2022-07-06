using System;

namespace Ejercicio1DeDiegoRomero
{
    class Program
    {
        static void Main(string[] args)
        {
           //encabezado del programa
            Console.WriteLine("distancia recorrida de un movil");
            Console.WriteLine("Inserte los valores a calcular");
                
            
            //definicion de las variables
                Console.Write("velocidad m/s: ");
                var velocidad = int.Parse(Console.ReadLine());
                Console.Write("tiempo seg.:");
                var tiempo = int.Parse(Console.ReadLine());
                int distancia;
                double kms;
            //proceso del programa
                distancia = velocidad * tiempo;
                kms = distancia * 0.001;
            //muestra de la informacion
            Console.WriteLine($"El objeto que se desplaza a {velocidad} m/s, a lo largo de {tiempo} segundos");
            Console.WriteLine($"Se ha desplazado {distancia} metros");
            Console.WriteLine($"Esto equivale a {kms} kms");

        }
    }
}
