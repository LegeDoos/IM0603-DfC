using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models
{
    internal class Slide : SlideshowComposite
    {
        public override void AddPart(SlideshowComponent child)
        {
            // only add items or lists here
            if (child is Item || child is List)
            {
                base.AddPart(child);
            }
            else
            {
                throw new Exception("Invalid child to add!");
            }

        }

        public override void Show()
        {
            // todo show children
        }
    }
}
