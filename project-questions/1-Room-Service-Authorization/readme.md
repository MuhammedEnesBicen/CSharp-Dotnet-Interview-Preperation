## .NET Core: Room Service Authorization

This question was asked on Hackerrank for a programme with the name "İnnova Install Future".

### Question Text:

A company is launching a room service for managing rooms. The service should be a web API layer using .NET Core 3.0. You already have a prepared infrastructure and need to implement the Web API Controller RoomsController. Use the Middleware mechanism from .Net Core to protect the API service from the third-party requests.

The following API calls are implemented:

1. Creating rooms: a POST request to the endpoint api/rooms adds the room to the database. The HTTP response code is 200.

2. Getting all rooms: a GET request to the endpoint api/rooms returns the entire list of rooms. The HTTP response code is 200.

3. Getting room by id: a GET request to the endpoint api/rooms/{id} returns the details of the room for {id}. If there is no room with {id}, status code 404 is returned. On success, status code 200 is returned.

4. Getting all rooms filtered by the Floor property: a GET request to the endpoint api/rooms?Floors={floor1}&Floors={floor2} returns the entire list of rooms for floor1 and floor2. The HTTP response code is 200.

Complete the Middleware of the project in the following way:

Implement Middleware that checks if the request contains the header passwordKey with the value passwordKey123456789. If the request contains this header, allow the request. If not, return HTTP response code 403 Forbidden.

Definition of the Room model:

id - The ID of the room. [INTEGER]

category - The category of the room. [STRING]

number - The number of the room. [INTEGER]

floor - The floor of the room. [INTEGER]

isAvailable - The flag that shows if the room is available. [BOOLEAN]

addedDate - The date when the room was added in UTC (GMT + 0). [EPOCH INTEGER]

---

Only needed class added this repo.

Instructions

1. Create a dotnet wepapi project

2. add EntityFrameworkCore.InMemory package with running this command : `dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 9.0.0-preview.2.24128.4`

in your Program.cs file

3. add `builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("Rooms"));` line
before `builder.Services.AddControllers();`


add

``` c#
app.Use(async (context, next) =>
{
    if (context.Request.Headers["passwordKey"] != "passwordKey123456789")
    {
        context.Response.StatusCode = 403;
        await context.Response.WriteAsync("Unauthorized");
        return;
    }
    await next();
});
```

afer `app.MapControllers();`

4. Create a RoomController then replace its content with RoomController.cs files content from this repo. Don't remove namespace block when you replace contents.

5. Add ApplicationDbContext.cs and Room.cs files to your project surround this files contents with namespace blocks.

``` c#
using Microsoft.EntityFrameworkCore;
using RoomServiceAuthorization.models;

namespace RoomServiceAuthorization.context // dont forget update namespace name according to your project
{
   // content should inside of this block
}
```

6. Dont forget to add using expressions
