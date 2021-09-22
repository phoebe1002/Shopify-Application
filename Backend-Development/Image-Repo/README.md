# Image Repository - Backend

## Overview
This is the backend development for Image Repository Application that offers developers APIs for adding and retrieving user and image information. 

## Start up
0. Directory Structure
* Separated 3 application layers and 1 direcotory for models. 
* To access Data Access layer, go to DL direcotry
* To access Business Logic layer, go to BL directory
* To access Web Api layer, go to ImageApi direcotry
* To access Models, to go Models dircotry

1. Save Connection Strings in your appsettings.json
```json
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
   "DB": "Server=chunee.db.elephantsql.com;Database=vghmleoe;UserId=vghmleoe;Password=wML3LyBF8-q1BGVAsWMZSWHeX1MbdpIh" 
  }
}
```

2. Navigate to Data Access layer (DL direcotry) and add migrations
* Before adding migrations, run scaffold commands to interact with your ef
```
    dotnet tool install --global dotnet-ef
```
* Then add migrations with specific names. 
```
    dotnet ef migrations add [enter migration name] -c AppDBContext --startup-project ../ImageApi
    dotnet ef database update --startup-project ../ImageApi
```

3. Navigate to ImageApi directory and run the following command:
```
    dotnet run
```

## Tables
* Users
* Images

## Tech Stack
* .NET 5
* C#
* EF Core (ORM)
* ASP.NET Web API
* PostgreSQL DB / ElephantSQL
* Azure for hosting

## API Endpoints
URL: https://image-repo.azurewebsites.net
### POST a User 
- URL + /User

### GET a User
- URL + /User/{Phone Number}
- Example: https://image-repo.azurewebsites.net/User/2063317069

### POST an Image
- URL + /Image

### GET all images by a User
- URL + /Image/{User Id}
* Example: https://image-repo.azurewebsites.net/Image/1
