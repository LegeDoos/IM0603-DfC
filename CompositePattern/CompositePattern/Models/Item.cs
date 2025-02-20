using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models
{
    internal class Item : SlideshowComposite
    {
        public override void AddPart()
        {
            // todo only add text, figure or list here

            base.AddPart();
        }

        public override void Show()
        {
            // todo show children
        }
    }
}
