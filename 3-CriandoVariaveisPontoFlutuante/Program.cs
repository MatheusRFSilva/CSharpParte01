using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3-Criando Variaveis ponto flutuante");

            double salario;
            salario = 1200.70;

            Console.WriteLine(salario);

            double idade;
            idade = 15 / 2.0;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine(" 5 / 3  = " + idade);

            idade = 5 / 3.0;
            Console.WriteLine("5 / 3.0 = " + idade);




            Console.Write("A execução acabou, aperte Enter para finalizar !");
            Console.Read();
        }
    }
}
