using System;
using System.Drawing;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        var hours = 1;
        var minutes = 59;

        Console.WriteLine($"{hours}:{minutes}");
        var hourTime = hours / 5;
        var hourMod = hours % 5;
        var mins = (minutes / 5);
        var minsMod = minutes % 5;
        var hourCount = 1; // every hour count
        var limit = 4; // limit for 4 columns
        var minLimit = 11; // limit for minutes column
        var minsCount = 3; // limit set for every 15 mins
        var fullminsLimit = 5; //this is the count for 5 mins
        // Start of setting hours
        SetBerlinTime(hourTime, hourCount, limit);
        SetBerlinTime(hourMod, hourCount, limit);
        // End of setting Hours
        // Start of seeting minutes
        SetBerlinTime(mins, minsCount, minLimit);
        SetBerlinTime(minsMod, fullminsLimit, limit);
        // End of setting minutes
    }

    private static void SetBerlinTime(int time, int timeCount, int limit)
    {
        var berlinTime = new StringBuilder();
        for (int i = 0; i < time; i++)
        {
            berlinTime.Append((i + 1) % timeCount == 0 ? "R" : "Y");
        }
        //padding to right all zero values
        Console.WriteLine(berlinTime.ToString().PadRight(limit, 'O'));
    }
}