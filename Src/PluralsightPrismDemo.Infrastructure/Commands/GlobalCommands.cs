using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PluralsightPrismDemo.Infrastructure.Commands
{
    public static  class GlobalCommands
    {

        public static CompositeCommand SaveAllCommand = new CompositeCommand();
    }
}
