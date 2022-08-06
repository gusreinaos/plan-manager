# Plan-Manager

Plan manager is a web application which makes it easy for our users to keep all plans in the same place, even from different categories, as well as invite  friends in a simple way and intuitive way.

## 🛠 Pre-Requirements 

There are some technical requirements that need to be taken into consideration before having full access to the program´s functionality.
- Install a suitable IDE for C# (recommending [Visual Studio](https://visualstudio.microsoft.com/) or [Rider](https://www.jetbrains.com/rider/) among others)
- Install SDK for .NET since we are using its framework
- Install [Entity Framework](https://docs.microsoft.com/en-us/ef/) (.NET object-database mapper)
- Install [Docker](https://www.docker.com/) (technology for creating images as code such as .dockerfile)
- Install [Docker Compose](https://docs.docker.com/compose/gettingstarted/) (technology for building up several dockers through the file docker-compose.yml)

## 🚀 Getting Started 

For starting using the service please type the commands below in your terminal:
```
git clone https://github.com/gusreinaos/plan-manager.git
cd plan-manager 
docker-compose up -d
cd PlanManager.API
dotnet run
```

## 👨‍💻 Technologies Used 

This project has been developed with a **Hexagonal Architecture** referring to the **SOLID principles** as well as with the use of various design patterns.

Design patterns are formalized best practices that the programmer can use to solve common problems when designing an application or system.

Design patterns can speed up the development process by providing tested, proven development paradigms.

The most important ones I can highlight would be: 

- **cqs** (command query separation) principle 
- **Repository** pattern (where repositories are classes or components that encapsulate the logic required to access data sources)
- **Mediator** pattern which defines an object that encapsulates how a set of objects interact between layers
- **DTO** pattern (where DTOs are classes which control the flow of information and reduce the number of method calls)

In addition, I have used several other tools, among which I highlight **Autofac**, which is responsible for maintaining the **injection of dependencies** in the program.

We also used Swagger in order to keep the documentation of the API

## 📖 User Manual 

Once the dotnet run has been executed, you will be able to access the following route https://localhost:7265/swagger/index.html in your browser from which via [Swagger](https://swagger.io/) you will be able to use the API with its several HTTP functionalities.
