using System.ComponentModel.DataAnnotations;

namespace Aterdigital.Pessoas;

public abstract class Pessoa
{
    [Required]
    [Key]
    public Guid Id { get; set; }
    public string NomeCompleto { get; set; }
    public string? Apelido { get; set; }
    public DateTime? DataDeNascimentoOuFundação { get; set; }
    public string? Endereco { get; set; }
    public string? Municipio { get; set; }
    public bool? Ativo { get; set; }
}