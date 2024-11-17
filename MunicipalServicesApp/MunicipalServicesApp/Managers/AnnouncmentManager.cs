using System;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalServicesApp.Services
{
    public class AnnouncementManager
    {
        private List<Models.Announcement> announcements;

        public AnnouncementManager()
        {
            announcements = new List<Models.Announcement>();

            // Load sample announcements
            LoadSampleAnnouncements();
        }

        private void LoadSampleAnnouncements()
        {
            var sampleAnnouncements = new List<Models.Announcement>
            {
                new Models.Announcement("Community Event Announcement", DateTime.Now.AddDays(1), "Community", "We invite all residents to participate in our upcoming community event to strengthen neighborhood ties."),
                new Models.Announcement("Health Awareness Initiative", DateTime.Now.AddDays(3), "Health", "Our health department is launching a new initiative to promote awareness and prevention of common health issues."),
                new Models.Announcement("Job Fair Notification", DateTime.Now.AddDays(7), "Job", "Attention job seekers! A job fair will be held next week, featuring local employers looking to hire."),
                new Models.Announcement("Recycling Drive Announcement", DateTime.Now.AddDays(14), "Environment", "Join us in our recycling drive to promote sustainability and environmental responsibility in our community."),
                new Models.Announcement("Free Yoga Class Offer", DateTime.Now.AddDays(5), "Health", "The community center is offering free yoga classes for all ages. Sign up today to improve your well-being."),
                new Models.Announcement("Beach Cleanup Day Reminder", DateTime.Now.AddDays(10), "Environment", "We are organizing a beach cleanup day. Help us keep our beaches clean and beautiful."),
                new Models.Announcement("Local Art Show Invitation", DateTime.Now.AddDays(12), "Culture", "You are invited to visit our local art show showcasing the talent of our community artists. Don't miss out on this cultural experience."),
                new Models.Announcement("Food Drive Call to Action", DateTime.Now.AddDays(20), "Charity", "Help those in need by donating non-perishable food items to our annual food drive. Every contribution counts."),
                new Models.Announcement("History Walking Tour Announcement", DateTime.Now.AddDays(25), "Culture", "Discover the rich history of our town by participating in our guided walking tour. Sign up for a unique experience."),
                new Models.Announcement("Family Fun Day Announcement", DateTime.Now.AddDays(30), "Community", "Mark your calendars! Our Family Fun Day is approaching, featuring activities for everyone in the family."),
                new Models.Announcement("Pet Adoption Fair Alert", DateTime.Now.AddDays(35), "Animals", "Looking to adopt a pet? Visit our pet adoption fair and find your perfect companion."),
                new Models.Announcement("Health Screening Event Reminder", DateTime.Now.AddDays(40), "Health", "Free health screenings will be conducted next month. Take advantage of this opportunity to check your health."),
                new Models.Announcement("Local Sports League Registration", DateTime.Now.AddDays(45), "Sports", "Attention sports enthusiasts! Registration for local sports leagues is now open. Sign up to participate."),
                new Models.Announcement("Gardening Workshop Announcement", DateTime.Now.AddDays(50), "Education", "Enhance your gardening skills by attending our informative gardening workshop. All skill levels are welcome."),
                new Models.Announcement("Movie Night in the Park Notice", DateTime.Now.AddDays(55), "Entertainment", "Join us for a special movie night in the park! Bring your blankets and enjoy a film under the stars.")
            };


            announcements.AddRange(sampleAnnouncements);
        }

        // Get all announcements
        public List<Models.Announcement> GetAllAnnouncements()
        {
            return announcements;
        }

        // Get announcements by category
        public List<Models.Announcement> GetAnnouncementsByCategory(string category)
        {
            if (string.IsNullOrWhiteSpace(category) || category == "All Categories")
            {
                return announcements;
            }

            return announcements.Where(a => a.Category == category).ToList();
        }

        // Get distinct categories
        public List<string> GetCategories()
        {
            var categories = announcements.Select(a => a.Category).Distinct().ToList();
            categories.Insert(0, "All Categories"); // Add the "All Categories" option
            return categories;
        }
    }
}
