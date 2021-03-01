![Welcome to Pierre's Bakery](img/pierres-bakery.png)

# _Pierre's Bakery_

#### _A console application that allows a user to place an order for bread and/or pastries_

#### By _**Chloe Loveall**_
<br>

![license](https://img.shields.io/github/license/chloeloveall/PierresBakery.Solution?color=blue&style=flat-square) &nbsp; ![top project language](https://img.shields.io/github/languages/top/chloeloveall/PierresBakery.Solution?style=flat-square) &nbsp; ![last github commit](https://img.shields.io/github/last-commit/chloeloveall/PierresBakery.Solution?style=flat-square) &nbsp; ![github pull requests](https://img.shields.io/github/issues-pr/chloeloveall/PierresBakery.Solution?style=flat-square) &nbsp; ![open issues](https://img.shields.io/github/issues-raw/chloeloveall/PierresBakery.Solution?style=flat-square) &nbsp; ![github contributors](https://img.shields.io/github/contributors/chloeloveall/PierresBakery.Solution?color=brightgreen&style=flat-square)

## Table of Contents

1. [Table of Contents](#table-of-contents)
2. [Description](#description)
4. [Technologies Used](#technologies-used)
5. [Setup and Installation Requirements](#setup-and-installation-requirements)
    * [Prior to Installation](#prior-to-installation)
    * [Installation](#installation)
    * [Unit Testing with MSTest](#unit-testing-with-ms-test)
6. [Specifications](#specifications)
7. [Known Bugs](#known-bugs)
8. [Contributing](#contributing)
9. [License](#license)
10. [Acknowledgements](#acknowledgements)
11. [Contact Information](#contact-information)

## Description

A basic console application for the first week of the Epicodus C# and .NET program. When the program is run, the user receives a welcome message, a menu with prices, and a prompt to begin their order with a bread quantity input. Next, the user receives a subtotal and a prompt to add a pastry quantity. The user then receives a grand total, a thank you message, and some ASCII art!

## Technologies Used

* C#
* MSTest
* .NET

## Setup and Installation Requirements

### Prior to Installation

* Confirm you have installed .NET installed - this will provide access to the C# language
  * [.NET for macOS](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.100-macos-x64-installer)
  * [.NET for Windows](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.102-windows-x64-installer)
* Additionally, you may want to install a REPL to allow you to practice, test, and experiment with C#. Below are instructions for the ```dotnet script``` REPL:
  * Install ```dotnet script``` by running the following terminal command: ```$ dotnet tool install -g dotnet-script```
  * **NOTE:** If you just installed .NET 5, restart the terminal. (Otherwise, you will not be able to run the following command.) 
    * Enter ```$ dotnet script``` in your terminal and a prompt will open: ```>```
    * To exit the REPL press: Ctrl +C

### Installation
* Clone the repository with the following git terminal command: ```$ git clone https://github.com/chloeloveall/PierresBakery.Solution.git```
* Open the project directory in your terminal
* Navigate to the ```PierresBakery.Tests``` directory
    * To create ```obj``` directories in both production and test projects, run the terminal command: ```$ dotnet restore```
    * **NOTE**: Do not touch the code in either ```obj``` directory.

### Unit Testing with MSTest
* Navigate to the ```PierresBakery.Tests``` directory
* Run the terminal command: ```$ $ dotnet test```
* If everything is set up correctly, you will see something similar to this: 
![MSTest Screenshot](img/mstest-screenshot.png)

## Specifications

| Behavior                                                         | Input  | Output  |
| ---------------------------------------------------------------- | :----- | :------ |
| User will receive a welcome message when they run the program             | user runs the program | Welcome to Pierre's Bakery! |
| User will receive a message with the cost of Bread                        | user runs the program | Bread: Buy 2, get 1 free. A single loaf costs $5. |
| User will receive a message with the cost of Pastry                       | user runs the program  | Pastry: Buy 1 for $2 or 3 for $5. |
| User receives an order prompt for Bread                                   | user runs the program  | How many loaves of bread would you like? |
| Program will add cost of bread to order price total                       | 1                      | $5
| User receives an order prompt for Pastry                                  | user bread order input | How many pastries would you like to add to your order? |
| Program will add pastries to order price total                            | 1                      | $2 |
| Program will start order over if invalid input is received                | Q                      | "This is not a valid input! Now you have to start over!" / Program starts again from Main() |

## Known Bugs

* None at this time

## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are greatly appreciated.

1. Fork the project on GirHub
    * Follow [Installation/Setup Instructions](#setup-&-installation-requirements) above
2. Create your Feature Branch: ```$ git checkout -b YourFeatureBranchName```
3. Commit your Changes ```$ git commit -m 'Add some Amazing Feature'```
4. Push to your feature branch on Github ```$ git push origin YourFeatureBranchName```
5. Open a Pull Request

## License

[MIT](LICENSE.md)

## Acknowledgements

* [Shields](https://shields.io/)
* [Choose an open source license](https://choosealicense.com/)
* [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [Patorjk.com ASCII Art Generator](https://www.patorjk.com/software/taag/#p=display&f=Graffiti&t=Type%20Something%20)

## Contact Information

_Chloe Loveall <chloeloveall@protonmail.com>_

![github followers](https://img.shields.io/github/followers/chloeloveall?style=social) &nbsp; ![github forks](https://img.shields.io/github/forks/chloeloveall/PierresBakery.Solution?label=Forks&style=social) &nbsp; ![github stars](https://img.shields.io/github/stars/chloeloveall/PierresBakery.Solution?style=social)

[Back to Top](#table-of-contents)