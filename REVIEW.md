## Demo walkthrough

First, I attempt to understand the provided general requirements given in the PDF document, before proceeding.

Then, it was noting down the desired console application commands to be introduced, while asking myself questions such as:

1. What does each command do?
2. What is the console output of each command?
3. How will I deal with outputting a nice "relative datetime" for user?
4. WHat is CQRS pattern?
5. If I am pressed for time, which of the SOLID design principles that I can easily introduce in C#? Single-responsibility? Liskov?

## Coding

After acquiring basic understanding of CQRS pattern from various online sources, I came up with my own folder structure that "closely resembles" Command Query Responsibility Segregation (CQRS) pattern. And I added Domain Driven Design (DDD) pattern too, from online examples like https://github.com/kgrzybek/sample-dotnet-core-cqrs-api.

- Commands
- Domain (Model classes?)
- Infrastructure (All of the "processor" files, to glue everything together)
- Queries (To declare and define query operations in this console app, particularly "reading" and "wall" commands)

During development, there were some slight struggle to re-familiarize C# language again, and finding it's suitable API methods that will help with development. And learning to use some unfamiliar methods along the way.

- Using such as `AddRange`, instead of a `foreach` loop.
- When to use `Dictionary` versus `List`?
- Why use `TryGetValue` versus `ContainsKey`? Is it only because `TryGetValue` is still present across all .Net versions?

## Learning CQRS (and DDD) on-the-go

Firstly, this is what I get for not reading further Uncle Bob's book - fml. I had to initially figure out where everything belongs based on this pattern, while having to incorporate DDD pattern together due to time.

To summarise what to mention:

- How I figured out where everything belonged
- Figured out how DDD is used with CQRS
- To elaborate how the code architecture fits in as a whole
- For future reference, learned how to extend the console application if need be

## Which of the SOLID design principles that were applied?

Due to C# programming challenges, I could only fit in single-responsibility design for the "Infrastructure" codebase.

Goal was to create reusability and clearly defined "repository classes" in the `CommandProcessor`. And then leverage by using an interface for new repositories called `IRepository`. Also, these repositories manages their "model persistence" for each domain model, and the `UserRepository` "manages" the `Dictionary` collection of `users`.

The single-responsibility design principle was only applied at the last stretch of this exercise, due the same exercise challenges mentioned earlier.

## Tech debt & improvements

- Need proper error handling throughout
- Should add validation layer for commands
- Consider adding configuration management
- Documentation needs to be more comprehensive
- To introduce unit testing with `xunit`, such as `dotnet new xunit -n InlogikConsoleApp.Tests` > `dotnet sln add InlogikConsoleApp.Tests/InlogikConsoleApp.Tests.csproj` > `dotnet add InlogikConsoleApp.Tests/InlogikConsoleApp.Tests.csproj reference InlogikConsoleApp/InlogikConsoleApp.csproj`.

## Extensibility / Scalability

The current architecture supports several extension points and scalability options:

### Data Persistence

- Current in-memory storage can be replaced with a proper database
- `IRepository` interface allows easy swap of storage implementations
- Could add MongoDB for document storage or SQL Server for relational data
- Repositories can be extended to support caching layers

### New Features

- Command pattern makes it easy to add new commands (commented example: `newRegex`)
- Query handlers can be extended for new read operations
- Message formatting can be enhanced with rich text or markdown
- Could add user authentication and authorization

### Scalability Considerations

- CQRS pattern already separates read/write operations
- Easy to scale read and write operations independently
- Could introduce event sourcing for better scalability
- Message queuing could be added for async operations

### Potential Improvements

- Add dependency injection for better testability
- Implement event-driven architecture for real-time updates
- Add logging and monitoring infrastructure
- Introduce API layer for web/mobile clients
