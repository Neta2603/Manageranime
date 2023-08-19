using Microsoft.EntityFrameworkCore;
class Gestion {

    public static void Personajes()
    {
        Console.Clear();
        Console.WriteLine(@"
            
            
            Gestion de Personajes

            1 - Agregar 
            2 - Editar
            3 - Eliminar
            4 - Regresar
            
            ");
            
        Console.Write("Escoga una opcion de las anteriores a la que deseas acceder: ");
        string opc = Console.ReadLine() ?? "";

        switch (opc)
        {
            case "1":
                Console.WriteLine("Agregar ");
                Gestion.Agregar();
            break;

            case "2":
                Console.WriteLine("Editar");
                Gestion.Editar();
            break;

            case "3":
                Console.WriteLine("Eliminar");
                Gestion.Eliminar();
            break;

            case "4":
                Utils.retorno();
            break;

            default:
                Console.Write("Opcion Invalida!! Eliga de nuevo");
                Console.ReadKey();
                Gestion.Personajes();
                break;
        }

    }


    public static void Agregar() {

        var db = new AnimeContext();
        Console.Clear();
        Console.WriteLine("Registrar Personajes");

        var p = new Personaje();

        p.Nombre = Utils.LeerCadena("Ingrese el Nombre: ");
        p.Apellido = Utils.LeerCadena("Ingrese el Apellido: ");
        p.Foto = Utils.LeerCadena("Ingrese la url de la foto: ");
        p.Pronunciacion = Utils.LeerCadena("Ingrese la pronunciacion del nombre del personaje: ");

        var ListadoAnime = db.anime.ToList();

        foreach (var anim in ListadoAnime)
        {
            Console.WriteLine($"{ListadoAnime.IndexOf(anim)+1} - {anim.Nombre}");
        }

        Console.Write("Ingrese el id del anime: ");
        var anm = db.anime.Find(int.Parse(Console.ReadLine() ?? ""));

        if (anm == null)
        {
            Console.WriteLine("No se encontro el anime");
        }
        else
        {
            p.anime = anm;
        }

        Console.WriteLine("Ingrese la fecha de nacimiento del personaje (DD/MM/AA):");
        string Fecha = Console.ReadLine() ?? "";
        DateTime fecha = DateTime.Parse(Fecha);
        p.Fecha = fecha;

        p.Habilidad =  Utils.LeerCadena("Ingrese la habilidad que posee: ");
        p.Frase = Utils.LeerCadena("Ingrese la frase iconica del personaje: ");
        p.Vestimenta = Utils.LeerCadena("Ingrese como viste el personaje: ");
        p.Altura = Utils.LeerEntero("Ingrese la altura: ");

        var ListadoSexo = db.sexo.ToList();

        foreach (var sx in ListadoSexo)
        {
            Console.WriteLine($"{ListadoSexo.IndexOf(sx)+1} - {sx.Nombre}");
        }

        Console.Write("Ingrese el id del sexo: ");
        var sxo = db.sexo.Find(int.Parse(Console.ReadLine() ?? ""));

        if (sxo == null)
        {
            Console.WriteLine("No se encontro el sexo");
        }
        else
        {
            p.Sexo = sxo;
        }

        var ListadoEstado = db.estado.ToList();

        foreach (var es in ListadoEstado)
        {
            Console.WriteLine($"{ListadoEstado.IndexOf(es)+1} - {es.Nombre}");
        }

        Console.Write("Ingrese el id del estado: ");
        var est = db.estado.Find(int.Parse(Console.ReadLine() ?? ""));

        if (est == null)
        {
            Console.WriteLine("No se encontro el estado");
        }
        else
        {
            p.Estados = est;
        }

        p.Direccion = Utils.LeerCadena("Ingrese la direccion: ");

        p.Latitud = Utils.LeerCadena("Ingrese la latitud: ");
        if(p.Latitud == ""){
            p.Latitud = "18.7088620639612952";
        }

        p.Longitud = Utils.LeerCadena("Ingrese la longitud: ");
        if(p.Longitud == ""){
            p.Longitud = "-70.60207406762096";
        }

        db.personaje.Add(p);
        db.SaveChanges();
        Console.WriteLine("Personaje registrado");
        Gestion.Personajes();
    }

    public static void Editar(){
        var db = new AnimeContext();
        Console.Clear();
        Console.WriteLine("Editar Personajes");

        var p = new Personaje();

        var ListadoPersonaje = db.personaje.ToList();

        foreach (var anim in ListadoPersonaje)
        {
            Console.WriteLine($@"
 
                    Id: {ListadoPersonaje.IndexOf(anim)+1} 
                    Nombre: {anim.Nombre}                   
                    Apellido: {anim.Apellido}

                ");
        }

            Console.Write("Ingrese el id del personaje a editar: ");
            var editar = db.personaje.Find(int.Parse(Console.ReadLine() ?? ""));

            if (editar == null)
            {
                Console.WriteLine("No se encontro el personaje");
            }
            else
            {
                Console.WriteLine($"Ingrese el nuevo nombre del personaje: ({editar.Nombre}) ");
                editar.Nombre = Console.ReadLine() ?? "";

                Console.WriteLine($"Ingrese el nuevo apellido del personaje: ({editar.Apellido}) ");
                editar.Apellido = Console.ReadLine() ?? "";                

                Console.WriteLine($"Ingrese la nueva foto del personaje: ({editar.Foto}) ");
                editar.Foto = Console.ReadLine() ?? "";

                Console.WriteLine($"Ingrese la nueva pronunciacion del personaje: ({editar.Pronunciacion}) ");
                editar.Pronunciacion = Console.ReadLine() ?? "";

                var ListadoAnime = db.anime.ToList();

                foreach (var anim in ListadoAnime)
                {
                    Console.WriteLine($"{ListadoAnime.IndexOf(anim)+1} - {anim.Nombre}");
                }

                Console.WriteLine($"Ingrese el id del anime al que quiere que pertenezca: ({editar.anime.Nombre}) ");
                editar.anime.id = Console.Read();

                Console.WriteLine($"Ingrese la nueva fecha de nacimiento del personaje: ({editar.Fecha}) ");
                string Fecha = Console.ReadLine() ?? "";
                DateTime fecha = DateTime.Parse(Fecha);
                p.Fecha = fecha;
        
                Console.WriteLine($"Ingrese el nuevo poder del personaje: ({editar.Habilidad}) ");
                editar.Habilidad = Console.ReadLine() ?? "";

                Console.WriteLine($"Ingrese la correcta frase favorita del personaje: ({editar.Frase}) ");
                editar.Frase = Console.ReadLine() ?? "";

                Console.WriteLine($"Ingrese la nueva vestimenta del personaje: ({editar.Vestimenta}) ");
                editar.Vestimenta = Console.ReadLine() ?? "";

                Console.WriteLine($"Ingrese la nueva altura del personaje: ({editar.Altura}) ");
                editar.Altura = Console.Read();

                var ListadoSexo = db.sexo.ToList();

                foreach (var sx in ListadoSexo)
                {
                    Console.WriteLine($"{ListadoSexo.IndexOf(sx)+1} - {sx.Nombre}");
                }

                Console.WriteLine($"Ingrese el nuevo sexo del personaje: ({editar.Sexo.Nombre}) ");
                editar.Sexo.id = Console.Read();

                var ListadoEstado = db.estado.ToList();

                foreach (var es in ListadoEstado)
                {
                    Console.WriteLine($"{ListadoEstado.IndexOf(es)+1} - {es.Nombre}");
                }      

                Console.WriteLine($"Ingrese el nuevo estado del personaje: ({editar.Estados.Nombre}) ");
                editar.Estados.id = Console.Read();

                Console.WriteLine($"Ingrese la nueva latitud del personaje: ({editar.Latitud}) ");
                editar.Latitud = Console.ReadLine() ?? "";

                Console.WriteLine($"Ingrese la nueva longitud del personaje: ({editar.Longitud}) ");
                editar.Longitud = Console.ReadLine() ?? "";

                db.SaveChanges();
                Console.WriteLine("Personaje editado");
                Console.ReadKey();
                Gestion.Personajes();
            }        

    }

    public static void Eliminar(){
        var db = new AnimeContext();
        Console.Clear();
        Console.WriteLine("Eliminar Personajes");

        var p = new Personaje();

        var ListadoPersonaje = db.personaje.ToList();

        foreach (var anim in ListadoPersonaje)
        {
            Console.WriteLine($@"
 
                    Id: {ListadoPersonaje.IndexOf(anim)+1} 
                    Nombre: {anim.Nombre}                   
                    Apellido: {anim.Apellido}
                    Anime: {anim.anime.Nombre} 
              
                ");
        }

            Console.Write("Ingrese el id del personaje a eliminar: ");
            var eliminar = db.personaje.Find(int.Parse(Console.ReadLine() ?? ""));

            if (eliminar == null)
            {
                Console.WriteLine("No se encontro el personaje");
                Gestion.Eliminar();
            }
            else
            {
                db.personaje.Remove(eliminar);
                db.SaveChanges();
                Console.WriteLine("Personaje eliminado");
                Console.ReadKey();
                Gestion.Personajes();
            }        

    }

}