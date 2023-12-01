using Homework1.Entities;

namespace Homework1.Abstracts;

public interface ILibraryService
{
    public void AddBook(Library library);

    public void DeleteBook(Library library);

    void WriteAllBook(Library library);
}