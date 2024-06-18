var input = File.ReadAllLines("input.txt");



var total = 0;

foreach (var line in input)
{

    var numbers = new List<int>();

    for (var i = 0; i < line.Length; i++)
    {
        if (char.IsNumber(line[i]))
        { 
            numbers.Add(int.Parse(line[i].ToString()));          
        }
        else
        {
            for (var j = 2; j < 6; j++)
            {
                try
                {    
                    switch (line.Substring(i, j).ToLower())
                    {
                        case "one":
                            numbers.Add(1);
                            //i += (j - 1);
                            break;
                        case "two":
                            numbers.Add(2);
                            //i += (j - 1);
                            break;
                        case "three":
                            numbers.Add(3);
                            //i += (j - 1);
                            break;
                        case "four":
                            numbers.Add(4);
                            //i += (j - 1);
                            break;
                        case "five":
                            numbers.Add(5);
                            //i += (j - 1);
                            break;
                        case "six":
                            numbers.Add(6);
                            //i += (j - 1);
                            break;
                        case "seven":
                            numbers.Add(7);
                            //i += (j - 1);
                            break;
                        case "eight":
                            numbers.Add(8);
                            //i += (j - 1);
                            break;
                        case "nine":
                            numbers.Add(9);
                            //i += (j - 1);
                            break;
                    }
                    
                }
                catch
                {
                   
                }
            }
        }


    }
    try
    {
        var combined = 0;
        combined = int.Parse($"{numbers.First()}{numbers.Last()}");
        total += combined;
    }
    catch
    {
    
    }

}

Console.WriteLine($"Total: {total}");
Console.ReadLine();