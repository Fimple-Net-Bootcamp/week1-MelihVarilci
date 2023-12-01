using Homework1.Abstracts;
using Homework1.Entities;

namespace Homework1.Concretes;

public class PrintableManager : IPrintableService
{
    public void WriteAllBook(Library library)
    {
        Console.WriteLine("{0,-10} {1,-30} {2,-25} {3,-15}", "ID", "KİTAP İSMİ", "YAZAR", "YAYIM YILI");
        Console.WriteLine("{0,-10} {1,-30} {2,-25} {3,-15}", "**", "*****", "******", "***********");
        foreach (Book book in library.Books)
        {
            Console.WriteLine("{0,-10} {1,-30} {2,-25} {3,-15}", book.Id, book.Title, book.AuthorName, book.YearOfPublication);
        }
    }
}