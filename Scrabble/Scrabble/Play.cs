/* Play.cs
 * Author: Rod Howell
 * Modified by: Ying Chen
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.ScrabbleLibrary
{
    /// <summary>
    /// A representation of a play of a tile on a Scrabble board.
    /// </summary>
    public struct Play
    {
        /// <summary>
        /// The letter played.
        /// </summary>
        private char _letter;

        /// <summary>
        /// Gets the letter played.
        /// </summary>
        public char Letter
        {
            get
            {
                return _letter;
            }
        }

        /// <summary>
        /// The row of the play.
        /// </summary>
        private int _row;

        /// <summary>
        /// Gets the row of the play.
        /// </summary>
        public int Row
        {
            get
            {
                return _row;
            }
        }

        /// <summary>
        /// The column of the play.
        /// </summary>
        private int _column;

        /// <summary>
        /// Gets the column of the play.
        /// </summary>
        public int Column
        {
            get
            {
                return _column;
            }
        }

        /// <summary>
        /// Indicates whether the play is a blank tile.
        /// </summary>
        private bool _isBlank;

        /// <summary>
        /// Gets whether the play is a blank tile.
        /// </summary>
        public bool IsBlank
        {
            get
            {
                return _isBlank;
            }
        }

        /// <summary>
        /// Construcst a play from the given information.
        /// </summary>
        /// <param name="letter">The letter played.</param>
        /// <param name="row">The row of the play.</param>
        /// <param name="col">The column of the play.</param>
        /// <param name="isBlank">Indicates whether the play is a blank tile.</param>
        public Play(char letter, int row, int col, bool isBlank)
        {
            _letter = letter;
            _row = row;
            _column = col;
            _isBlank = isBlank;
        }
    }
}
