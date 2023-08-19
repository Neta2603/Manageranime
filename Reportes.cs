class Reportes{

    public static void Listas(){
        var db = new AnimeContext();

        Console.Clear();
        Console.WriteLine(@"
            
            
              Reportes

              1 - Listado de personajes
              2 - Listado por signo Zodiacal
              3 - Reporte de cumpleaños
              4 - Mapa de personaje
              5 - Exportar personajes
              6 - Reporte por animes               
              7 - Reporte por estado              
              8 - Regresar
            
            ");
            
        Console.Write("Escoga una opcion de las anteriores a la que deseas acceder: ");
        string opc = Console.ReadLine() ?? "";

        switch (opc)
        {
            case "1":
                Console.WriteLine("Listado de personajes");
                
                var ListadoPersonaje = db.personaje.ToList();

                foreach (var anim in ListadoPersonaje)
                {
                    DateTime FechaN = anim.Fecha;
                    DateTime FechaA = DateTime.Today;
                    var edad = FechaA.Year - FechaN.Year;

                    Console.WriteLine($@"
 
                    Id: {ListadoPersonaje.IndexOf(anim)+1} 
                    Nombre: {anim.Nombre}                   
                    Apellido: {anim.Apellido}
                    Anime: {anim.anime.Nombre} 
                    Género: {anim.Sexo.Nombre}
                    Edad: {edad}
              
                    ");
                }

                Console.ReadKey();
                Reportes.Listas();

            break;

            case "2":
                Console.WriteLine("Listado por signo Zodiacal");

                var query = (from bd in db.personaje
                join an in db.anime on bd.anime equals an
                join es in db.estado on bd.Estados equals es
                join sx in db.sexo on bd.Sexo equals sx
                 
                select new {

                    bd.id,
                    bd.Nombre,
                    bd.Apellido,
                    bd.anime,
                    bd.Sexo,
                    Date = bd.Fecha

                }).ToList();

                var Aries = "";
                var Tauro = "";
                var Geminis = "";
                var Cancer = "";
                var Leo = "";
                var Virgo = "";
                var Libra = "";
                var Escorpio = "";
                var Sagitario = "";
                var Capricornio = "";
                var Acuario = "";
                var Piscis = "";

                foreach( var pj in query ){

                DateTime FechaN = pj.Date;
                DateTime FechaA = DateTime.Today;
              
                int dia = pj.Date.Day;
                int mes = pj.Date.Month;
                var edad = FechaA.Year - FechaN.Year;

                if (FechaN > FechaA.AddYears(-edad)) edad--;

                var Personajes = @$"

                ********************************************
                    Nombre: {pj.Nombre} 
                    Apellido: {pj.Apellido}
                    Anime: {pj.anime.Nombre} 
                    Sexo: {pj.Sexo.Nombre} 
                    Fecha de nacimiento: {pj.Date}
                    Edad: {edad}
                **********************************************
                ";

                if((dia>=21&&mes==3)||(dia<=20&&mes==4))
                  Aries+=Personajes;

                if((dia>=24&&mes==9)||(dia<=23&&mes==10))
                    Libra+=Personajes;
               
                if((dia>=21&&mes==4)||(dia<=21&&mes==5))
                    Tauro+=Personajes;
               
                if((dia>=24&&mes==10)||(dia<=22&&mes==11))
                    Escorpio+=Personajes;
               
                if((dia>=22&&mes==5)||(dia<=21&&mes==6))
                    Geminis+=Personajes;
               
                if((dia>=23&&mes==11)||(dia<=21&&mes==12))
                    Sagitario+=Personajes;
               
                if((dia>=21&&mes==6)||(dia<=23&&mes==7))
                    Cancer+=Personajes;
                
                if((dia>=22&&mes==12)||(dia<=20&&mes==1))
                    Capricornio+=Personajes;
                
                if((dia>=24&&mes==7)||(dia<=23&&mes==8))
                    Leo += Personajes;
               
                if((dia>=21&&mes==1)||(dia<=19&&mes==2))
                    Acuario += Personajes;
                
                if((dia>=24&&mes==8)||(dia<=23&&mes==9))
                    Virgo += Personajes;
                
                if((dia>=20&&mes==2)||(dia<=20&&mes==3))
                    Piscis += Personajes;

                Console.WriteLine(@$"

                   Aries: 
                   {Aries}

                   Libra: 
                   {Libra}

                   Tauro: 
                   {Tauro}

                   Escorpio: 
                   {Escorpio}

                   Geminis: 
                   {Geminis}

                   Sagitario: 
                   {Sagitario}

                   Cancer: 
                   {Cancer}

                   Capricornio:
                   {Capricornio}

                   Leo: 
                   {Leo}

                   Acuario: 
                   {Acuario}

                   Virgo: 
                   {Virgo}

                   Piscis: 
                   {Piscis}
                
                ");

                
            }
            Console.ReadKey();
            Reportes.Listas();

            break;

            case "3":
                Console.WriteLine("Reporte de cumpleaños");

                var querys = (from bd in db.personaje
                join an in db.anime on bd.anime equals an
                join es in db.estado on bd.Estados equals es
                join sx in db.sexo on bd.Sexo equals sx
                 
                select new {

                    bd.id,
                    bd.Nombre,
                    bd.Apellido,
                    bd.anime,
                    bd.Sexo,
                    Date = bd.Fecha

                }).ToList();

                var Enero ="";
                var Febrero ="";
                var Marzo ="";
                var Abril ="";
                var Mayo ="";
                var Junio ="";
                var Julio ="";
                var Agosto ="";
                var Septiembre ="";
                var Octubre ="";
                var Noviembre ="";
                var Diciembre ="";

                foreach( var pj in querys){

                DateTime FechaN = pj.Date;
                DateTime FechaA = DateTime.Today;
              
                int dia = pj.Date.Day;
                int mes = pj.Date.Month;
                var edad = FechaA.Year - FechaN.Year;

                if (FechaN > FechaA.AddYears(-edad)) edad--;

                var Personajes = @$"

                ********************************************
                    Nombre: {pj.Nombre} 
                    Apellido: {pj.Apellido}
                    Anime: {pj.anime.Nombre} 
                    Sexo: {pj.Sexo.Nombre} 
                    Fecha de nacimiento: {pj.Date}
                    Edad: {edad}
                **********************************************
                ";
                
                if(mes==1)
                  Enero+=Personajes;
              
                if(mes==2)
                    Febrero+=Personajes;
               

                if(mes==3)
                    Marzo+=Personajes;
               
                if(mes==4)
                    Abril+=Personajes;
               
                if(mes==5)
                    Mayo+=Personajes;
            
                if(mes==6)
                    Junio+=Personajes;
               
                if(mes==7)
                    Julio+=Personajes;
                

                if(mes==8)
                    Agosto+=Personajes;
                

                if(mes==9)
                    Septiembre += Personajes;
               

                if(mes==10)
                    Octubre += Personajes;
                

                if(mes==11)
                    Noviembre += Personajes;
                

                if(mes==12)
                    Diciembre += Personajes;
            }

                Console.WriteLine(@$"

                   Enero: 
                   {Enero}

                   Febrero: 
                   {Febrero}

                   Marzo: 
                   {Marzo}

                   Abril: 
                   {Abril}

                   Mayo: 
                   {Mayo}

                   Junio: 
                   {Junio}

                   Julio: 
                   {Julio}

                   Agosto:
                   {Agosto}

                   Septiembre: 
                   {Septiembre}

                   Octubre: 
                   {Octubre}

                   Noviembre: 
                   {Noviembre}

                   Diciembre: 
                   {Diciembre}
                
                ");
                

                Console.ReadKey();
                Reportes.Listas();
                
            break;

            case "4":
                Console.WriteLine("Mapa de personaje");

                var ListadoPersonajex = db.personaje.ToList();

                var marcadores="";

                foreach(var mp in ListadoPersonajex){

                marcadores+=@$"

                var marker = L.marker([{mp.Latitud}, {mp.Longitud}]).addTo(map)
		        .bindPopup(`
                Nombre: {mp.Nombre}
                Apellido: {mp.Apellido}</br>
                Anime: {mp.anime.Nombre}</br>
                Sexo: {mp.Sexo.Nombre}</br>
                `);

                ";
            }
        
            var map=System.IO.File.ReadAllText("map.html");
            map=map.Replace("CODIGODINAMICODEC#", marcadores);

            System.IO.File.WriteAllText("mapa.html", map);

            Utils.Nav("mapa.html");

            Console.ReadKey();
            Reportes.Listas();   

            break;

            case "5":

                Console.WriteLine("Exportar personajes");

                var queryy = (from personajes in db.personaje
                join an in db.anime on personajes.anime equals an
                join es in db.estado on personajes.Estados equals es
                join sx in db.sexo on personajes.Sexo equals sx

                select new {
                personajes.id,
                personajes.Nombre,
                personajes.Apellido,
                personajes.anime,
                personajes.Sexo,
                personajes.Habilidad,
                personajes.Vestimenta,
                personajes.Pronunciacion,
                personajes.Direccion,
                personajes.Foto,
                personajes.Estados,
                Date = personajes.Fecha,

        }).ToList();

       foreach (var pers in queryy){
           DateTime FechaN = pers.Date;
           DateTime FechaA = DateTime.Today;

           var anl = FechaN.Year - FechaA.Year;
           if(FechaN > FechaA.AddYears(- anl )) anl--;

            Console.WriteLine(@$"

            
             id: {pers.id}
             Nombre: {pers.Nombre}
             Apellido: {pers.Apellido}
             Anime: {pers.anime.Nombre}
             Fecha de nacimiento: {pers.Date}
             Direccion: {pers.Direccion}
             Habilidad: {pers.Habilidad}
             Vestimenta: {pers.Vestimenta}
             Pronunciacion: {pers.Pronunciacion}
             Sexo: {pers.Sexo.Nombre}
             Foto: {pers.Foto}
            
            ");

        }
        

       Console.Write("Ingrese la id del personaje a exportar: ");
       var editar = db.personaje.Find(int.Parse(Console.ReadLine() ?? ""));

       var html = System.IO.File.ReadAllText("datos.html");

            var datos = "";
            var cap = "";
            var tit = "";

            tit += @"
            <tr>
            <br>
            <th style='text-align: center; font-size: 200%;'>Personajes</th>
            </tr>
            ";

            cap += @"
            <tr>
            <th>Foto</th>
            <th>Nombre</th>
            <th>Apellido</th>
            <th>Pronunciacion</th>
            <th>Serie</th>
            <th>Fecha de Nacimiento</th>
            <th>Vestimenta</th>h>
            <th>Poder</th>
            <th>Sexo</th>
            <th>Estado</th>
            </tr>
            ";

            
            datos += @$"
            <tr>
            <th><img src='{editar.Foto}' width='150' height='150'></th>
            <th>{editar.Nombre}</th>
            <th>{editar.Apellido}</th>
            <th>{editar.Pronunciacion}</th>
            <th>{editar.anime}</th>
            <th>{editar.Fecha}</th>
            <th>{editar.Vestimenta}</th>
            <th>{editar.Habilidad}</th>
            <th>{editar.Sexo}</th>
            <th>{editar.Estados}</th>
            </tr>
            ";
        
                            
            html = html.Replace("{titulo}", tit);
            html = html.Replace("{cap}", cap);
            html = html.Replace("{datos}", datos);


       
            System.IO.File.WriteAllText("personajes.html", html);
            Utils.Nav("personajes.html");

   
            Console.ReadKey();
            Reportes.Listas(); 

            break;

            case "6":
                Console.WriteLine("Reporte por animes");

                var queryss = (from bd in db.personaje
                join an in db.anime on bd.anime equals an
                join es in db.estado on bd.Estados equals es
                join sx in db.sexo on bd.Sexo equals sx
                 
                select new {

                    bd.id,
                    bd.Nombre,
                    bd.Apellido,
                    bd.anime,
                    bd.Sexo,
                    Date = bd.Fecha

                }).ToList();
           
                var anime = (from an in db.anime
                join bd in db.personaje on an equals bd.anime

                select new{
                    Nombre= an.Nombre,
                    id = bd.id}).ToList().GroupBy(z => z.Nombre, (key, group)=> group.FirstOrDefault() );
                
                foreach (var anim in anime){
                Console.WriteLine(@$"

                    Anime
                {anim.Nombre}

                ");

                foreach( var pj in queryss){
                if (pj.anime.Nombre == anim.Nombre){

                        DateTime FechaN = pj.Date;
                        DateTime FechaA = DateTime.Today;

                        int dia = pj.Date.Day;
                        int mes = pj.Date.Month;
                        var anual = FechaA.Year - FechaN.Year;

                        if (FechaN > FechaA.AddYears(-anual))anual--;

                        var person = @$"

                        Id: {pj.id}
                        Nombre: {pj.Nombre}
                        Apellido: {pj.Apellido}
                        Anime: {pj.anime.Nombre}
                        Sexo: {pj.Sexo.Nombre}
                        Fecha de nacimiento: {pj.Date}
                        Edad: {anual}
            
                        ";

                        Console.WriteLine(pj);
                    }
                }
               
            }

                Console.ReadKey();
                Reportes.Listas();

            break;

            case "7":
                Console.WriteLine("Reporte por estado");
                
 
                var quer = (from bd in db.personaje
                join an in db.anime on bd.anime equals an
                join es in db.estado on bd.Estados equals es
                join sx in db.sexo on bd.Sexo equals sx
                 
                select new {

                    bd.id,
                    bd.Nombre,
                    bd.Apellido,
                    bd.anime,
                    bd.Sexo,
                    Date = bd.Fecha

                }).ToList();
           
                var estado = (from an in db.estado
                join bd in db.personaje on an equals bd.Estados

                select new{
                    Nombre = an.Nombre,
                    id = bd.id}).ToList().GroupBy(z => z.Nombre, (key, group)=> group.FirstOrDefault() );
                
                foreach (var anims in estado){
                Console.WriteLine(@$"

                    Anime
                {anims.Nombre}

                ");

                foreach( var pj in quer){

                        DateTime FechaN = pj.Date;
                        DateTime FechaA = DateTime.Today;

                        int dia = pj.Date.Day;
                        int mes = pj.Date.Month;
                        var anual = FechaA.Year - FechaN.Year;

                        if (FechaN > FechaA.AddYears(-anual))anual--;
                        var person= @$"
                    
                        id: {pj.id}
                        Nombre: {pj.Nombre}
                        Apellido: {pj.Apellido}
                        Anime: {pj.anime.Nombre}
                        Sexo: {pj.Sexo.Nombre}
                        Fecha de nacimiento: {pj.Date}
                        Edad: {anual}
                   
                        ";

                        Console.WriteLine(pj);
                    
                }
               
            }

                Console.ReadKey();
                Reportes.Listas();               

            break;

            case "8":
                Utils.retorno();
            break;

            default:
                Console.Write("Opcion Invalida!! Eliga de nuevo");
                Console.ReadKey();
                Reportes.Listas();
                break;
        }
   
   
   
   
   
   
    }
}