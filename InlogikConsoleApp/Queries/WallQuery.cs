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
        private string FormatWallMessage(Message message)
        {
            return $"{message.projectName} - {message.username}: {message.content} ({message.GetRelativeTimeString()})";
        }

        public IEnumerable<string> Handle(WallQuery query, Dictionary<string, User> users, Dictionary<string, Project> projects)
        {
            if (!users.ContainsKey(query.username))
            {
                return Enumerable.Empty<string>();
            }

            var followedProjects = users[query.username].projects;
            var allMessages = new List<Message>();

            foreach (var projectName in followedProjects)
            {
                if (projects.ContainsKey(projectName))
                {
                    allMessages.AddRange(projects[projectName].messages);
                }
            }

            return allMessages
                .OrderBy(m => m.timestamp)
                .Select(m => FormatWallMessage(m))
                .ToList();
        }
    }
} 