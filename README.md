# LibLoginAuthenticator
Visual C# .NET solution that provides a login authentication service. This solution will have a class library component and two application components contained within the same solution.

The LoginAuthenticator Class
Create a class library project named LibLoginAuthenticator that contains a class named LoginAuthenticator. The LoginAuthenticator class must support the following features:
The class defines a public string read/write property named Username which gets/sets the Username for the authenticator.
The class defines a public string property named Password which sets the Password for the authenticator. The get part should be private.
The constructor for the class should set the initial values of Username and Password to null.
The class defines a public method named Authenticate with no parameters which returns a bool? (nullable bool) value.
If either Username or Password is null, the method should return null to indicate that not all fields were provided.
If both Username and Password are not null, then the method should compare the username and password against 3 hardcoded sets of values in the method. Be sure to include one where the username is john and the password is doe (all lowercase). If a hardcoded username/password pair is found, the method returns true. Otherwise the method returns false.
The Console Application
Create a console application that asks the user to enter a username and password. The application will then pass the username and password to an instance of the LoginAuthenticator. If the username or password is empty string, the application must pass null to the authenticator instead (for whichever one is empty string). Note that you can test for empty string by checking for a 0 length or comparing with "" or string.Empty.
The application should then call the LoginAuthenticator object's Authenticate method. If the returned value is null, the application must give a message stating that both username and password are required. If the returned value is false, the application must display a message stating that the authentication has failed. Otherwise the application should state that the authentication was successful and allow the user to press any key to exit. The code should be included inside a loop so that the user is prompted to enter the username and password again if the authentication is unsuccessful.
The Windows Application
Create a Windows Forms application. The form window for the application appears as shown. Use proper names for the project, the form, and the controls and give your form a title. Notice the shortcut keys for Username and Password text boxes. The Login button should be set as the form's AcceptButton (see the form's AcceptButton property). The application must create an instance of the LoginAuthenticator in a private class field of the form.
When the user types in the username text box, the application assigns the text to the LoginAuthenticator object's Username property. If the text box is empty, the application assigns null instead.
When the user types in the password text box, the application assigns the text to the LoginAuthenticator object's Password property. If the text box is empty, the application assigns null instead.
When the user clicks the Login button, the application calls the LoginAuthenticator object's Authenticate method. If the returned value is null, the application shows an ERROR message box stating that the username and password must be provided. If the returned value is false, the application shows a WARNING message box stating that the authentication was not successful and then clears the username and password text boxes and put the focus back in the username text box. Otherwise the application shows an INFORMATION message box stating that the authentication was successful and then closes the form.
The windows application must also adhere to the following requirements:
The Form
The Username label should use ALT+U as the shortcut key for the Username text box.
The Password label should use ALT+P as the shortcut key for the Password text box.
The Password text box should set a password character so that the password is hidden.
When the application is run, the Username text box should initially have the focus.
The text boxes should initially be empty.
Set the form's FormBorderStyle to Fixed3D.
Set the form's MaximizeBox property to False.
When the form is initialized, a single LoginAuthenticator object should be created as a class field (so it can be used from multiple event procedures).
