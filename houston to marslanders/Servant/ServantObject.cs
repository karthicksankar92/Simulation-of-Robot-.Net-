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
        long c = 0, d = 0, e = 0, f = 0, temp, press;
        long bigrock = 400, bds = 600, mo = 900;
        Random r = new Random();//Creating Random Variable
        
        public ServantObject()
        {
            // Default constructor
        }
        public void doOpen()
        {
            Console.WriteLine("Robot Opened........");
        }
        public void doConnect()
        {
            Console.WriteLine("Robot Connected......");
        }
       
        public void doDrive(long b, long leftVelocity, 
            long rightVelocity)
        {
            
            Console.WriteLine("Robot Moving.......");
            Console.WriteLine("\tDistance is :{0} miles", b);
            //Distance Calculation
            d = d + b;
            c = bigrock - d;
            e = bds - d;
            f = mo - d;
            if (d == 400)
            {
                Console.WriteLine("Hurray!!!!! I found Big rock");
               
            }
            else if (d == 600)
            {
                Console.WriteLine("Hurray!!!!! I found Bowl Of Deep Sand");
            }
            else if(d==900)
            {
                Console.WriteLine("Hurray!!!!! I found Interesting Mars Object");
            }

            else if (d > 400 && d < 600)
            {
                Console.WriteLine("Robot Passed Big Rock!");
               
            }
            else if (d > 600 && d < 900)
            {
                Console.WriteLine("Robot Passed Big Rock!");
                Console.WriteLine("Robot Passed Bowl Of Big Sand!");
            }
            Console.WriteLine("\tDistance now from starting point :{0} miles", d);
            Console.WriteLine("\tDistance to bigrock :{0} miles", c);
            Console.WriteLine("\tDistance to Bowl Of Deep sand :{0} miles", e);
            Console.WriteLine("\tDistance to Interesting Mars: {0} miles", f);
            Console.WriteLine("\tLeft velocity is :{0}", leftVelocity);
            Console.WriteLine("\tRight velocity is :{0}", rightVelocity);
            
            }
       
        
        public void doStop()
        {
            Console.WriteLine("Server - Robot stopped");
        }
        public void doClose()
        {
            Console.WriteLine("Server - Closed connection to robot");
        }
        public string distancestatus()
        {
            Console.WriteLine(" Sending Status Of Robot....");
            string r = "distance now from starting point:" + d +" miles" +"\n\tDistance to bigrock: " + c + " miles"+"\n\tDistance to Bowl Of Deep sand:"

          + e+" miles"+ "\n\tDistance to Interesting Mars:"+f+" miles";
            return r ;
        }
        public string status()
        {
           
            
            if ( d >=0 && d <= 30 || d>=100 && d<=130 || d>=300 &&d<330 || d>=500 && d<530 || d>=700 && d<=750)
            {
                 temp = r.Next(0, 50);//Random Function
                press = r.Next(150, 500);
                Console.WriteLine("\nCurrent temperature {0}:", temp);
                Console.WriteLine("\nCurrent pressure {0}:", press);
                Console.WriteLine("\nRobot Stopped,is low Temperature ");
                string ret = "Current Temperature:" + temp + "\n Current Pressure:" + press + "\n  Robot Stopped because of low Temperature ";
                 return ret ;
                 
            }
            else if (d > 50 && d <=80 || d >=140 && d <= 170 || d>=420 && d<=450 || d>=360 &&d<370 || d>=620 && d<650 || d>=800 && d<=830)
            {
               temp = r.Next(50, 100);//Random function
               press = r.Next(0, 150);
               Console.WriteLine("\nCurrent temperature {0}:", temp);
                Console.WriteLine("\nCurrent pressure {0}:", press);
                Console.WriteLine("\n pressure is low..\n..starting to evade dust..");
               string ret = "Current Temperature:" + temp + "\n Current Pressure:" + press + "\n pressure is low..\n..starting to evade dust..";
                 return ret;
                 
            }
            else
            {
                
                 temp = r.Next(50, 100);//Random Function
                press = r.Next(150, 500);
                Console.WriteLine("\nCurrent temperature {0}:",temp);
                Console.WriteLine("\nCurrent Pressure {0}:", press);
                Console.WriteLine("\n...Robot good to go..");
                string retur = "\nCurrent Temperature is " + temp + "\nCurrent Pressure is " + press+ "\n Now Robot Good to go....";

                return retur;
                 
            }
            
        }
       
    }
}
