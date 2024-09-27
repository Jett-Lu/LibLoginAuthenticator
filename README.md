Login Authentication Service
Overview

This Visual C# .NET solution provides a robust login authentication service, comprising a class library and two application components: a console application and a Windows Forms application. The system allows users to authenticate with a predefined set of credentials.
Components
1. LibLoginAuthenticator

    A class library project that contains the LoginAuthenticator class.
    Features:
        Public property Username: Gets/Sets the username for authentication.
        Private property Password: Sets the password for authentication.
        Constructor initializes both properties to null.
        Method Authenticate: Returns a nullable bool (bool?):
            Returns null if either Username or Password is null.
            Compares the provided credentials against three hardcoded username/password pairs (including "john" as the username and "doe" as the password).
            Returns true if a match is found; otherwise returns false.

2. Console Application

    Prompts users to enter their username and password.
    Passes input to an instance of LoginAuthenticator.
    If input is empty, passes null instead.
    Calls Authenticate method and handles responses:
        Displays error messages for missing fields or failed authentication.
        Confirms successful authentication and allows the user to exit.
    Loops back to prompt for username and password again upon failure.

3. Windows Forms Application

    Provides a user-friendly graphical interface for authentication.
    Key Features:
        Proper naming conventions for projects, forms, and controls.
        Shortcut keys for Username (ALT+U) and Password (ALT+P).
        The Login button is set as the form's AcceptButton.
        Instances of LoginAuthenticator are created as private class fields.
        Input from text boxes is assigned to Username and Password properties, assigning null for empty inputs.
        Calls Authenticate method upon button click and displays appropriate message boxes based on the result.

How to Run

Clone the repository:
git clone <repository-url>

Open the solution in Visual Studio.
Build the solution to restore dependencies.
Run either the console application or the Windows Forms application to start the authentication process.
