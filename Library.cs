// Library.cs
using System;
using System.Collections.Generic;

public class Library {
    private List<Book> Books { get; set; }
    private List<User> Users { get; set; }

    public Library() {
        Books = new List<Book>();
        Users = new List<User>();
    }

    public void AddBook(Book book) {
        Books.Add(book);
    }

    public void AddUser(User user) {
        Users.Add(user);
    }

    public void DisplayBooks() {
        Console.WriteLine("Available Books:");
        foreach (var book in Books) {
            book.DisplayInfo();
        }
    }

    public void DisplayUsers() {
        Console.WriteLine("Library Users:");
        foreach (var user in Users) {
            user.DisplayInfo();
        }
    }
}
