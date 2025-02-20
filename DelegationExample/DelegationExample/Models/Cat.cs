using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationExample.Models
{
    public class Cat : Animal
    {
        private readonly ICanMove moveBehaviour = new Run(); // object creation should not happen here!

        public override void Move()
        {
            moveBehaviour.Move();
        }
    }
}
