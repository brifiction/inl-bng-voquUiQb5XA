using InlogikConsoleApp.Domain;
using InlogikConsoleApp.Queries;
using System.Collections.Generic;

namespace InlogikConsoleApp.Infrastructure
{
    public class QueryProcessor
    {
        private readonly ReadProjectQueryHandler readProjectHandler;

        public QueryProcessor()
        {
            readProjectHandler = new ReadProjectQueryHandler();
        }

        public IEnumerable<Message> ProcessReadProject(string projectName, Dictionary<string, Project> projects)
        {
            var query = new ReadProjectQuery(projectName);
            return readProjectHandler.Handle(query, projects);
        }
    }
} 