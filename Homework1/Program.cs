using Homework1.Abstracts;
using Homework1.Concretes;
using Homework1.Entities;

IPrintableService printableService = new PrintableManager();
ILibraryService libraryService = new LibraryManager(printableService);

List<Book> books = new()
{
    new() { Id = 1, AuthorName = "Sabahattin Ali", Title = "Kürk Mantolu Madonna", YearOfPublication = 1943 },
    new() { Id = 2, AuthorName = "Sabahattin Ali", Title = "Kuyucaklı Yusuf", YearOfPublication = 1937 },
    new() { Id = 3, AuthorName = "Peyami Safa", Title = "Dokuzuncu Hariciye Koğuşu", YearOfPublication = 1930  },
};

Library library = new()
{
    Books = books
};

bool loop = true;
while (loop)
{
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n" +
        "*******************************************\n" +
        "(1) Kitap Ekle\n" +
        "(2) Kitap Sil\n" +
        "(3) Kitapları Listele\n" +
        "(4) Çıkış Yap\n" +
        "Yapılacak işlem: ");

    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.Clear();
            libraryService.AddBook(library);
            break;

        case "2":
            Console.Clear();
            libraryService.DeleteBook(library);
            break;

        case "3":
            Console.Clear();
            libraryService.WriteAllBook(library);
            break;

        case "4":
            loop = false;
            break;

        default:
            Console.WriteLine("Geçersiz işlem. Lütfen tekrar giriş yapınız.");
            break;
    }
}