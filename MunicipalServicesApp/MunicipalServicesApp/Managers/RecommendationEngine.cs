using System;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalServicesApp.Services
{
    public class RecommendationEngine
    {
        private Queue<string> userSearchHistory; // To track recent searches
        private const int MaxHistorySize = 5; // Limit history to 5 items

        public RecommendationEngine()
        {
            userSearchHistory = new Queue<string>();
        }

        // Record a user search
        public void RecordSearch(string searchTerm)
        {
            if (userSearchHistory.Count >= MaxHistorySize)
            {
                userSearchHistory.Dequeue(); // Remove oldest entry if limit reached
            }
            userSearchHistory.Enqueue(searchTerm); // Add new search term
        }

        // Get recommendations based on user search history and term
        public List<Models.Event> GetRecommendations(EventManager eventManager, string searchTerm)
        {
            // Record the current search
            RecordSearch(searchTerm);

            // Gather all events
            var allEvents = eventManager.GetAllEvents();
            var recommendations = new List<Models.Event>();

            // Split the search term into keywords
            var keywords = searchTerm.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Check if any keyword matches the event title or category
            foreach (var evt in allEvents)
            {
                bool matches = keywords.Any(keyword =>
                    evt.Title.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    evt.Category.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0);

                if (matches)
                {
                    recommendations.Add(evt);
                }
            }

            // Include events related to previous searches
            foreach (var pastSearch in userSearchHistory)
            {
                var pastKeywords = pastSearch.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                recommendations.AddRange(allEvents.Where(evt =>
                    pastKeywords.Any(keyword =>
                        evt.Title.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        evt.Category.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)));
            }

            return recommendations.Distinct().ToList(); // Return unique recommendations
        }
    }
}
