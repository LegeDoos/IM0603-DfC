using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models
{
    internal class Item : SlideshowComposite
    {
        public override void AddPart(SlideshowComponent child)
        {
            // only add text, figure or list here

            if (child is Text || child is Figure || child is List)
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
