System.Console.WriteLine("Please enter your directions");
string input = args[0];

//zählt bei < eine stelle vorwärts und bei > eine stelle rückwärts
int Place = 0;
int zeichen = 0;
int teleportationen = 0;

do
{
    if (input[Place] == '<')
    {
        Place++;
        zeichen++;
    }
    else if (input[Place] == '>')
    {
        Place--;
        zeichen++;
    }
    else if (char.IsDigit(input[Place]))
    {
        teleportationen++;

        int y = input[Place] + 4;
        string x = input.Substring(input[Place], y);
        if (x.Contains("0")) 
        { 
            x.Replace("0","");

        }

        int PlaceFromPlace = int.Parse(x);
        Place = PlaceFromPlace;
    }
} while (Place < input.Length);

System.Console.WriteLine($"you have had {zeichen}subliments and {teleportationen}teleportations");