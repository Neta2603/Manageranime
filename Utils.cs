class Utils{

    public static string LeerCadena(string mensaje){
        Console.Write(mensaje);
        return Console.ReadLine() ?? "";
    }

    public static int LeerEntero(string mensaje){
        int num = 0;
        Console.Write(mensaje);
        while(!int.TryParse(Console.ReadLine(), out num)){
            Console.WriteLine("error, reingrese");
        }
        return num;
    }

    public static void retorno(){
        Console.WriteLine("");
        Menu.ops();
    }


    public static void Nav(string link){
        var psi = new System.Diagnostics.ProcessStartInfo();
        psi.UseShellExecute = true;
        psi.FileName = link;
        System.Diagnostics.Process.Start(psi);
    }
}