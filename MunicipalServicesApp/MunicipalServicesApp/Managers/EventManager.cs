// EventManager.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalServicesApp.Services
{
    public class EventManager
    {
        private SortedDictionary<DateTime, List<Models.Event>> eventsByDate;
        private HashSet<string> eventCategories;


        public EventManager()
        {
            eventsByDate = new SortedDictionary<DateTime, List<Models.Event>>();
            eventCategories = new HashSet<string>();

            LoadSampleEvents();
        }

        // Method to load sample events
        private void LoadSampleEvents()
        {
            var sampleEvents = new List<Models.Event>
            {
                new Models.Event("Community Clean-up", DateTime.Now.AddDays(1), "Community", "Join us for a community clean-up event to make our neighborhood cleaner."),
                new Models.Event("Health Fair", DateTime.Now.AddDays(5), "Health", "Free health screenings and wellness information at the Health Fair."),
                new Models.Event("Music Festival", DateTime.Now.AddDays(10), "Entertainment", "Enjoy live music from local bands at the annual music festival."),
                new Models.Event("Farmers Market", DateTime.Now.AddDays(15), "Market", "Visit the local farmers market for fresh produce and homemade goods."),
                new Models.Event("Book Reading", DateTime.Now.AddDays(20), "Culture", "Join us for a book reading by local author Jane Doe."),
                new Models.Event("Charity Run", DateTime.Now.AddDays(25), "Sports", "Participate in a charity run to support local charities and causes."),
                new Models.Event("Art Exhibition", DateTime.Now.AddDays(30), "Arts", "Explore the latest artworks from local artists at the art exhibition."),
                new Models.Event("Tech Workshop", DateTime.Now.AddDays(35), "Education", "Learn about the latest technology trends in our tech workshop."),
                new Models.Event("Community Picnic", DateTime.Now.AddDays(40), "Community", "Join us for a fun-filled picnic at the park with games and activities for all."),
                new Models.Event("Environmental Awareness Seminar", DateTime.Now.AddDays(45), "Environment", "Attend a seminar on environmental issues and sustainability practices."),
                new Models.Event("Neighborhood Potluck", DateTime.Now.AddDays(50), "Community", "Bring a dish to share and enjoy food with neighbors."),
                new Models.Event("Yoga in the Park", DateTime.Now.AddDays(55), "Health", "Join us for a free yoga session in the park."),
                new Models.Event("Open Mic Night", DateTime.Now.AddDays(60), "Entertainment", "Show off your talent at our open mic night."),
                new Models.Event("Summer Craft Fair", DateTime.Now.AddDays(65), "Market", "Shop for handmade goods from local artisans."),
                new Models.Event("Poetry Slam", DateTime.Now.AddDays(70), "Culture", "Compete or enjoy the poetry performances."),
                new Models.Event("Charity Football Match", DateTime.Now.AddDays(75), "Sports", "Join us for a charity football match to raise funds."),
                new Models.Event("Photography Exhibition", DateTime.Now.AddDays(80), "Arts", "Visit our photography exhibition featuring local photographers."),
                new Models.Event("Coding Bootcamp", DateTime.Now.AddDays(85), "Education", "Learn coding skills in our weekend bootcamp."),
                new Models.Event("Community Movie Night", DateTime.Now.AddDays(90), "Community", "Enjoy a movie under the stars with your neighbors."),
                new Models.Event("Health Cooking Class", DateTime.Now.AddDays(95), "Health", "Learn to cook healthy meals with local chefs."),
                new Models.Event("Theater Performance", DateTime.Now.AddDays(100), "Entertainment", "Watch a local theater group perform a classic play."),
                new Models.Event("Holiday Market", DateTime.Now.AddDays(105), "Market", "Shop for holiday gifts at our festive market."),
                new Models.Event("Historical Walking Tour", DateTime.Now.AddDays(110), "Culture", "Explore local history on a guided walking tour."),
                new Models.Event("Charity Bike Ride", DateTime.Now.AddDays(115), "Sports", "Participate in a bike ride to support local charities."),
                new Models.Event("Ceramics Workshop", DateTime.Now.AddDays(120), "Arts", "Create your own pottery in this fun workshop."),
                new Models.Event("Digital Marketing Seminar", DateTime.Now.AddDays(125), "Education", "Learn about digital marketing trends and strategies."),
                new Models.Event("Family Game Night", DateTime.Now.AddDays(130), "Community", "Bring your family for a night of games and fun."),
                new Models.Event("Mental Health Awareness Event", DateTime.Now.AddDays(135), "Health", "Join us for discussions on mental health."),
                new Models.Event("Local Music Showcase", DateTime.Now.AddDays(140), "Entertainment", "Enjoy performances by local musicians."),
                new Models.Event("Winter Festival", DateTime.Now.AddDays(145), "Market", "Celebrate winter with local vendors and activities."),
                new Models.Event("Art in the Park", DateTime.Now.AddDays(150), "Arts", "Create art in a relaxing outdoor setting."),
                new Models.Event("STEM Expo", DateTime.Now.AddDays(155), "Education", "Explore STEM projects and innovations."),
                new Models.Event("Neighborhood Watch Meeting", DateTime.Now.AddDays(160), "Community", "Join us to discuss neighborhood safety."),
                new Models.Event("Health and Wellness Fair", DateTime.Now.AddDays(165), "Health", "Discover resources for health and wellness."),
                new Models.Event("Outdoor Concert", DateTime.Now.AddDays(170), "Entertainment", "Enjoy an outdoor concert with local bands."),
                new Models.Event("Farm-to-Table Dinner", DateTime.Now.AddDays(175), "Market", "Savor a meal made from locally sourced ingredients."),
                new Models.Event("Literary Festival", DateTime.Now.AddDays(180), "Culture", "Celebrate literature with workshops and readings."),
                new Models.Event("Volleyball Tournament", DateTime.Now.AddDays(185), "Sports", "Join our friendly volleyball tournament."),
                new Models.Event("Art Workshop for Kids", DateTime.Now.AddDays(190), "Arts", "Kids can explore their creativity in this workshop."),
                new Models.Event("Entrepreneurship Forum", DateTime.Now.AddDays(195), "Education", "Learn about starting and running a business."),
                new Models.Event("Community Fundraiser", DateTime.Now.AddDays(200), "Community", "Help raise funds for local projects."),
                new Models.Event("Blood Donation Drive", DateTime.Now.AddDays(205), "Health", "Donate blood and save lives."),
                new Models.Event("Film Screening", DateTime.Now.AddDays(210), "Entertainment", "Watch a thought-provoking film with a discussion."),
                new Models.Event("Local Artisan Fair", DateTime.Now.AddDays(215), "Market", "Support local artisans and their crafts."),
                new Models.Event("Cultural Dance Festival", DateTime.Now.AddDays(220), "Culture", "Enjoy cultural dances from around the world."),
                new Models.Event("Charity Tennis Match", DateTime.Now.AddDays(225), "Sports", "Join us for a charity tennis match."),
                new Models.Event("Public Speaking Workshop", DateTime.Now.AddDays(230), "Education", "Enhance your public speaking skills."),
                new Models.Event("Community Garden Day", DateTime.Now.AddDays(235), "Community", "Help plant and maintain the community garden."),
                new Models.Event("Yoga Retreat", DateTime.Now.AddDays(240), "Health", "Relax and rejuvenate at our yoga retreat."),
                new Models.Event("Theater Workshop", DateTime.Now.AddDays(245), "Entertainment", "Learn about acting and stagecraft."),
            };

            foreach (var evt in sampleEvents)
            {
                AddEvent(evt);
            }
        }

        // Method to add an event
        public void AddEvent(Models.Event newEvent)
        {
            if (!eventsByDate.ContainsKey(newEvent.Date))
            {
                eventsByDate[newEvent.Date] = new List<Models.Event>();
            }

            eventsByDate[newEvent.Date].Add(newEvent);
            eventCategories.Add(newEvent.Category);
        }

        // Retrieve all events
        public List<Models.Event> GetAllEvents()
        {
            return eventsByDate.Values.SelectMany(events => events).ToList();
        }

        // Get distinct categories
        public List<string> GetCategories()
        {
            return eventCategories.ToList();
        }

        // Search events based on criteria
        // Search events based on title, category, and date range
        public List<Models.Event> SearchEvents(string searchTerm, string category, DateTime? startDate, DateTime? endDate)
        {
            var filteredEvents = new List<Models.Event>();

            foreach (var date in eventsByDate.Keys)
            {
                // Apply date range filtering
                if (startDate.HasValue && date < startDate.Value.Date || endDate.HasValue && date > endDate.Value.Date)
                    continue;

                foreach (var evt in eventsByDate[date])
                {
                    // Check if the event matches the category
                    if (!string.IsNullOrWhiteSpace(category) && evt.Category != category)
                        continue;

                    // Check if the event title contains the search term
                    if (!string.IsNullOrWhiteSpace(searchTerm) && !evt.Title.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase).Equals(-1))
                    {
                        filteredEvents.Add(evt);
                    }
                    else if (string.IsNullOrWhiteSpace(searchTerm))
                    {
                        // If there's no search term, just add the event if it matches the category
                        filteredEvents.Add(evt);
                    }
                }
            }

            return filteredEvents;
        }


    }
}
