# Visual Basic .NET Sales Management Application

## Description

This is a Visual Basic .NET application designed for managing clients, products, and sales. The application interacts with a SQL database and provides functionalities for:

- Adding, deleting, and modifying client, product, and sales records
- Searching for records using various filters
- Generating reports based on sales data

## Features

- **Client Management**: Add, modify, and delete client records.
- **Product Management**: Add, modify, and delete product records.
- **Sales Management**: Record sales transactions, update sale items, and manage total sales.
- **Search Filters**: Search records using various criteria such as client ID and product ID.
- **Reports**: Generate and view sales reports.

## Requirements

- **.NET Framework**: This application requires .NET Framework version 4.7.2 or higher.
- **Database**: SQL Server or any compatible SQL database.

## Installation

1. **Clone the Repository**

   ```bash
   git clone https://github.com/yourusername/your-repository.git
   cd your-repository
   ```
2. Open the Project

    Open the solution file (.sln) in Visual Studio.
## Configure the Application
1. Add the App.config File

Add the App.config file to the ClientProduct directory. The App.config file should contain the connection string for your SQL database. Here is a sample configuration:

```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup>
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
    </startup>
    <connectionStrings>
        <add name="MyConnectionString"
             connectionString="Server=localhost;Uid=sa;Pwd=sasa;MultipleActiveResultSets=True;Timeout=120;Database=pruebademo;" />
    </connectionStrings>
</configuration>
```
Replace the connectionString attribute with your database connection details.


## Build and Run the Application

### Build the Solution

1. Open the project in Visual Studio.
2. Build the solution by selecting `Build > Build Solution` from the menu.

### Run the Application

1. Start the application by selecting `Debug > Start Debugging` or pressing `F5`.
2. The application will launch, allowing you to manage clients, products, and sales.

## Usage

- **Add New Sales**: Use the 'New Sale' button to create and add new sales records.
- **Update Sales**: Modify existing sales by selecting a record and using the 'Update Sale' button.
- **Delete Sales**: Remove sales records using the 'Delete Sale' button.
- **Search Records**: Utilize the search boxes to filter and find specific records.
- **Generate Reports**: Access report generation features to view sales summaries and details.

## Contributing

If you wish to contribute to this project, please fork the repository and submit a pull request with your changes. Make sure to include appropriate tests and documentation for your contributions.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.

   
