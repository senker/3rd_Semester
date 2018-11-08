# DNP Exercises 08 - Consuming Web Services

## Exercise 1 - Issuing an HTTP Request

Install [Postman](https://www.getpostman.com) and get familiar with the interface. Perform basic GET requests to resources on the internet (e.g. <https://google.com> or an API like <https://www.googleapis.com/books/v1/volumes?q=query>). What responses do you get? Where to find the response body? Where to find the response headers?

## Exercise 2 - Using a Fake API

a) Using the [todos resource](https://jsonplaceholder.typicode.com/todos) of the [JSONPlaceholder API](https://jsonplaceholder.typicode.com), query the API with Postman so that only todo items which are already done are returned.

b) Query the API so that only todo items that are not completed and have a userId of 5 are shown. What is the name of this user? (hint: you cannot use the todos resource to find this information).

c) Looking at the documentation of the API, try performing POST, PUT, PATCH and DELETE requests as well (be aware that changes aren't persisted between calls).

## Exercise 3 - Using a Real API

Scout the internet for public APIs that you can perform queries on using Postman. Read through any available documentation of the APIs and see if you can use it as intended.

Here are some examples if you can't find any APIs yourself:

- <https://api.github.com>
- <https://earthquake.usgs.gov/fdsnws/event/1/>
- <https://xkcd.com/json.html>

You can look up more examples on <https://any-api.com> (many APIs require an API key before they can be used).

## Exercise 4 - A REST Client

Create a basic console application that consumes the API from exercise 2. Your application should display a list of users (by name and email) in the console using the <https://jsonplaceholder.typicode.com/users> endpoint.

*Hint: You will need to process the JSON response so that only the name and email of each user is displayed in the console.*

*Hint: [this tutorial](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient) goes through creating a client for a RESTful webservice.*

## Exercise 5 - Downloading Content

Create a program that asynchronously downloads all contents of www.via.dk and displays it in the console. The program should measure the download time and display this in the console after the content.

## Exercise 6 - Asynchronous Methods

Implement your own methods that can be executed asynchronously. You can do whatever you want in the body of your methods, but if you are feeling uninspired you can simply use a Task.Delay call as a proxy for some important work. Have one of your methods depend on the response of one of your asynchronous methods and do some other work while waiting for the asynchronous call to complete.

*Hint: The Task.Run method is simply a nice utility method that helps you schedule some synchronous work to be run asynchronously.*

*Bonus question: Answer the following question: What happens if you throw an exception within an async method?*

## Exercise 7 - A Client for a Service

Create a small application using a web service that you decide yourself. For inspiration, a few websites is listed below with access to the documentation of various APIs.

- <https://www.programmableweb.com/apis/directory>
- <https://www.data.gov/>
- <https://developers.google.com/apis-explorer/#p/>
- <http://portal.opendata.dk>
