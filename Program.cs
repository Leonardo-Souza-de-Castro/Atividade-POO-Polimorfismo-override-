using System;
using Exercicio_Sobrescrita.Classes;

namespace Exercicio_Sobrescrita
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMen m = new MegaMen();

            Zero z = new Zero();

            Console.WriteLine(m.Pular());
            Console.WriteLine(m.Correr());
            
            Console.WriteLine(z.Correr());
            Console.WriteLine(z.Pular());
        }
    }
}
