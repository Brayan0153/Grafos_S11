using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    internal class Grafo
    {
        private int[,] matriz;
        private int n;
        private Random rand = new Random();


        public Grafo(int vertices)
        {
            n = vertices;
            matriz = new int[n, n];


            for (int f = 0; f < n; f++)
                for (int c = 0; c < n; c++)
                    matriz[f, c] = 0;
        }


        public void Agregar(int origen, int destino)
        {
            if (origen >= 0 && origen < n && destino >= 0 && destino < n)
            {
                matriz[origen, destino] = 1;
                matriz[destino, origen] = 1;
            }
           
        }


        public void Mostrar()
        {
            Console.WriteLine("Matriz de Adyacencia:");

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
