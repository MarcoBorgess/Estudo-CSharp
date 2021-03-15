namespace ATV1
{
    public class Conta
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Conta(string nome, int numero, double saldo) 
        {
            this.Nome = nome;
            this.Numero = numero;
            this.Saldo = saldo;
        }
        public void Sacar(double valor)
        {
            Saldo -= valor;
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
    }
}