using CompositePattern.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models
{
    internal class List : SlideshowComposite
    {
        public override void AddPart(SlideshowComponent child)
        {
            // only add items here
            if (child is Item)
            {
                base.AddPart(child);
            }
            else
            {
                throw new InvalidItemException();
            }
        }

        public override void Show()
        {
            Console.WriteLine("This is the list level");

            // only show children
            if (children != null)
            {
                foreach (var child in children)
                {
                    child.Show();
                }
            }
        }
    }
}
