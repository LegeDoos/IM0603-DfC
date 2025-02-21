using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Models
{
    /// <summary>
    /// Dit is mijn collectie
    /// </summary>
    internal class MyCollection : IEnumerable
    {
        private readonly string[] items;

        public MyCollection(string[] items)
        {
            this.items = items;
        }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(items);
        }
    }
}
