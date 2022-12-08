using Aterdigital.Agricultores;
using Aterdigital.Usuarios;
using System.ComponentModel.DataAnnotations;

namespace Aterdigital.Agricultores;

public class CreateAgricultorViewModel
{
    [Required]
    public string NomeCompleto { get; set; }
    public string? Apelido { get; set; }
    public DateTime? DataDeNascimento { get; set; }
    public string? Endereco { get; set; }
    public string? Municipio { get; set; }
    public bool? Ativo { get; set; }
    public String UsuarioTexto { get; set; }
    [Required]
    public String Cpf { get; set; }
    [Required]
    [StringLength(35, MinimumLength = 6, ErrorMessage = "Nome com mais de x caracteres")]
    public String Senha { get; set; }
    [EmailAddress]
    public String? Email { get; set; }
    [Phone]
    public String? NumeroDoTelefone { get; set; }
    [Phone]
    public String? NumeroDoTelefone2 { get; set; }
    public Sexos? Sexo { get; set; }
    public String? AgricultorTexto { get; set; }
    public bool? Titular { get; set; }

    public Categorias? Categoria { get; set; }
    public Escolaridades? Escolaridade { get; set; }
    public String? CadPro { get; set; }
}
