﻿using System;

namespace Condicionais
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar.");
            }
            else
            {

                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos de idade, mais pode entrar porque está acompanhado.");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos, não pode entrar");
                }

            }

            Console.ReadLine();
        }
    }
}
