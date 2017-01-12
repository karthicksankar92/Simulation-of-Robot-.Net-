

using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace RoboRemoting 
{
    class server
    {
        static void Main(string[] args)
        {

            // CREATING A NEW TCP CHANNEL ON PORT 6099
            
            TcpChannel channel = new TcpChannel(8123);

            //REGISTERING THE CHANNEL FOR COMMUNICATION ORIENTED ON THE PORT 6099
            
            ChannelServices.RegisterChannel(channel, false);

            Console.WriteLine("\n\n ----------HUNTSVILLE SERVER HAS STARTED---------- \n\n");


            //REGISTER THE SERVICE
           
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Robo.Robo), "Robo", WellKnownObjectMode.Singleton);

            //HERE SINGLETON MODE IS USED TO CREATE/ACTIVATE THE OBJECT ONCE AND USE IT IN THE SERVER THROUGHOUT PROCESS.
            
            //HERE "ROBO" WII BE THE URI(NAME) OF THE OBJECT AT THE WEB ADDRESS(URL).


            Console.WriteLine("\n \n -----------PRESS ENTER TO EXIT/TERMINATE FROM THE HUNTSVILLE SERVER-----------\n\n");
            
            Console.ReadLine();
        }

    }
}










