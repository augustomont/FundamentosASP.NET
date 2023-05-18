namespace FundamentosASP.NET.Models
{
    public class HomeModel //Cria a Classe 
    {
        //Aqui é posto os Atributos da Model
        public string Nome { get; set; } //Cada Propriedade é considerada uma coluna quando migrado para SQL
        public string Email { get; set; }
    }
}
