using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_Construtores
{
    class maoobra
    {

        public string Nome;
        public int Idade;
        public char Sx;

        public maoobra  (string nome, int idade, char sx)
        {
            Nome = nome;
            Idade = idade;
            Sx = sx;
        }

        public int sbtrc(int idde)
        {
            return Idade = Idade - idde;
        }

        public string linha1()
        {
            string linha;
            Console.WriteLine("Nome: {0} \n" +
                "Idade: {1} \n" +
                "Sexo: {2}",Nome,Idade,Sx);
            return linha = Console.ReadLine();
            
            
        }
    }
}
