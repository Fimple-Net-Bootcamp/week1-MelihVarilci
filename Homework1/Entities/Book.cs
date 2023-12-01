namespace Homework1.Entities;

public class Book : WrittenWork
{
    public int Id { get; set; }

    public Book()
    {
    }

    public Book(int id,
        string title,
        string authorName,
        int yearOfPublication
        )
        : base(title, authorName, yearOfPublication)
    {
        Id = id;
    }
}