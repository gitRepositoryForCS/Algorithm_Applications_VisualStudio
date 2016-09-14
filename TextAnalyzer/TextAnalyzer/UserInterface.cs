/* UserInterface.cs
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
using System.Text.RegularExpressions;
using KansasStateUniversity.TreeViewer2;
using Ksu.Cis300.Sort;


namespace Ksu.Cis300.TextAnalyzer
{
    /// <summary>
    /// A GUI for a text analyzer program.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the event when "Text 1" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButton1_Click(object sender, EventArgs e)
        {
            if(uxOpenFile1.ShowDialog() == DialogResult.OK)
            {
                uxFile1.Text = uxOpenFile1.FileName;
            }
            if (uxFile1.Text != "" && uxFile2.Text != "")
            {
                uxAnalyze.Enabled = true;
            }
            else
            {
                uxAnalyze.Enabled = false;
            }
           
        }

        /// <summary>
        /// Handles the event when "Text 2" button is clicked.
        /// </summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButton2_Click(object sender, EventArgs e)
        {
            if (uxOpenFile2.ShowDialog() == DialogResult.OK)
            {
                uxFile2.Text = uxOpenFile2.FileName;
            }
            if (uxFile1.Text != "" && uxFile2.Text != "")
            {
                uxAnalyze.Enabled = true;
            }
            else
            {
                uxAnalyze.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the event when "Analyze Texts" button is clicked.
        /// </summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAnalyze_Click(object sender, EventArgs e)
        {
            Dictionary<string, WordOccurrence> dic = new Dictionary<string,WordOccurrence>();
            MinPriorityQueue<float, StoreFrequency> mpq = new MinPriorityQueue<float,StoreFrequency>();
          try
          {
              using (StreamReader sr1 = new StreamReader(uxFile1.Text))
              {
                  using (StreamReader sr2 = new StreamReader(uxFile2.Text))
                  {
                      dic = ProcessFile(sr1, dic, 1);
                      dic = ProcessFile(sr2, dic, 2);
                  }
              }
              int t1 = GetTotalNumber(dic, 1);
              int t2 = GetTotalNumber(dic, 2);
              mpq = GetHighestCombinedFrequencies(mpq, dic, t1, t2);
              float diff = CpmputDifferenceMeasure(mpq);
              MessageBox.Show("The difference measure is " + diff);

          }
            catch(Exception ex)
          {
              MessageBox.Show("This exception occurs: " + ex.ToString());
          }
        }

        /// <summary>
        /// Process a file, save it into a given dictionary, and return the dictionary.
        /// </summary>
        /// <param name="sr1">the StreamRead used to read the file</param>
        /// <param name="dic1">the dictionary to save the file.</param>
        /// <returns>the resulting dictionary.</returns>
        private Dictionary<string, WordOccurrence> ProcessFile(StreamReader sr1, Dictionary<string, WordOccurrence> dic, int file)
        {
            string pattern = "[^abcdefghijklmnopqrstuvwxyz]+";
            while (!sr1.EndOfStream)
            {
                string s1 = sr1.ReadLine().ToLower();
                string[] result1 = Regex.Split(s1, pattern);
                for (int i = 0; i < result1.Length; i++)
                {
                    if (result1[i] != "")
                    {
                        int[] f = new int[2];
                        WordOccurrence v1;
                        if (!dic.TryGetValue(result1[i], out v1))
                        {
                            v1 = new WordOccurrence(result1[i], f);
                            dic.Add(result1[i], v1);
                            dic[result1[i]].Increase(file, 1); 
                        }
                        else
                        {
                            dic[result1[i]].Increase(file, 1);
                        }
                    }
                }
            }
            return dic;
           
        }

        /// <summary>
        /// Gets the total number of words in a file from a given dictionary.
        /// </summary>
        /// <param name="dic">the given dictionary to look for</param>
        /// <param name="file">the file to look for</param>
        /// <returns>the total number of words.</returns>
        private int GetTotalNumber(Dictionary<string, WordOccurrence> dic, int file)
        {
            int total = 0;
            foreach(string k in dic.Keys)
            {
                total += dic[k][file - 1] ;
            }
            return total;
        }

        /// <summary>
        /// Gets the Highest 50 (if less than 50, then use them all.) combined frequencies from a given dictionary, save them into a given min-priority queue.
        /// </summary>
        /// <param name="mpq">the given min-priority queue to save the hightest combined frequencies.</param>
        /// <param name="dic">the given dictionary to look for.</param>
        /// <param name="t1">the total number of words in file 1.</param>
        /// <param name="t2">the total number of words in file 2.</param>
        /// <returns></returns>
        private MinPriorityQueue<float, StoreFrequency> GetHighestCombinedFrequencies(MinPriorityQueue<float, StoreFrequency> mpq, Dictionary<string, WordOccurrence> dic, int t1, int t2)
        {
           int[] number = {t1,t2};
           foreach(WordOccurrence v in dic.Values)
           {
               StoreFrequency s = new StoreFrequency(v, number);
               mpq.Add(s, s[0] + s[1]);
               if(mpq.Count > 50)
               {
                   mpq.RemoveMinimumPriority();
               }  
           }
           return mpq;
        }

        /// <summary>
        /// Computes the difference measure from a given min-priority queue.
        /// </summary>
        /// <param name="mpq">the given min-priority queue.</param>
        /// <returns>the difference measure.</returns>
        private float CpmputDifferenceMeasure(MinPriorityQueue<float, StoreFrequency> mpq)
        {
            float sum = 0;
            if (mpq.Count <= 50)
            {
                while (mpq.Count > 0)
                {
                    StoreFrequency min = mpq.RemoveMinimumPriority();
                    sum += (min[0] - min[1]) * (min[0] - min[1]);
                }
                return (float)Math.Sqrt(sum) * 100;
            }
            else
            {
                while (mpq.Count > 0)
                {
                    StoreFrequency min = mpq.RemoveMinimumPriority();
                    sum += (min[0] - min[1]) * (min[0] - min[1]);
                }
                return (float)Math.Sqrt(sum) * 100;
            }
           
        }

        private void uxFile2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
