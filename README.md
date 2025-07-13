# Population-Stats-Report

## Overview

The Population Reporting System is a C# application designed to retrieve and present population statistics from a world database. This system provides insights into demographic data, offering reports on countries, cities, and capital cities organized by population. Additionally, it includes features that allow users to generate customized reports based on specific criteria.

---

## Project Details

### Objective

The goal of this project is to develop a system using C# and MySQL that generates comprehensive reports on global population statistics. The key functionalities include:

* Displaying population data for countries, cities, and capital cities sorted by population size.
* Allowing users to define and view the top N most populated countries, cities, and capital cities.
* Offering population distribution insights by continent, region, country, and city.
* Presenting statistics on major language speakers, including Chinese, English, Hindi, Spanish, and Arabic.

### System Features

#### 1. Report Generation

* Retrieve and display country, city, and capital city data sorted by population.
* Generate user-defined top N reports for countries, cities, and capital cities.
* Provide population distribution details at various levels (continent, region, country, and city).

#### 2. Language Demographics

* Report on the number of people speaking widely used languages such as:

  * Chinese
  * English
  * Hindi
  * Spanish
  * Arabic

#### 3. Data Access and Population Insights

* Retrieve population figures from different geographic levels, including continents, regions, and cities.
* Offer data on individuals residing in urban areas versus those in rural settings.

#### 4. Structured Reports

* **Country Report**: Displays country code, name, continent, region, population, and capital city.
* **City Report**: Provides city name, country, district, and population.
* **Capital City Report**: Lists capital cities along with their respective country and population.
* **Population Report**: Details the population breakdown by continent, region, and country, including urban and rural distributions.

---

## Use Cases

### Use Case 1: Country Population Report

* **Preconditions**:

  * The user must be authenticated.
  * The system must have access to a database containing country population data.
* **Trigger**: The user selects the option to generate a population report for countries.
* **Main Flow**:

  1. User chooses the "View Country Population Report" option.
  2. System fetches country population data from the database.
  3. Data is sorted in descending order by population.
  4. System presents the report displaying each country's name and population details.
* **Expected Outcome**: A detailed country population report is displayed in descending order of population.
* **Exceptions**:

  * If the database connection fails, an error message is displayed.

### Use Case 2: Retrieve Top Populated Cities

* **Preconditions**:

  * The user must be authenticated.
  * The system must have a valid dataset of city population information.
  * The user should provide the number of cities to retrieve (Top N).
* **Trigger**: The user selects the "Retrieve Top N Populated Cities" option and specifies the number.
* **Main Flow**:

  1. User selects the option.
  2. System prompts for the number of cities (N).
  3. User provides a valid number.
  4. System retrieves and sorts city data by population.
  5. Top N results are displayed in a structured format.
* **Expected Outcome**: Top N most populated cities are presented.
* **Exceptions**:

  * Invalid number entered prompts user for valid input.
  * If data retrieval fails, an error message is shown.

### Use Case 3: User Authentication

* **Preconditions**:

  * User must have an existing account.
  * System must have access to stored credentials.
* **Trigger**: The user attempts to log in by providing credentials.
* **Main Flow**:

  1. User accesses the login screen.
  2. System requests username and password.
  3. User inputs credentials.
  4. System validates them.
  5. If successful, user is redirected to the dashboard.
* **Expected Outcome**: User logs into the system successfully.
* **Exceptions**:

  * Incorrect credentials show an error.
  * System failures notify the user.

### Use Case 4: Modify Country Population Data (Admin)

* **Preconditions**:

  * User must be logged in with administrator privileges.
  * System must offer an interface for modifying country data.
* **Trigger**: Administrator selects to update country population.
* **Main Flow**:

  1. Admin logs into the system.
  2. Admin selects "Modify Country Population Data."
  3. System prompts for the country to modify.
  4. Admin selects a country.
  5. Current population data is shown.
  6. Admin enters updated population.
  7. System saves the update and confirms.
* **Expected Outcome**: Population data is updated successfully.
* **Exceptions**:

  * If the country does not exist, show an error.
  * Invalid value prompts for valid input.

---

## Implementation Details

This system is developed using **C#** with **MySQL** serving as the database backend. The application interacts with the database to extract relevant information and generate reports efficiently.

### Key Functionalities

* **Dynamic Queries**: The system enables users to request customized reports with sorted population data.
* **User-Defined Parameters**: Users can specify the number of top entries they want to retrieve in reports.
* **Detailed Population Breakdown**: Provides a clear distribution of population statistics across different geographic locations.

---

## Setup and Installation

1. Clone the repository to your local system:

```bash
git clone https://github.com/username/PopulationReportingSystem.git
```

2. Open the project in Visual Studio or any compatible C# IDE.
3. Ensure MySQL is installed and import the world database using the provided schema.
4. Build and run the application through the IDE or using command-line tools.

---

## Usage Instructions

Upon launching the application, users will be presented with an interactive menu. Users can select different report options, including:

* Viewing all countries, cities, and capitals sorted by population.
* Retrieving the top N most populated countries, cities, and capitals based on user input.

---

## Continuous Integration and Deployment (CI/CD)

The project utilizes **GitHub Actions** to automate builds and run tests upon each commit.

* These automated workflows ensure that code is compiled and tested before being merged into the main branch.

---

## System Diagrams

### Use Case Diagram

The system supports multiple roles, including **Administrators** and **End Users**. Below is an outline of their interactions with the system:

**Administrator:**

* Generates population reports.
* Manages user access and permissions.

**End User:**

* Views population reports based on country, city, and region.
* Requests customized reports for the top N most populated locations.

**System:**

* Processes user requests to generate top N reports.
* Provides breakdowns of population statistics, including urban and rural populations.

*Diagram Files: (to be added)*

### Activity Diagram

The activity diagram illustrates the step-by-step process of generating population reports and user interactions with the system.

*Diagram File: (to be added)*

---

## Contribution Guidelines

* Fork the repository before contributing.
* Create a new feature branch (`feature/your-feature-name`) or a bug fix branch (`bugfix/your-bugfix-name`).
* Submit a pull request with a clear description of your changes.

---

## Code of Conduct

All contributors are expected to adhere to the project's Code of Conduct to maintain a respectful and inclusive environment.

---

## Project Team

* **Product Owner**: Defines system requirements and prioritizes tasks.
* **Scrum Master**: Ensures smooth implementation of Scrum methodology and removes development obstacles.
* **Development Team**: Implements features and reports as per the project specifications.
