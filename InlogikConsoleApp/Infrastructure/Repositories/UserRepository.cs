using InlogikConsoleApp.Domain;
using InlogikConsoleApp.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace InlogikConsoleApp.Infrastructure.Repositories
{
    public class UserRepository : IRepository<string, User>
    {
        private readonly Dictionary<string, User> users;

        public UserRepository()
        {
            users = new Dictionary<string, User>();
        }

        public User? Get(string username)
        {
            return users.TryGetValue(username, out var user) ? user : null;
        }

        public void Add(string username, User user)
        {
            users[username] = user;
        }

        public bool ContainsKey(string username)
        {
            return users.ContainsKey(username);
        }

        public Dictionary<string, User> GetAll()
        {
            return users;
        }
    }
} 