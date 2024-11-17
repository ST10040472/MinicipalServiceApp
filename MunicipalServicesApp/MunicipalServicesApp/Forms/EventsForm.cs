using MunicipalServicesApp.Models;
using MunicipalServicesApp.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class EventsForm : Form
    {
        private EventManager eventManager;
        private AnnouncementManager announcementManager;
        private RecommendationEngine recommendationEngine;

        public EventsForm()
        {
            InitializeComponent();

            // Initialize the event and announcement manager
            eventManager = new EventManager();
            announcementManager = new AnnouncementManager();
            recommendationEngine = new RecommendationEngine(); 


            // Populate UI components
            InitializeCategoryComboBox();
            DisplayEvents(eventManager.GetAllEvents());
            DisplayAnnouncements(announcementManager.GetAllAnnouncements());
        }

        private void InitializeCategoryComboBox()
        {
            cmbCategoryEvents.Items.Add("All Categories");
            cmbCategoryEvents.Items.AddRange(eventManager.GetCategories().ToArray());
            cmbCategoryEvents.SelectedIndex = 0;

            cmbCategoryAnnouncements.Items.Add("All Categories");
            cmbCategoryAnnouncements.Items.AddRange(announcementManager.GetCategories().ToArray());
            cmbCategoryAnnouncements.SelectedIndex = 0;
        }

//Events Code-------------------------------------

        //Display Events
        private void DisplayEvents(List<Event> events)
        {
            listViewEvents.Items.Clear();
            foreach (var evt in events)
            {
                var listViewItem = new ListViewItem(new[] { evt.Title, evt.Date.ToString("dd MMM yyyy"), evt.Category, evt.Description });
                listViewEvents.Items.Add(listViewItem);
            }
        }
        //*

        //Filtering for Events
        private void btnApplyFilterEvents_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategoryEvents.SelectedItem?.ToString();
            DateTime? startDate = chkUseDateFilterEvents.Checked ? datePickerStartDateEvents.Value.Date : (DateTime?)null;
            DateTime? endDate = chkUseDateFilterEvents.Checked ? datePickerEndDateEvents.Value.Date : (DateTime?)null;

            // Get the search term from the input textbox
            string searchTerm = txtSearchEvents.Text.Trim();

            // Handle "All Categories" selection
            if (selectedCategory == "All Categories")
            {
                selectedCategory = null;
            }

            // Call the updated SearchEvents method with the searchTerm
            var filteredEvents = eventManager.SearchEvents(
                searchTerm,
                selectedCategory,
                startDate,
                endDate);

            groupBoxFilterEvents.Visible = false;
            btnFilterEvents.Text = "Show Filters";
            DisplayEvents(filteredEvents);
        }

        //*

        //Displays and Hides Filtering Options
        private void btnFilterEvents_Click(object sender, EventArgs e)
        {
            groupBoxFilterEvents.Visible = !groupBoxFilterEvents.Visible;
            btnFilterEvents.Text = groupBoxFilterEvents.Visible ? "Hide Filters" : "Show Filters";
        }
        //*

        //Allows view to hide or display details for events
        private void btnViewDetailEvent_Click(object sender, EventArgs e)
        {
            if (listViewEvents.View == View.Tile)
            {
                // Switch to Details view
                listViewEvents.View = View.Details;
                btnViewDetailEvent.Text = "Hide Details";
            }
            else
            {
                // Switch back to Tile view
                listViewEvents.View = View.Tile;
                btnViewDetailEvent.Text = "View Details";
            }
        }
        //*

        //Search Events
        private void btnSearchEvent_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchEvents.Text.Trim();
            string selectedCategory = cmbCategoryEvents.SelectedItem?.ToString();

            // Treat "All Categories" as no category filter
            if (selectedCategory == "All Categories")
            {
                selectedCategory = null;
            }

            DateTime? startDate = chkUseDateFilterEvents.Checked ? datePickerStartDateEvents.Value.Date : (DateTime?)null;
            DateTime? endDate = chkUseDateFilterEvents.Checked ? datePickerEndDateEvents.Value.Date : (DateTime?)null;

            // Search events with current filters
            var filteredEvents = eventManager.SearchEvents(searchTerm, selectedCategory, startDate, endDate);

            // Get recommendations based on the search term
            var recommendedEvents = recommendationEngine.GetRecommendations(eventManager, searchTerm);

            DisplayEvents(filteredEvents); // Display filtered events
            DisplayRecommendations(recommendedEvents); // Display recommendations
        }
        //*

        private void DisplayRecommendations(List<Models.Event> recommendedEvents)
        {
            pnlRecommendations.Items.Clear(); // Clear previous recommendations

            if (recommendedEvents.Count == 0)
            {
                // Optionally add a message indicating no recommendations
                var noRecItem = new ListViewItem("No recommendations available.");
                pnlRecommendations.Items.Add(noRecItem);
            }
            else
            {
                foreach (var evt in recommendedEvents)
                {
                    var listViewItem = new ListViewItem(new[]
                    {
                        evt.Title,
                         evt.Category,
                        evt.Date.ToString("dd MMM yyyy")
                    });
                    pnlRecommendations.Items.Add(listViewItem); // Add each recommendation to the ListView
                }
            }
        }

        //End of Events Code------------------------------


        //Announcements Code------------------------------
        //Display Announcements
        private void DisplayAnnouncements(List<Models.Announcement> announcements)
        {
            listViewAnnouncements.Items.Clear();
            foreach (var ann in announcements)
            {
                var listViewItem = new ListViewItem(ann.Title); // Set the Title as the main item text
                listViewItem.SubItems.Add(ann.Date.ToString("dd MMM yyyy")); // Add Date as a subitem
                listViewItem.SubItems.Add(ann.Category); // Add Category as a subitem
                listViewItem.SubItems.Add(ann.Description); // Add Description as a subitem

                listViewAnnouncements.Items.Add(listViewItem);
            }
        }
        //*

        //Filtering for Announcements
        private void btnApplyFilterAnnouncements_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategoryAnnouncements.SelectedItem?.ToString();
           
            var filteredAnnouncements = announcementManager.GetAnnouncementsByCategory(selectedCategory);
            DisplayAnnouncements(filteredAnnouncements);
        }
        //*

        //Displays and Hides Filtering Options
        private void btnFilterAnnouncements_Click(object sender, EventArgs e)
        {
            groupBoxFilterAnnouncements.Visible = !groupBoxFilterAnnouncements.Visible;
            btnFilterAnnouncements.Text = groupBoxFilterAnnouncements.Visible ? "Hide Filters" : "Show Filters";
        }

        //Allows view to hide or display details for announcements   
        private void btnViewDetailAnnouncements_Click(object sender, EventArgs e)
        {
            if (listViewAnnouncements.View == View.Tile)
            {
                // Switch to Details view
                listViewAnnouncements.View = View.Details;
                btnViewDetailAnnouncements.Text = "Hide Details";
            }
            else
            {
                // Switch back to Tile view
                listViewAnnouncements.View = View.Tile;
                btnViewDetailAnnouncements.Text = "View Details";
            }
        }

        




        //*

        //end of Announcements Code-------------------------
    }
}
