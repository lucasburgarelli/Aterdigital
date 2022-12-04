using Aterdigital.Usuario;
using Aterdigital.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aterdigital.Agricultores;

public class Agricultor : Usuario
{
    public String Agricultorr { get; set; }// (texto - pessoa física - Usuário)
    public Boolean Titular { get; set; }// (botão com resposta única) (Sim ou Não)
    public String Categoria { get; set; }// (dropdown em tabela auxiliar com resposta única) (Agricultor familiar, Agricultor outro, Pescador, Quilombola, Indígena, ...)
    public String Escolaridade { get; set; }// (dropdown em tabela auxiliar com resposta única) (Fundamental, 1º grau,2º grau, 3º grau, ...)
    public String CadPro { get; set; }// (texto com formato padrão)
    public String ResponsavelpelaValidacao { get; set; }// (Preenchido automático pelo sistema - buscar em uma tabela o Usuário responsável pela validação dos dados)
    public DateTime DataDaValidacao { get; set; }// (Preenchimento automático pelo sistema - dd/mm/aaaa)
    public DateTime DataDeInclusao { get; set; }// (Preenchimento automático pelo sistema - dd/mm/aaaa)
}
