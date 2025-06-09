// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// using book_management;

// LibraryItem book = new LibraryItem{ Title =, Author = , issue_date = "FEB 30 2999"};
// book.ShowInfo();

using LibManagement;

Book book = new Book("Harry Potter", "JK Rowling", "124676");
book.FetchDetails();

Console.WriteLine();

Magazine mg = new Magazine("12345678", "Magic Pot");
mg.FetchDetails();

Console.WriteLine();

DVD dvd = new DVD("Criminal Case of Natalia Grace", "1.30 hrs");
dvd.ShowInfo();