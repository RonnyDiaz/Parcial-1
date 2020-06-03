using System;

namespace Programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
             string semana;

            Console.WriteLine("Debe poner la primera letra en mayuscula...  Ej: Lunes");

            Console.Write("Escriba un dia de la semana: "); 
            semana = Console.ReadLine();

           
            switch (semana)
            {
                case "Lunes": Console.WriteLine("No es fin de semana"); break;
                case "Martes": Console.WriteLine("No es fin de semana"); break;
                case "Miercoles": Console.WriteLine("No es fin de semana"); break;
                case "Jueves": Console.WriteLine("No es fin de semana"); break;
                case "Viernes": Console.WriteLine("No es fin de semana"); break;
                case "Sabado": Console.WriteLine("Es fin de semana"); break;
                case "Domingo": Console.WriteLine("Es fin de semana"); break;

                default: Console.WriteLine("Error"); break;

            }
           






        }
    }
}
