using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Models
{
    /// <summary>
    /// Dit is de enumerator die daadwerkelijk over de collectie kan itereren
    /// </summary>
    internal class MyEnumerator : IEnumerator
    {
        private readonly string[] items;
        private int position = -1;

        public MyEnumerator(string[] items)
        {
            this.items = items;
        }

        public object Current
        {
            get
            {
                try
                {
                    return items[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < items.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
