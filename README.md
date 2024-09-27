# Login Authentication Service

**Solution Type**: Visual C# .NET  
**Components**: Class Library and Console Application with Windows Forms  

## Overview

This solution provides a login authentication service built using Visual C# .NET. It contains a class library component (`LibLoginAuthenticator`) that defines a `LoginAuthenticator` class and two application components: a console application and a Windows Forms application.

## Components

### 1. Class Library: LibLoginAuthenticator

The `LoginAuthenticator` class includes the following features:

- **Properties**:
  - `Username`: A public string property for getting and setting the username.
  - `Password`: A public string property for setting the password (the getter is private).

- **Constructor**:
  - Initializes `Username` and `Password` to `null`.

- **Method**:
  - `Authenticate()`: A public method that returns a `bool?` (nullable bool).
    - Returns `null` if either `Username` or `Password` is `null`.
    - Compares the provided credentials against three hardcoded username/password pairs, including "john" as the username and "doe" as the password.
    - Returns `true` if a matching pair is found; otherwise, returns `false`.

### 2. Console Application

The console application prompts the user to enter a username and password. It processes the input as follows:

- If either field is empty, it passes `null` to the `LoginAuthenticator`.
- Calls the `Authenticate()` method:
  - If the result is `null`, displays a message indicating that both fields are required.
  - If the result is `false`, displays an authentication failure message.
  - If successful, displays a success message and allows the user to exit.
  
The application loops until a successful login is achieved.

### 3. Windows Forms Application

The Windows Forms application provides a graphical interface for the login process:

- **Form Elements**:
  - Username and Password text boxes with shortcut keys (`ALT+U` and `ALT+P` respectively).
  - A Login button set as the form's `AcceptButton`.
  - The Password text box hides input characters.

- **Functionality**:
  - Creates an instance of `LoginAuthenticator` as a private class field.
  - Assigns input from the text boxes to the `Username` and `Password` properties of `LoginAuthenticator`.
  - Calls the `Authenticate()` method when the Login button is clicked:
    - Displays appropriate message boxes based on the result (error, warning, or information).
    - Clears the input fields and focuses back on the Username text box if authentication fails.
  
- **Form Properties**:
  - `FormBorderStyle` is set to `Fixed3D`.
  - `MaximizeBox` property is set to `False`.
  - The Username text box has initial focus when the form is loaded.

## Getting Started

### Prerequisites

- Visual Studio or any C# .NET IDE.
- .NET Framework installed on your machine.

### Running the Solution

1. Open the solution in Visual Studio.
2. Build the solution to ensure all components are compiled.
3. Run the Console Application or Windows Forms Application as needed.

## Acknowledgments

This project showcases fundamental concepts in C# such as object-oriented programming, file handling, and user interface design.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
