using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPublishing
{
    class EventPublishing
    {
        static void Main(string[] args)
        {
            // Publisher of the event
            EventPublisher publisher = new EventPublisher();

            // Subscribers for the event
            EventSubscriber firstSubscriber = new EventSubscriber(publisher);
            EventSubscriber secondSubcriber = new EventSubscriber(publisher);
            EventSubscriber thirdSubscriber = new EventSubscriber(publisher);
            
            // Publisher do some work and after that the event has been raised
            publisher.DoSomething();
        }
    }
}
