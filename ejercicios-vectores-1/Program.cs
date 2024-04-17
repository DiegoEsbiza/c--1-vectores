namespace ejercicios_vectores_1;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

        int[] n = new int[10];

        int max, pos;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("ingrese un número");
            n[x] = int.Parse(Console.ReadLine());
        }

        max = n[0];
        pos = 0;
        for (int x = 0; x < 10; x++)
        {
            if(n[x] >= max)
            {
                max = n[x];
                pos = x + 1;
            }
        }
        
        Console.WriteLine("El número mayor es: " + max + " y fue ingresado en la posicion n° " + pos);
    }
}
