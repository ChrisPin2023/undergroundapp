using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Models.DataBase
{
    public class UndergroundDbContext: DbContext
    {
        public UndergroundDbContext(DbContextOptions<UndergroundDbContext> options) 
        : base(options){}


        // Mapeando as tabelas do banco de dados
        // public DbSet<Nome da Classe c#> Nome que sera registrado na bd {get; set;}
        public DbSet<Contacto> Tb_Contacto {get; set;}
        public DbSet<Endereco> Tb_Endereco {get; set;}
        public DbSet<Pessoa> Tb_Pessoa {get; set;}
        public DbSet<Entrada> Tb_Entrada {get; set;}
        public DbSet<Saida> Tb_Saida {get; set;}
        public DbSet<Hospital> Tb_Hospital {get; set;}
        public DbSet<Paciente> Tb_Paciente {get; set;}
        public DbSet<Tecnico> Tb_Tecnico {get; set;}
        public DbSet<Medico> Tb_Medico {get; set;}
        public DbSet<Naturalidade> Tb_Naturalidade {get; set;}
        public DbSet<Pedido> Tb_Pedido {get; set;}
        public DbSet<Stock> Tb_Stock {get; set;}
        public DbSet<Dador> Tb_Dador {get; set;}
        
    }
}