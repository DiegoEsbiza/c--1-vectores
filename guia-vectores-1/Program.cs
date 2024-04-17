namespace guia_vectores_1;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que solicite 50 números enteros y los guarde en un vector.
        // Luego recorrer el vector y determinar e informar cuál es la suma de los valores
        // del mismo.
        // Nota: usar dos ciclos: uno para guardar los números en el vector y otro para
        // recorrerlo y leerlo.

        int[] n = new int[50];

        for (int x = 0; x < 50; x++)
        {
            Console.WriteLine("Ingrese un número");
            n[x] = int.Parse(Console.ReadLine());

        }

        int acu = 0;
        for (int x = 0; x < 50; x++)
        {
            acu += n[x];
        }
            Console.WriteLine("La suma de los valores ingresados es:  " + acu);
    }
}
