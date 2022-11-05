
string Cadena1;
string Cadena2;

Console.WriteLine(" --------- Candenas Subsecuentes --------- ");

Console.WriteLine("Ingrese una cadena de texto ");
Cadena1 = Console.ReadLine();

Console.WriteLine("Ingrese una cadena de texto ");
Cadena2 = Console.ReadLine();


char[] ch1 = Cadena1.ToCharArray();
char[] ch2 = Cadena2.ToCharArray();

string resultado = "";

if (ch1.Length > ch2.Length)
{
	for (int i = 0; i < ch2.Length; i++)
	{
		if (ch1[i].Equals(ch2[i]))
		{
			resultado += ch2 [i];
		}
	}
}
else
{
    for (int i = 0; i < ch1.Length; i++)
    {
        if (ch2[i].Equals(ch1[i]))
        {
            resultado += ch1[i];
        }
    }
}

Console.WriteLine(" ");
Console.WriteLine("Resultado: ");
Console.WriteLine(resultado);
Console.ReadKey();

