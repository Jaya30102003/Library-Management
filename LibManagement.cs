namespace LibManagement;

class LibraryItem
{
    public string Id { get; set; }
    
    public string Title{ get; set; }

    public LibraryItem(string id, string title)
    {
        Id = id;
        Title = title;
    }

    public LibraryItem(){}

    public LibraryItem(string title)
    {
        Title = title;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Title : {Title}");
    }
}