using System.Collections.Generic;

namespace InlogikConsoleApp.Domain
{
    public class Project
    {
        public string Name { get; private set; }
        public List<Message> Messages { get; private set; }

        public Project(string name)
        {
            Name = name;
            Messages = new List<Message>();
        }

        public void PostMessage(string userName, string content)
        {
            Messages.Add(new Message(content, userName, Name));
        }
    }
}