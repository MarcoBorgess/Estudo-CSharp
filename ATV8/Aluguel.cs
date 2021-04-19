namespace ATV8
{
    public class Aluguel
    {
        public Aluguel(string nome, string email, int quarto)
        {
            this.Nome = nome;
            this.Email = email;
            this.Quarto = quarto;

        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }
    }
}