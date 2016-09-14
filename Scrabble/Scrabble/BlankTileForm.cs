/* BlankTileForm.cs
 * Author: Rod Howell
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.Scrabble
{
    /// <summary>
    /// A dialog to retrieve the desired letter for a blank tile.
    /// </summary>
    public partial class BlankTileForm : Form
    {
        /// <summary>
        /// Constructs the dialog.
        /// </summary>
        public BlankTileForm()
        {
            InitializeComponent();
            uxLetters.SelectedIndex = 0;
        }

        /// <summary>
        /// Gets the letter selected.
        /// </summary>
        public char Letter
        {
            get
            {
                return uxLetters.SelectedItem.ToString()[0];
            }
        }
    }
}
