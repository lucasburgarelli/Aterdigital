using BCrypt.Net;
using static BCrypt.Net.BCrypt;

namespace Aterdigital.Helpers;

public static class Cryptography
{
    public static string Encrypt(string password) => HashPassword(password, 12);
    public static bool Verify(string password, string passwordEncrypted) => Verify(password, passwordEncrypted);
}
