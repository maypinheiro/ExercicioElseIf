using System;

namespace Exercicio
{
    class Program
    {
          static void  VerificaDDD(int ddd) {
              
            if (ddd == 61) Console.WriteLine("Brasilia");
            else if (ddd == 71) Console.WriteLine("Salvador");
            else if (ddd == 11) Console.WriteLine("São Paulo");
            else if (ddd == 21) Console.WriteLine("Rio de Janeiro");
            else if (ddd == 32) Console.WriteLine("Juíz de Fora");
            else if (ddd == 19) Console.WriteLine("Campinas");
            else if (ddd == 31) Console.WriteLine("Belo Horizonte");
              
            else Console.WriteLine("DDD não cadastrado");
        }

        
        static void Main(string[] args)
        {
            int ddd= int.Parse(Console.ReadLine());
            VerificaDDD(ddd);
            Console.ReadKey();
        }
    }
}
