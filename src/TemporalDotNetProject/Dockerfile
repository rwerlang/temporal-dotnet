FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app
COPY . .

# Restore dependencies and build the project
RUN dotnet restore ./TemporalDotNetProject.csproj
RUN dotnet publish ./TemporalDotNetProject.csproj -c Release -o /app/out



# Use the runtime image for the final stage
FROM mcr.microsoft.com/dotnet/runtime:8.0


# Set the working directory inside the container
WORKDIR /app

COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "TemporalDotNetProject.dll"]
