namespace LibManagement;

class Book : LibraryItem
{
    public string Author { get; set; }
    public string ISBN { get; set; }


    public Book(string title, string author, string isbn) : base(title)
    {
        base.Title = title;
        Author = author;
        ISBN = isbn;
        try
        {
            if (ISBN.Length < 6)
            {
                throw new InvalidISBN("Atleast 6 characters please");
            }
        }

        catch (InvalidISBN ex)
        {
            Console.WriteLine($"{ex.Message}");
        }

        finally
        {
            Console.WriteLine("ISBN Mandatory condition is checked");
        }
    }

    public void FetchDetails() 
    {
        Console.WriteLine($"The book name : {Title}\nThe author is : {Author}\nThe ISBN is : {ISBN}");
    }
}

class Magazine : LibraryItem
{
    public string IssueNo { get; set; }
    public Magazine() { }

    public Magazine(string issueno, string title) : base(title)
    {
        IssueNo = issueno;
        Title = title;
    }

    public void FetchDetails()
    {
        base.ShowInfo();
        Console.WriteLine($"The issue no : {IssueNo}\n");
    }
}

class DVD : LibraryItem
{
    public string Duration { get; set; }
    public DVD() { }

    public DVD(string title, string duration) : base(title)
    {
        Title = title;
        Duration = duration;
    }

    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Duration : {Duration}\n");
    }
}