using System;
class SayaMusicTrack
{
    private int id;
    private string title;
    private string playCount;

    public SayaMusicTrack(string title)
    {
        Random random = new Random();
        id = random.Next(10000, 100000);
        this.title = title;
        playCount = "0";
    }

    public void IncreasePlayCount(int jumlah)
    {
        playCount += jumlah;
    }
    public void PrintTrackDetails()
    {
        Console.WriteLine("ID Track: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("PlayCount: " + playCount);
        Console.WriteLine("-------------------------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack lagu1 = new SayaMusicTrack("18 - One Direction");
        SayaMusicTrack lagu2 = new SayaMusicTrack("I Would - One Direction");
        SayaMusicTrack lagu3 = new SayaMusicTrack("Heart Attack - One Direction");

        lagu1.IncreasePlayCount(5);
        lagu2.IncreasePlayCount(8);
        lagu3.IncreasePlayCount(10);

        lagu1.PrintTrackDetails();
        lagu2.PrintTrackDetails();
        lagu3.PrintTrackDetails();

        Console.ReadLine();
    }
}
