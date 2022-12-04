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
        builder.Entity<Usuario>().HasData(Data.usuarios);
        builder.Entity<Agricultor>().HasData(Data.agricultores);


        return builder;
    }
}

internal static class Data
{
    public static List<Usuario> usuarios = new ()
    {
        new Usuario() {}
    };

    public static List<Agricultor> agricultores = new ()
    {
        new Agricultor() {}
    };
}