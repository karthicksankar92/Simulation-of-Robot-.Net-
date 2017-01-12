Etzkorn NOTE:  uses robot interface but apparently does not call robot DLL

This represents the submission for the second and third projects for CS553 Fall 2007.  The project is implemented using client, server, and servant projects/assemblies using C#.

In order to run the project, the following steps are required:

1) Copy the Project2 directory to your local machine
2) Launch a DOS window and change directory to Project2
3) Execute the Project2.bat file

Project2.bat will do the following:
1) Execute sever which will create a DOS window into which the server will print commands recieved from the client.  The server will register the servant object as a well known singleton object.
2) Pause for input from the keyboard in order to ensure that the server process is running.
3) Execute client which will create a DOS window from which the client will prompt for input which is then sent to the server.  Keyin "?" in order to get a list of valid commands.