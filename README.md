# ASP.NET Core Web App (MVC) - Customize Authentication with Unit Test
This solution included 2 Projects: Main project is a basic customize-authentication of MVC Identiy and a Unit Test project using XUnit

# Environment
1. Visual Studio Community 2019
2. SQL Server Developer 2019 v18.10

# Setup for running first time
1. In VS, open Project CustomizeAuthentication / appsettings.json: Edit your connection string to your local SQL Server DB
2. Open Package Manager Console, run Update-Database
3. Check your local SQL Server DB if the database is migrated (there's might be issue here, check #Known Bugs and Issues for more information
4. Running CustomizeAuthentication

# Known Bugs and Issues
- Entity Framework might not working properly due to unknown caused, this will make command "Update-Database" not migrated any table into the Database you selected. 
Please follow below step to migrate database
1. Drop your migrated database.
2. Delete folder Migrations in CustomizeAuthentication project
3. Open Package Manager Console, run *Add-Migrations "Re-migration"* and then run *"Update-Database"*
4. Check you local SQL Server DB if the database is migrated. If there is still an issued, please create new Issues. 
