namespace guia_vectores_8;

class Program
{
    static void Main(string[] args)
    {
        // Se ingresa una lista de 20 números en un vector. Se pide ordenar dichos
        // números en forma decreciente (de mayor a menor). Mostrar el listado
        // ordenado informando también la posición original de cada número en el
        // vector.
        // Pista: usar ciclos combinados.

        int[] n = new int[20];
        int[] pos = new int[20];
        int aux;

        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("Ingrese un número");
            n[x] = int.Parse(Console.ReadLine());
            pos[x] = x+1; 
        }
        for (int x = 0; x < 20; x++)
        {
            aux = 0;
            for(int y = 0; y < 19; y++)
            {
                if (n[y] < n[y +1])
                {
                    aux = n[y];
                    n[y] = n[y+1];
                    n[y+1] = aux;
                    aux = pos[y];
                    pos[y] = pos[y+1];
                    pos[y+1] = aux;
                }
            }
        }

        Console.WriteLine("Los números ingresados son: ");

        for (int x = 0; x < 20; x++)
        {
            Console.Write(n[x] + ", ");
        }

        Console.WriteLine("A continuación, se mostraran las posiciones en las que ingresaron originalmente: ");

        for (int x = 0; x < 20; x++)
        {
            Console.Write(pos[x] + ", ");
        }
    }
}
