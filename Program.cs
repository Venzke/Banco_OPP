using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main()
        { 

            //Inserção dos dados nas váriaveis 
            Console.Write("Informe o número da conta: ");
            int N_Conta = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome: ");
            string Nome = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Deseja realizar um deposito (S/N)? ");
            string Opcao = Console.ReadLine();

            double Deposito = 0.0;

            Conta p = new Conta(Nome, N_Conta, Deposito); //Instanciando o construtor

            //Controle para saber se haverá depósito
            if (Opcao == "S" || Opcao == "s")
            {

                Console.Write("insira o valor: ");
                Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                p.AdicionaSaldo(Deposito);
            }

            Double Saldo = p.InformaSaldo();

            //Validação dos dados
            Console.WriteLine("Dados da conta:");
            Console.WriteLine("N° da conta: {0}", N_Conta);
            Console.WriteLine("Titular: {0}", Nome);
            Console.WriteLine("Saldo: R$ {0:F2}", Saldo);

            Console.WriteLine();

            //Depósito

            Console.Write("Insira o valor do depósito: ");
            Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Saldo = p.AdicionaSaldo(Deposito); // Saldo recebe o return do método AdicionaSaldo

            Console.WriteLine("Saldo: R$ {0:F2}", Saldo);
            Console.WriteLine();

            //Saque

            Console.WriteLine("Insira o valor do saque: ");
            double Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Saldo = p.Saque(Saque); // Saldo recebe o return do método Saque

            Console.Write("Saldo: R$ {0:F2}", Saldo);
            Console.WriteLine();

            Console.Read();
        }
    }
}
