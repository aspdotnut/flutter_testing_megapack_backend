namespace flutter_testing_megapack_backend.Models;

public class Password(string passwrd)
{
    public int Id { get; set; }
    public string Passwrd { get; set; } = passwrd;
}