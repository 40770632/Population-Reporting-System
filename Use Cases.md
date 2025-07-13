**Population Reporting System - Use Case Document**

---

**Use Case 1: Country Population Report**

**Preconditions:**

* The user must be authenticated.
* The system must have access to a database containing country population data.

**Trigger:**

* The user selects the option to generate a population report for countries.

**Main Flow:**

1. The user chooses the "View Country Population Report" option.
2. The system fetches country population data from the database.
3. The data is sorted in descending order by population.
4. The system displays each country's name and population details.

**Expected Outcome:**

* A detailed country population report is displayed in descending order of population.

**Exceptions:**

* If the database connection fails, an error message is displayed.

---

**Use Case 2: Retrieve Top Populated Cities**

**Preconditions:**

* The user must be authenticated.
* The system must have a valid dataset of city population information.
* The user should provide the number of cities to retrieve (Top N).

**Trigger:**

* The user selects the "Retrieve Top N Populated Cities" option and specifies the number of cities.

**Main Flow:**

1. The user selects the "Retrieve Top N Populated Cities" option.
2. The system prompts the user to enter the number of cities (N).
3. The user provides a valid number.
4. The system retrieves city population data from the database.
5. The data is sorted in descending order by population, and the top N cities are selected.
6. The system displays the results in a structured format.

**Expected Outcome:**

* The system successfully presents the top N most populated cities.

**Exceptions:**

* If the user enters an invalid number, they are prompted to input a valid value.
* If data retrieval fails, an appropriate error message is displayed.

---

**Use Case 3: User Authentication**

**Preconditions:**

* The user must have an existing account.
* The system must have access to stored user credentials.

**Trigger:**

* The user attempts to log in by providing credentials.

**Main Flow:**

1. The user accesses the login interface.
2. The system requests a username and password.
3. The user enters their login credentials.
4. The system verifies the credentials against the database.
5. If successful, the user is redirected to the main dashboard.

**Expected Outcome:**

* The user successfully logs into the system.

**Exceptions:**

* If credentials are incorrect, an error message is displayed.
* If a system failure occurs, the user is notified of a temporary issue.

---

**Use Case 4: Modify Country Population Data (Admin)**

**Preconditions:**

* The user must be logged in with administrator privileges.
* The system must provide an interface for modifying country population data.

**Trigger:**

* The administrator selects the option to update country population details.

**Main Flow:**

1. The administrator logs into the system.
2. The administrator selects "Modify Country Population Data."
3. The system prompts for the name of the country to be modified.
4. The administrator selects a country.
5. The system displays the current population data.
6. The administrator enters the updated population value.
7. The system updates the database and confirms the changes.

**Expected Outcome:**

* The population data for the selected country is updated successfully.

**Exceptions:**

* If the specified country does not exist, the system returns an error.
* If an invalid value is entered, the system requests valid input.

---
