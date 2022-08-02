using CCSANoteApp.Domain;

namespace CCSANoteApp.Infrastructure.Services
{
    public class UserService : IUserService
    {
        List<User> users = new List<User>();

        #region USER DETAILS
        public void CreateUser(string username, string email, string password)
        {
            users.Add(new User
            {
                Username = username,
                Email = email,
                Password = password
            });
        }

        public void CreateUser(User user)
        {
            users.Add(user);
        }

        public void DeleteUser(Guid id)
        {
            var user = users.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                users.Remove(user);
            }
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public User GetUser(Guid id)
        {
            var user = users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public void UpdateName(Guid id, string name)
        {
            var user = users.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                user.Username = name;
            }
        }

        public void UpdateEmail(Guid id, string email)
        {
            var user = users.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                user.Email = email;
            }
        }

        #endregion
    }
}
