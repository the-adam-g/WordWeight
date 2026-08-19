(int averageScore, int percentage) calculateScore(string methodString, string methodString2, char[] characters)
{
    int Score = 0;
    int averageScore = 0;
    int percentage = 0;
    if (methodString.Length < methodString2.Length)
    {
        for (int i = 0; i < methodString.Length; i++)
        {
            if (characters.IndexOf(methodString[i]) < characters.IndexOf(methodString2[i])) {
                Score = Score + characters.IndexOf(methodString2[i]) - characters.IndexOf(methodString[i]);
            } else
            {
                Score = Score + characters.IndexOf(methodString[i]) - characters.IndexOf(methodString2[i]);
            }
        }
        for (int i = methodString.Length; i < methodString2.Length; i++)
        {
            Score = Score + 26;
        }
        averageScore = Score / methodString2.Length;
        percentage = 100 - (averageScore * 100 / 26);
    } else{
        for (int i = 0; i < methodString2.Length; i++)
        {
            if (characters.IndexOf(methodString2[i]) < characters.IndexOf(methodString[i])) {
                Score = Score + characters.IndexOf(methodString[i]) - characters.IndexOf(methodString2[i]);
            } else
            {
                Score = Score + characters.IndexOf(methodString2[i]) - characters.IndexOf(methodString[i]);
            }
        }
        for (int i = methodString2.Length; i < methodString.Length; i++)
        {
            Score = Score + 26;
        }
        averageScore = Score / methodString.Length;
        percentage = 100 - (averageScore * 100 / 26);
    }
    return (averageScore, percentage);
}

// Idea: take a string and turn it to a score based off each letter having a different numeric value and return a score based off the two

char[] characters = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' '];

Console.WriteLine("---------------------------------------------------\nWordWeight V2.1 (19-08-2026) - Made by Adam Gillion\n---------------------------------------------------");

Console.WriteLine("Enter the first string: ");
string firstString = Console.ReadLine() ?? "";

Console.WriteLine("Enter the second string: ");
string secondString = Console.ReadLine() ?? "";

firstString = firstString.ToLower();
secondString = secondString.ToLower();

var (calculatedAverage, calculatedPercentage) = calculateScore(firstString, secondString, characters);

Console.WriteLine($"{firstString} and {secondString} has an average score of {calculatedAverage}. Similarity of {calculatedPercentage}%");

Console.WriteLine("Press any key to exit...");
Console.ReadKey();   
