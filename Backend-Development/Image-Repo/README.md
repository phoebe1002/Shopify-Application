# Image Repository - Backend

## Overview
This is the backend development for Image Repository Application that offers developers APIs for adding and retrieving user and image information. 

## Start up
Navigate to ImageApi directory and run the following command:
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
* POST a User 
- URL + /User

* GET a User
- URL + /User/{Phone Number}
- Example: https://image-repo.azurewebsites.net/User/2063317069

* POST an Image
- URL + /Image

* GET all images by a User
- URL + /Image/{User Id}
* Example: https://image-repo.azurewebsites.net/Image/1
