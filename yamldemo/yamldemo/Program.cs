namespace yamldemo;
class Program
{
    private void AddVisits(GuestEntry entry)
    {
        for(var counter = 0; counter < 2; counter++)
        {
            entry.Visits.Add(new GuestVisit()
            {
                Id = counter,
                Visit = $"visit-{counter}",
                Created = DateTime.Now
            });
        }
    }
    private GuestBook CreateGuestBook()
    {
        GuestBook guestBook = new GuestBook();

        for (var counter = 0; counter < 10; counter++)
        {
            var entry = new GuestEntry()
                            {
                                Name = $"test-{counter}",
                                Email = $"test{counter}@test.org",
                                Note = $"note{counter}",
                                Created = DateTime.Now
                            };
            AddVisits(entry);
            guestBook.Entries.Add(entry);
        }
        return guestBook;
    }
    private void WriteGuestBook(GuestBook guestBook, string path)
    {
        var serializer = new YamlDotNet.Serialization.Serializer();
        StreamWriter writer = new StreamWriter(path);
        serializer.Serialize(writer, guestBook);
        writer.Close();
    }
    private GuestBook ReadGuestBook(string filePath)
    {
        var reader = new StreamReader(filePath);
        var deserializer = new YamlDotNet.Serialization.Deserializer();
        var guestBook = deserializer.Deserialize<GuestBook>(reader);
        reader.Close();
        return guestBook;
    }
    private void run()
    {
        string filePath = "./guestBook.yaml";

        GuestBook guestBook = CreateGuestBook();
        WriteGuestBook(guestBook, filePath);
        var readGuestBook = ReadGuestBook(filePath);

        if (guestBook.Entries.Count == readGuestBook.Entries.Count)
        {
            Console.WriteLine("good read");
        }
        else
        {
            Console.WriteLine("bad read");
        }
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.run();
    }
}

