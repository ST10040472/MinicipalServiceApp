// IssueManager.cs
using System;
using System.Collections.Generic;
using System.IO;

namespace MunicipalServicesApp
{
    public class IssueManager
    {
        private List<Issue> _issueList = new List<Issue>();
        public int TotalProgressSteps { get; } = 4;

        // Adds a new issue to the list
        public void AddIssue(string location, string category, string description, string filePath)
        {
            var newIssue = new Issue(location, category, description, filePath);
            _issueList.Add(newIssue);
        }

        // Validates form inputs and returns a validation result
        public bool ValidateFormInputs(string location, string category, string description, string attachmentPath, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(location))
            {
                errorMessage = "Please enter a location.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                errorMessage = "Please select a category.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                errorMessage = "Please enter a description.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(attachmentPath) || !IsValidImageFile(attachmentPath))
            {
                errorMessage = "Please upload a valid image file.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        // Checks if the file path corresponds to a valid image file
        private bool IsValidImageFile(string filePath)
        {
            string[] validExtensions = { ".jpg", ".jpeg", ".png", ".bmp" };
            string fileExtension = Path.GetExtension(filePath)?.ToLower();

            return Array.Exists(validExtensions, ext => ext.Equals(fileExtension));
        }

        // Calculates progress based on filled form fields
        public int CalculateProgress(string location, string category, string description, string attachmentPath)
        {
            int progress = 0;

            if (!string.IsNullOrWhiteSpace(location)) progress++;
            if (!string.IsNullOrWhiteSpace(category)) progress++;
            if (!string.IsNullOrWhiteSpace(description)) progress++;
            if (!string.IsNullOrWhiteSpace(attachmentPath)) progress++;

            return progress;
        }

        // Returns a list of categories for the category combo box
        public string[] GetCategories()
        {
            return new string[] { "General", "Maintenance", "Potholes", "Street Lights" };
        }
    }
}
