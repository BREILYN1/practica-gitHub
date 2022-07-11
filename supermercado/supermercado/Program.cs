using System;

namespace supermercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Complete La Siguiente Informacion---");

            string nombre;
            Console.WriteLine("Nombre");
            nombre = Console.ReadLine();

            string sexo;
            Console.WriteLine("Sexo (f para femenino y m para masculino)");
            sexo = Console.ReadLine();

            int hijos;
            Console.WriteLine("Cuantos hijos tiene");
            hijos = int.Parse(Console.ReadLine());

            double totalPagar;
            Console.WriteLine("Ingrese el total a pagar");
            totalPagar = double.Parse(Console.ReadLine());

            if (sexo == "f") 
            {
                if (hijos == 0)
                {
                    double descuHijo = totalPagar * 0.10;
                    double precioFin = totalPagar - descuHijo;
                    Console.WriteLine($"Señ@r {nombre} el precio inicial de las compras es de: {totalPagar} " +
                        $"y con el descuento ya aplicado es de {precioFin} gracias por su compra el descuento es de: {descuHijo}");
                }
                if (hijos <= 2)
                {
                    double descuHijo = totalPagar * 0.15;
                    double precioFin = totalPagar - descuHijo;
                    Console.WriteLine($"Señ@r {nombre} el precio inicial de las compras es de: {totalPagar} " +
                    $"y con el descuento ya aplicado es de {precioFin} gracias por su compra el descuento es de: {descuHijo}");
                }
                if (hijos >= 3)
                {
                    double descuHijo = totalPagar * 0.20;
                    double precioFin = totalPagar - descuHijo;
                    Console.WriteLine($"Señ@r {nombre} el precio inicial de las compras es de: {totalPagar} " +
                    $"y con el descuento ya aplicado es de {precioFin} gracias por su compra el descuento es de: {descuHijo}");
                }
            }

            else if (sexo == "m")
            {
                if (hijos == 0)
                {
                    double descuHijo = totalPagar * 0.025;
                    double precioFin = totalPagar - descuHijo;
                    Console.WriteLine($"Señ@r {nombre} el precio inicial de las compras es de: {totalPagar} " +
                        $"y con el descuento ya aplicado es de {precioFin} gracias por su compra el descuento es de: {descuHijo}");
                }
                if (hijos >= 1)
                {
                    double descuHijo = totalPagar * 0.5;
                    double precioFin = totalPagar - descuHijo;
                    Console.WriteLine($"Señ@r {nombre} el precio inicial de las compras es de: {totalPagar} " +
                    $"y con el descuento ya aplicado es de {precioFin} gracias por su compra el descuento es de: {descuHijo}");
                }
            }



        }
    }
}
