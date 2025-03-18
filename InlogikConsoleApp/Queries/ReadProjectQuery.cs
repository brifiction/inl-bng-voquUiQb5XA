using InlogikConsoleApp.Domain;
using System.Collections.Generic;
using System.Linq;

namespace InlogikConsoleApp.Queries
{
    public class ReadProjectQuery
    {
        public string projectName { get; private set; }

        public ReadProjectQuery(string projectName)
        {
            this.projectName = projectName;
        }
    }

    public class ReadProjectQueryHandler
    {
        public IEnumerable<Message> Handle(ReadProjectQuery query, Dictionary<string, Project> projects)
        {
            if (!projects.ContainsKey(query.projectName))
            {
                return Enumerable.Empty<Message>();
            }

            return projects[query.projectName].messages
                .OrderBy(m => m.timestamp)
                .ToList();
        }
    }
} 