/* UserInterface.cs
 * Author: Rod Howell
 * Modified by: Ying Chen
 */
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ksu.Cis300.TextEditor
{
    /// <summary>
    /// A GUI for a simple text editor.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// The most recent text seen.
        /// </summary>
        private string _lastText = "";

        /// <summary>
        /// LinkedListCell of kill ring is used to maintain a history of all of the strings from Kill and Copy as Kill.
        /// </summary>
        private LinkedListCell<string> _killRing = null;
            //new LinkedListCell<string>();

        /// <summary>
        /// The location of the beginning of the text inserted by the last yank.
        /// </summary>
        private int _textLocation = 0 ;

        /// <summary>
        /// The length of the text inserted by the last yank.
        /// </summary>
        private int _textLength = 0;

        /// <summary>
        /// Indicates the location for YankPrevious. 
        /// </summary>
        private LinkedListCell<string> _lastYankLocation = new LinkedListCell<string>();

        /// <summary>
        /// Indicates if the change due to Kill/Yank or normal user operation (ctrl+c, ctrl+v,ctrl+x,backspace,delete...). 
        /// _killtextchanged variable is to indicate the text change event due to kill operation.
        /// </summary>
        /// <param name="s">true if caused by Kill/Yank, false if by others.</param>
        /// 
        private bool _killtextchanged;

        /// <summary>
        /// _yanktextchanged variable is to indicate the text change event due to yank operation.
        /// </summary>
        private bool _yanktextchanged;
        /// <summary>
        /// _yanktextchanged_remove variable is to indicate the text change event due to Remove in yank operation.
        /// </summary>
        private bool _yanktextchanged_remove = false;
        /// <summary>
        /// _yanktextchanged_remove_insert variable is to tell if the event is due to Insert in yank operation.
        /// </summary>
        private bool _yanktextchanged_remove_insert = false;
        /// <summary>
        ///  _yanktextchanged_remove variable is to indicate the text change event due to Insert in yank operation.
        /// </summary>
        private bool _yanktextchanged_insert = false;
        /// <summary>
        ///  _yankprevioustextchanged variable is to indicate the text change event due to yankprevious operation.
        /// </summary>
        private bool _yankprevioustextchanged = false;
        /// <summary>
        /// _yankprevioustextchanged_remove variable is to indicate the text change event due to Remove in yank operation.
        /// </summary>
        private bool _yankprevioustextchanged_remove = false;
        /// <summary>
        /// _yankprevioustextchanged_remove_insert variable is to tell if the event is due to Insert in yank operation.
        /// </summary>
        private bool _yankprevioustextchanged_remove_insert = false;
        /// <summary>
        /// _yankprevioustextchanged_insert variable is to indicate the text change event due to Insert in yank operation.
        /// </summary>
        private bool _yankprevioustextchanged_insert = false;

        /// <summary>
        /// Push a given string on top of the kill ring.
        /// </summary>
        /// <param name="s">The string to be pushed.</param>
        public void PushStringToKillRingTop(string s)
        {
            LinkedListCell<string> cell = new LinkedListCell<string>();
            cell.Data = s;
            cell.Next = _killRing;
            _killRing = cell;
            _lastYankLocation = _killRing;
        }

        /// <summary>
        /// Retrieve the string at the top of the kill ring. Throw an InvalidOperationException if the kill ring is empty. 
        /// </summary>
        /// <returns>The string at the top.</returns>
        public string RetrieveStringFromKillRingTop()
        {
            if(_killRing == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                _lastYankLocation = _killRing;
                return _killRing.Data;
            }
        }


        /// <summary>
        /// The edits that have not been undone.  Each edit is described by 3 elements in the
        /// stack: a bool indicating whether the edit is a deletion, an int giving the beginning
        /// of the edit, and a string giving the inserted/deleted text.
        /// </summary>
        private Stack _editingHistory = new Stack();

        /// <summary>
        /// The edits that can be redone.  Each edit is described as above.
        /// </summary>
        private Stack _undoHistory = new Stack();

        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles a Click event on the "Open . . ." menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = uxOpenDialog.FileName;
                    uxDisplay.Text = File.ReadAllText(fileName);
                    _lastText = uxDisplay.Text;
                    _editingHistory.Clear();
                    _undoHistory.Clear();
                    uxUndo.Enabled = false;
                    uxRedo.Enabled = false;
                    uxYankPrevious.Enabled = false;
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }

        /// <summary>
        /// Handles a Click event on the "Save As . . ." menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSaveAs_Click(object sender, EventArgs e)
        {
            if (uxSaveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = uxSaveDialog.FileName;
                    File.WriteAllText(fileName, uxDisplay.Text);
                }
                catch (Exception ex)
                {
                    ShowError(ex);
                }
            }
        }

        /// <summary>
        /// Displays the given exception in a dialog.
        /// </summary>
        /// <param name="e"></param>
        private void ShowError(Exception e)
        {
            MessageBox.Show("The following error occurred: " + e.ToString());
        }

        /// <summary>
        /// Rotates the given character c n positions through the alphabet whose first
        /// letter is firstLetter and whose number of letters is alphabetLen. alphabetLen
        /// must be positive.
        /// </summary>
        /// <param name="c">The character to rotate.</param>
        /// <param name="n">The number of positions to rotate c.</param>
        /// <param name="firstLetter">The first letter of the alphabet.</param>
        /// <param name="alphabetLen">The number of letters in the alphabet.</param>
        /// <returns>The result of the rotation.</returns>
        private char Rotate(char c, int n, char firstLetter, int alphabetLen)
        {
            return (char)(firstLetter + (c - firstLetter + n) % alphabetLen);
        }

        /// <summary>
        /// Encrypts the given character.
        /// </summary>
        /// <param name="c">The character to encrypt.</param>
        /// <returns>The encrypted character.</returns>
        private char Encrypt(char c)
        {
            if (c >= 'a' && c <= 'z')
            {
                return Rotate(c, 13, 'a', 26);
            }
            else if (c >= 'A' && c <= 'Z')
            {
                return Rotate(c, 13, 'A', 26);
            }
            else
            {
                return c;
            }
        }

        /// <summary>
        /// Handles a Click event on the "With String" menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEncryptWithString_Click(object sender, EventArgs e)
        {
            string text = uxDisplay.Text;
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                result += Encrypt(text[i]);
            }
            uxDisplay.Text = result;
            uxYankPrevious.Enabled = false;
        }

        /// <summary>
        /// Handles a Click event on the "With StringBuilder" menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEncryptWithStringBuilder_Click(object sender, EventArgs e)
        {
            string text = uxDisplay.Text;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                result.Append(Encrypt(text[i]));
            }
            uxDisplay.Text = result.ToString();
            uxYankPrevious.Enabled = false;
        }

        /// <summary>
        /// Handles a TextChanged event on uxDisplay.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxDisplay_TextChanged(object sender, EventArgs e)
        {
          //  MessageBox.Show(Convert.ToString(uxDisplay.SelectionStart));
                string currentText = uxDisplay.Text;
                bool isDeletion = currentText.Length < _lastText.Length;
                int loc = 0;
                string edit = " ";
                if (uxDisplay.Modified || _killtextchanged || _yankprevioustextchanged || _yanktextchanged)
                {
                    if (uxDisplay.Modified)
                    {
                        if (isDeletion)
                        {
                            loc = uxDisplay.SelectionStart;
                            int len = _lastText.Length - currentText.Length;
                            edit = _lastText.Substring(loc, len);
                        }
                        else
                        {
                            int len = currentText.Length - _lastText.Length;
                            loc = uxDisplay.SelectionStart - len;
                            edit = currentText.Substring(loc, len);
                        }
                        uxYankPrevious.Enabled = false;
                    }
                    if (_killtextchanged)
                    {
                        //_killtextchanged = false;
                        loc = _textLocation;
                        int len = _lastText.Length - currentText.Length;
                        edit = _lastText.Substring(loc, len);
                        // _lastText = currentText;
                        uxYankPrevious.Enabled = true;
                    }
                    if (_yanktextchanged)
                    {
                        //_yanktextchanged = false;
                        if (_yanktextchanged_remove)
                        {
                            if (!_yanktextchanged_remove_insert)
                            {
                                int len = _lastText.Length - currentText.Length;
                                loc = _textLocation; //+ uxDisplay.SelectionStart - len;
                                edit = _lastText.Substring(loc, len);
                            }
                            else 
                            {
                                int len = currentText.Length - _lastText.Length;
                                loc = _textLocation; //+ uxDisplay.SelectionStart - len;
                                edit = currentText.Substring(loc, len);
                            }
                        }
                        if (_yanktextchanged_insert)
                        {
                            int len = currentText.Length - _lastText.Length;
                            loc = _textLocation; //+ uxDisplay.SelectionStart - len;
                            edit = currentText.Substring(loc, len);
                        }
                        uxYankPrevious.Enabled = true;
                    }
                    if (_yankprevioustextchanged)
                    {
                        if (_yankprevioustextchanged_remove)
                        {
                            if (!_yankprevioustextchanged_remove_insert)
                            {
                                int len = _lastText.Length - currentText.Length;
                                loc = _textLocation; //+ uxDisplay.SelectionStart - len;
                                edit = _lastText.Substring(loc, len);
                            }
                            else
                            {
                                int len = currentText.Length - _lastText.Length;
                                loc = _textLocation; //+ uxDisplay.SelectionStart - len;
                                edit = currentText.Substring(loc, len);
                            }
                        }
                        uxYankPrevious.Enabled = true;
                    }

                    _editingHistory.Push(isDeletion);
                    _editingHistory.Push(loc);
                    _editingHistory.Push(edit);
                    _lastText = currentText;
                    uxUndo.Enabled = true;
                    _undoHistory.Clear();
                    uxRedo.Enabled = false;
                    
                }
        }

        /// <summary>
        /// Inserts the given string into uxDisplay at the given location.
        /// </summary>
        /// <param name="loc">The index at which s is to be inserted.</param>
        /// <param name="s">The string to insert.</param>
        private void Insert(int loc, string s)
        {
            uxDisplay.Text = uxDisplay.Text.Insert(loc, s);
            uxDisplay.SelectionStart = loc + s.Length;
        }

        /// <summary>
        /// Deletes from uxDisplay the string with the given length starting
        /// at the given location.
        /// </summary>
        /// <param name="loc">The location at which the deleiton should 
        /// begin.</param>
        /// <param name="len">The length of the string to delete.</param>
        private void Delete(int loc, int len)
        {
            uxDisplay.Text = uxDisplay.Text.Remove(loc, len);
            uxDisplay.SelectionStart = loc;
        }

        /// <summary>
        /// Handles a Click event on the Undo menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxUndo_Click(object sender, EventArgs e)
        {
            string edit = (string)_editingHistory.Pop();
            int loc = (int)_editingHistory.Pop();
            bool isDeletion = (bool)_editingHistory.Pop();
            _undoHistory.Push(isDeletion);
            _undoHistory.Push(loc);
            _undoHistory.Push(edit);
            uxRedo.Enabled = true;
            if (isDeletion)
            {
                Insert(loc, edit);
            }
            else
            {
                Delete(loc, edit.Length);
            }
            uxUndo.Enabled = _editingHistory.Count > 0;
            _lastText = uxDisplay.Text;
            uxYankPrevious.Enabled = false;
        }

        /// <summary>
        /// Handles a Click event on the Redo menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxRedo_Click(object sender, EventArgs e)
        {
            string edit = (string)_undoHistory.Pop();
            int loc = (int)_undoHistory.Pop();
            bool isDeletion = (bool)_undoHistory.Pop();
            _editingHistory.Push(isDeletion);
            _editingHistory.Push(loc);
            _editingHistory.Push(edit);
            uxRedo.Enabled = _undoHistory.Count > 0;
            if (isDeletion)
            {
                Delete(loc, edit.Length);
            }
            else
            {
                Insert(loc, edit);
            }
            uxUndo.Enabled = true;
            _lastText = uxDisplay.Text;
            uxYankPrevious.Enabled = false;
        }

        /// <summary>
        /// Handles a click event on the Kill menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxKill_Click(object sender, EventArgs e)
        {
            if(uxDisplay.SelectionLength != 0)
            {
                _killtextchanged = true;

                string currentText = uxDisplay.Text;
                PushStringToKillRingTop(uxDisplay.SelectedText);
                _textLength = uxDisplay.SelectionLength;
                _textLocation = uxDisplay.SelectionStart;
                Delete(_textLocation, _textLength);
                uxYank.Enabled = true;
                uxYankPrevious.Enabled = false;
                _killtextchanged = false;
            }
        }

        /// <summary>
        ///  Handles a click event on the Copy as Kill menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCopyAsKill_Click(object sender, EventArgs e)
        {
            if (uxDisplay.SelectionLength != 0)
            {
                string currentText = uxDisplay.Text;
                PushStringToKillRingTop(uxDisplay.SelectedText);
                uxYank.Enabled = true;
                uxYankPrevious.Enabled = false;
            }
        }

        /// <summary>
        ///  Handles a click event on the Yank menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxYank_Click(object sender, EventArgs e)
        {
            _yanktextchanged = true;
            _textLocation = uxDisplay.SelectionStart;
            _textLength = RetrieveStringFromKillRingTop().Length;

            if (uxDisplay.SelectionLength != 0)
            {
                _yanktextchanged_remove = true;             //To tell the text event is due to Remove operation.
                Delete(uxDisplay.SelectionStart, uxDisplay.SelectionLength);
                _yanktextchanged_remove_insert = true;      //To tell the text event is due to Insert operation.
                Insert(uxDisplay.SelectionStart, RetrieveStringFromKillRingTop());
                _yanktextchanged_remove = false;
                _yanktextchanged_remove_insert = false;
            }
            else
            {
                _yanktextchanged_insert = true;
                Insert(uxDisplay.SelectionStart, RetrieveStringFromKillRingTop());
                _yanktextchanged_insert = false;
            }
            uxDisplay.Select(_textLocation, _textLength);
            uxYankPrevious.Enabled = true;
            _yanktextchanged = false;
        }

        /// <summary>
        ///  Handles a click event on the Yank Previous menu item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxYankPrevious_Click(object sender, EventArgs e)
        {
            _yankprevioustextchanged = true;

            if (_lastYankLocation.Next != null)
            {
                _yankprevioustextchanged_remove = true;
                Delete(_textLocation, _textLength);

                _yankprevioustextchanged_remove_insert = true;

                _textLength = _lastYankLocation.Next.Data.Length;
                Insert(_textLocation, _lastYankLocation.Next.Data);

                _lastYankLocation = _lastYankLocation.Next;
                _yankprevioustextchanged_remove = false;
                _yankprevioustextchanged_remove_insert = false;
            }
            else
            {
                _yankprevioustextchanged_remove = true;
                _lastYankLocation = _killRing;
                Delete(_textLocation, _textLength);
                _yankprevioustextchanged_remove_insert = true;
                _textLength = _lastYankLocation.Data.Length;
                Insert(_textLocation, _lastYankLocation.Data);
                _yankprevioustextchanged_remove = false;
                _yankprevioustextchanged_remove_insert = false;
            }
            uxDisplay.Select(_textLocation, _textLength);
            _yankprevioustextchanged = false;
        }


    }
}
