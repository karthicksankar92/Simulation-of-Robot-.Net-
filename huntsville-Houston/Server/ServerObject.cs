
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Servant;

namespace Server
{
    class ServerObject
    {
        static void Main(string[] args)
        {
            // Inform the user that we are running
           
           Console.WriteLine("\n\n ----------HOUSTON SERVER HAS STARTED---------- \n\n");
            // Create a new TCP channel over which binary communication
            // between client and server will occur.  In this case we
            // use port 8123.
            TcpChannel tcpChannel = new TcpChannel(8123);

            // Register a new TcpChannel.  Note that this API is deprecated
            // in .NET version 3.
            ChannelServices.RegisterChannel(tcpChannel);

            // Register a well known singleton object (the servant)
            // whose name/URI is "ServantObjectURI".
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(Servant.ServantObject),
                "ServantObjectURI",
                WellKnownObjectMode.Singleton);

            // Wait for the user
            Console.WriteLine("\n\n ----------HIT ENTER TO EXIT---------- \n\n");
            Console.ReadLine();

            // Unregister the channel
            ChannelServices.UnregisterChannel(tcpChannel);            
        }
    }
}
