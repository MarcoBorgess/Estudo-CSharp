namespace ATV7
{
    public class Veiculo
    {
        public Veiculo(string marca, string modelo, string cor, double diaria)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Cor = cor;
            this.Diaria = diaria;

        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public double Diaria { get; set; }
    }
}