/*
 * CS553 Program assignment 2
 *
 * 11/13/07 - Richard L. Watson
 *
 * This class is the servant object which is provided by the server.
 * The class provides the interface to the robot itself via a set
 * of methods.  The methods are currently stubs which simply execute
 * print statements in order to acknowledge that the .NET remoting
 * pathway is functioning properly.
 */
using System;

namespace Servant
{
    public class ServantObject : MarshalByRefObject
    {
        public ServantObject()
        {
            // Default constructor
        }
        public void doOpen()
        {
            Console.WriteLine("Server - Opened robot");
        }
        public void doConnect()
        {
            Console.WriteLine("Server - Connected to robot");
        }
        public void doCalibrate()
        {
            Console.WriteLine("Server - Calibrated robot");
        }
        public void doDrive(long distance, long leftVelocity, 
            long rightVelocity, long power)
        {
            Console.WriteLine("Server - Driving robot");
            Console.WriteLine("\tDistance is {0}", distance);
            Console.WriteLine("\tLeft velocity is {0}", leftVelocity);
            Console.WriteLine("\tRight velocity is {0}", rightVelocity);
            Console.WriteLine("\tPower is {0}", power);
        }
        public void doRotate(long Degrees, long velocity, 
            long power, long direction)
        {
            Console.WriteLine("Server - Rotating robot");
            Console.WriteLine("\tDegrees is {0}", Degrees);
            Console.WriteLine("\tVelocity is {0}", velocity);
            Console.WriteLine("\tPower is {0}",  power);
            Console.WriteLine("\tDirection is {0}", direction);
        }
        public void doStop()
        {
            Console.WriteLine("Server - Robot stopped");
        }
        public void doClose()
        {
            Console.WriteLine("Server - Closed connection to robot");
        }
        public void doResetAxis(long axis)
        {
            Console.WriteLine("Server - Axis reset to {0}", axis);
        }
        public void doM3GetStatus()
        {
            Console.WriteLine("Server - Get robot status");
        }
        public void docheckSensors()
        {
            Console.WriteLine("Server - Check robot sensors");
        }
    }
}
