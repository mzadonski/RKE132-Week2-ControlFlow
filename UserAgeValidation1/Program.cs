// See https://aka.ms/new-console-template for more information

// Rakendus kysib kasutajal sisestada tema vanust
// Kui kasutaja vanus on vaiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age");

string userAge = Console.ReadLine();

int UserAgeNum = 0;
//boolean - ture/false

bool isAgeNumber = Int32.TryParse(userAge, out UserAgeNum);


Console.WriteLine($"Prase re {isAgeNumber}. User is {UserAgeNum} yo");

if (isAgeNumber)
{
    if (UserAgeNum >= 13)
    {
        Console.WriteLine("Welcome");

    }
    else
    {
        Console.WriteLine("Could not read your age");
    }

}
else
{
    Console.WriteLine("Could not read your age.");
}








