namespace ATV7
{
    public class Locacao
    {
        public Locacao(string nome, string data, double diasLoc, Veiculo veiculo)
        {
            this.Nome = nome;
            this.Data = data;
            this.DiasLoc = diasLoc;
            this.Veiculo = veiculo;

        }
        public string Nome { get; set; }
        public string Data { get; set; }
        public double DiasLoc { get; set; }
        public Veiculo Veiculo { get; set; }

        public string mostrarDados(){
            return $"Cliente: {Nome} \nData: {Data} \nVeiculo: {Veiculo.Marca} {Veiculo.Modelo} \nCor: {Veiculo.Cor} \nDias Alugado: {DiasLoc} \nValor diária: {Veiculo.Diaria.ToString("F2")}";
        }
        public double valorTotal(){
            return (DiasLoc * Veiculo.Diaria);
        }
    }
}