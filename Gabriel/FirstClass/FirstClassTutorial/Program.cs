using FirstClassTutorial;
// See https://aka.ms/new-console-template for more information

//Manual Data mapping
CreateBookAuthorDto userData = new();
userData.BookName = "Get Rich";
userData.AuthorName = "Gabriel";

Book book = new();
book.Name = userData.BookName;

Author author = new();
author.Name = userData.AuthorName;


Console.WriteLine(book.Name);

