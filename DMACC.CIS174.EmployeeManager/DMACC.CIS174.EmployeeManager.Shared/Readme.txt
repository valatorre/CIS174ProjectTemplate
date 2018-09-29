DMACC.CIS174.EmployeeManager.Shared

This project will serve as the bridge between the domain project and the projects that
will need to do the CRUD operations.

This is where almost all of your business logic will reside. Also anything that needs to
be shared and used from multiple places. By putting any shared logic here you will only
have one place to update it should you need to update it in the future. Also it is easier
to debug if you don't have similar functionality on your website acting differently because
they are using two different sources of code. 