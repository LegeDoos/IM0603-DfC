using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Models
{
    /// <summary>
    /// Interface of the implementation of the list
    /// </summary>
    public interface iRobList<T>
    {
        /// <summary>
        /// insert an object on a given position
        /// </summary>
        /// <param name="pos">the position, counting starts at 0</param>
        /// <param name="obj">the object to add</param>
        public void Insert(int pos, T obj);

        /// <summary>
        /// Remove the object on position pos
        /// </summary>
        /// <param name="pos">the position, counting starts at 0</param>
        public void Remove(int pos);

        /// <summary>
        /// Return the element at position pos
        /// </summary>
        /// <param name="pos">the position, counting starts at 0</param>
        /// <returns>The object on pos</returns>
        public T? ElementAtPos(int pos);

        /// <summary>
        /// The number of elements
        /// </summary>
        /// <returns></returns>
        public int Size();
    }
}
