namespace ATV4
{
    public class ProdutoUsado : Produto
    {
        public int anoFabr { get; set; }

        public override string PrecoEtiqueta()
        {
            return (nome + " (usado) $" + preco.ToString("F2") + " (Ano de fabricação: "+ anoFabr + ")");
        }
    }
}