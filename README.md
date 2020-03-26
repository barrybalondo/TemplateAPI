# TemplateAPI

A simple template API in .NET Core with the following features.
+ Serilog for easier integration of sinks.
+ Swagger endpoints.
+ Healtcheck endpoints.
+ Global exception handling.
+ Configured to be able to swap configurations.
+ Dapper for raw sql
+ IdenityServer Integration (TODO)

# Setup

Configuration needed to run the project.

## Step 1:

In sql folder, run the initial_migration.sql script in your database.

## Step 2:

Change the Default ConnectionStrings to connect to your database. Example in appsettings.Dev.json.

```json
  "ConnectionStrings": {
    "Default": "Server={Server};Database={Database};User Id={UserId};Password={Password};"
  }
```

# Changing environments

The API will look for the environment variable ASPNETCORE_ENVIRONMENT and will pick up the matching appsetting.{environment}.json

The project however will look for launchSettings.json and if available. environmentVariables settings in launchSettings.json override environment variables. Porject default environment is Dev.

## Example 1: Changing (published) binary environment.

If you compiled the project into binary, the project will run as Prd by default if no environment variable ASPNETCORE_ENVIRONMENT is available. However, to change it by command line you can run the command below.

```
ASPNETCORE_ENVIRONMENT=Dev dotnet Template.API.dll
```
