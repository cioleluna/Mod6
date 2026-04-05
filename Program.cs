using System;
using System.Diagnostics;
using System.Linq.Expressions;
class SayaMusicTrack
{
    private int id;
    private string title;
    private int playCount;

    public SayaMusicTrack(string title)
    {
        Debug.Assert(title != null, "Judul tidak boleh kosong");
        Debug.Assert(title.Length <= 100, "Judul maksimal 100 karakter");

        Random random = new Random();
        id = random.Next(10000, 100000);
        
        this.title = title;
        playCount = 0;
    }

    public void IncreasePlayCount(int jumlah)
    {
        Debug.Assert(jumlah <= 10000000, "Penambahan play count maksimal 10.000.000");

        try
        {
            checked 
            {
                playCount += jumlah;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas maksimum integer!");
            throw;
        }

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
        try
        {


            SayaMusicTrack lagu1 = new SayaMusicTrack("18 - One Direction");
            SayaMusicTrack lagu2 = new SayaMusicTrack("I Would - One Direction");
            SayaMusicTrack lagu3 = new SayaMusicTrack("Heart Attack - One Direction");

            lagu1.IncreasePlayCount(5000000);
            lagu2.IncreasePlayCount(8000000);
            lagu3.IncreasePlayCount(10);

            lagu1.PrintTrackDetails();
            lagu2.PrintTrackDetails();
            lagu3.PrintTrackDetails();

            for (int i = 0; i < 1000; i++)
            {
                lagu2.IncreasePlayCount(10000000);
            }

            lagu2.PrintTrackDetails();
        }
        
        catch (Exception e)
         {
            Console.WriteLine("Terjadi error: " + e.Message);
        }
        Console.ReadLine();
    }
}
