## Use Case 1
### Name: 
Login to user account
### Actor: 
Applies to all roles
### Pre-condition: 
User has an existing account to login to.
### Primary Path:
1. The user is on the login screen.
2. The user enters their username and password combination correctly.
3. The system verifies the credentials and takes the user to their home page.
4. The use case ends.
### Post-Condition: 
The user successfully logs into the system and arrives at the home page/dashboard.
### Alternate-Path:
1. The user is on the login screen.
2. The user enters their username and password combination incorrectly.
3. The system denies access to the system and displays an error message detailing the incorrect credentials to the user.
4. The use case ends.
### Post-Condition: 
The user does not login to the system and remains on the login screen to attempt again.



## Use Case 2
### Name: 
Receive guidance on the most relevant required Visa
### Actor: 
Applicant
### Pre-Condition: 
User is logged into their account.
### Primary Path:
1. The user is on the home page with all of the possible options.
2. The user clicks on a button titled get visa advice.
3. The system shows a form for the user to fill in their circumstances.
4. The user submits the form.
5. The system displays the most relevant Visa(s) listed for the individual's case.
6. The use case ends.
### Post-Condition: 
The applicant successfully views information for the visa(s) they can apply for.

## Use Case 3
### Name: 
View more information on the specific eligibility rules for a specific visa.
### Actor: 
Applicant, Visa consultant
### Pre-Condition: 
User has submitted a form to receive visa guidance.
### Primary Path:
1. The user has the identified possible visa(s) they can apply for listed on screen. (See use case 2)
2. The user clicks a link to view more information underneath an identified visa type.
3. The system displays detailed information on the specific eligibility criteria for the selected visa.
4. The use case ends.
### Post-Condition: 
The applicant successfully views the specific details surrounding the eligibility for a selected visa.

## Use Case 4
### Name:
Submit a visa application
### Actor: 
Applicant
### Pre-Condition: 
User is logged into their account.
### Primary Path:
1. The user is on their homepage.
2. The user clicks the option to start a new application.
3. The system displays the visa form with the necessary fields to be filled in.
4. The user fills in each page with their information and clicks next.
5. The user uploads the necessary documentation.
6. The user reviews their whole application before clicking the submit button.
7. The system displays a message stating to the user that it has been submitted successfully.
8. The use case ends.
### Post-Condition: 
The visa application is now saved to the system database ready to be reviewed.
### Alternate Path:
1. The user is on their homepage.
2. The user clicks the option to start a new application.
3. The system displays the visa form with the necessary fields to be filled in.
4. The user fills in each page with their information and clicks next.
5. The user leaves the application unfinished.
6. The user is notified that the progress of the current application has been saved.
7. The use case ends.
### Post-Condition: 
The partially filled in visa application is saved locally on the users machine until the user returns to it but is not submitted through to the system. 

### Use Case 5
### Name: View the progress of a submitted visa application.
### Actor: Applicant, Visa Consultant
### Pre-Condition: A visa has been submitted prior.
### Primary Path:
1. The user is on their homepage.
2. The user views the list of submitted visa applications.
3. The user clicks the button to retrieve the most up to date status for the visa.
4. The system updates to show the status of the visa (pending, processing, submitted, declined, etc)
5. The use case ends.
### Post-Condition: The applicant successfully views the status of their previously submitted visa application(s). 

### Use Case 6
### Name: Review applicants submitted documentation
### Actor: Documentation Reviewer
### Pre-Condition: User is logged into their account
### Primary Path: 
The user is on their homepage.
The user selects the option to review documentation.
The system shows on screen the visa applications that have come through to the system with the attached documentation.
The user reviews the documentation provided alongside a visa application.
The user marks the provided documentation as sufficient and it is ready to be sent to the visa authorities.
The use case ends.
### Post-Condition: The system updates the user’s visa application to display that it has been approved to be sent to the visa authorities.
### Alternate Path:
The user is on their homepage.
The user selects the option to review documentation.
The system shows on screen the visa applications that have come through to the system with the attached documentation.
The user reviews the documentation provided alongside a visa application.
The user marks the provided documentation as insufficient and it is updated on the users system to provide the necessary information stated by the reviewer.
The use case ends.
### Post-Condition: The system updates the user’s visa application to display that it has been disapproved to be sent to the visa authorities and they must submit the necessary further documentation.

Use Case 7
Name: View statistics of overall processed visas
Actor: Branch manager
Pre-Condition: User is logged into their account
Primary Path:
The user is on their homepage.
The user selects the option to view branch statistics.
The system displays a screen with a line graph showing the monthly levels of visas processed in the year.
The use case ends.
Post-Condition: The user successfully views the annual/monthly visa statistics for their branch. 

Use Case 8
Name: View underperforming staff 
Actor: Branch manager
Pre-Condition: User is logged into their account
Primary Path:
The user is on their homepage.
The user selects the option to view branch statistics.
The system displays a bar graph alongside the line graph detailing each staff member's processed visa amount.
The user can identify those underperforming by the shortest height bar.
The use case ends.
Post-Condition: The user successfully identifies the underperforming individuals using the system.

Use Case 9
Name: Add a new type of Visa 
Actor: National Administrator
Pre-Condition: User is logged into their account
Primary Path:
The user is on their homepage.
They click on the option to be taken to the admin panel.
They select the option for creating new visa types.
The system displays a form with the details for the visa type to be added.
The user fills in the form with the necessary information and clicks the create button.
The system updates to reflect the new visa type added.
The use case ends.
Post-Condition: The new visa type can now be applied for using the system.

Use Case 10
Name: Adding a new country for Visa applications
Actor: International Administrator
Pre-Condition: User is logged into their account
Primary Path:
The user is on their homepage.
They click on the option to be taken to the admin panel.
They select the option for setting up a new country.
The system displays a form with the details for the new country and the options to be enabled and disabled.
The user fills in the necessary details and clicks the create button.
The system updates to reflect the changes and staff can now be given roles and assigned to branches within the country to assume the visa process there.
The use case ends.
Post-Condition: The country is successfully created and the business process can assume there once staff have been assigned to the branches within the country.

Use Case 11
Name: Assigning user roles and permissions to internal staff within a branch
Actor: International Administrator
Pre-Condition: User is logged into their account
Primary Path:
The user is on their homepage.
They click on the option to be taken to the admin panel.
They select a country from the dropdown listing all currently available visa destinations.
They select a branch within that country from the dropdown.
The system displays the users alongside their roles and checkboxes for their given permissions.
The user checks which permissions each user role should have.
The user clicks the button to update.
The use case ends.
Post-Condition: The users have successfully been assigned the selected user permissions and should be able to access the content given from their homepages now.
Alternate Path:
The user is on their homepage.
They click on the option to be taken to the admin panel.
They select a country from the dropdown listing all currently available visa destinations.
They select a branch within that country from the dropdown.
The system displays the users alongside their roles and checkboxes for their given permissions.
The user checks which permissions each user role should have.
The user does not click the update button.
The use case ends.
Post-Condition: The system will not persist any changes to the database as update was not pressed and permissions will remain the same despite any made on the user interface by the admin user.
