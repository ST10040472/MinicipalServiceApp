// Announcement.cs
using System;

namespace MunicipalServicesApp.Models
{
    public class Announcement
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public Announcement(string title, DateTime date, string category, string description)
        {
            Title = title;
            Date = date;
            Category = category;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Title} ({Category}) - {Date:dd MMM yyyy}";
        }
    }
}
