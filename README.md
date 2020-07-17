# _Bakery_

#### _Console Application for Ordering Baked Goods_

#### By _**James Henager**_

## Description

_This console application is designed to take orders for a bakery. The user will input how many loaves of bread and how many pastries they'd like, the application then tells them their total cost._

### Specifications
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
|Program should create class for Bread |  |  |  
|Program should create class for Pastry  |  |  |  
|Program should create class for Order  |  |  |  
|Program should add a method for calculating price for Bread per x amount of orders | 2 Orders | 10 |  
|Program should add a method for calculating price for Pastry per x amount of orders| 2 Orders | 4 |  
|Program should add method to Bread Class to calculate special deals| 3 Orders | 10 |  
|Program should add method to Pastry Class to calculate special deals| 3 Orders | 5 |  
|Program should add Bread or Pastry to Order when instantiated|  |  |  
|Program should add a total cost property to the Order Class  | Bread Total: 5, Pastry Total: 7 | Order Total: 12 |  


## Setup/Installation Requirements

1. This program utilizes .NET version 3.1, and requires this framework to be pre-installed:
    * Please go to https://dotnet.microsoft.com/download/dotnet-core/3.1 and install the SDK   version 3.1 or greater patch version, but do not upgrade to a higher minor version number.
2. Clone this repository onto your computer: https://github.com/...
3. In your preferred terminal window, navigate into Bakery.Solution/Bakery using cd (i.e. cd desktop/Bakery.Solution/Bakery) and open the project with your preferred code editor.
4. Run the following terminal command: $ dotnet restore
5. To initiate this terminal program, run the command: $ dotnet run
6. To run the test suite included with this project, navigate into Bakery.Tests within the terminal and run the following commands:
    * $ dotnet restore
    * $ dotnet test


## Known Bugs

_There is currently a bug where if a user makes an incorrect input, the value is still saved even when the method restarts._

## Support and contact details

_If you encounter any issues with this application, please contact me at jameschenager@gmail.com_

## Technologies Used

- C#
- .NET

### License

_This software is licensed under the MIT license_

Copyright (c) 2020 **James Henager**.