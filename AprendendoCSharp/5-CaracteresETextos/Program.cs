﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5, caracteres e textos");

            char primeiraLetra = 'a';

            primeiraLetra = (char) 65;

            primeiraLetra = (char)(primeiraLetra + 1);

            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia " + 2020;
            string cursosProgramacao = 
@"- .NET 
- Java
- Javascript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);
            Console.ReadLine();
        }
    }
}
