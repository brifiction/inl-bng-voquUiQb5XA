using InlogikConsoleApp.Domain;
using InlogikConsoleApp.Queries;
using System.Collections.Generic;

namespace InlogikConsoleApp.Infrastructure
{
    public class QueryProcessor
    {
        private readonly ReadProjectQueryHandler readProjectHandler;
        private readonly WallQueryHandler wallHandler;
        public QueryProcessor()
        {
            readProjectHandler = new ReadProjectQueryHandler();
            wallHandler = new WallQueryHandler();
        }

        public IEnumerable<Message> ProcessReadProject(string projectName, Dictionary<string, Project> projects)
        {
            var query = new ReadProjectQuery(projectName);
            return readProjectHandler.Handle(query, projects);
        }

        public IEnumerable<Message> ProcessWall(string username, Dictionary<string, Project> projects)
        {
            var query = new WallQuery(username);
            return wallHandler.Handle(query, projects);
        }
    }
} 