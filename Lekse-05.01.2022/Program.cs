class Program
{
    static Random Random = new Random();
    static void Main(string[] args)
    {
        var randomLetters = new char[10];
        var randomNumbers = new int[10];

        for (int i = 0; i < 10; i++)
        {
            var randomLetter = GetRandomUpperCaseLetter();
            var randomNumber = Random.Next(0, 10);

            randomLetters[i] = randomLetter;
            randomNumbers[i] = randomNumber;
        }
    }

    private static char GetRandomUpperCaseLetter()
    {
        return GetRandomLetter('A', 'Z');
    }


    private static char GetRandomLetter(char min, char max)
    {
        return (char)Random.Next(min, max);
    }
}