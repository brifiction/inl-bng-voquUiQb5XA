# InlogikConsoleApp.Tests

A dedicated project solution to store all unit testing using `xunit`. This project is built with .NET 9.0 and uses the latest xUnit testing framework.

## How to Use

1. **Running Tests**

   ```bash
   dotnet test
   ```

   This will execute all tests in the project.

1. **Running Specific Tests**
   ```bash
   dotnet test --filter "FullyQualifiedName~UserTests"
   ```
   This will run only tests in the UserTests class.

## Project Structure

- `UserTests.cs` - Contains tests for the User domain class
- Additional test files should follow the naming convention: `{ClassUnderTest}Tests.cs`

## Design Patterns

The project follows these key testing patterns and principles:

1. **Arrange-Act-Assert Pattern**
   Each test is structured in three parts:

   - Arrange: Set up the test data and conditions
   - Act: Perform the operation being tested
   - Assert: Verify the results

1. **Naming Convention**
   Tests are named using the pattern:
   `{MethodUnderTest}_{Scenario}_{ExpectedResult}`

   Example: `UserWhenCreated_ShouldHaveCorrectUsernameAndEmptyProjects`, see https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices.

1. **Test Independence**
   Each test is independent and can run in isolation without depending on other tests.
