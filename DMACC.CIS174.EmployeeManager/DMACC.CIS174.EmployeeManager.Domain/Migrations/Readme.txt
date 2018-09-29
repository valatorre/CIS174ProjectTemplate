DMACC.CIS174.EmployeeManager.Domain     Migrations folder

This folder will hold all the migrations you add by using the "Add-Migration" command in the 
package manager console window (after selecting this project in the drop down at the top of 
that window). 

"Add-Migration" should be run after you have finished making changes for a feature.  You can 
have as many migrations as you need but it is easier to look through them if they are grouped
in a logical manner. Example you are going to add an Employee for the create employee story. 
Once you have created the Employee class and added all properties that you need for that feature
you would then run the command on all the changes. 

I highly encourage you to review the migration that is created by Visual Studio because sometimes
there are things that don't make sense in there and it gives you a chance to check yourself 
before things get messed up.  If the Migration is not created correctly you can delete the migration 
from this folder at this point and no damage is done. 

Once you are sure that the Migration is correct you will want to run the "Update-Database" 
command in the package manager console window.  This will apply your changes to the database that
you are pointed to in the start up project's config file connection string value. If you get things
messed up after this it is usually best to create a new migration to fix the issue.  You can pull
out migrations to fix them but it gets a little more tricky. 

** IMPORTANT **
When working with your team it is best to let people on the team know that you are going to be
creating a migration and the rest of the team hold off making any migrations of their own until 
you check in the migration that you have created.  Creating migrations in parallel is a pain and
makes for very messy merge and deployements.

You should NOT add any files to this folder manually.  All the files in this folder will be
created by Visual Studio after running the above command.