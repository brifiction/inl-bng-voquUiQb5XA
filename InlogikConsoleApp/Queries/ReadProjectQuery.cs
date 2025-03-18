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
        // TODO: Implement the logic to read a project
    }
} 