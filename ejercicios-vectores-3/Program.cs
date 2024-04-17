namespace ejercicios_vectores_3;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. 
        
        // Ejemplo:

        //     CADENA FUENTE: “La mar estaba serena"
        //     CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
        //     CADENA RESULTADO: “Li mir estibi sereni"

        char[] frase = new char[50];
        char c1, c2, letra;
        int i = 0;

        Console.WriteLine("Ingrese su texto letra por letra (max 50 caracteres): ");
        letra = char.Parse(Console.ReadLine());

        while (i < 50 && letra != '0')
        {
            frase[i] = letra;
            Console.WriteLine("Ingrese su texto letra por letra (max 50 caracteres): ");
            letra = char.Parse(Console.ReadLine());
            i++;            
        }
        
        i = '\0';
        Console.WriteLine("el texto ingresado es el siguiente: ");
        i = 0;
        while (frase[i] != '\0')
        {
            Console.Write(frase[i]);
            i++;  
        }         

        Console.WriteLine(" ");
        Console.WriteLine("A continuación, ingrese la letra a reemplazar: ");
        c1 = char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la letra que reemplazara a la seleccionada anteriormente");
        c2 = char.Parse(Console.ReadLine());

        i = 0;
        while (frase[i] != '\0')
        {
            if (frase[i] == c1)
                frase[i] = c2;
            i++;
        }

        Console.WriteLine("Su texto modificado es el siguiente: ");

        i = 0;
        while (frase[i] != '\0')
        {
            Console.Write(frase[i]);
            i++;
        }

        Console.WriteLine(" ");
        Console.WriteLine("Fin del programa.");
    }
}
