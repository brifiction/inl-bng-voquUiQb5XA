using InlogikConsoleApp.Domain;
using System.Collections.Generic;

namespace InlogikConsoleApp.Commands
{
    public class FollowProjectCommand
    {
        public string username { get; private set; }
        public string projectName { get; private set; }

        public FollowProjectCommand(string username, string projectName)
        {
            this.username = username;
            this.projectName = projectName;
        }
    }

    public class FollowProjectCommandHandler
    {
        public void Handle(FollowProjectCommand command, Dictionary<string, User> users, Dictionary<string, Project> projects)
        {
            // TODO: Implement the logic to follow a project
        }
    }
}