namespace Roofiy.Shared.Infrastructure.Security.Encryption;

public interface IHasher
{
    string Hash(string data);
}