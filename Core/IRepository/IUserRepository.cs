using Core.Model;

namespace Core.IRepository
{
    public interface IUserRepository
    {
        User Get(string name, string password);
    }
}