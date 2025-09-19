References:
Step 1: How to use Visual Studio Code instead of Visual Studio (e.g., by installing C# and the C# Dev Kit in Visual Studio Code) : https://youtu.be/ZVGutgqBMUM?si=POZ_w76qPnEkbgvI 
Step 2: Build a REST API in .NET 9: https://youtu.be/38GNKtclDdE?si=W3_1ozdNTZeXFWo4 

✅ Project Summary: REST API with SQL Server Integration on macOS
I recently completed a project to build a REST API that performs full CRUD operations, inspired by a YouTube tutorial. While the tutorial used a Windows-based setup, I adapted the workflow to suit my MacBook environment, using Docker and Azure Data Studio.

🧰 My Development Stack
Code Editor: Visual Studio Code (VS Code)
Database: SQL Server running inside a Docker container
Database Management Tool: Azure Data Studio
Operating System: macOS

🔄 Differences from the Tutorial
The original tutorial used:
Visual Studio (Windows)
SQL Server 2022 Express Edition
SQL Server Management Studio (SSMS)
In contrast, I used:
VS Code instead of Visual Studio
SQL Server in Docker instead of Express Edition
Azure Data Studio instead of SSMS

📁 What I’ve Completed
Built a REST API with full CRUD functionality
Connected the API to SQL Server via Docker
Verified that all database changes made through the API are reflected in Azure Data Studio
Successfully ran and tested the project on macOS