namespace ATV5
{
    public class Vendedor : Funcionario
    {
        public double comissao { get; set; }
        public Vendedor(){
            comissao = 300.00;
        }
        public override string mostrarSalario()
        {
            salario += comissao;
            return base.mostrarSalario();
        }
    }
}