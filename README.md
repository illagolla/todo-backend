# Backend - TODO Application

Welcome to the README for the backend of fantastic TODO list application. This backend is developed using Entity Framework with SQLite as the SQLite database.

## Quick Setup Guide

Follow these steps to quickly set up and run the backend:

1. Begin by cloning this repository to your local machine.

2. Once cloned, navigate to the 'backend' directory.

3. Install all required packages by executing the following command:
```bash
dotnet restore
```
4. Run the migrations to create the necessary database schema:
```bash
Update-Database
```
5. Now, it's time to start the backend server. Simply run the following command:
```bash
dotnet run
```

## API Endpoints

This backend offers the following API endpoints for seamless interaction with the TODO list:

### Get All tasks
```http
  GET /api/item
```
### Get Single task
```http
  GET /api/item/${id}
```
### Add New task
```http
  POST /api/item
```
### Update task
```http
  PUT /api/item/${id}
```
### Delete task
```http
  PUT /api/item/${id}
```

Feel free to explore and utilize these endpoints to manage your TODO list efficiently!