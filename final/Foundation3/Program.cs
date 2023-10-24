class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("BP70 Cassava St", "Tema West", "Accra", "Ghana");
        Address address2 = new Address("XY105 Yam St", "Tema West", "Accra", "Ghana");
        Address address3 = new Address("AB20 Marian boulevard St", "Afaja", "Volta", "Ghana");

        Lecture lecture = new Lecture("Tech Talk", "Exciting Tech Innovations", DateTime.Now, new TimeSpan(15, 30, 0), address1, "Kevin Amevor", 100);
        Reception reception = new Reception("Networking Event", "Meet And Greet", DateTime.Now, new TimeSpan(18, 0, 0), address2, "reception@gmail.com");
        OutdoorGathering gathering = new OutdoorGathering("Hiking", "Overcome Mount Afaja", DateTime.Now, new TimeSpan(12, 0, 0), address3, "Sunny weather expected");

        Console.WriteLine("Event 1 (Lecture):");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Event 2 (Reception):");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Event 3 (Outdoor Gathering):");
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine(gathering.GetShortDescription());
    }
}