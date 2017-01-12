/*
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
            Console.WriteLine("Giving command to Mars Lander to open........");
        }
        public void doConnect()
        {
            Console.WriteLine("Giving command to Mars Lander to connect...");
            Console.WriteLine("Houston trying to connect.......");
        }
        
        public void doDrive(long b, long leftVelocity, 
            long rightVelocity )
        {   
           Console.WriteLine("Giving Command to Mars  Lander to Move {0}:",b);
            }
        
        public void doStop()
        {
            Console.WriteLine("Giving Command to Marslander to Stop..");
        }
        public void doClose()
        {
            Console.WriteLine("Giving Command to Marslander to close connection....");
        }
       
        public void status()
        {
            Console.WriteLine("\nRequesting distance status to Marslander....");
               
        }
        public void docheckstatus()
        {
            Console.WriteLine("Requesting Marslander to send Temperature and Pressure status....");
            
        }
    }
}
