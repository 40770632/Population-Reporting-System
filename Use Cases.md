Use Case 1: Country Population Report
Preconditions:

User is authenticated.

System has access to country population data.

Trigger:

User selects "View Country Population Report."

Main Flow:

User selects the report option.

System fetches country population data.

Data is sorted descending by population.

System displays country names and population details.

Expected Outcome:

User sees a detailed report of countries sorted by population.

Exceptions:

If database connection fails, show an error message.

Use Case 2: Retrieve Top Populated Cities
Preconditions:

User is authenticated.

City population data is available.

User provides number N.

Trigger:

User selects "Retrieve Top N Populated Cities."

Main Flow:

User selects the option.

System prompts for number N.

User enters N.

System fetches city population data.

System sorts data descending and selects top N.

System displays the top N cities.

Expected Outcome:

User sees top N most populated cities.

Exceptions:

Invalid N input: prompt again.

Data fetch failure: show error.

Use Case 3: User Authentication
Preconditions:

User has an account.

Credentials are stored.

Trigger:

User attempts to log in.

Main Flow:

User enters username and password.

System verifies credentials.

If valid, user is logged in and redirected.

Expected Outcome:

User gains access.

Exceptions:

Invalid credentials: show error.

System failure: notify user.

Use Case 4: Modify Country Population Data (Admin)
Preconditions:

User logged in as admin.

System allows data modification.

Trigger:

Admin selects modify option.

Main Flow:

Admin logs in and selects modification.

Admin selects country.

System displays current data.

Admin enters updated population.

System validates and updates database.

System confirms update.

Expected Outcome:

Population data updated.

Exceptions:

Country not found: error.

Invalid input: prompt again.

Use Case 5: Retrieve Language Speaker Statistics
Preconditions:

User authenticated.

Language population data available.

Trigger:

User selects "View Language Speaker Statistics."

Main Flow:

User selects the option.

System retrieves language speaker data.

System sorts languages by number of speakers.

System displays language names and statistics.

Expected Outcome:

User views sorted language speaker data.

Exceptions:

Data retrieval error: show message.

Use Case 6: Generate Capital City Population Report
Preconditions:

User authenticated.

Capital city population data available.

Trigger:

User selects "Capital City Population Report."

Main Flow:

User selects the report option.

System fetches capital cities data.

Data is sorted descending by population.

System displays capital cities and populations.

Expected Outcome:

Report of capital cities shown to user.

Exceptions:

Database error: display error.

Use Case 7: Export Report
Preconditions:

User has generated a report.

Trigger:

User selects "Export Report."

Main Flow:

User selects export format (PDF, Excel).

System generates export file.

System prompts user to save or opens file.

Expected Outcome:

Report is exported successfully.

Exceptions:

Export failure: notify user.

Use Case 8: View Historical Population Trends
Preconditions:

User authenticated.

Historical data available.

Trigger:

User selects "View Population Trends."

Main Flow:

User chooses a country or city.

System retrieves historical population data.

System displays trends in chart form.

Expected Outcome:

User views population trends over time.

Exceptions:

No data found: inform user.

Use Case 9: Admin User Management
Preconditions:

Admin logged in.

Trigger:

Admin selects "Manage Users."

Main Flow:

Admin views user list.

Admin adds, edits, or deletes users.

System updates user database accordingly.

System confirms changes.

Expected Outcome:

Admin manages users successfully.

Exceptions:

Operation failure: show error.

Use Case 10: Password Reset
Preconditions:

User has an account.

Trigger:

User selects "Forgot Password."

Main Flow:

User inputs email or username.

System verifies user identity.

System sends password reset link or temporary password.

User resets password using provided method.

Expected Outcome:

User resets password and regains access.

Exceptions:

Invalid email/username: prompt user.

Email delivery failure: notify user.
