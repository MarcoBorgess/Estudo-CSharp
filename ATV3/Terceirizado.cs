namespace ATV3
{
    public class Terceirizado : Funcionario
    {
        public double despesaAdd { get; set; }

        public override double Pagamento()
        {
            double add = (despesaAdd*1.1);
            return (horas*valorHora)+add;
        }
    }
}