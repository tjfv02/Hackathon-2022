// See https://aka.ms/new-console-template for more information

string[] array = new string[] { "This is an", "Example of text", "Justification." };

foreach (var linea in array)
{
    Console.WriteLine(linea);
}
Console.WriteLine();
Console.WriteLine("Ingresa la cantidad máxima de caracteres por línea");
int CaracteresMax = Convert.ToInt32(Console.ReadLine());


int[] CantidadCaracteres = new int[array.Length];

Console.WriteLine();

string[] ExtraerPalabras(string linea)
{
    string[] words = linea.Split(' ');

    return words;
}

int ContarLetras(string palabra)
{
    int letras = palabra.Length;
    return letras;
}

int CalcularEspacios(int cantidadLetras)
{
    return cantidadLetras - CaracteresMax;
}

string JustificarLinea(string frase){
    string[] palabras = ExtraerPalabras(frase);
    int totalCaracteres = 0;
    int distribucionEspacios = 0;
    string resultado = "";

    foreach (var palabra in palabras)
    {
        totalCaracteres = totalCaracteres + ContarLetras(palabra);
    };

    if (totalCaracteres < CaracteresMax)
    {
        distribucionEspacios = CalcularEspacios(frase.Length)/palabras.Length;
        foreach (var palabra in palabras)
        {
            resultado = resultado + palabra;
            for (int i = 0; i < distribucionEspacios; i++)
            {
                resultado += " ";
            }
        }
    }

    return resultado;

}
