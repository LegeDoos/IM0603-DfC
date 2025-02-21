using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models
{
    internal class Text : SlideshowLeaf
    {
        public string TheText { private get; set; } = string.Empty;

        public override void Show()
        {
            Console.WriteLine(TheText);
        }
    }
}
