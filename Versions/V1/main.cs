int calculateScore(string methodString, char[] characters)
{
    int Score = 0;
    for (int i = 0; i < methodString.Length; i++)
    {
        Score = Score + characters.IndexOf(methodString[i]);
    }
    return Score;
}

// Idea: take a string and turn it to a score based off each letter having a different numeric value and return a score based off the two

char[] characters = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
int difference = 0; // initiallise difference to avoid CS0103

Console.WriteLine("------------------------------------\nWordWeight V1 - Made by Adam Gillion\n------------------------------------");

Console.WriteLine("Enter the first string: ");
string? firstString = Console.ReadLine();

Console.WriteLine("Enter the second string: ");
string? secondString = Console.ReadLine();

firstString = firstString.ToLower();
secondString = secondString.ToLower();

int firstScore = calculateScore(firstString, characters);
int secondScore = calculateScore(secondString, characters);

if (secondScore > firstScore)
{
    difference = secondScore - firstScore;
} else
{
    difference = secondScore - firstScore;
}
Console.WriteLine($"{firstString} has a score of {firstScore}");
Console.WriteLine($"{secondString} has a score of {secondScore}");
Console.WriteLine($"String difference: {difference}");
