using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationExample.Models
{
    public abstract class Animal : ICanMove
    {
        public abstract void Move();
    }
}
