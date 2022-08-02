using CCSANoteApp.Domain;

namespace CCSANoteApp.Infrastructure.Services
{
    public interface IUserService
    {
        void CreateUser(string username, string email, string password);
        void CreateUser(User user);
        void DeleteUser(Guid id);
        List<User> GetAllUsers();
        User GetUser(Guid id);
        void UpdateEmail(Guid id, string email);
        void UpdateName(Guid id, string name);
    }
}
