# Use the .NET SDK image for build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory in the container
WORKDIR /app

# Copy the project files to the container
COPY *.sln ./
COPY HNG12Stage0Api/*.csproj ./HNG12Stage0Api/

# Restore dependencies
RUN dotnet restore

# Copy the rest of the application files
COPY . .

# Build the application
RUN dotnet publish -c Release -o out

# Use a smaller runtime image for running the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Expose the port your application runs on
EXPOSE 5000

# Set the entry point for the application
ENTRYPOINT ["dotnet", "HNG12Stage0Api.dll"]
