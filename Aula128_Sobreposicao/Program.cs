/* SOBREPOSICAO OU SOBRESCRITA - Implementacao de um metodo de uma superclasse na subclasse 
 
    - Virtual - Prefixo que permite a sobreposicao;
    - Override - Prefixo para fazer a sobrescrita - Para o metodo metodo .ToString, por exemplo,
      este pertence a classe Object. Essa clase, por sua vez, e Superclasse de todas as outras classes;

    - Palavra BASE no contexto da Sobreposicao - Podemos chamar a superclasse com o uso da palavra BASE.

*/

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using Aula128_Sobreposicao.Entities;
namespace Aula128_Sobreposicao

{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Vinicius", 100000.00);
            Account acc2 = new SavingsAccount(1002, "Juliane", 500000.00, 0.02); // Upcasting

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            
        }
    }
}
