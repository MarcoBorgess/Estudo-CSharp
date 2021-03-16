namespace ATV4
{
    public class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }

        public virtual string PrecoEtiqueta()
        {
            return (nome + " $" + preco.ToString("F2"));
        }
    }
}