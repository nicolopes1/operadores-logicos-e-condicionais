using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_3_operadores_logicos_e_condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // var a = 2;
            /* if (a == 1)
               {
                   Console.WriteLine("Entrou na condição do IF");
                   Console.WriteLine("=================");
               }
               else if(a == 2)
               {
                   Console.WriteLine("Caiu no bloco do Else se a = 2!");
               }
               else
               {
                   Console.WriteLine("Caiu no bloco do Else!");
               }
               */


            /* switch (a)
               {
                   case 1:
                       Console.WriteLine("Case 1");
                       break;
                   case 2:
                       Console.WriteLine("Case 2");
                       break;
                   default:
                       Console.WriteLine("Nenhum");
                       break;
               }
               */

            /* var a = 1;
               string teste = (a == 1 ? "o valor a" : "mais um");
               Console.WriteLine("ola pessoal "+ teste);
               */

            /* var a = 3;
            
            if(!(a == 2))  // ou     if ( a != 2)
            {
                Console.WriteLine("Olá");
            }

            if (a == 2 && a == 3)
            {
                Console.WriteLine("Entrou na condição");
            }

            if (a == 2 || a == 3)
            {
                Console.WriteLine("Entrou na condição");
            }

            if (a < 2)
            {
                Console.WriteLine("A é menor do que 2");
            }

            if (a > 2)
            {
                Console.WriteLine("A é maior do que 2");
            }


            Console.WriteLine("Hello Word!"); */

            int i = 0;
            while (true) {
                i++;
                if (i == 1) continue;
                Console.WriteLine("oasas");
            }

            Console.Read();


        }
    }
}
