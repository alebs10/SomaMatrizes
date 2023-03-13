﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int [3,3];
            int[,] matriz2 = new int[3,3];
            int[,] resultado = new int[3, 3];

            Console.WriteLine("Preencher a matriz #1: ");

            for(int linha = 0; linha < 3; linha++)
            {
                for(int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write("Matriz#1 Posição.[" + linha + "][" + coluna + "]: ");
                    matriz1[linha, coluna] = int.Parse(Console.ReadLine()); 
                }
            }
            Console.WriteLine("\nPreencher a matriz #2: ");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write("Matriz#2 Posição.[" + linha + "][" + coluna + "]: ");
                    matriz2[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nResultado da Matriz#1 + Matriz#2: ");
            resultado[0, 0] = matriz1[0, 0] + matriz2[0, 0];
            resultado[0, 1] = matriz1[0, 1] + matriz2[0, 1];
            resultado[0, 2] = matriz1[0, 2] + matriz2[0, 2];
            resultado[1, 0] = matriz1[1, 0] + matriz2[1, 0];
            resultado[1, 1] = matriz1[1, 1] + matriz2[1, 1];
            resultado[1, 2] = matriz1[1, 2] + matriz2[1, 2];
            resultado[2, 0] = matriz1[2, 0] + matriz2[2, 0];
            resultado[2, 1] = matriz1[2, 1] + matriz2[2, 1];
            resultado[2, 2] = matriz1[2, 2] + matriz2[2, 2];

            Console.WriteLine("[" + resultado[0, 0] + "][" + resultado[0, 1] + "][" + resultado[0, 2] + "]");
            Console.WriteLine("[" + resultado[1, 0] + "][" + resultado[1, 1] + "][" + resultado[1, 2] + "]");
            Console.WriteLine("[" + resultado[2, 0] + "][" + resultado[2, 1] + "][" + resultado[2, 2] + "]");

            Console.WriteLine("Pressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
