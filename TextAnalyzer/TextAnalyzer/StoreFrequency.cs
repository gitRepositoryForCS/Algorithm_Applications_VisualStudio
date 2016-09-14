/* StoreFrequency.cs
 * Author: Ying Chen
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TextAnalyzer
{
    /// <summary>
    /// a structure to store the frequencies of a word in different files.
    /// </summary>
    public struct StoreFrequency
    {
        /// <summary>
        /// the word to store.
        /// </summary>
        private string _word;

        /// <summary>
        /// the array to store frequencies of the word in different files.
        /// </summary>
        private float[] _frequency;

        /// <summary>
        /// Constructs a StoreFrequency given a WordOccurrence and array of type int.
        /// </summary>
        /// <param name="w">The given WordOccurence containing the word.</param>
        /// <param name="number">The given array containing the total number of words for different files.</param>
        public StoreFrequency(WordOccurrence w, int[] number)
        {
            _word = w.Word;
            _frequency = new float[w.Files];
           for( int i = 0; i < w.Files; i++)
           {
               _frequency[i] = (float)w[i] / number[i] ;
           }
            
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
        /// an indexer to get the word's frequency given the file's number.
        /// </summary>
        /// <param name="i">the file number.</param>
        /// <returns>the frequency of the word in the file.</returns>
        public float this[int i]
        {
            get
            {
                return (float)_frequency[i];
            }
        }

    }
}
