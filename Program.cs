using System;
namespace EstruturaDoPrograma
{
    class Program
    {
        static void Main()
        {
            var s = new Pilha();

            s.Empilha(0);
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            s.Empilha(1000);
            s.Empilha(10000);
            s.Empilha(100000);
            s.Empilha(1000000);

            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine("Desempilhamento Realizado com Sucesso!!!");

        }
    }
}