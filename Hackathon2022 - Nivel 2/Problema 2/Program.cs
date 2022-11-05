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

for (int i = 0; i < array.Length; i++)
{
    CantidadCaracteres[i] = array[i].Length;
}

foreach (var caracteres in CantidadCaracteres)
{
    if (caracteres < CaracteresMax)
    {

    }
}

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

void JustificarLinea(string frase){
    string[] palabras = ExtraerPalabras(frase);
    int totalCaracteres = 0;

    foreach (var palabra in palabras)
    {
        totalCaracteres = totalCaracteres + ContarLetras(palabra);
    };

    if (totalCaracteres < CaracteresMax)
    {
        foreach (var palabra in palabras)
        {
            return palabra + 
        }
    }

}
