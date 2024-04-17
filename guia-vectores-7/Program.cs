namespace guia_vectores_7;

class Program
{
    static void Main(string[] args)
    {
        // Una empresa comercializa 15 tipos de artículos y por cada venta realizada
        // genera un registro con los siguientes datos:
        // • Número de artículo (1 a 15).
        // • Cantidad vendida.
        // Puede haber varios registros para el mismo artículo y el último se indica
        // número de artículo igual a cero.
        // Se pide determinar e informar:
        // a. El número de artículo que más se vendió en total.
        // b. Los números de artículos que no registraron ventas.
        // c. La cantidad de unidades vendidas para el artículo número 10.
        // Nota: tener en cuenta el concepto de “registro” y el planteo de estructura
        // principal separado de consignas (ver videos de ciclos combinados y ejercicios
        // resueltos de ciclos combinados).


        int[] vnumart = new int[15]; 
        int[] vcant = new int [15]; 
        int[] acuventas = new int[15];
        bool[] ventas = new bool[15];

        int numart,cant, max,i;
        
        //inicialización de vectores, lote de carga
        for (int x = 0; x < 15; x++)
        {
            vnumart[x] = x+1;
            vcant[x] = 0;
            acuventas[x] = 0; //vector del punto A
            ventas[x] = false; //vector del punto B
        }

        //pedido de datos
        Console.WriteLine("Ingrese número de Articulo (1 al 15): ");
        numart = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese cantidad vendida: ");
        cant = int.Parse(Console.ReadLine());

        //lote de proceso
        while (numart !=0)
        {
            //punto A
            for (int x = 0; x < 15; x++)
            {
                if (numart == vnumart[x])
                {
                    acuventas[x] += cant;

                    //punto B
                    ventas[x] = true;
                }
            }
                
            Console.WriteLine("Ingrese siguiente número de Articulo o 0 para finalizar: ");
            numart = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cantidad vendida: ");
            cant = int.Parse(Console.ReadLine());
        }

        //punto A, hallar el número de articulo mas vendido
        max = 0;
        i = 0;
        for (int x = 0; x < 15; x++)
        {
            if (acuventas[x] >= max)
            {
                max = acuventas[x];
                i = x+1;
            }
        }
        //Punto A
        Console.WriteLine("El articulo más vendido es el número: " + i);
        //Punto B
        Console.WriteLine("No se registraron ventas para los siguientes articulos: n°" );
        for (int x = 0; x < 15; x++)
        {
            if (!ventas[x])
            {
                i = x+1;
                Console.Write(i +", ");
            }
        }
        //Punto C
        Console.WriteLine("El articulo n° 10 registro un total de: " + acuventas[10] +" ventas");

    }
}
