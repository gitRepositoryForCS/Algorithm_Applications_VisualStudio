/* Cell.cs
 * Author: Rod Howell
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.MazeSolver
{
    /// <summary>
    /// A representation of a cell in a maze.
    /// </summary>
    public struct Cell
    {
        /// <summary>
        /// The row of the cell.
        /// </summary>
        private int _row;

        /// <summary>
        /// Gets the row of the cell.
        /// </summary>
        public int Row
        {
            get
            {
                return _row;
            }
        }

        /// <summary>
        /// The column of the cell.
        /// </summary>
        private int _column;

        /// <summary>
        /// Gets the column of the cell.
        /// </summary>
        public int Column
        {
            get
            {
                return _column;
            }
        }

        /// <summary>
        /// The hash code.
        /// </summary>
        private int _hashCode;

        /// <summary>
        /// Constructs a cell representing the given row and column.
        /// </summary>
        /// <param name="row">The row of the cell.</param>
        /// <param name="col">The column of the cell.</param>
        public Cell(int row, int col)
        {
            _row = row;
            _column = col;
            unchecked
            {
                // Because there are only two fields, and each is expected to have a small value,
                // we'll use a larger multiplier than usual.
                _hashCode = row * 65533 + col;
            }
        }

        /// <summary>
        /// Determines whether the given cells are equal.
        /// </summary>
        /// <param name="x">One cell.</param>
        /// <param name="y">The other cell.</param>
        /// <returns>Whether the given cells are equal.</returns>
        public static bool operator ==(Cell x, Cell y)
        {
            return x.Row == y.Row && x.Column == y.Column;
        }

        /// <summary>
        /// Determines whether the given cells are different.
        /// </summary>
        /// <param name="x">One cell.</param>
        /// <param name="y">The other cell.</param>
        /// <returns>Wether the given cells are different.</returns>
        public static bool operator !=(Cell x, Cell y)
        {
            return !(x == y);
        }

        /// <summary>
        /// Determines whether this Cell is equal to the given object.
        /// </summary>
        /// <param name="obj">The object to compare to.</param>
        /// <returns>Whether this cell is equal to the given object.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Cell)
            {
                return this == (Cell)obj;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the hash code.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return _hashCode;
        }
    }
}
