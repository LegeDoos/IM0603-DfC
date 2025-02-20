using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DelegationExample.Models
{
    internal class Fly : ICanMove
    {
        public void Move()
        {
            Console.WriteLine("Flying");
        }
    }
}
