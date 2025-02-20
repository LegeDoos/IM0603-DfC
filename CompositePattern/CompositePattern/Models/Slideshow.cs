using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models
{
    internal class Slideshow : SlideshowComposite
    {
        public override void AddPart()
        {
            // todo only add slides here

            base.AddPart();
        }

        public override void Show()
        {
            // todo show children
        }
    }
}
