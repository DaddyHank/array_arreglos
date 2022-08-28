using System;
using System.Collections;

namespace array_arreglos_3
{
    class Program
    {
        static void Main(string[] args)
            // poner el puntero en el error y presionat alt + enter.
        {
            ArrayList lista = new ArrayList();
            Console.WriteLine("Cantidad: {0}", lista.Count);
            Console.WriteLine("Cantidad: {0}", lista.Capacity);
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                lista.Add("Dato" + i);
            }
            Console.WriteLine("Cantidad: {0}", lista.Count);
            Console.WriteLine("Cantidad: {0}", lista.Capacity);
            Console.WriteLine();

            for (int i = 10; i < 20; i++)
            {
                lista.Add("Dato" + i);
            }
            Console.WriteLine("Cantidad: {0}", lista.Count);
            Console.WriteLine("Cantidad: {0}", lista.Capacity);
            Console.WriteLine();
            foreach(string row in lista)
            {
                Console.WriteLine(row);
            }
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_Eliminar rango-_-_-_-_-_-_-_-_-_-");
            lista.RemoveRange(4, 4);
            lista.RemoveRange(10, 4);
            foreach (string row in lista)
            {
                Console.WriteLine(row);
            }
            lista.Insert(11, "Elemento insertado");
            foreach (string row in lista)
            {
                Console.WriteLine(row);
            }

            lista.Clear();
            Console.WriteLine("Cantidad: {0}", lista.Count);
            Console.WriteLine("Capacidad: {0}", lista.Capacity);
        }
    }
}
