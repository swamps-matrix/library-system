// Program.cs
class Program {
    static void Main() {
        // Create books
        Book book1 = new Book("The Catcher in the Rye", "J.D. Salinger");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");

        // Create users
        User user1 = new User("Alice");
        User user2 = new User("Bob");

        // Create a library
        Library library = new Library();

        // Add books to the library
        library.AddBook(book1);
        library.AddBook(book2);

        // Add users to the library
        library.AddUser(user1);
        library.AddUser(user2);

        // Display library information
        library.DisplayBooks();
        library.DisplayUsers();

        // Simulate user actions
        user1.CheckoutBook(book1);
        user2.CheckoutBook(book2);

        // Display updated library information
        library.DisplayBooks();
        library.DisplayUsers();
    }
}
