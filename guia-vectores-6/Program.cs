namespace guia_vectores_6;

class Program
{
    static void Main(string[] args)
    {
        // Dada una lista de 10 números, cargarlos en un vector. Luego detectar si en el
        // vector hay algún elemento repetido. De haberlo, indicarlo con un cartel
        // aclaratorio “Hay repetidos”, de lo contrario indicar “No hay repetidos”.
        // Pista: usar ciclos combinados.

        int[] n = new int[10];

        bool rep;
        int aux, cont;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese un número: ");
            n[x] = int.Parse(Console.ReadLine());
        }

        rep = false;
       
        for (int x = 0; x < 10; x++)
        {
            aux = n[x];
            cont = 0; 
            for (int y = 0; y < 10; y++)
            {
                if (n[y] == aux)
                {
                    cont++;     
                }
            }

            if (cont >= 2)
            {
                rep = true;
            }
        }

        if (rep)
        {
            Console.WriteLine("Hay números repetidos");
        }else
        {
            Console.WriteLine("No hay números repetidos");
        }
    }
}