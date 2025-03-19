using NodaTime;
using NodaTime.Extensions;

namespace InlogikConsoleApp.Domain
{
    public class Message
    {
        public string content { get; set; }
        public string username { get; set; }
        public string projectName { get; set; }
        public Instant timestamp { get; set; }

        public Message(string content, string username, string projectName)
        {
            this.content = content;
            this.username = username;
            this.projectName = projectName;
            this.timestamp = SystemClock.Instance.GetCurrentInstant();
        }

        // TODO https://nodatime.org/2.4.x/api/NodaTime.SystemClock.html
        public string GetRelativeTimeString()
        {
            var now = SystemClock.Instance.GetCurrentInstant();
            var duration = now - timestamp;
            
            if (duration.TotalMinutes < 60)
            {
                var minutes = (int)duration.TotalMinutes;
                return $"{minutes} {(minutes == 1 ? "minute" : "minutes")} ago";
            }
            if (duration.TotalHours < 24)
            {
                var hours = (int)duration.TotalHours;
                return $"{hours} {(hours == 1 ? "hour" : "hours")} ago";
            }
            if (duration.TotalDays < 7)
            {
                var days = (int)duration.TotalDays;
                return $"{days} {(days == 1 ? "day" : "days")} ago";
            }
            if (duration.TotalDays < 30)
            {
                var weeks = (int)(duration.TotalDays / 7);
                return $"{weeks} {(weeks == 1 ? "week" : "weeks")} ago";
            }
            if (duration.TotalDays < 365)
            {
                var months = (int)(duration.TotalDays / 30);
                return $"{months} {(months == 1 ? "month" : "months")} ago";
            }
            
            var years = (int)(duration.TotalDays / 365);
            return $"{years} {(years == 1 ? "year" : "years")} ago";
        }
    }
}