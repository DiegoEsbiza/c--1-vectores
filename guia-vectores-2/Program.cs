namespace guia_vectores_2;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que solicite 50 números enteros y los guarde en un vector.
        // Luego recorrer todos los elementos del vector y determinar cuál es el valor
        // máximo y su posición dentro del vector.

        int[] n = new int[50];

        for (int x = 0; x < 50; x++)
        {
            Console.WriteLine("Ingrese un número");
            n[x] = int.Parse(Console.ReadLine());
        }

        int max = 0;
        int pos = 0;

        for (int x = 0; x < 50; x++)
        {
            if (n[x] > max)
            {
                max = n[x];
                pos = x+1;
            }
        }

        Console.WriteLine("El mayor número ingresado es: " + max + ". Fue ingresado en la posicion " + pos) ;
    }
}
