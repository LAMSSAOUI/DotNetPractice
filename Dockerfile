# Use .NET 9.0 SDK for building
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /source

# Copy the project file
COPY ["ConsoleApp1/ConsoleApp1.csproj", "ConsoleApp1/"]

# Restore dependencies
RUN dotnet restore "ConsoleApp1/ConsoleApp1.csproj"

# Copy the rest of the application files
COPY . .

# Publish the application
RUN dotnet publish "ConsoleApp1/ConsoleApp1.csproj" -c Release -o /app

# Use .NET runtime for running the app
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app .

ENTRYPOINT ["dotnet", "ConsoleApp1.dll"]
