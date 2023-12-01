namespace Homework1.Entities;

public abstract class WrittenWork 
{
    public string Title { get; set; }
    public string AuthorName { get; set; }
    public int YearOfPublication { get; set; }

    public WrittenWork()
    {
        Title = string.Empty;
        AuthorName = string.Empty;
    }

    public WrittenWork(string title,
                      string authorName,
                      int yearOfPublication)
    {
        Title = title;
        YearOfPublication = yearOfPublication;
        AuthorName = authorName;
    }
}