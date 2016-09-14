/* SeedForm.cs
 * Author: Rod Howell
 * Modified by: Ying Chen
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
    /// A form to retrieve a seed for the random number generator.
    /// </summary>
    public partial class SeedForm : Form
    {
        /// <summary>
        /// Constructs the form.
        /// </summary>
        public SeedForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets the seed.
        /// </summary>
        public int Seed
        {
            get
            {
                return (int)uxSeed.Value;
            }
        }
    }
}
