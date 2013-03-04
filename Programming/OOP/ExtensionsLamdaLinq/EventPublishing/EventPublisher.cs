using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPublishing
{
    class EventPublisher
    {
        // Declaring event handler which will be executed after 
        // some event (the event handler is a delegate) 
        public event EventHandler RaiseEvent;

        // Method that do some work
        public void DoSomething()
        {
            // and calling the method which raise the event
            OnRaiseEvent(new EventArgs());
        }

        // The actual method which is raising the event
        protected virtual void OnRaiseEvent(EventArgs eventArgs)
        {
            // Temporary event handler to prevent from race condition if a subscriber 
            // unsubscribe between the null check and the actual raising 
            EventHandler eventHandler = RaiseEvent;
            
            // Checking if there is subscribers for the event
            if (eventHandler != null)
            {
                Console.WriteLine("An event has been raised.");
                
                // The actual raising of the event
                RaiseEvent(this, eventArgs);
            }
        }
    }
}
