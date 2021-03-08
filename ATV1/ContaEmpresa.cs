namespace ATV1
{
    public class ContaEmpresa : Conta
    {
        public double LimiteEmprestimo { get; set; }
        public void Emprestar(double valor){
            if (LimiteEmprestimo>=valor){
                Depositar(valor);
            }
        }
    }
}