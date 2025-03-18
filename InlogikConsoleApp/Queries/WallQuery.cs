using InlogikConsoleApp.Domain;
using System.Collections.Generic;
using System.Linq;

namespace InlogikConsoleApp.Queries
{
    public class WallQuery
    {
        public string username { get; private set; }

        public WallQuery(string username)
        {
            this.username = username;
        }
    }

    public class WallQueryHandler
    {
        public IEnumerable<Message> Handle(WallQuery query, Dictionary<string, Project> projects)
        {
            if (!projects.ContainsKey(query.username))
            {
                return Enumerable.Empty<Message>();
            }

            return projects[query.username].messages
                .OrderBy(m => m.timestamp)
                .ToList();
        }
    }
} 