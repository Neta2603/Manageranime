class Config{

    public static void Programa()
    {
        Console.Clear();
        Console.WriteLine(@"
            
            
            Configuración

            1 - Animes
            2 - Estados
            3 - Sexos
            4 - Regresar
            
            ");
            
        Console.Write("Escoga una opcion de las anteriores a la que deseas acceder: ");
        string opc = Console.ReadLine() ?? "";

        switch (opc)
        {
            case "1":
                Console.WriteLine("Animes ");
                Config.Series();
            break;

            case "2":
                Console.WriteLine("Estados");
                Config.Estado();
            break;

            case "3":
                Console.WriteLine("Sexo");
                Config.Sexo();
            break;

            case "4":
                Utils.retorno();
            break;

            default:
                Console.Write("Opcion Invalida!! Eliga de nuevo");
                Console.ReadKey();
                Config.Programa();
                break;
        }

    }

    public static void Series() {

        var db = new AnimeContext();
        Console.Clear();
        Console.WriteLine(@"

            Gestion de Series.

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
                Console.Clear();
                Console.WriteLine("Registrar Animes");

                var a = new Anime();
        
                a.Nombre = Utils.LeerCadena("Ingrese el Nombre: ");
        
                db.anime.Add(a);
                db.SaveChanges();
                Console.WriteLine("Anime registrado");
                Console.ReadKey();
                Config.Series();

            break;

            case "2":
                Console.Clear();
                Console.WriteLine("Editar Animes");

                var ListadoAnime = db.anime.ToList();

                foreach (var anim in ListadoAnime)
                {
                    Console.WriteLine($"{ListadoAnime.IndexOf(anim)+1} - {anim.Nombre}");
                }

                Console.Write("Ingrese el id del anime: ");
                var editar = db.anime.Find(int.Parse(Console.ReadLine() ?? ""));

                if (editar == null)
                {
                    Console.WriteLine("No se encontro el anime");
                }
                else
                {
                    Console.WriteLine($"Ingrese el nuevo nombre del anime: ({editar.Nombre}) ");
                    editar.Nombre = Console.ReadLine() ?? "";
                    db.SaveChanges();
                    Console.WriteLine("Anime editado");
                    Console.ReadKey();
                    Config.Series();
                }
                    
            break;

            case "3":
                Console.Clear();
                Console.WriteLine("Eliminar Animes");

                var Listadoanime = db.anime.ToList();

                foreach (var anim in Listadoanime)
                {
                    Console.WriteLine($"{Listadoanime.IndexOf(anim)+1} - {anim.Nombre}");
                }

                Console.Write("Ingrese el id del anime: ");
                var eliminar = db.anime.Find(int.Parse(Console.ReadLine() ?? ""));

                if (eliminar == null)
                {
                    Console.WriteLine("No se encontro el anime");
                    Config.Series();
                }
                else
                {
                    db.anime.Remove(eliminar);
                    db.SaveChanges();
                    Console.WriteLine("Anime eliminado");
                    Console.ReadKey();
                    Config.Series();
                }

            break;

            case "4":
                Config.Programa();
            break;

            default:
                Console.Write("Opcion Invalida!! Eliga de nuevo");
                Console.ReadKey();
                Config.Programa();
                break;
        }
    }

    
    public static void Estado() {

        var db = new AnimeContext();
        Console.Clear();
        Console.WriteLine(@"

            Gestion de Estados.

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
                Console.Clear();
                Console.WriteLine("Registrar Estados");

                var a = new Estado();
        
                a.Nombre = Utils.LeerCadena("Ingrese el estado: ");
        
                db.estado.Add(a);
                db.SaveChanges();
                Console.WriteLine("Estado registrado");
                Console.ReadKey();
                Config.Estado();

            break;

            case "2":
                Console.Clear();
                Console.WriteLine("Editar Estados");

                var ListadoEstado = db.estado.ToList();

                foreach (var anim in ListadoEstado)
                {
                    Console.WriteLine($"{ListadoEstado.IndexOf(anim)+1} - {anim.Nombre}");
                }

                Console.Write("Ingrese el id del estado: ");
                var editar = db.estado.Find(int.Parse(Console.ReadLine() ?? ""));

                if (editar == null)
                {
                    Console.WriteLine("No se encontro el estado");
                }
                else
                {
                    Console.WriteLine($"Ingrese el nuevo nombre del estado: ({editar.Nombre}) ");
                    editar.Nombre = Console.ReadLine() ?? "";
                    db.SaveChanges();
                    Console.WriteLine("Estado editado");
                    Console.ReadKey();
                    Config.Estado();
                }
                    
            break;

            case "3":
                Console.Clear();
                Console.WriteLine("Eliminar Estado");

                var ListadoEstadox = db.estado.ToList();

                foreach (var anim in ListadoEstadox)
                {
                    Console.WriteLine($"{ListadoEstadox.IndexOf(anim)+1} - {anim.Nombre}");
                }

                Console.Write("Ingrese el id del estado: ");
                var eliminar = db.estado.Find(int.Parse(Console.ReadLine() ?? ""));

                if (eliminar == null)
                {
                    Console.WriteLine("No se encontro el estado");
                    Config.Estado();
                }
                else
                {
                    db.estado.Remove(eliminar);
                    db.SaveChanges();
                    Console.WriteLine("Estado eliminado");
                    Console.ReadKey();
                    Config.Estado();
                }

            break;

            case "4":
                Config.Programa();
            break;

            default:
                Console.Write("Opcion Invalida!! Eliga de nuevo");
                Console.ReadKey();
                Config.Programa();
                break;
        }
    }

    public static void Sexo() {

        var db = new AnimeContext();
        Console.Clear();
        Console.WriteLine(@"

            Gestion de Sexos.

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
                Console.Clear();
                Console.WriteLine("Agregar Sexos");

                var a = new Sexo();
        
                a.Nombre = Utils.LeerCadena("Ingrese el Sexo: ");
        
                db.sexo.Add(a);
                db.SaveChanges();
                Console.WriteLine("Sexo registrado");
                Console.ReadKey();
                Config.Sexo();

            break;

            case "2":
                Console.Clear();
                Console.WriteLine("Editar Sexo");

                var ListadoSexo = db.sexo.ToList();

                foreach (var anim in ListadoSexo)
                {
                    Console.WriteLine($"{ListadoSexo.IndexOf(anim)+1} - {anim.Nombre}");
                }

                Console.Write("Ingrese el id del sexo: ");
                var editar = db.sexo.Find(int.Parse(Console.ReadLine() ?? ""));

                if (editar == null)
                {
                    Console.WriteLine("No se encontro el sexo");
                }
                else
                {
                    Console.WriteLine($"Ingrese el nuevo nombre del sexo: ({editar.Nombre}) ");
                    editar.Nombre = Console.ReadLine() ?? "";
                    db.SaveChanges();
                    Console.WriteLine("Sexo editado");
                    Console.ReadKey();
                    Config.Sexo();
                }
                    
            break;

            case "3":
                Console.Clear();
                Console.WriteLine("Eliminar Sexo");

                var ListadoSexox = db.sexo.ToList();

                foreach (var anim in ListadoSexox)
                {
                    Console.WriteLine($"{ListadoSexox.IndexOf(anim)+1} - {anim.Nombre}");
                }

                Console.Write("Ingrese el id del sexo: ");
                var eliminar = db.sexo.Find(int.Parse(Console.ReadLine() ?? ""));

                if (eliminar == null)
                {
                    Console.WriteLine("No se encontro el sexo");
                    Config.Sexo();
                }
                else
                {
                    db.sexo.Remove(eliminar);
                    db.SaveChanges();
                    Console.WriteLine("Sexo eliminado");
                    Console.ReadKey();
                    Config.Sexo();
                }

            break;

            case "4":
                Config.Programa();
            break;

            default:
                Console.Write("Opcion Invalida!! Eliga de nuevo");
                Console.ReadKey();
                Config.Programa();
                break;
        }

    }

}