TogglNetApi
===========

Toggl is a free time tracking application.  https://www.toggl.com/

It provides an API and this is a .net wrapper for that API!

There are 3 projects in the solution.
1 - TogglApi.  This is a class library project containing the API.
2 - TogglApi.Web.  An MVC 4 project just to play with the API.
3 - TogglApi.Tests.  An MS Tests project that will contain coded tests for the API.

The solution has been created in VS 2012.

It supports both username/password and api token authentication.

------

As of 17.12.2013 I have just started the project, as part of an internal project to look at Toggl.
So there really isn't much in the API at present, but I plan to build it out step by step and share the code here.

------

For the API I have used the well know REST library RESTSharp. http://restsharp.org/

I have used JSON C# Class Generator to help build the model classes. https://jsonclassgenerator.codeplex.com/
