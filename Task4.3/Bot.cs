namespace Task4._3;

public class Bot
{
    protected int countBot = 0;
    internal string Choice(string[] value)
    {
        var rnd = new Random();
        var botNumber = rnd.Next(value.Length);

        return value[botNumber];
    }

    internal void Win()
    {
        countBot++;
    }

    internal int ResultBot()
    {
        return countBot;
    }
}