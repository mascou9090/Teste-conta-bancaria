namespace Exercicio_1
{
    internal class Conta
    {
        public string Name { get; set; }
        public int Number { get; private set; }

        public double AcountValue { get; private set; }


        public Conta(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public Conta(string name, int number, double acountValue) : this(name, number)
        {
            AcountValue = acountValue;
        }

        public void Deposito(double amount)
        {
            AcountValue += amount;
        }

        public void Saque(double amount)
        {
            AcountValue -= amount + 5.00;
        }

        public override string ToString()
        {
            return "Conta " + Number + ", Titular: " + Name + ", Saldo: $ " + AcountValue;
        }
    }
}
