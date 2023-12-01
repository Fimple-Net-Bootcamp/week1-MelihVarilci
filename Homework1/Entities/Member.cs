namespace Homework1.Entities;

public class Member
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Number { get; set; }
    public ICollection<Book> Books { get; set; } = null!;

    public Member()
    {
        Name = string.Empty;
        Surname = string.Empty;
        Number = string.Empty;
    }

    public Member(string name,
        string surname,
        string number)
    {
        Name = name;
        Surname = surname;
        Number = number;
    }
}