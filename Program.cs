internal class Program
{
    private static void Main(string[] args)
    {
        Person p1 = new Person() { Id = 1, Name = "mahmoud" };
        
        // before
        Console.WriteLine(p1.Name);


        ChangeDataPesons(p1);
        // after
        Console.WriteLine(p1.Name);
    }

    // non primtive
    public static void ChangeDataPesons(Person person)
    {
        person.Name = "alaa";
    }

}
