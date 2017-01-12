/*
 * CS553 Program assignment 2
 *
 * 11/13/07 - Richard L. Watson
 *
 * This class is the server object which registers the
 * servant object for use by the client.  This server is
 * a singleton because it represents communication with a
 * single/physical robot.
 */
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
            Console.WriteLine("Server is starting execution");

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
            Console.WriteLine("Hit enter to terminate");
            Console.ReadLine();

            // Unregister the channel
            ChannelServices.UnregisterChannel(tcpChannel);            
        }
    }
}
