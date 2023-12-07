// User.cs
using System;
using System.Collections.Generic;

public class User {
    public string Name { get; set; }
    private List<Book> CheckedOutBooks { get; set; }

    public User(string name) {
        Name = name;
        CheckedOutBooks = new List<Book>();
    }

    public void DisplayInfo() {
        Console.WriteLine($"User: {Name}");
    }

    public void CheckoutBook(Book book) {
        Console.WriteLine($"{Name} checked out {book.Title}");
        CheckedOutBooks.Add(book);
    }

    public void ReturnBook(Book book) {
        Console.WriteLine($"{Name} returned {book.Title}");
        CheckedOutBooks.Remove(book);
    }
}
