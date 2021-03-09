namespace ATV2
{
    public class Conta
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public void Sacar (double valor){
            if (Saldo>=valor) {
                 Saldo -= valor;
            } 
        }
        public void Depositar (double valor){
            Saldo += valor;
        }
        public Conta transferir (Conta favorecido, double valor){
            Saldo -= valor;
            favorecido.Saldo += valor;
            return favorecido;
        }
    }
}