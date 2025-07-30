using System.Security.Cryptography;
using System.Text;

public static class PasswordHelper
{
    public static string HashPassword(string password)
    {
        if (password == null) 
            throw new ArgumentNullException(nameof(password));
        using (SHA256 sha = SHA256.Create())
        {
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var b in bytes)
                stringBuilder.Append(b.ToString("*2"));
            return stringBuilder.ToString();
        }
    }

}
