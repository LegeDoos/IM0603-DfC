using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models
{
    internal class Slide : SlideshowComposite
    {
        public override void AddPart()
        {
            // todo only add items or lists here

            base.AddPart();
        }

        public override void Show()
        {
            // todo show children
        }
    }
}
