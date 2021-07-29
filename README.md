# _VitallyVeg API_

### _Custom API made with my own recipes from [vitallyveg.com](https://vitallyveg.com)_

##### By:
#####  _** Jamie Knutsen ©2021 **_


## Technologies Used

* _Visual Studio Code_
* _C# and .NET_ 
* _Node_
* _MySQL_
* _Entity Framework Core (EF Core)_


## Description: 
This API was designed to seed data from [vitallyveg.com](https://vitallyveg.com). This API was created so that it can be used for my Capstone project at Epicodus. The user will be able to cycle through the provided recipes in this API and make a grocery list from the recipe ingredients. 

## Setup/Installation Requirements
_You can view this webpage by checking out the url:_
https://github.com/Knutsenjamie/Vitally-Veg-API.git

### Prerequisites
* [C# & .NET] Install at (https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.100-macos-x64-installer) (If Mac) OR https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.102-windows-x64-installer (If Windows)
* [dotnet script] After installing C# and .NET, run the command `dotnet tool install -g dotnet-script` in your computer's terminal or text editors terminal. 
* [Node] (https://nodejs.org/en/)
* A text editor such as [VS Code] (https://code.visualstudio.com/)
* For the database, you'll need to install MySQL (https://dev.mysql.com/downloads/file/?id=484914). I also suggest using MySQL workbench as a GUI for viewing databases to check that they're up to date. 

### Installation
1. Open terminal
2. Input these commands into terminal's command line:
3. `cd desktop`
4. Clone https://github.com/Knutsenjamie/Vitally-Veg-API.git
5. Run the command `code .` in your computer's terminal
6. Open VS Code or other preffered text editor terminal within the project file
7. To start a development server and view the project in the browser:
  * Run the command 'npm install' to install dependencies within the project file.
8. In order to use the database you must make an appsettings.json file. Run the command `touch appsettings.json` in the `VitallyVeg` directory of the project. 
  * Within `appsettings.json`, you will want to paste in this exact code (with the exception entering in your own password to access MySQL)
  
  ```
  {
    {
      "Logging": {
        "LogLevel": {
          "Default": "Information",
          "Microsoft": "Warning",
          "Microsoft.Hosting.Lifetime": "Information"
        }
      },
      "AllowedHosts": "*",
            "ConnectionStrings": {
                "DefaultConnection": "Server=localhost;Port=3306;database=vitally_veg;uid=root;pwd=[YOUR-PASSWORD-HERE];"
        }
    }

  }
  ```
  This way, you can access and create the MySQL database locally.
  * Then navigate into the `VitallyVeg` directory again if not there already, and run the command `dotnet ef database update`. You should now be able to open MySQL workbench and see a database named `vitally_veg` that includes all of the projects correct tables and be able to use the database for this API.  
  * In your individual projects terminal, run the command `cd VitallyVeg` to navigate into the project file from the root directory. 
  * Type the command `dotnet restore` to update and restore all needed packages and dependencies to run the application.
  * Finally, run the command `dotnet run` or `dotnet watch run` to start a development server to see and test the API's swagger endpoints. 
  * To connect the API to the react front end, enter the launchurl `http://localhost:5000/api/recipes` after starting the development server.  

## Licensing

Licensed under the [MIT License](license).

## Contact Information

_Jamie Knutsen (knutsenjamie@yahoo.com)_