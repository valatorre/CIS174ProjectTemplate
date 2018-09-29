DMACC.CIS174.EmployeeManager.Shared     Services folder

This folder will be where you put any and all of your services.  "Services" is just a common
wording that is used to indicated reusable code that is used by multiple callers. In this
folder we will create services to provide functionality and features that will be consumed
from multiple places in our application. 

Simple Example: You need to get people based on a set of eligibility criteria such as hire date,
termination date, and country.  This is needed on multiple pages such as your PTO balance screen,
all employee activity report, and the home page of a supervisor.  Instead of creating this logic
in each place we would create something like an EligibilityService which might have a method named
GetAllActiveFrenchEmployees() which implements the specific logic on how to get those employees. 
Then each of the Orchestrators responsible for getting the data in the above pages would just call
EligibilityService.GetAllActiveFrenchEmployees().