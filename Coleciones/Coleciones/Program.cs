using System;
using System.Collections.Generic;

namespace Coleciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando las listas!");
            List<int> numeros = new List<int>();//declarando coleccion tipo lista
            int[] listaNumeros = new int[] { 3, 8, 6, 4, 10 };


            numeros.Add(5);
            numeros.Add(4);
            numeros.Add(8);

            for (int i = 0; i < 5; i++)//agregar datos a la lsita mediante un arreglo 
            {
                numeros.Add(listaNumeros[i]);
            }

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("Lista creada inserrtar datos!");
            List<int> numeros1 = new List<int>();//declarando coleccion tipo lista


            Console.WriteLine("Cuantos elementos quieres introducir?");

            int elem = Int32.Parse(Console.ReadLine());
            Console.WriteLine("----------------Introducir elementos---------------");
            for (int i = 0; i < elem; i++)
            {
                numeros1.Add(Int32.Parse(Console.ReadLine()));
            }

            Console.WriteLine("----------------Elementos introducidos -------------");
            for (int i = 0; i < elem; i++)
            {
                Console.WriteLine(numeros1[i]);
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Elementos dentro de la lista son :"+numeros1.Count);


            Console.WriteLine("--------------------");
            Console.WriteLine("Introducir elementos nuevamente...");
            int elem1 = 1;
            while (elem1 != 0)
            {
                elem1 = Int32.Parse(Console.ReadLine());
                numeros.Add(elem1);
            }

            Console.WriteLine("Elementos introducidos nuevamente: ");
            foreach(int num in numeros)
            {
                Console.WriteLine("Nuevos elementos totales son: "+num);
            }
        }
    }
}
