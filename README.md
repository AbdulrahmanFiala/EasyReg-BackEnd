# EasyReg-BackEnd

## Description

EasyReg is a simple registration form with CRUD functionality for inserting and editing data in the database. It includes form validation and a responsive interface. Additionally, there's a web page to display retrieved data from the database.

## Features

- Registration form with the following fields:
  - Name
  - Email
  - Phone
  - Age
- CRUD functionality:
  - Create: Insert new data into the database via the form.
  - Read: Retrieve and display data from the database.
  - Update: Edit existing data in the database.
  - Delete: Remove data from the database.
- Form validation to ensure data integrity.
- Responsive interface for seamless user experience across devices.

## Installation

### Prerequisites
- .NET Core SDK installed
- Maven build tool installed
- SQL Server Express installed and running

### Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/AbdulrahmanFiala/EasyReg-BackEnd.git

2. Navigate to the project directory:
   ```bash
   cd "EasyReg-BackEnd"

3. Open and execute the buedb.sql to create the database filled with tables and dummy-data.

4. Restore Dependencies:
   ```bash
   dotnet restore

5. Build the Project:
   ```bash
   dotnet build

6. Run the Project:
   ```bash
   dotnet run

## Usage
Once the application is running, you can access it in your web browser at:
[https://localhost:7242](https://localhost:7242)

For the frontend of the application, you can refer to the [EasyReg-FrontEnd](https://github.com/AbdulrahmanFiala/EasyReg-FrontEnd) repository.

 
