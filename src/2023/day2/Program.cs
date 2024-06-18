
internal class Program
{
    public static int totalRed = 12;
    public static int totalGreen = 13;
    public static int totalBlue = 14;
    private static void Main(string[] args)
    {
        var input = File.ReadAllLines("input.txt");
        var total = 0;

        foreach (var line in input)
        {
            total += GetResult(line);
        }

        Console.WriteLine(total);
    }


    public class Round
    {
        public int r;
        public int g;
        public int b;
    }

    public static int GetResult(string game)
    {
        var lowestB = 0;
        var lowestG = 0;
        var lowestR = 0;

        var strGame = game.Split(':');
        var id = int.Parse(strGame[0].Substring(5));

        var strRounds = strGame[1].Split(';').ToList();

        foreach (var r in strRounds)
        { 
            var round = new Round();

            foreach (var c in r.Split(','))
            {
                var spl = c.Split(' ');
                if (spl[2] == "blue")
                {
                    round.b = int.Parse(spl[1]);
                }
                else if (spl[2] == "green")
                {
                    round.g = int.Parse(spl[1]);
                }
                else if (spl[2] == "red")
                {
                    round.r = int.Parse(spl[1]);
                }
            }
            if (round.r > lowestR)
            {
                lowestR = round.r; 
            }
            if (round.g > lowestG)
            {
                lowestG = round.g;
            }
            if (round.b > lowestB)
            {
                lowestB = round.b;
            }
        }

        return (lowestR*lowestB*lowestG);
    }
}
