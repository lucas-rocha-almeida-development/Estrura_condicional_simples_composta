using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrura_condicional_simples_composta {
internal class Program {
    static void Main(string[] args) {
        //estrutura condional composta
        Console.WriteLine("Entre com um numero inteiro: ");
        int NumeroInteiro = int.Parse(Console.ReadLine());

        if (NumeroInteiro % 2 == 0) {
            //Condição sendo verdadeira ira executar esse comando
            Console.WriteLine("Numero Digitado é PAR!!");
                
        }
        else {
            //condição sendo falsa ira executar esse comando!!
            Console.WriteLine("Numero Digitado é IMPAR!!");
        }
            Console.ReadKey();
    }
}
}
