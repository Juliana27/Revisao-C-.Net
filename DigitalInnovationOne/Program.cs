using System;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main()
        {
            var p = new Pilha();
            p.Empilha(1);
            p.Empilha(10);
            p.Empilha(100);
            Console.WriteLine(p.Desempilha());
            Console.WriteLine(p.Desempilha());
            Console.WriteLine(p.Desempilha());
        }
    }
}
