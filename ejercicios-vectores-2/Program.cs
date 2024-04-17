namespace ejercicios_vectores_2;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

        int[] n = new int[10];
        int acu = 0, prom = 0;
        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("ingrese un número");
            n[x] = int.Parse(Console.ReadLine());
            acu += n[x];
        }

        prom = acu/10;

        Console.WriteLine("El promedio de los números ingresados es: " + prom);
        Console.WriteLine("Los siguientes números son mayores al promedio: ");

        for (int x = 0; x < 10; x++)
        {
            if (n[x] > prom)
            {
                Console.Write(n[x] + ", ");
            }
        }
    }
}