namespace ejercicios_vectores_3_1;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. 
        
        // Ejemplo:

        //     CADENA FUENTE: “La mar estaba serena"
        //     CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
        //     CADENA RESULTADO: “Li mir estibi sereni"

        //MISMO EJERCICIO PERO REALIZADO CON STRING!

        string frase;
        char letraActual, letraNueva;

        Console.WriteLine("Ingrese la frase: ");
        frase = Console.ReadLine();
        Console.WriteLine("Ingrese la letra a reemplazar");
        letraActual = char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la letra nueva");
        letraNueva = char.Parse(Console.ReadLine());

        frase = frase.Replace(letraActual, letraNueva);

        Console.WriteLine("La frase nueva es: ");
        Console.WriteLine(frase);
    }
}
