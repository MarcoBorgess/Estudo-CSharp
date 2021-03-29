namespace ATV6
{
    public class Capa
    {
        public string cor { get; set; }
        public string material { get; set; }
        public double valor { get; set; }
        public Capa(string cor, string material, double valor)
        {
            this.cor = cor;
            this.material = material;
            this.valor = valor;
        }
    }
}