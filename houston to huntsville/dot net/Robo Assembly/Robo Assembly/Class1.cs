
using System;
using System.Text;


namespace Robo
{
    public class Robo : MarshalByRefObject  
                                            
    {
        public void Temp(long temp,string sta)
        {
            Console.WriteLine("\n\n----------CURRENT STATUS OF THE CLIENT-MARSLANDER----------");

            ///<SUMMARY> DISPALYS THE CURRENT STATUS OF ROBOT.
            
            Console.WriteLine("\n\n TEMPERATURE VALUE IS "+ temp);
            Console.WriteLine("\n\n ROBOT TEMPERATURE STATUS " + sta);
        }

        public void Press(long press,string sta1)
        {
            Console.WriteLine("\n\n PRESSURE VALUE IS " + press);
            Console.WriteLine("\n\n ROBOT PRESSURE STATUS " + sta1);
        }
        public void dist(long distance)
        {
            Console.WriteLine("\n\n DISANCE FROM STARTING POINT " + distance);
        }
        public void big(long bigrock,string sta2)
        {
            Console.WriteLine("\n\n DISTANCE TO BIGROCK " + bigrock);
            Console.WriteLine("\n"+sta2);
        }

        public void deep(long deepsand,string sta3)
        {
            Console.WriteLine("\n\n DISTANCE TO BOWL OF DEEP SAND " + deepsand);
            Console.WriteLine("\n"+sta3);
        }
        public void mi(long mi,string sta4)
        {
            Console.WriteLine("\n\n DISTANCE TO INTERESTING MARS OBJECT " + mi);
            Console.WriteLine("\n"+sta4);
        }
        
    }
}

