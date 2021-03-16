namespace ATV4
{
    public class ProdutoImportado : Produto
    {
        public double taxaImportacao { get; set; }

        public override string PrecoEtiqueta()
        {
            preco+= taxaImportacao;
            return (nome + " $" + preco.ToString("F2") + " (taxa de importação $" + taxaImportacao + ")");
        }
    }
}