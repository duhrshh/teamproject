# Team 8 - The Classics


Welcome to our team repository, created for our class project for SWE 3313. All possible documentation will be added here as the project is developed and will ultimately lead to a finished product ready for use.

As for the project itself, the ***Classics*** team is creating an online storefront to sell vintage vinyls of various musical genres with the use of C# and ASP.NET Core Blazor. Walk with us as we learn about the intricacies of developing and managing solutions for our clients.

### Features:

- **Browse** and **search** vinyl inventory  
- **Add to cart**, adjust quantities  
- **Checkout** with shipping options (Overnight, 3-Day, Ground)  
- **Order confirmation** & receipt per user  
- **Admin dashboard**: sales report (all orders, totals & revenue)  
- **User dashboard**: view your past receipts  

All business logic lives in services; UI is cleanly separated into reusable Blazor components.

---
### Prerequisites:

- OS: Windows 10/11+ or macOS 12+ or Linux (Ubuntu 22.04+, Debian 12+, CentOS 8+, etc.)
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)  
- (Optional) [dotnet-ef CLI tools](https://docs.microsoft.com/ef/core/cli/dotnet)  
- A modern browser (Edge, Chrome, Firefox, Safari)

### Getting Started: Follow the instructions below or watch [this](https://www.loom.com/share/b8a258fe8c1041b8a50905dd37de82c9)

1. **Extract the archive**  
	On Windows: right-click → “Extract All…” (or use [7-Zip](https://www.7-zip.org/) / WinRAR)  
	On macOS: double-click in Finder (or use [The Unarchiver](https://theunarchiver.com/))  
	On Linux: `unrar x TheClassics.rar` or use your file-manager’s “Extract Here”
2. **Restore & build**: open Terminal in IDE and run:
	dotnet restore
	dotnet build
3. **Apply EF Migrations (to create the database)**
	dotnet ef database update
4. **Run the app**
	dotnet run

Navigate to `https://localhost:5001` (or port shown in console).

---

## Team Selection

The project started with compiling a group of aspiring engineers that shared the same passion for music:

- [Darsh Patel](/resumes/darsh.md)
- [Chris Pham](/resumes/chris.md)
- [Josiah Regis](/resumes/josiah.md)

---

## Project Plan

Once we gathered, certain discussions were started in order to create an effective plan that would result in a proper product.

#### Team Assignments

- In order to maximize efficiency throughout the project, we assigned certain roles to each contributor:
  - [Project Manager](/projectplan/projectmanager.md) (Darsh)
  - [Front-End Developer](/projectplan/frontend.md) (Chris)
  - [Back-End Developer](/projectplan/backend.md) (Josiah)

#### Technology Selection

- In order to familiarize ourselves with industry-standard tools, we chose to code the project using C# through an ASP.NET Blazor server. To store our data, we utilized an SQLite database. Microsoft Teams was also used to ensure effective communication throughout the length of the project.
- Click [here](/projectplan/technologyselection.md) for a detailed explanation of what technologies and tools we are using and why.

#### Gantt Chart

- Click [here](/projectplan/ganttchart.png) to view our Project Plan in Gantt Chart form via. YouTrack.

#### Presentation
- Click [here](https://www.loom.com/share/61d8d45837cb4d569c5de5bd90054811) to view our Project Plan presentation in Loom.

---

## Requirements

After a lengthy conversation with our customer, we were able to capture their required functionalities, features, and processes necessary for the project to be deemed successful.

In summary, we defined functionality for an online vinyl store that supports account creation, inventory browsing, and secure checkout. Users can register, log in, add unique one-off vinyl records to their cart, and complete purchases using validated payment and shipping information. Admins have extended privileges, including promoting users, managing inventory, and accessing sales reports. The system ensures price accuracy, excludes sold items from listings, and provides high-fidelity UI mockups and receipt displays for clarity and consistency.

The detailed requirements that were elicited from the aforementioned conversation are detailed [here](/requirements/requirementswritten.md).

#### Use Case Diagram
- Click [here](/requirements/usecasediagram.md) for a detailed Use-Case Diagram for our project.

#### Decision Table
- Click [here](/requirements/decisiontable.md) for a detailed view of our Decision Table for all processes in Version 1.

#### Presentation
- Click [here](https://www.loom.com/share/069d267cb07d4b3eb83f0d792977e7f5?t=13) to view our Requirements presentation in Loom.

---

## User Interface Design

Upon drafting our requirements, we got together to create a prototype for our website and all the inner processes.
#### High Fidelity Mockup
- Click [here](https://marvelapp.com/prototype/g080003) for a link to our prototype using Marvel App.

#### Presentation
- Click [here](https://www.loom.com/share/7d4deb348f73421d88ecc8f2680b72e5) to view our User Interface Design presentation in Loom.

---
## Technical Design

After careful consideration, we determined what tools to utilize in order to create our product. The following solutions were deemed to be the most efficient at the time, and were selected with concern for real-time efficiency as well as future maintainability.

#### Implementation Languages & Frameworks
- Click [here](/technicaldesign/languagesframeworks.md) for a detailed review of our languages and framework selection.

#### Entity Relationship Diagrams
- Click [here](/technicaldesign/erd.md) for all our materials relating to ERD diagrams.

#### Data Storage Plan
- Click [here](/technicaldesign/datastorage.md) for an overview of our storage plan.

#### Coding Style Guide
- Click [here](technicaldesign/codingstyle.md) to view a guide to our coding style.

#### Presentation
- Click [here](https://www.loom.com/share/e0a141f35c274266b0f87a961a50ddfb) to view our Technical Design presentation in Loom.

---
## Implementation

Following weeks of immense planning and preparation, we started our final implementation of our solution. Throughout the process, we tested the application numerous times to assure the best balance of efficiency and design was achieved.


#### Implementation Demonstrations.
- Click [here](https://www.loom.com/share/b8a258fe8c1041b8a50905dd37de82c9) for a guide on how to download, install, and run our application on your local machine.
- Click [here](https://www.loom.com/share/a05ba0a606b64a5eaa259467da34625e?sid=8fad71ab-61d5-434f-a8a7-34ec12969922) for a guide on how to manually add items to the InventoryItem entity via SQL query.

---
## Final Presentation

- Click [here](https://www.loom.com/share/19c25425f9a54c9badd253a7fd723e75) to view our final presentation to our clients for the working product.
