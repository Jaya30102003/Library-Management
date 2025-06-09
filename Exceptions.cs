namespace LibManagement;

class InvalidISBN : Exception
{
    public InvalidISBN(string message) : base(message){}
}