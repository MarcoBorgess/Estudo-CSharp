namespace ATV1
{
    public class Conta
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public void Sacar(double valor){
            Saldo -= valor;
        }
        public void Depositar(double valor){
            Saldo += valor;
        }
    }
}