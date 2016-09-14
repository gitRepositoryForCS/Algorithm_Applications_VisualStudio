/* LinkedListCell.cs
 * Author: Rod Howell
 * Modified by: Ying Chen
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.Scrabble
{
    /// <summary>
    /// A single cell of a generic linked list.
    /// </summary>
    /// <typeparam name="T">The type of the element stored in the cell.</typeparam>
    public class LinkedListCell<T>
    {
        /// <summary>
        /// The data element stored in this cell.
        /// </summary>
        private T _data;

        /// <summary>
        /// Gets the data element stored in this cell.
        /// </summary>
        public T Data
        {
            get
            {
                return _data;
            }
        }

        /// <summary>
        /// The next cell in the linked list.
        /// </summary>
        private LinkedListCell<T> _next;

        /// <summary>
        /// Gets the next cell in the list.
        /// </summary>
        public LinkedListCell<T> Next
        {
            get
            {
                return _next;
            }
        }

        /// <summary>
        /// Constructs a new LinkedListCell containing the given values.
        /// </summary>
        /// <param name="data">The data stored in the cell.</param>
        /// <param name="next">The next cell in the list.</param>
        public LinkedListCell(T data, LinkedListCell<T> next)
        {
            _data = data;
            _next = next;
        }
    }
}
