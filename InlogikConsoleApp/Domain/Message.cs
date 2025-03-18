using System;

namespace InlogikConsoleApp.Domain
{
    public class Message
    {
        public string content { get; set; }
        public string username { get; set; }
        public string projectName { get; set; }
        public DateTime timestamp { get; set; }

        public Message(string content, string username, string projectName)
        {
            this.content = content;
            this.username = username;
            this.projectName = projectName;
            this.timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{username} -> @{projectName}: {content} ({timestamp.ToString("yyyy-MM-dd HH:mm:ss")})";
        }
    }
}