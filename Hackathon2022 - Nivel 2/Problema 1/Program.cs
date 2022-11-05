Console.WriteLine("Problema 1 - Scramble");

//Creación de variables
string confirmacion = "si";
string palabra1;
string palabra2;
string palabra1O = "";
string palabra2O = "";
bool validacion = true;

//Ciclo de utilización del programa
while (confirmacion == "si")
{
    //Ingreso de datos y verificacion de longitud
    while (validacion)
    {
        Console.WriteLine("Ingresa la primera palabra");
        palabra1O = Console.ReadLine();
        Console.WriteLine("Ingresa la segunda palabra");
        palabra2O = Console.ReadLine();
        if(palabra1O.Length == palabra2O.Length)
        {
            validacion = false;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Las palabras no son de la misma longitud");
            validacion = true;
        }
    }

    //Validación de similitud
    palabra1 = String.Concat(palabra1O.ToLower().OrderBy(c => c));
    palabra2 = String.Concat(palabra2O.ToLower().OrderBy(c => c));
    if (palabra1.Equals(palabra2)) 
    {
        validacion = true;
    }
    else
    {
        validacion = false;
    }

    //Respuesta
    Console.WriteLine(string.Format("{0} - {1} {2}", palabra1O, palabra2O, validacion));
    Console.WriteLine("¿Desea analizar otra palabra? Ingrese Si o No");
    confirmacion = Console.ReadLine();
    confirmacion = confirmacion.ToLower();
    Console.Clear();
    validacion = true;
}

