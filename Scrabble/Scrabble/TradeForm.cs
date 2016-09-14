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
    public partial class TradeForm : Form
    {
        public TradeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the characters displayed to those in the given list.
        /// </summary>
        /// <param name="chars">The list of characters to display.</param>
        public void SetCharacters(List<char> chars)
        {
            uxTiles.Items.Clear();
            foreach (char c in chars)
            {
                uxTiles.Items.Add(c);
            }
        }

        /// <summary>
        /// Gets a list of the selected characters.
        /// </summary>
        public List<char> SelectedCharacters
        {
            get
            {
                List<char> list = new List<char>();
                foreach (object x in uxTiles.CheckedItems)
                {
                    list.Add((char)x);
                }
                return list;
            }
        }
    }
}
