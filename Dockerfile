# Use the .NET SDK for build
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source

# Copy project files
COPY . .

# Restore dependencies
#RUN dotnet restore "./ConsoleApp1/ConsoleApp1.csproj" --disable-parallel

# Build the project
RUN dotnet publish "./ConsoleApp1/ConsoleApp1.csproj" -c Release -o /app --no-restore

# Use the runtime image for the final build
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app

# Copy published files
COPY --from=build /app .

# Expose port 80
EXPOSE 80

# Run the application
ENTRYPOINT ["dotnet", "DotNetPractice.dll"]
