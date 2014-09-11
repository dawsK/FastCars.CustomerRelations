using System;

namespace FastCars.CustomerRelations
{
    public class Bootstrapper
    {

        public void Start()
        {
            Console.WriteLine("Press Enter to publish an event");
            while (Console.ReadLine() != null)
            {
                Console.WriteLine("Published ClientBecamePreferred event");
            }
        }

        public void Stop()
        {
            
        }
    }
}
