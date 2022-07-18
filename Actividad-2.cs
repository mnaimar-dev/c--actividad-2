using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----- Homework Solution -----

            // 1- Solicita al usuario la captura de dos valores numéricos de punto flotante, desplegando un mensaje para solicitar cada uno y capturarlo en una variable de tipo double.
            Console.WriteLine("Introduce un número de punto flotante: ");
            double numero_1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce otro número de punto flotante: ");
            double numero_2 = double.Parse(Console.ReadLine());

            // 2- Posteriormente muestra en la consola de salida el resultado de efectuar cada una de las cuatro operaciones numéricas básicas, más el residuo, con los dos valores capturados.

            double suma = numero_1 + numero_2;
            Console.WriteLine("Resultado de la suma: " + suma);

            double resta = numero_1 - numero_2;
            Console.WriteLine("Resultado de la resta: " + resta);

            double multiplicacion = numero_1 * numero_2;
            Console.WriteLine("Resultado de la multiplicacion: " + multiplicacion);

            double division = numero_1 / numero_2;
            Console.WriteLine("Resultado de la division: " + division);

            double residuo = numero_1 % numero_2;
            Console.WriteLine("Resultado de la residuo: " + residuo);

            // 3- Incluye un comentario donde expliques qué significa el resultado de la operación residuo.
            /* 
                La operación de residuo calcula la división entre dos nuúmeros y devuelve el resto o residuo de dicha operación. 
                Por ejemplo: si se divide 5 entre 2, el residuo o resto será 1. Este será el resultado que obtendremos de realizar
                la operación 5 % 2.
            */
        }
    }
}







