

using System;
using System.Text;
using Robo;
using System.Runtime.Remoting;

namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {

            long temp, press, distance, bigrock, deepsand, mi;
            string sta = "", sta1 = "", sta2 = "", sta3 = "", sta4 = "";
            //URI of the Server with the application name 

            string servantURL = "TCP://127.0.0.1:8123/Robo";
          
            Type serverType = typeof(Robo.Robo);

            //Register the Client

            RemotingConfiguration.RegisterWellKnownClientType(serverType, servantURL);

            //Proxy instance of the Remote Robo

            Robo.Robo obj = new Robo.Robo();

           
            
            Console.WriteLine("\n\n\n----HOUSTON SENDING THE CURRENT STATUS OF MARSLANDERS TO HUNTSVILLE SERVER----");
            
          

            Console.Write("\n\n<<ENTER THE TEMPERATURE VALUE>>");
            temp = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n<<IS TEMPERATURE LOW?(yes/no): >>");
            string w = Console.ReadLine();
            if (w == "yes")
            {
                Console.Write("\nTemperature is low so the robot is shutting down...");
                 sta = "\nTemperature is low so the robot is shutting down...";     
            }
            else
            {

                Console.Write("\nGood temperature....");
                 sta = "\nGood temperature....."; 
            }

            Console.Write("\n\n<<ENTER THE PRESSURE VALUE>>");

            press = Convert.ToInt32(Console.ReadLine());
          

            Console.Write("\n\n<<IS PRESSURE LOW?(yes/no): >>");
            string x = Console.ReadLine();
            if (x == "yes")
            {
                Console.Write("\nPressure is low so robot starting to evade dust...");
                 sta1 = "\nPressure is low so robot starting to evade dust...";
            }
            else
            {

                Console.Write("\nGood Pressure.....");
                 sta1 = "\nGood Pressure.....";
            }

            Console.Write("\n\n<<ENTER THE DISTANCE FROM STARTING POING>>");

            distance = Convert.ToInt32(Console.ReadLine());
     
            Console.Write("\n\n<<ENTER THE DISTANCE FROM BIG ROCK>>");
            bigrock = Convert.ToInt32(Console.ReadLine());
            if (bigrock == 0)
            {
                sta2 = "Hurray!!!!! Robot found Big rock...";
            }

            Console.Write("\n\n<<ENTER THE DISTANCE FROM BOWL OF DEEP SAND>>");
            deepsand = Convert.ToInt32(Console.ReadLine());
            if (deepsand == 0)
            {
                sta3 = "Hurray!!!!! Robot found deepsand...";
            }
            Console.Write("\n\n<<ENTER THE DISTANCE FROM INTERESTING OBJECT>>");
            mi = Convert.ToInt32(Console.ReadLine());
            if (mi == 0)
            {
                sta4 = "Hurray!!!!! Robot found Interesting Mars Object...";
            }
            obj.Temp(temp,sta);
            obj.Press(press,sta1);
            obj.dist(distance);
            obj.big(bigrock,sta2);
            obj.deep(deepsand,sta3);
            obj.mi(mi,sta4);
            Console.WriteLine("\n \n----CURRENT STATUS OF CLIENT-MARSLANDER HAS BEEN SENT TO THE SERVER-HUNTSVILLE----");


       
            Console.ReadLine();
            Console.Clear();
        }
    }
}











