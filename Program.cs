Menu.ops();


class Menu
{
    public static void ops()
    {
        Console.Clear();
        Console.WriteLine(@"
             ________________________________________________
            /                                                \
           |    _________________________________________     |
           |   |                                         |    |
           |   |  C:\> ProyectoFinal.exe  run            |    |
           |   |  C:\> _                                 |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |_________________________________________|    |
           |                                                  |
            \_________________________________________________/
                   \___________________________________/
                ___________________________________________
             _-'    .-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.  --- `-_
          _-'.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.--.  .-.-.`-_
       _-'.-.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-`__`. .-.-.-.`-_
    _-'.-.-.-.-. .-----.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-----. .-.-.-.-.`-_
 _-'.-.-.-.-.-. .---.-. .-------------------------. .-.---. .---.-.-.-.`-_
:-------------------------------------------------------------------------:
`---._.-------------------------------------------------------------._.---'

                Bienvenid@ al proyecto final!!

");

Console.WriteLine(@"

1- Gestionar Personajes          2- Reportes 

3- Configuracion                 4- Acerca De

5 - Salir

");
        Console.Write("Escoga una opcion de las anteriores a la que deseas acceder: ");
        string opcion = Console.ReadLine() ?? "";
        Console.Clear();

        switch (opcion)
        {
            case "1":  
            Console.Clear();
            Console.WriteLine("Gestion de Personajes");
            Gestion.Personajes();
            break;

            case "2": 
            Console.Clear();
            Console.WriteLine("Reportes");
            Reportes.Listas();            
            break;

            case "3": Config.Programa();
            break;

            case "4": 
            Utils.Nav("https://youtu.be/qACyiNS5fDI");
            break;
        
            case "5": 
            Console.WriteLine("Saliendo del programa...... Presione una tecla para finalizar");
            Console.ReadKey();
            Environment.Exit(0);
            break;

            default: 
            Console.Write("Opcion Invalida!! Eliga de nuevo");
            Console.ReadKey();
            Menu.ops();
            break;
        }


    }
}