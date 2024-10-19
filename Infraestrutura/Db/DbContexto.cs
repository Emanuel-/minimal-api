using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Entidades; 

namespace MinimalApi.Infraestrutura.Db;
public class DbContexto : DbContext
{
    private readonly IConfiguration _configuracaoAppSettings;
    public DbContexto(IConfiguration configuracaoAppSettings)
    {
        _configuracaoAppSettings = configuracaoAppSettings;
    }
    public DbSet<Administrador> Administradores { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            "string de conexão", 
            ServerVersion.AutoDetect("String de Conexão")
            );
    }

}