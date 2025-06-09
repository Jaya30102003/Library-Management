namespace book_management;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }


    // public Book(string title, string author, string isbn)
    // {
    //     Title = title;
    //     Author = author;
    //     ISBN = isbn;
    // }

    public void FetchDetails()
    {
        Console.WriteLine($" The book name : {Title}\n The author is : {Author}\n The ISBN is :{ISBN}");
    }
}