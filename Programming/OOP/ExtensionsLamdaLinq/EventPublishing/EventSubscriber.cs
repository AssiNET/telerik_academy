using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPublishing
{
    class EventSubscriber
    {
        // Constructors
        public EventSubscriber(EventPublisher publisher)
        {
            // handling the event from the publisher
            publisher.RaiseEvent += HandleEvent;
        }
        
        // Method which has been invoked after the event has been handled
        private void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("The event has been handled.");
        }
    }
}
