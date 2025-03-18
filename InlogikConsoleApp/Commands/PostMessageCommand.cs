using InlogikConsoleApp.Domain;
using System.Collections.Generic;

namespace InlogikConsoleApp.Commands
{
    public class PostMessageCommand
    {
        public string username { get; private set; }
        public string projectName { get; private set; }
        public string content { get; private set; }

        public PostMessageCommand(string username, string projectName, string content)
        {
            this.username = username;
            this.projectName = projectName;
            this.content = content;
        }
    }

    public class PostMessageCommandHandler
    {
        public void Handle(PostMessageCommand command, Dictionary<string, Project> projects)
        {
            // TODO: Implement the logic to post a message
        }
    }
}