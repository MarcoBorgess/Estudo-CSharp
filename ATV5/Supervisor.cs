namespace ATV5
{
    public class Supervisor : Funcionario
    {
        public double comissao { get; set; }
        public Supervisor() {
            comissao = 600.00;
        }
        public override string mostrarSalario()
        {
            salario += comissao;
            return base.mostrarSalario();
        }
    }
}