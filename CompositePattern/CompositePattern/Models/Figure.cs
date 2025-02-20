using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models
{
    internal class Figure : SlideshowLeaf
    {
        public string Reference { private get; set; } = string.Empty;

        public override void Show()
        {
            Console.WriteLine($"Reference of this figure: {Reference}");
        }
    }
}
