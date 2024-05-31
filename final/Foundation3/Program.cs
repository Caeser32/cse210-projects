using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("3 starcruzie St", "Port Elizabeth", "EC", "SA");
        Address address2 = new Address("85 Oak St", "Knysna", "WC", "SA");
        Address address3 = new Address("7 mowbray St", "Brits", "NW", "SA");

        Lecture lecture = new Lecture("Advanced C# Programming", "A deep dive into C#", "12/12/2023", "10:00 AM", address1, "Simphiwe Msiza", 100);
        Reception reception = new Reception("Wedding Reception", "Celebrating the wedding of Langelihle and Tumisang", "25/12/2023", "5:00 PM", address2, "btdmsiza@gmail.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Community Picnic", "A fun day out in the park", "01/01/2024", "11:00 AM", address3, "Sunny");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var evt in events)
        {
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine(new string('-', 20));
        }
    }
}
