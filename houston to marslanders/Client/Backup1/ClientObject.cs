/*
 * CS553 Program assignment 2
 *
 * 11/13/07 - Richard L. Watson
 *
 * This class is the client object which collects robot
 * commands to execute via the console and then relays
 * these commands to the server using .NET remoting.
 */
using System;
using Servant;

namespace Client
{
    class ClientObject
    {
        static void Main(string[] args)
        {
            // Get a proxy to the remote well known object.
            // This uses the TCP protocol, on the local machine,
            // via port 8123, using the object/URI "ServantObjectURI".
            object remoteObject = Activator.GetObject(
                typeof(Servant.ServantObject),
                "tcp://localhost:8123/ServantObjectURI");

            // Downcast/narrow the object returned
            ServantObject robot = (ServantObject) remoteObject;

            // Define local variables which effect the robot
            int myPower = 50;                     // Start power off at medium
            const int myLeftVelocity = 50;        // Make the velocities all 
            const int myRightVelocity = 50;       // medium and keep them that
            const int myRotateVelocity = 50;      // way

            // Transient local variables
            string command;         // The command we are executing
            long distance;          // The distance the robot is to move
            int iRotate;            // The angle the robot is to rotate

            // Catch any exceptions which occur when we try to drive the robot
            try
            {
                // Enter a loop to process robot commands until the user
                // indicates that they are done
                do
                {
                    Console.Write("Enter command in lowercase: ");
                    command = Console.ReadLine();
                    Console.WriteLine();

                    // Branch based on the type of command being executed
                    switch (command)
                    {
                        case "open":
                            robot.doOpen();
                            break;
                        case "connect":
                            robot.doConnect();
                            break;
                        case "power":
                            Console.Write("Enter new power value: ");
                            myPower = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            break;
                        case "df":
                            robot.doDrive(100, myLeftVelocity, 
                                myRightVelocity, myPower);
                            break;
                        case "db":
                            robot.doDrive(-100, myLeftVelocity, 
                                myRightVelocity, myPower);
                            break;
                        case "drivef":
                            Console.Write("Enter distance: ");
                            distance = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            robot.doDrive(distance, myLeftVelocity, 
                                myRightVelocity, myPower);
                            break;
                        case "driveb":
                            Console.Write("Enter distance: ");
                            distance = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            robot.doDrive(-distance, myLeftVelocity, 
                                myRightVelocity, myPower);
                            break;
                        case "r":
                            Console.Write("Enter direction, 0=clockwise," +
                                " 1=anticlockwise: ");
                            iRotate = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            robot.doRotate(25, myRotateVelocity, 
                                myPower, iRotate);
                            break;
                        case "rotate":
                            Console.Write("Enter direction, 0=clockwise," +
                                " 1=anticlockwise: ");
                            iRotate = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\nEnter number of degrees: ");
                            long degrees = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            robot.doRotate(degrees, myRotateVelocity, 
                                myPower, iRotate);
                            break;
                        case "stop":
                            robot.doStop();
                            break;
                        case "close":
                            robot.doClose();
                            break;
                        case "status":
                            robot.doM3GetStatus();
                            break;
                        case "sensors":
                            robot.docheckSensors();
                            break;
                        default:
                            Console.WriteLine("Unknown command." +
                                "Robot commands are:\n" +
                                "\tdone, open, connect, power\n" +
                                "\tdf, drivef, db, driveb\n" + 
                                "\tr, rotate, stop, close, status, sensors");
                            break;
                    } // switch
                }
                while (command != "done");
            }
            // If we catch an exception then inform the user of this
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught while trying to" +
                    " communicate with robot");
                Console.WriteLine("Exception message is: **{0}**", ex.Message);
                Console.WriteLine("Has the server been run first?");

                // Wait for the user such that we know the error 
                // message was read
                Console.WriteLine("Hit enter to terminate");
                Console.ReadLine();
            } // catch
        } // Main
    } // ClientObject
} // Client
