using CompositePattern.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Models
{
    internal abstract class SlideshowComponent
    {
        public SlideshowComponent? Parent { get; set; }
        protected List<SlideshowComponent>? children;

        public abstract void Show();

        public virtual void AddPart(SlideshowComponent child)
        {
            if (this is SlideshowLeaf)
            {
                throw new InvalidItemException();
            }

            child.Parent = this;
            children ??= [];
            children.Add(child);
        }
    }
}
