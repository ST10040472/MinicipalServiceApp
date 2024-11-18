

# Municipal Services App

The **Municipal Services App** is a desktop application designed to streamline the reporting and tracking of municipal issues, such as potholes, streetlight malfunctions, and general maintenance. It also provides access to local events and announcements and lets users track the progress of their service requests.

---

## Features

### 🛠️ Issue Reporting
- Submit detailed reports with descriptions, locations, categories, and attached images.
- Upload images in `.jpg`, `.jpeg`, `.png`, or `.bmp` formats.
- A progress bar updates in real-time as you fill in the required fields.

### 📅 Events and Announcements
- Browse local events and announcements posted by the municipality.
- Get personalized event recommendations powered by a recommendation engine based on your search history.
- Search and filter events/announcements by category or date range.
- Toggle between a **detailed view** (showing time, date, location, and description) and a **compact view** (titles and essential info only).

### 📈 Service Request Status
- Track the progress of your submitted service requests with statuses like **Pending**, **In Progress**, or **Completed**.
- Use advanced filtering options:
  - **By Status**: Display requests based on their current status.
  - **By Priority**: Sort and show high-priority issues first using a priority queue.
  - **Search by ID**: Quickly locate a request by its unique ID.
- Visualize dependencies between requests through an interactive graph:
  - **Zoom** with the scroll wheel.
  - **Pan** using drag-and-drop.
  - **Click nodes** for detailed information on specific requests.

---

## System Requirements

- **Operating System**: Windows 7, 8, 10, or 11
- **Framework**: .NET Framework 4.7.2 or later
- **Memory**: Minimum 2 GB RAM
- **Storage**: At least 100 MB free space

---

## Getting Started

### 🚀 Downloading and Running the Application

1. **Clone or Download the Repository**:
   ```bash
   git clone https://github.com/ST10040472/MunicipalServiceApp.git
   ```
   Or download the ZIP file directly from the repository and extract it.

2. **Open the Project in Visual Studio**:
   - Open Visual Studio and click **Open a Project or Solution**.
   - Navigate to the downloaded repository folder and open the `.sln` file.

3. **Restore Dependencies**:
   - Go to `Tools > NuGet Package Manager > Manage NuGet Packages for Solution` and restore missing packages.

4. **Build the Solution**:
   - Select `Build > Build Solution` or press `Ctrl + Shift + B`.

5. **Run the Application**:
   - Set the project as the startup project.
   - Click **Start** or press `F5` to run the app.

---

## How to Use

### 🔀 Main Navigation
- **Report Issues**: Opens the "Report Issues" form to submit new service requests.
- **Local Events**: Opens the "Events and Announcements" page to browse events and announcements.
- **Service Status**: Opens the "Service Request Status" page to track your submitted requests.

### 📝 Reporting an Issue
1. Fill in the required fields:
   - **Location**: Enter the issue's location.
   - **Category**: Select the issue type (e.g., "Potholes," "Streetlights").
   - **Description**: Provide details about the issue.
   - **Image**: Upload an optional image related to the issue.
2. Monitor the progress bar as fields are completed.
3. Click **Submit** when all fields are complete. A success message confirms the report was submitted.

### 📢 Events and Announcements
- **Browse** through events and announcements.
- Use **search** and **filters** to narrow results by keywords, category, or date.
- View event/announcement details in a **detailed view** or switch to a **compact view** for a quick overview.
- Receive **personalized recommendations** based on your search history.

### 📊 Viewing Service Request Status
- **Filter** requests by status or priority.
- **Search** for a specific request using its ID.
- Use the **graph** to visualize request dependencies. Zoom, pan, and click nodes for details.

---

## License

This project is licensed under the [MIT License](LICENSE).

---

Feel free to contribute or suggest improvements! 😊
