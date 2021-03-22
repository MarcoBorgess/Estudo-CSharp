namespace ATV5
{
    public class Funcionario
    {
        public int matricula { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public double salario { get; set; }

        public string mostrarDados(){
            return $"Matricula: {matricula} \r\nNome: {nome} \r\nIdade: {idade}";
        }
        public virtual string mostrarSalario(){
            return $"Salario: {salario.ToString("F2")}\r\n";
        }
    }
}