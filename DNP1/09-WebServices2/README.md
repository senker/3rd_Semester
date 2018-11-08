# DNP Exercises 09 - Exposing Web Services

## Exercise 1 - Create a Web API Project

Using the CLI, create a new web API project.

*Optional*: Start your project using “dotnet new web” instead and extend the template so that you have the same starting point as a “dotnet new webapi” project.

*(You can even start the project as a basic console application if you’re interested in knowing how to transition from a basic console app to a web API)*

## Exercise 2 - A Client for Testing

Run your web API (using “dotnet run” in the root folder of your project) and then perform a `GET` request to your web API using Postman (typically located on <http://localhost:5000>).

- What response do you receive?
- What is the content and format of the response?

## Exercise 3 - Building Your API

Create a C# `TodoItem` class with appropriate properties (`long` Id, `string` Name, `bool` IsComplete).

Now, here’s an example overview of what your API should be able to do:

| API                       | Description               | Request body | Response body        |
|---------------------------|---------------------------|--------------|----------------------|
| GET /api/todo             | Get all to-do items       | None         | Array of to-do items |
| GET /api/todo/{id}        | Get an item by ID         | None         | To-do item           |
| POST /api/todo            | Add a new item            | To-do item   | To-do item           |
| PUT /api/todo/{id}        | Update an existing item   | To-do item   | None                 |
| DELETE /api/todo/{id}     | Delete an item            | None         | None                 |

You can choose to use another model for your API. For example, if you like cats, create your API around retrieving and storing information about cats. Or if you like pizza, have the API be able to retrieve/add/delete/edit pizzas!

The main areas that you should keep an eye on when creating your API:

### Accessing Data

Configure your API so that the data is stored in the in memory database.

### Attribute Routing / Route Templates

Adjust your controller so that the routes match the above overview of the API. Use route tokens and extract route values when needed.

### Model Binding and Validation

Use the `[FromBody]` attribute to bind the incoming request body using the default JSON formatter.

Apply data annotations to your model (e.g. the `Name` property should at least be 3 characters long).

### Action Results

Change your controller actions to use `IActionResult` so that a status code is included in the response to the client. Remember to validate your model wherever appropriate.

For your `POST` request, you should use the `CreatedAtRoute` method (of the `ControllerBase` class) to tell the user where the data was stored.

### Optional: Formatting

Configure your API so that it can also send a response formatted as `XML`.

Test that this is working by setting the request accept header of a `GET` request using Postman.

Next, configure your controller so that JSON is always returned regardless of the request accept header when performing a `GET` request to the same URI.

If you’re finding it hard to get started with building the API on your own, follow [this official tutorial from Microsoft](https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-vsc).

## Exercise 4 - Help Pages (optional)

Create help pages for your Web API using Swagger.

[This is a good place to start](https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-2.1).

## Exercise 5 - A Client for the API

Create a basic console application that consumes your web API.

The client should perform a GET request to one of your API endpoints, download the data in an asynchronous manner and then write the response to the console.

Next, extend your client to also use the POST, PUT and DELETE endpoints of your API.
