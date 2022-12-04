using Aterdigital.Pessoas;
using System.ComponentModel.DataAnnotations;

namespace Aterdigital.Usuarios;


public class Usuario : Pessoa
{
    [Required]
    public string UUsuario { get; set; }
    public String Cpf { get; set; }
    [StringLength(6, MinimumLength = 35, ErrorMessage = "Nome com mais de x caracteres")]
    public String Senha { get; set; }
    [EmailAddress]
    public String Email { get; set; }
    [Phone]
    public String NumeroDoCelular { get; set; } 
    [Phone]
    public String NumeroDoTelefone2 { get; set; }
    public String Sexo { get; set; }// (dropdown com resposta única) (Masculino ou Feminino)
    public String Inclusão { get; set; } // (Preenchimento automático pelo sistema - Usuário responsável pela inclusão dos dados)
    public DateTime DataDeInclusão { get; set; } // (Preenchimento automático pelo sistema - dd/mm/aaaa)
}
