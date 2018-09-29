DMACC.CIS174.EmployeeManager.Domain

This project is where you will put your database schema and configuration stuff. Everything
that Entity Framework needs in order to be able to create, configure, and update the database
is kept here. 

There shouldn't be any business logic or view models in this project.  Also do NOT expose the
database objects to the consumers of your app.  You should only reference this project from 
the DMACC.CIS174.EmployeeManager.Shared project.