using Aterdigital.Pessoas;
using System.ComponentModel.DataAnnotations;

namespace Aterdigital.Usuarios;

public class Usuario : Pessoa
{
    public String UsuarioTexto { get; set; }
    [Required]
    public String Cpf { get; set; }
    [StringLength(35, MinimumLength = 6, ErrorMessage = "Nome com mais de x caracteres")]
    public String Senha { get; set; }
    [EmailAddress]
    public String? Email { get; set; }
    [Phone]
    public String? NumeroDoTelefone { get; set; }
    [Phone]
    public String? NumeroDoTelefone2 { get; set; }
    public Sexos? Sexo { get; set; }
    public Guid Inclusão { get; set; } = new Guid(); // (Preenchimento automático pelo sistema - Usuário responsável pela inclusão dos dados)
    public DateTime DataDeInclusão { get; set; } = DateTime.Now; // (Preenchimento automático pelo sistema - dd/mm/aaaa)
}

public enum Sexos
{
    Masculino,
    Feminino
}
