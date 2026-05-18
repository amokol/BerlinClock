using System;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        var hours = 13;
        var minutes = 33;

        Console.WriteLine($"{hours}:{minutes}");
        var fiveHourBlock = hours / 5;
        var singleHourBlock = hours % 5;
        var fiveMinuteBlock = minutes / 5;
        var oneMinuteBlock = minutes % 5;
        var hoursMark = 1; // interval for hours
        var limit = 4; // interval for every 4 hours/minutes
        var minuteLimitCount = 11; // limit for minutes column
        var fifteenMinuteMark = 3; // interval for every 15 minutes
        var fiveMinuteMark = 5; // interval for every 5 minutes
        // Start of setting hours
        SetBerlinTime(fiveHourBlock, hoursMark, limit);
        SetBerlinTime(singleHourBlock, hoursMark, limit);
        // End of setting Hours
        // Start of seeting minutes
        SetBerlinTime(fiveMinuteBlock, fifteenMinuteMark, minuteLimitCount);
        SetBerlinTime(oneMinuteBlock, fiveMinuteMark, limit);
        // End of setting minutes
    }

    private static void SetBerlinTime(int time, int intervalCount, int limit)
    {
        var berlinTime = new StringBuilder();
        for (int i = 0; i < time; i++)
        {
            berlinTime.Append((i + 1) % intervalCount == 0 ? 'R' : 'Y');
        }
        //padding to right all zero values
        Console.WriteLine(berlinTime.ToString().PadRight(limit, 'O'));
    }
}