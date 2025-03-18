using System.Collections.Generic;

namespace InlogikConsoleApp.Domain
{
    public class Project
    {
        public string name { get; private set; }
        public List<Message> messages { get; private set; }

        public Project(string name)
        {
            this.name = name;
            this.messages = new List<Message>();
        }

        public void PostMessage(string userName, string content)
        {
            messages.Add(new Message(content, userName, name));
        }
    }
}