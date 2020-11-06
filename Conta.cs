namespace Exercicios
{
    class Conta
    {

        private int Num_Conta { get; set; }
        private string Nome { get; set; }
        private double Saldo { get; set; }

        public Conta(string nome, int numero, double saldo) {
            Nome = nome;
            Num_Conta = numero;
            Saldo = saldo;
        }

        public double AdicionaSaldo(double valor) {

            return Saldo = Saldo + valor;

        }

        public double InformaSaldo()
        {
            return Saldo;
        }

        public double Saque(double valor)
        {
            Saldo = (Saldo - valor) - 5;
            return Saldo;
        }
    }
}
