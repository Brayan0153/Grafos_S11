using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    internal class Grafo
    {
        private int[,] matrizbi;
        private int n;
        private Random rand = new Random();


        public Grafo(int v)
        {
            n = v;
            matrizbi = new int[n, n];


            for (int f = 0; f < n; f++)
                for (int c = 0; c < n; c++)
                    matrizbi[f, c] = 0;
        }


        public void Agregar(int ori, int des)
        {
            if (ori >= 0 && ori < n && des >= 0 && des < n)
            {
                matrizbi[ori, des] = 1;
                matrizbi[des, ori] = 1;
            }
           
        }


        public void Mostrar()
        {
            Console.WriteLine("Matriz de Adyacencia:");

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(matrizbi[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
