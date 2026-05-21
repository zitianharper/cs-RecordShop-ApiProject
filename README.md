Overview

RecordShop is a full-stack ASP.NET Core and Blazor web application for managing and displaying music album records.

Features:
Display albums from backend API
Component-based UI architecture
Loading indicators
Error handling
JSON API communication
Strong separation of concerns
Running the Application

Prerequisites:
.NET 8 SDK
Visual Studio 2022 or VS Code

The project consists of:

A backend REST API built with ASP.NET Core
A frontend Blazor Web App built with .NET 8
A simple JSON-based data store
Reusable Blazor components for displaying album data

The application demonstrates:
REST API development
Layered architecture
Blazor component composition
HTTP communication between frontend and backend
JSON serialization/deserialization
Asynchronous programming with async/await
Basic error handling and loading states

Technologies Used:
.NET 8
ASP.NET Core Web API
Blazor Web App
Razor Components
C#
JSON
HttpClient

This project is still in production. In the future, this project aims to add these features:
CSS styling and responsive layout
Album search/filtering
Album detail pages
Create/Edit/Delete UI
Database integration with Entity Framework
Authentication and user accounts
Shopping basket functionality
Dependency injection for HttpClient
Shared model library between frontend and backend


Some challenges encountered during development included:
API route mismatches
Incorrect component naming
Namespace/component resolution issues
Blazor component parameter binding
Distinguishing loading vs error states
Running frontend and backend simultaneously

Recommended Visual Studio Setup

Use Multiple Startup Projects:

Right-click solution
Select Set Startup Projects
Choose Multiple startup projects
Start:
RecordShop
RecordShop.Web
