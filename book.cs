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
    }

    public void FetchDetails() 
    {
        Console.WriteLine($" The book name : {Title}\n The author is : {Author}\n The ISBN is :{ISBN}");
    }
}

