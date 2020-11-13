using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            int meses = idade*12;
            Console.WriteLine(meses +" meses");

            int dias = idade*365;
            Console.WriteLine(dias +" dias");

            int horas = dias*24;
            Console.WriteLine(horas +" horas");

            int minutos = horas*60;
            Console.WriteLine(minutos +" minutos");

        }//FIM DO MAIN
    }
}
