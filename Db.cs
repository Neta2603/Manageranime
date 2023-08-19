using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

class AnimeContext : DbContext{
    public DbSet<Anime> anime { get;set; }
    public DbSet<Estado> estado { get;set; }
    public DbSet<Sexo> sexo { get;set; }
    public DbSet<Personaje> personaje {get;set;}
        
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite($"Data Source=anime.db");

}


public class Personaje {
    public int id { get; set; }
    public string Nombre { get; set; } = "";
    public string Apellido { get; set; } = "";
    public string Foto { get; set; } = "";
    public string Pronunciacion { get; set; } = "";
    public string Habilidad { get; set; } = "";
    public string Frase { get; set; } = "";
    public string Vestimenta { get; set; } = "";
    public float Altura { get; set; }
    public string Direccion{ get; set; } = "";
    public string Latitud { get; set; } = "";
    public string Longitud { get; set; } = "";
    public Anime anime { get; set; } = new Anime();
    public Sexo Sexo { get; set; } = new Sexo();
    public Estado Estados { get; set; } = new Estado();
    public DateTime Fecha { get; set; } 


}

public class Anime {
    public int id { get; set; }
    public string Nombre { get; set; } = "";
}

public class Sexo {
    public int id { get; set; }
    public string Nombre { get; set; } = "";
}

public class Estado {
    public int id { get; set; }
    public string Nombre { get; set; } = "";
}