using Homework1.Abstracts;
using Homework1.Entities;

namespace Homework1.Concretes;

public class LibraryManager : ILibraryService
{
    private readonly IPrintableService _printableService;

    public LibraryManager(IPrintableService printableService)
    {
        this._printableService = printableService;
    }

    public void AddBook(Library library)
    {
        string title;
        string authorName;
        int yearOfPublication;
        bool inputIsValid;

        // Kitap başlığını al
        do
        {
            Console.Write("Kitap Başlığı: ");
            title = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Geçerli bir kitap başlığı giriniz.");
            }
        } while (string.IsNullOrWhiteSpace(title));

        // Yazar adını al
        do
        {
            Console.Write("Yazar: ");
            authorName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(authorName))
            {
                Console.WriteLine("Geçerli bir yazar adı giriniz.");
            }
        } while (string.IsNullOrWhiteSpace(authorName));

        // Yayın yılını doğru formatta al
        do
        {
            Console.Write("Yayın Yılı: ");
            inputIsValid = int.TryParse(Console.ReadLine(), out yearOfPublication);
            if (!inputIsValid)
            {
                Console.WriteLine("Geçersiz Yayın Yılı. Lütfen bir sayı giriniz.");
            }
        } while (!inputIsValid);

        try
        {
            // Yeni kitap oluştur ve kütüphaneye ekle
            int newBookId = library.Books.Max(x => x.Id) + 1;
            Book newBook = new(newBookId, title, authorName, yearOfPublication);
            library.Books.Add(newBook);
            Console.WriteLine("Kitap başarıyla eklendi.");
        }
        catch (ArgumentException ex)
        {
            // Ekleme işlemi sırasında bir hata oluşursa (örneğin, ID geçersizse) hata mesajını yazdır
            Console.WriteLine(ex.Message);
        }
    }

    public void DeleteBook(Library library)
    {
        bool inputIsValid;
        WriteAllBook(library);
        int bookId;

        do
        {
            Console.Write("Silmek istediğiniz kitabın ID bilgisini giriniz: ");
            inputIsValid = int.TryParse(Console.ReadLine(), out bookId);
            if (!inputIsValid)
            {
                Console.WriteLine("Geçersiz Yayın Yılı. Lütfen bir sayı giriniz.");
            }
        } while (!inputIsValid);

        Book? deletedBook = library.Books.FirstOrDefault(x => x.Id == bookId);

        if (deletedBook is not null)
            library.Books.Remove(deletedBook);
        else
            Console.WriteLine("Geçersiz kitap ID!");
    }

    public void WriteAllBook(Library library)
    {
        _printableService.WriteAllBook(library);
    }
}