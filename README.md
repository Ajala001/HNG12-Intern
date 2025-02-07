
# HNG12 Stage 0 API Task
This repository contains a simple public API developed as part of the HNG12 internship Stage 0 backend task. The API returns basic information such as the registered email address, the current datetime in ISO 8601 format, and the GitHub URL of the project.

# Project Description
The API is designed to:

Accept a GET request to a public endpoint.
Return the following details in JSON format:
. Registered email address.
. Current datetime (UTC) in ISO 8601 format.
. GitHub URL of the project.

# Technologies Used
Programming Language: C#
Framework: ASP.NET Core Web API
Deployment: Hosted on a publicly accessible endpoint
Version Control: Git and GitHub

# How to Run the Project Locally
# Prerequisites
Ensure you have the following installed:
.NET 8.0 SDK or later
Git

# Clone the repository:
git clone https://github.com/Ajala001/HNG12-Intern.git

# Steps to Run
Open the project in your favorite IDE (e.g., Visual Studio, Visual Studio Code).

# Restore dependencies:
dotnet restore(Visual Studio Code).

# Run the application:
dotnet run(Visual Studio Code).

Access the API by visiting http://localhost:<port>/api/info in your browser or API client (e.g., Postman).

# API Documentation
Endpoint
GET /api/info

Response Format

{
  "email": "ajala.ba2014@gmail.com",
  "current_datetime": "2025-01-30T09:30:00Z",
  "github_url": https://github.com/Ajala001/HNG12-Intern.git
}

# Response Code
200 Ok

License
This project is open-source and available under the MIT License.


