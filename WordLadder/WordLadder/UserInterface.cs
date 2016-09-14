/*UserInterfac.cs
 * Author: Ying Chen
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
using System.IO;
using Ksu.Cis300.Graphs;

namespace Ksu.Cis300.WordLadder
{
    /// <summary>
    ///  A GUI for a program to find the word ladder from a starting word to a ending word.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// the array of directed graph to store the words with different lengths. 
        /// </summary>
        DirectedGraph<string, decimal>[] _graphs;

        /// <summary>
        /// Constructs the GUI. 
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the event when Open Dictionary is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpenButton_Click(object sender, EventArgs e)
        {
            if(uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ReadWordList(uxOpenDialog.FileName);
                    MessageBox.Show("Dictionary successfully read.");
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Exception occures: " + exc.ToString() );
                }
            }
        }

        /// <summary>
        /// Reads a given file into graph.
        /// </summary>
        /// <param name="fileName">the file to be read.</param>
        private void ReadWordList(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                _graphs = new DirectedGraph<string,decimal>[25];

                for (int i = 1; i < 25; i++ )
                {
                    _graphs[i] = new DirectedGraph<string, decimal>();
                }

                while (!sr.EndOfStream)
                {
                    string word = sr.ReadLine().ToLower();
                    int len = word.Length - 1;
                    List<string> list = new List<string>();
                    
                    if(word == "")
                      {
                          _graphs[0] = new DirectedGraph<string,decimal>();
                      }
                    else
                    {
                        _graphs[len].AddNode(word);

                        foreach (string node in _graphs[word.Length - 1].Nodes)
                        {
                            if (WhetherAddEdge(word, node, word.Length) == 1)
                            {
                                list.Add(node);
                            }
                        }

                        foreach (string node in list)
                        {
                            _graphs[word.Length - 1].AddEdge(word, node, 1);
                            _graphs[word.Length - 1].AddEdge(node, word, 1);
                        }
                    }

                }
            }
 
        }

        /// <summary>
        /// Determin whether an edge would be added or not between two words. If count is 1, edge should be added. otherwise, it shouldn't.
        /// </summary>
        /// <param name="word1">one word</param>            
        /// <param name="word2">the other word</param>
        /// <param name="len">the length of the word.</param>
        /// <returns>the number of positions in which the two words have different characters.</returns>
        private int WhetherAddEdge(string word1, string word2, int len)
        {
            int count = 0;

            if(word1 == word2)
            {
                return count;
            }

            for (int i = 0; i < len; i++ )
            {
                if (word1.Substring(i, 1) != word2.Substring(i, 1))
                {
                    count++;

                    if(count >= 2)
                    {
                        return count;
                    }
                }
            }

            return count; 
        }

        /// <summary>
        /// Handles the event when Find Word Ladder is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxFindWordLadder_Click(object sender, EventArgs e)
        {
            string start = uxStartWord.Text;
            string end = uxEndWord.Text;

            if(start.Length != end.Length)
            {
                uxListBox.Items.Clear();
                MessageBox.Show("No word ladder found.");    
            }
            else if (_graphs == null)
            {
                uxListBox.Items.Clear();
                MessageBox.Show("No word ladder found.");
            }
            else
            {
                if (start == "" && end == "" && _graphs[0] != null)
                {
                    uxListBox.Items.Clear();
                }
                else if (start == "" && end == "" && _graphs[0] == null)
                {
                    uxListBox.Items.Clear();
                    MessageBox.Show("No word ladder found.");
                }
                else if (start.Length - 1 < 1 || end.Length - 1 < 1)
                {
                    uxListBox.Items.Clear();
                    MessageBox.Show("No word ladder found.");
                }
                else
                {
                    Dictionary<string, string> dic = FindWordLadder(start, end);

                    if (dic.Count == 0)
                    {
                        uxListBox.Items.Clear();
                        MessageBox.Show("No word ladder found.");
                    }
                    else
                    {
                        AddPathToListbox(start, end, dic);
                    }
                }

                
            }
           
            
        }

        /// <summary>
        /// Finds the word ladder from the starting word to the ending word.
        /// </summary>
        /// <param name="start">the starting word</param>
        /// <param name="end">the ending word</param>
        /// <returns>the dictionary that saves the word ladder.</returns>
        private Dictionary<string, string> FindWordLadder(string start, string end)
        {
          
            Dictionary<string, string> dic = new Dictionary<string, string>();

            if (_graphs[start.Length - 1].ContainsNode(start) && _graphs[start.Length - 1].ContainsNode(end))
            {
                if (start == end)
                {
                    dic.Add(start, start);
                    return dic;
                }

                Queue<Tuple<string, string>> q = new Queue<Tuple<string, string>>();
           
                dic.Add(start, start);

                    foreach (Tuple<string, decimal> edge in _graphs[start.Length - 1].OutgoingEdges(start))
                    {
                        q.Enqueue(new Tuple<string, string>(start, edge.Item1));
                    }

                    while (q.Count > 0)
                    {
                        Tuple<string, string> edge = q.Dequeue();
                        if (!dic.ContainsKey(edge.Item2))
                        {
                            dic.Add(edge.Item2, edge.Item1);

                            if (edge.Item2 == end)
                            {
                                return dic;
                            }

                            foreach (Tuple<string, decimal> outgoing in _graphs[start.Length - 1].OutgoingEdges(edge.Item2))
                            {
                                q.Enqueue(new Tuple<string, string>(edge.Item2, outgoing.Item1));
                            }
                        }
                    }

                    return new Dictionary<string, string>();
            }
            else
            {
                return dic;
            }

        }

        /// <summary>
        /// Adds all the words in the dictionary to the listbox.
        /// </summary>
        /// <param name="start">the starting word</param>
        /// <param name="end">the ending word</param>
        /// <param name="dic">the given dictionary</param>
        private void AddPathToListbox(string start, string end, Dictionary<string, string> dic)
        {
            Stack<string> path = new Stack<string>();

            while (end != start)
            {
                path.Push(end);
                end = dic[end];
            }

            uxListBox.BeginUpdate();
            uxListBox.Items.Clear();
            uxListBox.Items.Add(start);

            while (path.Count > 0)
            {
                uxListBox.Items.Add(path.Pop());
            }

            uxListBox.EndUpdate();
        }
      
    }
}
