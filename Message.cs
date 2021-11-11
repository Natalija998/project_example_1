using System;
using System.Collections.Generic;
using System.Text;

namespace project_example_1
{
    class Message
    {
        public string Poruka { get; private set; }

        public Message(string poruka)
        {
            Poruka = poruka;
        }
    }
}
