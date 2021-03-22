namespace ATV4
{
    public class ProdutoImportado : Produto
    {
        public double taxaImportacao { get; set; }

        public override string PrecoEtiqueta()
        {
            return (nome + " $" + PrecoTotal().ToString("F2") + " (taxa de importação $" + taxaImportacao + ")");
        }
        public double PrecoTotal()
        {
            return preco+taxaImportacao;
        }
    }
}