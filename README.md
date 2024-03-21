Library Management System

The Library Management System is a console-based application that provides functionality for managing a library. It allows users to perform various operations such as 
adding books, removing books, displaying all books, searching for books, and checking book availability.

Features:

Add a Book: Users can add a new book to the library by providing the book's details such as title, author, genre, and publication year.
Remove a Book: Users can remove a book from the library by specifying the book's ID. The application will prompt for confirmation before removing the book.
Display All Books: Users can view the details of all the books present in the library.
Search for a Book: Users can search for books based on a keyword. The application will display a list of books that match the search criteria.
Check Book Availability: Users can check the availability of a book by entering its title. The application will indicate whether the book is available or currently checked out.

Project Structure:

The project consists of the following components:

Models: Contains the Book class that represents a book with properties such as ID, title, author, genre, publication year, and availability status. The ToString() method is overridden to provide a custom string representation of the book.

Services.Interfaces: Defines the ILibraryRepository interface that declares methods for interacting with the library repository.

Services.Repositories: Implements the ILibraryRepository interface in the LibraryRepository class. This class provides functionality for managing the library, including adding and removing books, retrieving all books, searching for books, and checking book availability. It uses a List<Book> to store the books in memory.

ExtensionMethods: Contains the Validator class, which provides methods to validate user inputs. It includes methods for validating publication year, non-empty input, and ID.

Program: The entry point of the application. It contains the Main method that displays the menu and handles user input to perform operations on the library.
