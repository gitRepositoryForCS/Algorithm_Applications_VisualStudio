/* WordOccurrence.cs
 * Author: Ying Chen*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TextAnalyzer
{
    /// <summary>
    /// A class to save a word and its number of occurence in different files.
    /// </summary>
    public class WordOccurrence
    {
        /// <summary>
        /// store a word. 
        /// </summary>
        private string _word;

        /// <summary>
        /// store the number of occurence for difference files in an array.
        /// </summary>
        private int[] _file;

        /// <summary>
        /// Constructs a WordOccurrence given a word and an array of type int.
        /// </summary>
        /// <param name="word">the word to store</param>
        /// <param name="file">the array contains the number of occurence for different files</param>
        public WordOccurrence(string word, int[] file)
        {
            _word = word;
            _file = new int[file.Length];
            file.CopyTo(_file, 0);
        }

        /// <summary>
        /// Gets the word.
        /// </summary>
        public string Word
        {
            get
            {
                return _word;
            }
        }

        /// <summary>
        /// Gets the number of files.
        /// </summary>
        public int Files
        {
            get
            {
                return _file.Length;
            }
        }

        /// <summary>
        /// an indexer to get the number of occurrences of the word in a specified file.
        /// </summary>
        /// <param name="i">the file to look for</param>
        /// <returns>the number of occurrences of the word.</returns>
        public int this[int i]
        {
            get
            {
                return _file[i];
            }
        }

        /// <summary>
        /// Increases the number of occurrences of the word in the given file.
        /// </summary>
        /// <param name="i">the given file number</param>
        /// <param name="occur">the number to increase for the word.</param>
        public void Increase(int i, int occur)
        {
            _file[i-1] += occur;
        }
    }
}
