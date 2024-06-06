using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("001 Iyenogie St", "Textile Mill Road", "Edo State", "Nigeria");
        Address address2 = new Address("25", "Orunto St", "Oyo State", "Nigeria");
        Address address3 = new Address("227 Umusam St", "Delta State", "Akwa Ibom State", "Nigeria");

        Event lecture = new Lecture("Health Talk", "A talk on the dangers of eating too much sugar.", new DateTime(2024, 7, 10), new TimeSpan(14, 0, 0), address1, "Jane Doe", 100);
        Event reception = new Reception("Birthday Bash", "Celebrating the CEO's Birthday .", new DateTime(2024, 8, 5), new TimeSpan(18, 0, 0), address2, "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Class Picnic", "Annual class picnic with fun and engaging activities.", new DateTime(2024, 9, 15), new TimeSpan(11, 0, 0), address3, "Sunny with a chance of rain");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var evt in events)
        {
            Console.WriteLine(evt.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(evt.FullDetails());
            Console.WriteLine();
            Console.WriteLine(evt.ShortDescription());
            Console.WriteLine();
        }
    }
}