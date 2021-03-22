namespace ATV5
{
    public class Gerente : Funcionario
    {
        public double comissao { get; set; }
        public Gerente()
        {
            comissao = 1000.00;
        }
        public override string mostrarSalario()
        {
            salario += comissao;
            return base.mostrarSalario();
        }
    }
}