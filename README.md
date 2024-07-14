# Sales Forecast Application

This repository contains a .NET WinForms application for sales forecasting and a set of database scripts for creating and inserting data into the database, as well as stored procedures for calculating sales metrics.

## Table of Contents

- [Sales Forecast Application](#sales-forecast-application)
  - [Table of Contents](#table-of-contents)
  - [Project Structure](#project-structure)
  - [Setup Instructions](#setup-instructions)
    - [Database Setup](#database-setup)
    - [WinForms Application Setup](#winforms-application-setup)
  - [Usage](#usage)
  - [Contributing](#contributing)
  - [License](#license)

## Project Structure

The project is organized into the following directories:

- `SalesForecastApp/`: Contains the .NET WinForms application for sales forecasting.
- `DBScripts/`: Contains SQL scripts for creating database tables, inserting data, and stored procedures.

### SalesForecastApp/

This directory contains the source code for the .NET WinForms application. The application provides an interface for users to forecast sales based on historical data.

### DBScripts/

This directory contains the SQL scripts.


## Setup Instructions

### Database Setup

1. Open your SQL Server Management Studio (SSMS) or any other SQL database management tool.
2. Execute the scripts in the following order:
	
   - `CreateDBScript.sql`: Creates the database.
   - `CreateCustomer.sql`: Creates the Customers Table and insert the orders data.
   - `CreateOrders.sql`: Creates the Orders Table and insert the customers data.
   - `CreateProducts.sql`: Creates the Products Table and insert the products data.
   - `CreateOrderProductInfo.sql`: Creates the OrderProductInfo Table and insert the OrderProductInfo data.
   - `CreateOrderReturns.sql`: Creates the OrderReturns Table and insert the OrderReturns data.
   - `Sp_CalculateYearlySalesByState.sql`: Creates the stored procedures for calculating the years sales.
   - `Sp_ApplyCommonSalesIncrementToState.sql`: Creates the stored procedures for applying the increment value to the state sales.

### WinForms Application Setup

1. Open the `SalesForecastApp` directory in Visual Studio.
2. Restore the NuGet packages by right-clicking on the solution in the Solution Explorer and selecting `Restore NuGet Packages`.
3. Build the solution by pressing `Ctrl+Shift+B` or selecting `Build Solution` from the `Build` menu.
4. Run the application by pressing `F5` or selecting `Start Debugging` from the `Debug` menu.

## Usage

1. Launch the Sales Forecast application.
2. Use the interface to input the required parameters for forecasting.
3. View the forecast results and analysis provided by the application.

## Contributing

Contributions are welcome! Please fork this repository and submit a pull request with your changes.

## License

This project is licensed under the MIT License. See the `LICENSE` file for more details.
