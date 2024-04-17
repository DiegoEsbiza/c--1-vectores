namespace guia_vectores_3;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que solicite 100 números enteros y los guarde en un
        // vector. Luego recorrer ese vector para calcular el promedio. Mostrar por
        // pantalla los valores del vector que son mayores al promedio calculado.

        int[] n = new int[25];
        int acu = 0, prom = 0;

        for (int x = 0; x < 25; x++)
        {
            Console.WriteLine("Ingrese un número");
            n[x] = int.Parse(Console.ReadLine());
            acu += n[x];
        }

        prom = acu/25;

        for (int x = 0; x < 25; x++)
        {
            if(n[x] > prom)
            {
                Console.WriteLine(n[x] + " Es mayor al promedio");
            }
        }

        Console.WriteLine("Fin del programa");
    }
}
