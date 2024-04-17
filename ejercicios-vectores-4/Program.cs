namespace ejercicios_vectores_4;

class Program
{
    static void Main(string[] args)
    {
        // Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
        // - Número de Artículo (1 a 15)
        // - Cantidad Vendida 

        // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
        // Se pide determinar e informar:
        // a) El número de artículo que más se vendió en total.
        // b) Los números de artículos que no registraron ventas.
        // c) Cuantas unidades se vendieron del número de artículo 10.

        int[] vart = new int[15];
        int[] vcant = new int[15];
        bool[] ventas = new bool [15];

        int cont = 1, art, cant, max, i;

        //Lote de carga de registros
        for (int x = 0; x < 15; x++)
        {
            vart[x] = cont;
            vcant[x] = 0;
            ventas[x] = false;
            cont++;
        }

        //Lote de proceso
        Console.WriteLine("Ingrese número de articulo (1 - 15): ");
        art = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad vendida: ");
        cant = int.Parse(Console.ReadLine());

        while (art != 0)
        {
            for (int x = 0; x < 15; x++)
            {
                if (art == vart[x])
                {
                    vcant[x] += cant; //Punto A - Punto C
                    ventas[x] = true; //Punto B
                }
            }
            
            Console.WriteLine("Ingrese número de articulo (1 - 15) o 0 para finalizar: ");
            art = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cant = int.Parse(Console.ReadLine());
        }

        max = 0;
        i = 0;

        for (int x = 0; x < 15; x++)
        {
            if (vcant[x] > max)
            {
                max = vcant[x]; //Punto A
                i = x+1;
            }
        }

        Console.WriteLine("El articulo mas vendido es: " + i + " con un total de " + max + " unidades" ); //Punto A
        Console.WriteLine("Los siguientes articulos NO registraron venta: "); //Punto B

        //Punto B
        i = 0;
        for (int x = 0; x < 15; x++)
        {
            if (!ventas[x])
            {
                i = x+1;
                Console.Write(i + ", ");
            }
        }

        Console.WriteLine(" ");
        Console.WriteLine("El articulo N° 10 registro un total de " + vcant[9] + " ventas"); //Punto C
        Console.WriteLine("Fin del programa.");
    }
}
