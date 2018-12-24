using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PluralsightPrismDemo.Infrastructure.Events
{
    public class PersonUpdatedEvent : CompositePresentationEvent<string>
    {
    }
}
