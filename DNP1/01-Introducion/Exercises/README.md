# DNP Exercises 01 - Course Introduction

## Exercise 1
Take the official .NET and C# in-browser tutorial: https://www.microsoft.com/net/learn/in-browser-tutorial/1

## Exercise 2
Create a new console application using the .NET Core CLI. Have the application output your name to the console.

## Exercise 3
Create a new `Person` class in a separate file. The class should contain a name field and an `Introduce` method that prints *“Hi, I am (name)”* to the console. In the `Main` method of the `Program` class, create an instance of the `Person` class, specifying the `name` property with object initializer notation and then call the `Introduce` method on the object.

## Exercise 4
Write a program that prints all even numbers between 0 and 100 using a for loop. Next, create a while loop that prints all the uneven numbers.

## Exercise 5
Write a program that uses a switch-case structure. The program should take a number between 0 and 10. If the number is 0, print *“this is the first number”* to the console. If the number is 10, the program should write *“this is the last number”*. In any other case, the program should print the number provided. (unless the number is not between 0 and 10, in which case it should output *“invalid number”*).

## Exercise 6
Create a Calculator class and put it in it's own `MathLib` namespace inside a separate `DNP` namespace. Create an `Add` method in the calculator that takes two numbers and use it in the `Main` method of `Program.cs`. Add an overload method for `Add` that takes an array of integers and adds them together. Use this overload method in the `Main` method of the program.

## Exercise 7
Write a program that takes two number inputs from the console and then displays the maximum of the two. (hint: use the `Console.ReadLine()` method)

## Exercise 8
Write a program that asks the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

## Exercise 9
Create a static `SummarizeText` method in a separate `StringUtility` class. Use this class to return a summarized text string if the provided string is more than 20 characters long (i.e. the string will end early with “...”) (hint: use the `Split` and `Join` methods of the `String` class)

## Exercise 10
Expand on your `Calculator` class from earlier. Implement methods for subtraction, division and multiplication. (remember to check for division by zero)
