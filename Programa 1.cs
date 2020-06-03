using System;

namespace Programa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double producto;
            string formapago;
            double numerotarjeta;

            Console.Write("Escriba el precio del producto: ");
            producto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Desea pagar efectivo o tarjeta ?: ");
            formapago = Console.ReadLine();

            if(formapago.Equals("tarjeta"))
            {
                Console.Write("Digite el numero de la tarjeta: ");
                numerotarjeta = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("El precio del producto es {0}, el pago se realizo con la tarjeta de serie {1}", producto, numerotarjeta);
            }
            else
            {
                if(formapago.Equals("efectivo"))
                {
                    Console.WriteLine("Se ha pagado un monto de: {0}", producto);
                }
                else
                {
                    Console.WriteLine("La forma de pagar no es la adecuada");
                }
           
            }

        }
    }
}
