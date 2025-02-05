20250121 2035 - Run the Application

20250121 2045 - Created the new Project MvcMovie

 20250121 2048 - Added new Controller HelloWorldController

 20500121 2050 - Typed the code and run the class public class       HelloWorldController : Controller

 -
GET: /HelloWorld/ Printed the output" This is my default action".
  GET: /HelloWorld/Welcome/  and got the output "This is the Welcome action method"


20250121 2100 - Made changes to the code to pass some parameters. Created class public string Welcome(string name, int numTimes = 1)
 printed out "Hello Akhil, NumTimes is: 1"

20250122 0910 - added parameters to run the ID 

20250121 2110 - Added the view Index
https://localhost:7086/HelloWorld
 printed "Index"

 
20250121 2115 - Made changes to Index.cshtml and printed
 "Privacy Policy"

20250121 2120 -  Made changes to the Layout.cshtml
printed
""My Movie List""
Hello from our View Template!

20250122 1000 - Created the model class and added new scaffolded item
20250122 1020 - Started initial migration

20250122 1035 - Added the class public partial class InitialCreate : Migration
20250122 1036 - The timestamp is initiated  20250122153115_InitialCreate.cs
20250127 2332 - Movies Releasedate  Populated
20250127 0012 - Added the model to the database 
20250127 0015 - App Initialized and the data is visible in Browser.

20250128 2246 - Added Search to filter the movies
20250128 2255 - Added the search filter using the Id instead of string

20250128 2320 - Added the filter to the index page

20250129 0911 - added the filter by genre.
20250129 0932 - 09:31:59:287	Build started at 09:31...
09:31:59:886	1>------ Build started: Project: MvcMovie, Configuration: Debug Any CPU ------
09:32:09:483	1>MvcMovie -> C:\Users\akhil\source\repos\MvcMovie\bin\Debug\net8.0\MvcMovie.dll
09:32:09:537	========== Build: 1 succeeded, 0 failed, 0 up-to-date, 0 skipped ==========
09:32:09:537	========== Build completed at 09:32 and took 10.324 seconds ==========

20250129 1001 - Added the rating field

20250131 0010 - Added the validation for each and every field

