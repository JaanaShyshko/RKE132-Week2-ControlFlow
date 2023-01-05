// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kusataja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi]" / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f)");

char UserGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis

Console.WriteLine("Please, enter your name:");
string UserLastName = Console.ReadLine();

if(UserGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {UserLastName}!");
}

else if(UserGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {UserLastName}!");
}

else
{
    Console.WriteLine($"Welcome, {UserLastName}!");
}


