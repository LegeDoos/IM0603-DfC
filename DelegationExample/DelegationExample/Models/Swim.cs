using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationExample.Models
{
    public class Swim : ICanMove
    {
        public void Move()
        {
            Console.WriteLine("Swimming");
        }
    }
}
