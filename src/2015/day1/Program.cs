internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine().ToCharArray();

        var up = input.Count(c => c == '(');
        var down = input.Count(c => c == ')');
        
        var floor = up - down;

        Console.WriteLine(floor);
        Console.ReadLine();        
    }
}
