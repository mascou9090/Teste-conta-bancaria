using Exercicio_1;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.WriteLine("Entre o número da conta: ");
            int numberAux = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta: ");
            string nameAux = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            char resAux = char.Parse(Console.ReadLine());
            double amountAux;

            if(resAux == 's' || resAux == 'S')
            {
                Console.WriteLine("Entre o valor de depósito inicial: ");
                amountAux = double.Parse(Console.ReadLine());
                conta = new Conta(nameAux, numberAux, amountAux);
                
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);
                Console.WriteLine();
            }
            else
            {

                conta = new Conta(nameAux, numberAux);

                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);
                Console.WriteLine();
            }

            Console.Write("Entre um valor para depósito:");
            amountAux = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine();

            conta.Deposito(amountAux);
            
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para saque:");
            amountAux = double.Parse(Console.ReadLine());
            conta.Saque(amountAux);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
        }
    } 
}