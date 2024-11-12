using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    // Book Model
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearOfPublication { get; set; }
        public string ISBN { get; set; } // Support both ISBN-10 and ISBN-13

        public Book(string title, string author, int year, string isbn)
        {
            Title = title;
            Author = author;
            YearOfPublication = year;
            ISBN = isbn;
        }
    }

    // User Model
    public class User
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string UID { get; set; }

        public User(string fullName, string address)
        {
            FullName = fullName;
            Address = address;
            UID = Guid.NewGuid().ToString(); // Generate a unique identifier for each user
        }
    }

    // Loan Model
    public class Loan
    {
        public User User { get; set; }
        public Book Book { get; set; }
        public DateTime DateLoaned { get; set; }
        public DateTime? DateReturned { get; set; }

        public Loan(User user, Book book)
        {
            User = user;
            Book = book;
            DateLoaned = DateTime.Now;
        }
    }

    // Main Library System Logic
    public class LibrarySystem
    {
        private List<Book> books = new List<Book>();
        private List<User> users = new List<User>();
        private List<Loan> loans = new List<Loan>();

        // Add a book
        public void AddBook(string title, string author, int year, string isbn)
        {
            var book = new Book(title, author, year, isbn);
            books.Add(book);
            Console.WriteLine($"Book '{title}' added successfully.");
        }

        // List all books
        public void ListBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
            }
        }

        // Add a user
        public void AddUser(string fullName, string address)
        {
            var user = new User(fullName, address);
            users.Add(user);
            Console.WriteLine($"User '{fullName}' added with UID: {user.UID}");
        }

        // List all users
        public void ListUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("No users registered.");
                return;
            }

            foreach (var user in users)
            {
                Console.WriteLine($"Name: {user.FullName}, UID: {user.UID}");
            }
        }

        // Loan a book to a user
        public void LoanBook(string uid, string isbn)
        {
            var user = users.FirstOrDefault(u => u.UID == uid);
            var book = books.FirstOrDefault(b => b.ISBN == isbn);

            if (user == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            if (loans.Any(l => l.Book.ISBN == isbn && l.DateReturned == null))
            {
                Console.WriteLine("This book is already loaned out.");
                return;
            }

            var loan = new Loan(user, book);
            loans.Add(loan);
            Console.WriteLine($"Book '{book.Title}' loaned to {user.FullName}.");
        }

        // Return a loaned book
        public void ReturnBook(string uid, string isbn)
        {
            var loan = loans.FirstOrDefault(l => l.User.UID == uid && l.Book.ISBN == isbn && l.DateReturned == null);

            if (loan == null)
            {
                Console.WriteLine("No active loan found for this book.");
                return;
            }

            loan.DateReturned = DateTime.Now;
            Console.WriteLine($"Book '{loan.Book.Title}' returned by {loan.User.FullName}.");
        }

        // List all active loans
        public void ListLoans()
        {
            var activeLoans = loans.Where(l => l.DateReturned == null).ToList();
            if (activeLoans.Count == 0)
            {
                Console.WriteLine("No active loans.");
                return;
            }

            foreach (var loan in activeLoans)
            {
                Console.WriteLine($"User: {loan.User.FullName}, Book: {loan.Book.Title}, Loaned: {loan.DateLoaned}");
            }
        }

        // View book history (which users borrowed this book)
        public void ViewBookHistory(string isbn)
        {
            var loanHistory = loans.Where(l => l.Book.ISBN == isbn).ToList();

            if (loanHistory.Count == 0)
            {
                Console.WriteLine("No loan history for this book.");
                return;
            }

            foreach (var loan in loanHistory)
            {
                var returnDate = loan.DateReturned.HasValue ? loan.DateReturned.Value.ToString() : "Not returned";
                Console.WriteLine($"User: {loan.User.FullName}, Loaned: {loan.DateLoaned}, Returned: {returnDate}");
            }
        }

        // View user history (which books the user has borrowed)
        public void ViewUserHistory(string uid)
        {
            var userHistory = loans.Where(l => l.User.UID == uid).ToList();

            if (userHistory.Count == 0)
            {
                Console.WriteLine("No loan history for this user.");
                return;
            }

            foreach (var loan in userHistory)
            {
                var returnDate = loan.DateReturned.HasValue ? loan.DateReturned.Value.ToString() : "Not returned";
                Console.WriteLine($"Book: {loan.Book.Title}, Loaned: {loan.DateLoaned}, Returned: {returnDate}");
            }
        }
    }

    // Program (UI)
    class Program
    {
        static void Main(string[] args)
        {
            var library = new LibrarySystem();

            while (true)
            {
                Console.WriteLine("\n--- Library System ---");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. List Books");
                Console.WriteLine("3. Add User");
                Console.WriteLine("4. List Users");
                Console.WriteLine("5. Loan Book");
                Console.WriteLine("6. Return Book");
                Console.WriteLine("7. List Active Loans");
                Console.WriteLine("8. View Book History");
                Console.WriteLine("9. View User History");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Book Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Year of Publication: ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Enter ISBN (10 or 13 digits): ");
                        string isbn = Console.ReadLine();
                        library.AddBook(title, author, year, isbn);
                        break;

                    case "2":
                        library.ListBooks();
                        break;

                    case "3":
                        Console.Write("Enter User Full Name: ");
                        string fullName = Console.ReadLine();
                        Console.Write("Enter User Address: ");
                        string address = Console.ReadLine();
                        library.AddUser(fullName, address);
                        break;

                    case "4":
                        library.ListUsers();
                        break;

                    case "5":
                        Console.Write("Enter User UID: ");
                        string uidLoan = Console.ReadLine();
                        Console.Write("Enter ISBN: ");
                        string isbnLoan = Console.ReadLine();
                        library.LoanBook(uidLoan, isbnLoan);
                        break;

                    case "6":
                        Console.Write("Enter User UID: ");
                        string uidReturn = Console.ReadLine();
                        Console.Write("Enter ISBN: ");
                        string isbnReturn = Console.ReadLine();
                        library.ReturnBook(uidReturn, isbnReturn);
                        break;

                    case "7":
                        library.ListLoans();
                        break;

                    case "8":
                        Console.Write("Enter ISBN to view history: ");
                        string isbnHistory = Console.ReadLine();
                        library.ViewBookHistory(isbnHistory);
                        break;

                    case "9":
                        Console.Write("Enter User UID to view history: ");
                        string uidHistory = Console.ReadLine();
                        library.ViewUserHistory(uidHistory);
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
