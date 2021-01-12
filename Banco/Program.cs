using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.WriteLine("Entre com o numero da conta");
            int numeroconta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta");
            string titular = (Console.ReadLine());
            Console.WriteLine("Haverá deposito inicial ? S (Sim) N (Não)");
            char op = char.Parse(Console.ReadLine());

            if (op == 's' || op == 'S')
            {
                double Saldo = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numeroconta, titular, Saldo);
            } else
            {
                conta = new ContaBancaria(numeroconta, titular);
            }



           // Console.WriteLine("Digite uma opção para continuar");
           // Console.WriteLine("");
           // Console.WriteLine("Efetuar um depósito - 1");
           // Console.WriteLine("");
           // Console.WriteLine("Efetuar um saque - 2");
            //int op1 = int.Parse(Console.ReadLine());

           // switch (op1)
          //  {
                //case 1:
            //        conta.Deposito(op1);
           //         break;
          //      case 2:
             //       conta.Saque(op1);
             //       break;
             //   default: Console.WriteLine("Função invalida"); 
           //         break;
            //        
         //   }


            Console.WriteLine("");
            Console.WriteLine("DADOS DA CONTA");
            Console.WriteLine( conta);

            Console.WriteLine("");
            Console.WriteLine("Entre com um valor para deposito:");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);
            Console.WriteLine(  "DADOS DA CONTA ATUALIZADOS:");
            Console.WriteLine(conta);

            Console.WriteLine("");
            Console.WriteLine("Entre com um valor para saque:");
            double saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);
            Console.WriteLine("DADOS DA CONTA ATUALIZADOS:");
            Console.WriteLine(conta);
            Console.WriteLine("");
        }
    }
}
