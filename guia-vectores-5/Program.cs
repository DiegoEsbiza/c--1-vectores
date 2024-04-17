namespace guia_vectores_5;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que solicite una serie de valores de tipo char (caracteres).
        // Se entiende por carácter a cada elemento que se obtiene de presionar una
        // tecla. Por ejemplo el valor “25” tiene dos caracteres (si quisiéramos guardarlo
        // en variables enteras nos alcanza con una, pero si queremos guardarlo en
        // variables char, necesitaremos dos); la frase “maxi programa” tiene 13 (se
        // incluye el espacio como un carácter).
        // La cantidad de valores será como máximo 50, pero el programa puede cortar
        // antes si se ingresa el carácter “.” (punto). Una vez cargado el vector de char,
        // recorrerlo y reemplazar todas las apariciones de la letra “a” por la letra “e”,
        // por ejemplo:
        // Vector char original: “Hola muchachada cómo están”.
        // Vector char modificado: “Hole muchechede cómo esten”
        // Finalmente, mostrar el resultado en pantalla.
        // Nota: necesitaremos un vector char de 50, pero no lo cargaremos con un For.

        char[] vcaracteres = new char[50];
        char[] vmodificados = new char[50];
        int i = 0;

        Console.WriteLine("ingrese sus caracteres o punto para finalizar");
        vcaracteres[i] = char.Parse(Console.ReadLine());
        vmodificados[i] = vcaracteres[i];

        while (vcaracteres[i] != '.' && i < 50)
        {
            i++;
            vcaracteres[i] = char.Parse(Console.ReadLine());
            if (vcaracteres[i] == 'a')
            {
                vmodificados[i] = 'e';
            }else{
                vmodificados[i] = vcaracteres[i];
            }
        }

        Console.WriteLine("El mensaje ingresado fue el siguientes: ");
        for (int x = 0; x < 50; x++)
        {
            Console.Write(vcaracteres[x]);
        }

        Console.WriteLine(" ");
        Console.WriteLine("Mensaje modificado: ");
        for (int x = 0; x < 50; x++)
        {
            Console.Write(vmodificados[x]);
        }

    }
}
