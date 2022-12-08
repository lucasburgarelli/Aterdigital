using Aterdigital.Agricultores;
using Aterdigital.Usuarios;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.IO.Pipelines;
using System.Reflection.Metadata;

namespace Aterdigital;

public static class ModelBuilderExtension
{
    public static ModelBuilder SeedData(this ModelBuilder builder)
    {
        builder.Entity<Agricultor>().HasData(Data.agricultores);

        return builder;
    }
}

internal static class Data
{
    public static List<Agricultor> agricultores = new()
    {
        new Agricultor(new CreateAgricultorViewModel
            {
                NomeCompleto = "Levi Manuel Roberto Campos",
                Apelido = "Ademiro",
                DataDeNascimento = DateTime.Now,
                Endereco =  "Rua Vereador Homero Franco 1208, Numero 262",
                Municipio = "Campina da Lagoa",
                Cpf = "562.395.709-90",
                Senha = "adminadmin",
                Email = "admin@admin.com",
                UsuarioTexto= "admin",
            })
    };
}