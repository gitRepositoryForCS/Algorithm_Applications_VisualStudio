/*Vector.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.MatrixMultiplier
{
    /// <summary>
    /// A
    /// </summary>
    /// <typeparam name="?">int</typeparam>
    public class Vector
    {
        /// <summary>
        /// The list to store all the elements.
        /// </summary>
        private LinkedListCell<KeyValuePair<int, double>> _header = new LinkedListCell<KeyValuePair<int,double>>();

        /// <summary>
        /// Set given numbers in the linked list. 
        /// </summary>
        /// <param name="index">The index of the number.</param>
        /// <param name="value">The value to be stored.</param>
        public void SetValue(int index, double value)
        {
            LinkedListCell<KeyValuePair<int, double>> p = _header;
            while(p.Next != null)
            {
                if(p.Next.Data.Key == index)
                {
                    KeyValuePair<int, double> k = new KeyValuePair<int,double>(index, value);
                    LinkedListCell<KeyValuePair<int, double>> cell = new LinkedListCell<KeyValuePair<int, double>>();
                    cell.Data = k;
                    cell.Next = p.Next.Next;
                    p.Next = cell;
                    return;
                }
                else if (p.Next.Data.Key < index)
                {
                    KeyValuePair<int, double> k = new KeyValuePair<int, double>(index, value);
                    LinkedListCell<KeyValuePair<int, double>> cell = new LinkedListCell<KeyValuePair<int, double>>();
                    cell.Data = k;
                    cell.Next = p.Next;
                    p.Next = cell;
                    return;
                }
                p = p.Next;
            }
            if(p.Next == null)
            {
              KeyValuePair<int, double> r = new KeyValuePair<int, double>(index, value);
              LinkedListCell<KeyValuePair<int, double>> c = new LinkedListCell<KeyValuePair<int, double>>();
              c.Data = r;
              c.Next = p.Next;
              p.Next = c;
            }

        }

        /// <summary>
        /// Dot product of two vectors.
        /// </summary>
        /// <param name="a">The first vector.</param>
        /// <param name="b">The second vector.</param>
        /// <returns></returns>
        public static double DotProduct( Vector a, Vector b)
        {
            double sum = 0;
            if (a == null || b == null)
            {
                return sum;
            }
            else
            {
                LinkedListCell<KeyValuePair<int, double>> c = a._header;
                LinkedListCell<KeyValuePair<int, double>> d = b._header;

                while (c != null && d != null)
                {
                    if (c.Data.Key == d.Data.Key)
                    {
                        sum += c.Data.Value * d.Data.Value;
                        c = c.Next;
                        d = d.Next;
                    }
                    else if (c.Data.Key > d.Data.Key)
                    {
                        c = c.Next;
                    }
                    else
                    {
                        d = d.Next;
                    }
                }
            }
           
            return sum;

        }


    }
}
