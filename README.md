# Municipal Services App
Table of Contents
•	Introduction
•	Features
•	System Requirements
•	Usage
o	Main Form Navigation
o	Reporting an Issue
o	Events and Announcements
o	Viewing Service Request Status
•	Downloading and Running the Application
•	License
________________________________________
Introduction
The Municipal Services App is a desktop application designed to streamline the reporting and tracking of municipal issues such as potholes, street light malfunctions, and general maintenance. Users can easily report issues with detailed information and track their progress via the "Service Request Status" feature. Additionally, users can view events and announcements posted by the municipality and manipulated the data with various filtering options.
________________________________________
Features
•	Issue Reporting: Submit detailed issue reports with descriptions, locations, categories, and uploaded images.
•	Events and Announcements: 
•	Service Request Status: View the current status of submitted service requests with options to filter by status, priority, or category. A moveable graph is available to the user to see dependencies that request have on each other
________________________________________
System Requirements
•	Operating System: Windows 7/8/10/11
•	Framework: .NET Framework 4.7.2 or later
•	Memory: Minimum 2 GB RAM
•	Storage: At least 100 MB free space
________________________________________
Usage
Main Form Navigation
•	Upon launching the app, you will see the Main Form with the following options:
o	Report Issues: Navigate to the "Report Issues Form."
o	Local Events: Navigate to the “Events and Announcements Form”
o	Service Status: Navigate to the "Service Request Status" page to view submitted requests.
________________________________________
Reporting an Issue
1.	On the "Report Issues Form," fill in the following details:
o	Location: Enter the specific location of the issue.
o	Category: Choose the issue category from the drop-down list (e.g., "Potholes," "Street Lights").
o	Description: Provide a detailed description of the issue.
o	Image: Upload an image file related to the issue. Supported formats include .jpg, .jpeg, .png, and .bmp.
2.	The Progress Bar at the bottom of the form updates as fields are completed.
3.	Once all fields are filled, click the Submit button. A success message will confirm submission.
________________________________________
Events and Announcements
4.	View Events and Announcements: Browse local events and announcements.
5.	Recommendation Engine: Personalized event recommendations based on user past searches
6.	Search and Filter: Search for events and announcements using keywords and filter by category or date range.
7.	Detail Toggling: Toggle between a detailed and compact view of events and announcements.
8.	In detailed view, full event or announcement details (e.g., time, date, location, description) are displayed.
9.	In compact view, only the titles and essential information are shown.

________________________________________
Viewing Service Request Status
1.	From the Main Form, click the Service Status button.
2.	The "Service Request Status" page displays all submitted issues along with their current statuses, such as "Pending," "In Progress," or "Completed."
3.	Use the available filters:
o	Filter by Status: Display requests based on their current status.
o	Filter by Priority: Show high-priority issues at the top.
o	Search by ID: Quickly locate a specific request by its unique ID.
o	Sort by Priority: Utilizes a priorityQueue to quickly organise the list by priority

Graph Feature
View the graph that shows direct dependencies between Service Requests, you can zoom in and out with the scroll wheel, drag around with your mouse and click on nodes to view details about that request
________________________________________
Downloading and Running the Application
1.	Download the Repository:
o	Visit the GitHub repository 
o	Click on the Code button and select Download ZIP or use (git clone https://github.com/ST10040472/MunicipalServiceApp.git) in your terminal.
2.	Compile and Run in Visual Studio:
o	Step 1: Open Visual Studio and click Open a Project or Solution.
o	Step 2: Navigate to the downloaded repository folder and open the .sln file.
o	Step 3: Restore dependencies by going to Tools > NuGet Package Manager > Manage NuGet Packages for Solution. 
o	Step 4: Build the solution using Build > Build Solution or by pressing Ctrl + Shift + B.
o	Step 5: Set the project as the startup project, then click Start or press F5 to run the application.
________________________________________
License
This project is licensed under the MIT License. 

