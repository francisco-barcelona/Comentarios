# Comentarios
Basic Comments CRUD using: 
BackEnd -> Web API ASP.NET · 
FrontEnd -> Angular 2 · 
DataBase -> MySQL · 
ORM -> Entity FrameWork

This is a project which can be helpful for ASP.NET Backend Developers who need a Basic CRUD system to manage the results of a MySQL Database table through Angular FrontEnd. 
It includes the following options: List all results, list result by Id, delete result by Id and update result by Id.

I have used:
Backend: Visual Studio · 
Frontend: Visual Studio Code & Angular CLI · 
Database: XAMPP

Install:
It requires the creation of a database called Comentarios in a MySQL server like XAMPP. I have used the port 3306 for the database, you may have another.
Change it at the Connection String:
BEComentarios-> appsettings.json

There must be running at the same time the MySQL Server, the Visual Studio IIS Server and Visual Studio Code ng server.
The application is accessible at http://localhost:4200.

Troubleshooting:
It may happen that after download the app and try to run it at the console of Visual Studio Code using 'ng serve --o' appears the following message:
An unhandled exception occurred: Cannot find module '@angular-devkit/build-angular/package.json'
Require stack:
...
Followed by multiple paths.

Just execute in the console 'npm update' and after the process execute again 'ng serve --o'. It should work fine.
