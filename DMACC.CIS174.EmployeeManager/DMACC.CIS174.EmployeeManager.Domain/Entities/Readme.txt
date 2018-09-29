DMACC.CIS174.EmployeeManager.Domain     Entities folder

This is the folder where you will want to put all your entity classes which represent your
database schema.

The classes in this folder will generally contain only public properties which coorespond to
the columns in the database table with the same name. 

Every class in this folder should be declared as a DbSet in the EmployeeManagerContext class 
in order to tell entity framework that you would like it to be included in the database schema.