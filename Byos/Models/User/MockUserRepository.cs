using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Byos.Models
{
    public class MockUserRepository : IUserRepository
    {
        private List<User> _userList;
        public MockUserRepository()
        {
            _userList = new List<User>()
            {
                new User() { Id = 1, Name = "Daniel Pana", Email = "karo@webi.ro", Password = "test" },
                new User() { Id = 2, Name = "Test User", Email = "test@webi.ro", Password = "test" }
            };
        }

        public User Add(User user)
        {
            user.Id = _userList.Max(e => e.Id) + 1;
            _userList.Add(user);
            return user;
        }

        public User Delete(int Id)
        {
            User deletedUser = _userList.FirstOrDefault(e => e.Id == Id);
            if (deletedUser != null)
            {
                _userList.Remove(deletedUser);
            }
            return deletedUser;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userList;
        }

        public User GetUser(int Id)
        {
            return _userList.FirstOrDefault(t => t.Id == Id);
        }

        public User Update(User userChanges)
        {
            User user = _userList.FirstOrDefault(e => e.Id == userChanges.Id);
            if (user != null)
            {
                user.Name = userChanges.Name;
                user.Email = userChanges.Email;
                user.Password = userChanges.Password;
            }
            return user;
        }
    }
}
