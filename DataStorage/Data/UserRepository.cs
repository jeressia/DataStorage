using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStorage.Data
{
    class UserRepository
    {
        List<User> _users = new List<User>();

        public List<User> GetAll()
        {
            return _users;
        }

        public void Add(User userToAdd)
        {
            userToAdd.Id = Guid.NewGuid();
            _users.Add(userToAdd);
        }

        public void Remove(User userToRemove)
        {
            _users.Remove(userToRemove);
        }

        public User Update(Guid userId, string firstName, string lastName)
        {
            var user = _users.First(x => x.Id == userId);
            user.FirstName = firstName;
            user.LastName = lastName;

            return user;
        }


    }

    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}
