namespace InlogikConsoleApp.Domain
{
    public class Message
    {
        public string content { get; set; }
        public string userName { get; set; }
        public string projectName { get; set; }
        public DateTime timestamp { get; set; }

        public Message(string content, string userName, string projectName)
        {
            this.content = content;
            this.userName = userName;
            this.projectName = projectName;
            this.timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{userName} -> @{projectName}: {content} ({timestamp.ToString("yyyy-MM-dd HH:mm:ss")})";
        }
    }
}