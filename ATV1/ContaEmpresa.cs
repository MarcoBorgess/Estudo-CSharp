namespace ATV1
{
    public class ContaEmpresa : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaEmpresa(string nome, int numero, double saldo, double limiteEmprestimo) :
        base(nome, numero, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }
        public void Emprestar(double valor){
            if (LimiteEmprestimo>=valor){
                Depositar(valor);
            }
        }
    }
}