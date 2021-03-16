namespace ATV3
{
    public class Funcionario
    {
        
        public string nome { get; set; }
        public double horas { get; set; }
        public double valorHora { get; set; }
        public Funcionario()
        {

        }
        public virtual double Pagamento(){
            return horas * valorHora;
        }
    }
}