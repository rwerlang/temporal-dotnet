# Temporal .NET Project

This project demonstrates how to use the Temporal client to connect to a Temporal server and implement workflows and activities in a .NET application.

## Project Structure

- **TemporalDotNetProject.sln**: Solution file for the .NET project.
- **src/TemporalDotNetProject**: Contains the main application code.
  - **Program.cs**: Entry point of the application, sets up the Temporal client.
  - **Workflow.cs**: Defines a simple workflow.
  - **Activity.cs**: Implements activities that can be called from workflows.


## Setup Instructions

1. **Clone the repository**:
   ```
   git clone <repository-url>
   cd TemporalDotNetProject
   ```

2. **Restore dependencies**:
   ```
   dotnet restore
   ```

3. **Build the project**:
   ```
   dotnet build
   ```

4. **Run the application**:
   ```
   dotnet run --project src/TemporalDotNetProject/TemporalDotNetProject.csproj
   ```

## Usage

- Implement your workflows and activities in the respective folders.
- Use the `TemporalClient` class to interact with the Temporal server.
- Write unit tests in the `TemporalDotNetProject.Tests` project to ensure your workflows and activities behave as expected.

## Contributing

Feel free to submit issues or pull requests to improve the project.