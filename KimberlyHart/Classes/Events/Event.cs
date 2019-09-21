using System;
using System.Collections.Generic;
using System.Text;
using CableJumpers.Classes.Hosts;

namespace CableJumpers.Classes.Events
{
    class Event
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public List<Host> HostList { get; set; }


        public Event(string name, int year)
        {

        }
    }
}
