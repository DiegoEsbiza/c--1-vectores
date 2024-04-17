namespace guia_vectores_4;

class Program
{
    static void Main(string[] args)
    {
        // Dada una lista de 10 números enteros, cargarlos en un vector. Luego,
        // determinar e informar si el vector está ordenado en forma creciente. Por
        // ejemplo el vector con los valores 1, 3, 5, 7 y 9 está ordenado; el vector 1, 5, 3, 7
        // y 9 no lo está.

        int[] n = new int[10];

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese un número");
            n[x] = int.Parse(Console.ReadLine());
        }

        bool orden = true;
        int max = n[0];

        for (int x = 0; x < 10; x++)
        {
            if(n[x] >= max)
            {
                max = n[x];
            }else{
                orden = false;
            }
        }

        if (orden)
        {
            Console.WriteLine("El vector esta ordenado en forma creciente");
        }else{
            Console.WriteLine("El vector NO esta ordenado");
        }
    }
}
