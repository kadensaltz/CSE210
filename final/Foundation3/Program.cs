class Program
{
    static void Main(string[] args)
    {
        Address LAddress = new Address("3512 Temple Square loop", "Salt Lake City", "UT", "USA");
        Lectures lecture = new Lectures(
            "General Conference",
            "An opportunity to hear the prophet and apostles speak.",
            "10/08/2024",
            "10:00 AM",
            LAddress,
            "The church of Jesus Christ of Latter-day Saints",
            21000
        );

        Address RAddress = new Address("1234 BYUI dr", "Rexburg", "ID", "USA");
        Receptions reception = new Receptions(
            "Cybersecurity Networking Event",
            "An evening for Cybersecurity professionals to connect",
            "01/15/2025",
            "6:00 PM",
            RAddress,
            "rsvp@byuicyberevents.com"
        );

        Address OAddress = new Address("2468 Diamond Center Ave", "Anchorage", "AK", "USA");
        Outdoor outdoor = new Outdoor(
            "Freeze your toes off festival",
            "An outdoor music festival",
            "12/18/2025",
            "5:00 PM",
            OAddress,
            "15 degrees below 0"
        );

        Event[] events = { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(e.StandardDetails());
            Console.WriteLine("\nFull Details:");
            Console.WriteLine(e.FullDetails());
            Console.WriteLine("\nShort Description:");
            Console.WriteLine(e.ShortDescription());
            Console.WriteLine("\n");
        }
    }
}