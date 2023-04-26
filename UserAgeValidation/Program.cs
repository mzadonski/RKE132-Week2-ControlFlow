// See https://aka.ms/new-console-template for more information

//rakendus kysib kasutajalt valida tema sugu (m/f)
//rakendus kysib kasutajalt sisestada tema perekonnanimi
//lahtudes kasutaja valikust, rakendus tervitab kasutajat jargmiselt:
//"Welcome , Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Select your gender (m/f)");

char userGender = Char.Parse(Console.ReadLine());
Console.WriteLine("Please, enter your name");

string userLastName = Console.ReadLine();
if (userGender == 'm')
{
    Console.WriteLine($"Welcome,Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Mrs. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome {userLastName}");
}

