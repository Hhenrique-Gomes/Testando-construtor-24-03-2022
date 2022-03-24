using System;

namespace _51_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Nome do(a) construtor(a)");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do(a) construtor(a)");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o sexo do(a) construtor(a)");
            char sexo = Convert.ToChar(Console.ReadLine());

            maoobra j = new maoobra(nome,idade,sexo);

            Console.WriteLine("Digite um numero para diminuir a idade");
            int idde = Convert.ToInt32(Console.ReadLine());
            j.sbtrc(idde);

            Console.WriteLine("{0}",j.linha1());

        }
    }
}
