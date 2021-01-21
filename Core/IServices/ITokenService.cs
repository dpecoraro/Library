using Core.Model;

namespace Core.IServices
{
    public interface ITokenService
    {
        string GenerateToken(User user); 
    }
}