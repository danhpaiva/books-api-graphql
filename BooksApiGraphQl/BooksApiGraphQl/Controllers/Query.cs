using BooksApiGraphQl.Models;

namespace BooksApiGraphQl.Controllers;

public class Query
{
    private static List<Book> books = new()
    {
        new Book { Id = new Guid(), Title = "Code Clean", Author = "Robert C. Martin"},
        new Book { Id = new Guid(), Title = "Domain-Driven Design", Author = "Eric Evans"},
    };

    public List<Book> GetBooks() => books;
}