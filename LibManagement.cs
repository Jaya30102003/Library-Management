namespace LibManagement;

class LibraryItem
{
    public string Id { get; set; }

    public string Title { get; set; }

    public LibraryItem(string id, string title)
    {
        Id = id;
        Title = title;
    }

    public LibraryItem() { }

    public LibraryItem(string title)
    {
        Title = title;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Title : {Title}");
    }
}

class FineCalculator
{
    public int NoOfDays { get; set; }
    private int fine = 5;
    public FineCalculator(int overdue)
    {
        NoOfDays = overdue;
    }

    public FineCalculator() { }
    public void showFine()
    {
        if (NoOfDays - 15 <= 0) Console.WriteLine("Perfect on time");
        else
        {
            Console.WriteLine($"Overdue by {NoOfDays - 15} days ");
            Console.WriteLine($"Fine : {(NoOfDays - 15) * fine}");
            Console.Write("Enter the membership type u own : ");
            string type = Console.ReadLine();
            Membership(type);
        }
        
    }

    public void Membership(string type)
    {
        if (type == "PREMIUM") Console.WriteLine($"With the membership, the fine to be paid is : {(NoOfDays - 15) * (fine - 4)}");
        else if (type == "TEACHER" || type == "STAFF") Console.WriteLine($"With the membership, the fine to be paid is : {(NoOfDays - 15) * (fine - 3)}"); 
        else if(type == "STUDENT") Console.WriteLine($"With the membership, the fine to be paid is : {(NoOfDays - 15) * 0}. Go ahead pal!! We have got u covered!! Enjoy"); 
    }

    
}