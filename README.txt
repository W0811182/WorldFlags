Program name: WorldFlags webApp

Program purpose: produce an MVC web app with ASP.NET Core 3.1sdk about a fictional flag
company

Program Author: Eric Workman

Date: 2023-10-12 

-- 1301--

Created new MVC web application with individual user authentication and HTTPS config
First test run with IIS Express -- 1302 --

IIS Express Generated certificate claimed and test ran successfully.

Now changing details about the web app to display information about my fictional company
(title, links etc)

Changed title on webapp to "WorldFlags" and changed the welcome message to include the name.
removed the default asp.net message when starting a new project and am going to 
make it link to the catalogue page.

Now going to create the Catalogue folder and Catalogue.cs Controller and alter it to return
a new page that will have the catalogue.

created a new View page for the newly created and altered catalogue controller to point to.
Before adding the functionality to the links I am going to type "https://localhost:{PORT}/Catalogue" 
to test that my view and controller is setup properly.

--1326

New controller and view work properly when typing in the URL directly.

changed my Catalogue view to have the proper viewData title "Catalogue".
Also changed the <h2> tag below to say "Flag Catalogue".

added a link to the navbar for my catalogue page in the _layout.cshtml page.
now creating and linking to a new "About us" page detailing things like company,staff,headquarters etc.


--1400

Created the "About Us" Controller and viewer now going to give the nav links to the page.
"About Us" link on navbar now links to the about us page (no content within this page yet).

--1407

Now creating a model for my catalogue page

created the model for the catalogue page including
-id
-continent
-country
-price
-Colour
-size
-rating

Now installing Microsoft.EntityFrameworkCore.SqlServer from the Nuget Package Manager.
Microsoft.EntityFrameworkCore.SqlServer(version 3.1.31) downloaded.
Now creating a .cs file within the data folder

--1448

Created a FlagsContext file within the data folder to coordinate the CRUD functions of the catalogue.
changed the connection string (currently on line 32) to my FlagsContext file instead of the default one.
adding FlagsContext to the appsettings.json file now.
added FlagsContext ConnectionString into the appsettings.json file.
Now scaffolding Flags pages.
scaffolding created a file called FlagsController.cs to the Controller folder.

-1500 

Starting initial migrations now
Add-Migration InitialCreate -Context WorldFlagsContext
Update-Database -Context WorldFlagsContext
Commands used to for initial Migration


Now creating seedData.cs in models folder for database

Done creating seed data for flags catalogue now adding the seed initializer to the Program.cs file
Testing app after adding seed data and changing Program.cs file

2023-10-13

--1158

After reviewing what I have done so far and looking 
at the requirements on the rubric i have to still
	-customize the layout of the pages
	-link on the front page "here" links to the catalogue page as intended
	-search and filter functions for the catalogue page
	-make copyright year automatically updatable
	-deploy to azure?

Now linking the link on the front page to go to the catalogue view
Link on home page now directs to flags catalogue

using DateTime.now.year to maek the copyright year update automatically

Now moving on to thinking of some ideas for the layout and testing some colours and fonts