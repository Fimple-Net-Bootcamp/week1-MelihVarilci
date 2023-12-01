namespace Homework1.Entities;

public class Library
{
    public ICollection<Book> Books { get; set; } = null!;
    public ICollection<Member> Members { get; set; } = null!;
}