DMACC.CIS174.EmployeeManager.Shared     ViewModels folder

This is the folder where you will put all your viewmodels which will be how you will
transfer data between the domain (database) project and your consuming applications
(Web / Api)

These are used in order to mask the database schema from the end users.  Also there are
many use cases where we will not want or need all the data from the database table 
for the function or feature that we are working on and then we can use a slimmed down
view model in order to save memory, save CPU cost, and make a more performant application.