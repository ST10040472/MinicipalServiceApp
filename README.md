

# Municipal Services App

The **Municipal Services App** is a desktop application designed to streamline the reporting and tracking of municipal issues, such as potholes, streetlight malfunctions, and general maintenance. It also provides access to local events and announcements and lets users track the progress of their service requests.
---
### Video Demonstration of Muncipal App

* 🎥 https://www.youtube.com/watch?v=Gjz7XfWyoXw

---
# Implementation Report

### Overview

This report delves into the "Service Request Status" feature of the Municipal Services Application, highlighting the role of various data structures in its functionality. It covers how these structures were chosen to optimize the feature's performance and illustrates how they contributed to managing and tracking service requests efficiently.

### Roles and Contributions of Data Structures

1. **AVL Trees**

   - **Role**: AVL trees are used to keep service requests sorted by their unique request ID. They are balanced trees, which ensure that search operations can be performed quickly.  
   - **Challenge Overcome**: Managing a large number of service requests without slowing down the system was a significant challenge. Without AVL trees, a basic list could have led to slow searches, especially as the dataset grows. By using an AVL tree, the application performs searches with logarithmic time complexity, ensuring faster lookups even as the number of requests increases.  
   - **Real-World Scenario**: For example, when a user searches for a specific service request by ID, the AVL tree ensures that the lookup time remains quick, regardless of the total number of requests stored. This is particularly important when service requests are added regularly and need to be retrieved efficiently.

2. **Heaps**

   - **Role**: Heaps are used to prioritize service requests based on their urgency, allowing the highest-priority tasks to be accessed quickly.  
   - **Challenge Overcome**: Prioritizing requests was crucial, but manually sorting and filtering large datasets would have been inefficient. Using a heap allows us to access the highest-priority request in constant time, which optimizes the user experience when sorting or filtering requests by priority.  
   - **Real-World Scenario**: If a user sorts the service requests by priority, the heap ensures that the top-priority task is immediately available without waiting for the entire list to be sorted. This means that urgent requests can be dealt with promptly, improving operational efficiency.

3. **Hash Tables and Dictionaries** 

   - **Role**: Hash tables and dictionaries store details about service requests, enabling quick access via unique identifiers such as request IDs.  
   - **Challenge Overcome**: When the user interacts with the dependency graph, we needed a fast way to retrieve detailed service request information. Without hash tables, this process could have been much slower, especially when dealing with large datasets.  
   - **Real-World Scenario**: When a user clicks a node in the dependency graph, the application uses the hash table to fetch the corresponding service request details instantly. This ensures a smooth and responsive interaction without delays in retrieving information.

4. **Queues** 

   - **Role**: Queues are used to handle the order of dependent tasks in the service request workflow, ensuring tasks are completed in the correct sequence.  
   - **Challenge Overcome**: Managing task dependencies manually was error-prone and inefficient. By using queues, we could automate and streamline task processing, ensuring that tasks are handled in the proper order.  
   - **Real-World Scenario**: When a service request depends on the completion of another, the queue ensures that the tasks are processed one after the other, preserving the logical order of operations. This is especially useful when a task cannot proceed without the prior task being completed first.

5. **Graph Data Structure** 

   - **Role**: The graph data structure is used to model the dependencies between service requests. Each request is represented as a node, and edges represent dependencies between them (e.g., Task A must be completed before Task B can begin). This structure enables the visualization of relationships and workflow management.  
   - **Challenge Overcome**: Visualizing complex interdependencies between service requests without overwhelming the user was a challenge. The graph structure provided an elegant solution for displaying dependencies in an intuitive and interactive way.  
   - **Real-World Scenario**: For example, users can view service requests as nodes in a graph, with arrows representing dependencies. This makes it easier for users to understand which tasks need to be completed first and how requests are related. The use of a graph allows for better task management, ensuring that users can prioritize dependent tasks efficiently and visually track progress.
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
