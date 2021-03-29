namespace ATV6
{
    public class Celular
    {
        public string marca { get; set; }
        public string cor { get; set; }
        public string modelo { get; set; }
        public double valor { get; set; }
        public Capa Capa { get; set; }
        public Celular(string marca, string cor, string modelo, double valor, Capa capa)
        {
            this.marca = marca;
            this.cor = cor;
            this.modelo = modelo;
            this.valor = valor;
            this.Capa = capa;
        }
        
        public double valorTotal()
        {
            return (valor+Capa.valor);
        }
    }
}