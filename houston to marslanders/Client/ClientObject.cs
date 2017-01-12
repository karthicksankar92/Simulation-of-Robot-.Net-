/*
 * This is the program of Houston Client which will command the Robot to navigate
 */
using System;
using Servant;

namespace Client
{
    class ClientObject
    {
        static void Main(string[] args)
        {
             // Initializing remote object and connected via port 8123
            object remoteObject = Activator.GetObject(
                typeof(Servant.ServantObject),
                "tcp://localhost:8123/ServantObjectURI");//tcp protocol

            // Downcast/narrow the object returned
            ServantObject robot = (ServantObject) remoteObject;

            // Define local variables which effect the robot
                               
            const int myLeftVelocity = 50;         
            const int myRightVelocity = 50;       
                 

            // Transient local variables
            string command;         
            long b;          // The distance the robot is to move
                        

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

                 
                    switch (command)
                    {
                        case "open":
                            robot.doOpen();
                            break;
                        case "connect":
                            robot.doConnect();
                            break;
                        case "driveforward":
                            Console.Write("Enter distance(in miles): ");
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            robot.doDrive(b, myLeftVelocity, 
                                myRightVelocity);
                             break;
                        case "drivebackward":
                            Console.Write("Enter distance(in miles): ");
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            robot.doDrive(-b, myLeftVelocity, 
                                myRightVelocity);
                            break;
                        case "stop":
                            robot.doStop();
                            break;
                        case "close":
                            robot.doClose();
                            break;
                        case "distancestatus":
                            string s=robot.distancestatus();
                            Console.WriteLine("\nDistance Status(in miles):{0}",s);
                            break;
                        case "tempstatus":
                            string v=robot.status();
                            Console.WriteLine("\nstatus:{0}",v);
                            break;
                        default:
                            Console.WriteLine("Unknown command." +
                                "Robot commands are:\n" +
                                "\tdone, open, connect"  +
                                "\t, driveforward,  drivebackward\n" + 
                                "\t,distancestatus , stop, close, tempstatus, ");
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
