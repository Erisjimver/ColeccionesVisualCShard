using System;
using System.Collections.Generic;

namespace Coleciones
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iniciando las listas!");
            Dictionary<string,int> edades = new Dictionary<string, int>();

            //rellenar el diccionario
            edades.Add("Israel", 26);
            edades.Add("Jimena", 19);
            edades.Add("Ruben", 30);
            edades.Add("Marlene", 50);

            edades["Juan"] = 20;

            //recorrer el dicionario
            foreach (KeyValuePair<string,int> persona in edades)
            {
                Console.WriteLine("Nombre: "+persona.Key+" edad: "+persona.Value);
            }




            /*
            Stack<int> numeros = new Stack<int>();
            //insertando datos en la cola+
            foreach (var numero in new int[5] { 2, 4, 6, 8, 10 })
            {
                numeros.Push(numero);
            }

            //recorriendo el stack LIFO
            Console.WriteLine("Recorriendo el Queue");
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //eliminando elementos
            Console.WriteLine("Eliminando Elementos ...");
            numeros.Pop();
            Console.WriteLine("Recorriendo el Queue");
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            */


            /*
            Queue<int> numeros = new Queue<int>();
            //insertando datos en la cola+
            foreach (var numero in new int[5] { 2,4,6,8,10 })
            {
                numeros.Enqueue(numero);
            }

            //recorriendo la cola
            Console.WriteLine("Recorriendo el Queue");
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //eliminando elementos
            Console.WriteLine("Eliminando Elementos ...");
            numeros.Dequeue();
            Console.WriteLine("Recorriendo el Queue");
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
            */



            /*
            LinkedList<int> numeros = new LinkedList<int>();//declarando coleccion tipo linked lista //usando constructor por defecto

            foreach (var numero in new int[] { 10,8,6,4,2,0})
            {
                numeros.AddFirst(numero);
            }
            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);

            numeros.AddFirst(nodoImportante);

            //numeros.Remove(6);//eliminar un elemento segun su valor

            //leer nodos o listas en oprimera forma izi facil como sea
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //leer numeros o listas en segunda forma
            for (LinkedListNode<int> nodo=numeros.First; nodo!=null; nodo=nodo.Next)
            {
                int numero = nodo.Value;
                Console.WriteLine(numero);
            }

            */

            /*
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
            numeros.RemoveAt(numeros.Count-1);//elimina un numero en este caso el ultimo introducido
            Console.WriteLine("Elementos introducidos nuevamente: ");
            foreach(int num in numeros)
            {
                Console.WriteLine("Nuevos elementos totales son: "+num);
            }
            */
        }

    }
}
