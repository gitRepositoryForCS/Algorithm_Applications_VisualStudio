/* UserInterface.cs
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
using Ksu.Cis300.ScrabbleLibrary;

namespace Ksu.Cis300.Scrabble
{
    public partial class UserInterface : Form
    {
        /// <summary>
        /// The width and height of each tile in pixels.
        /// </summary>
        private const int _tileSize = 32;

        /// <summary>
        /// The font to use for the tiles.
        /// </summary>
        private Font _tileFont = new Font(FontFamily.GenericSansSerif, 14);

        /// <summary>
        /// The cells on the board.
        /// </summary>
        private Button[,] _cells = new Button[15, 15];

        /// <summary>
        /// The letter tiles of the current player.
        /// </summary>
        private Button[] _letters = new Button[7];

        /// <summary>
        /// The controller for the current game.
        /// </summary>
        private GameController _controller;

        /// <summary>
        /// The currently selected button from the tray of tiles.
        /// </summary>
        private Button _selectedTrayButton = null;

        /// <summary>
        /// The background color for an unselected tile.
        /// </summary>
        private Color _normalTileBackground = Color.Wheat;

        /// <summary>
        /// The background color for a selected tile.
        /// </summary>
        private Color _selectedTileBackground = Color.Yellow;

        /// <summary>
        /// The background color for a tile played in the current play.
        /// </summary>
        private Color _playedTileBackground = Color.LightYellow;

        /// <summary>
        /// The background color for an empty tray button
        /// </summary>
        private Color _emptyTrayButton = Color.LightGray;

        /// <summary>
        /// The foreground color to use for blanks on the board.
        /// </summary>
        private Color _blankForeground = Color.Gray;

        /// <summary>
        /// The normal foreground color for tiles.
        /// </summary>
        private Color _normalForeground = Color.Black;

        /// <summary>
        /// The dialog used to retrieve a seed from the user.
        /// </summary>
        private SeedForm uxSeedDialog = new SeedForm();

        /// <summary>
        /// The dialog used to retrieve the letter to use for a blank tile.
        /// </summary>
        private BlankTileForm uxBlankTileDialog = new BlankTileForm();

        /// <summary>
        /// The dialog used to determine which letters to trade.
        /// </summary>
        private TradeForm uxTradeDialog = new TradeForm();

        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
            for (int i = 0; i < GameController.BoardSize; i++)
            {
                for (int j = 0; j < GameController.BoardSize; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(_tileSize, _tileSize);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = _tileFont;
                    _cells[i, j] = btn;
                    uxBoardPanel.Controls.Add(btn);
                    btn.Click += new EventHandler(BoardButton_Click);
                }
            }
            for (int i = 0; i < _letters.Length; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(_tileSize, _tileSize);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Font = _tileFont;
                uxTrayPanel.Controls.Add(btn);
                btn.Click += new EventHandler(TrayButton_Click);
                _letters[i] = btn;
            }
        }

        /// <summary>
        /// Sets the tray buttons to the tiles of the current player, and updates the tiles remaining.
        /// </summary>
        private void SetTrayButtons()
        {
           // List<char> tiles = _controller.GetCurrentPlayerTiles();
            List<char> tiles = _controller.GetPlayerTiles(0);
            for (int i = 0; i < tiles.Count; i++)
            {
                SetTrayButton(_letters[i], tiles[i].ToString());
            }
            for (int i = tiles.Count; i < _letters.Length; i++)
            {
                SetTrayButton(_letters[i], "");
            }
            int rem = _controller.TilesRemaining;
            uxRemaining.Text = rem.ToString();
            uxTrade.Enabled = _controller.PendingCells.Count == 0 && _controller.TilesRemaining > 0;
        }

        /// <summary>
        /// Sets the value modification for the given button to the given value.
        /// </summary>
        /// <param name="btn">The button whose value modification is to be set.</param>
        /// <param name="value">The value modification.</param>
        private void SetValueModification(Button btn, CellValue value)
        {
            switch (value)
            {
                case CellValue.Normal:
                    btn.BackColor = Color.White;
                    break;
                case CellValue.DoubleLetter:
                    btn.BackColor = Color.LightBlue;
                    break;
                case CellValue.DoubleWord:
                    btn.BackColor = Color.Pink;
                    break;
                case CellValue.TripleLetter:
                    btn.BackColor = Color.LightGreen;
                    break;
                case CellValue.TripleWord:
                    btn.BackColor = Color.Salmon;
                    break;
            }
            if (value != CellValue.Normal)
            {
                uxToolTips.SetToolTip(btn, value.ToString());
            }
        }

        /// <summary>
        /// Verifies that the application was successfully initialized - if not, the application exits.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserInterface_Load(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fn = uxOpenDialog.FileName;
                    if (uxSeedDialog.ShowDialog() == DialogResult.OK)
                    {
                        _controller = new GameController(fn, uxSeedDialog.Seed);
                    }
                    else
                    {
                        _controller = new GameController(fn);
                    }
                    NewGame();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("No dictionary loaded - the application will exit.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Starts a new game.
        /// </summary>
        private void NewGame()
        {
            _controller.StartGame();
            for (int i = 0; i < GameController.BoardSize; i++)
            {
                for (int j = 0; j < GameController.BoardSize; j++)
                {
                    SetBoardButton(i, j, "", false);
                }
            }
            SetTrayButtons();
            uxPlayerALabel.Enabled = true;
            uxScoreA.Enabled = true;
            uxScoreA.Text = "0";
            uxPlayerBLabel.Enabled = false;
            uxScoreB.Enabled = false;
            uxScoreB.Text = "0";
            uxTrade.Enabled = true;
        }

        /// <summary>
        /// Handles a Click event on the Check Value button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCheck_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(_controller.EvaluatePlay() + " points.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles a Click event on one of the buttons in the tray of tiles.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e"></param>
        private void TrayButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == _selectedTrayButton)
            {
                _selectedTrayButton.BackColor = _normalTileBackground;
                _selectedTrayButton = null;
            }
            else
            {
                if (_selectedTrayButton != null)
                {
                    _selectedTrayButton.BackColor = _normalTileBackground;
                }
                btn.BackColor = _selectedTileBackground;
                _selectedTrayButton = btn;
            }
        }

        /// <summary>
        /// Handles a Click event on a board button.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e"></param>
        private void BoardButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Cell loc = GetBoardLocation(btn);
            Color fg = _normalForeground;
            if (_selectedTrayButton != null)
            {
                char letter = _selectedTrayButton.Text[0];
                int value;
                bool isBlank = false;
                if (letter == ' ')
                {
                    isBlank = true;
                    if (uxBlankTileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    letter = uxBlankTileDialog.Letter;
                    value = 0;
                    fg = _blankForeground;
                }
                else
                {
                    value = GameController.GetValue(letter);
                }
                try
                {
                    _controller.AddTile(letter, loc, isBlank);
                    SetBoardButton(loc.Row, loc.Column, letter.ToString(), isBlank);
                    SetTrayButton(_selectedTrayButton, "");
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Invalid Play", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (btn.BackColor == _playedTileBackground)
            {
                _controller.RemoveTile(loc);
                for (int i = 0; i < _letters.Length; i++)
                {
                    if (!_letters[i].Enabled)
                    {
                        if (btn.ForeColor == _normalForeground)
                        {
                            SetTrayButton(_letters[i], btn.Text);
                        }
                        else
                        {
                            SetTrayButton(_letters[i], " ");
                        }
                        break;
                    }
                }
                SetBoardButton(loc.Row, loc.Column, "", false);
            }
            uxTrade.Enabled = _controller.PendingCells.Count == 0 && _controller.TilesRemaining > 0;
        }

        /// <summary>
        /// Sets the given tray button to the given text, and sets the background color, enabled, and
        /// tool tip accordingly.
        /// </summary>
        /// <param name="btn">The button to set.</param>
        /// <param name="text">The text for the button to display.</param>
        private void SetTrayButton(Button btn, string text)
        {
            btn.Text = text;
            _selectedTrayButton = null;
            if (text == "")
            {
                btn.BackColor = _emptyTrayButton;
                btn.Enabled = false;
                uxToolTips.SetToolTip(btn, "");
            }
            else
            {
                btn.BackColor = _normalTileBackground;
                btn.Enabled = true;
                uxToolTips.SetToolTip(btn, GameController.GetValue(text[0]).ToString());
            }
        }

        /// <summary>
        /// Sets the appearance of the button at the given board location.
        /// </summary>
        /// <param name="row">The row of the button.</param>
        /// <param name="col">The column of the button.</param>
        /// <param name="text">The text to be shown.</param>
        /// <param name="isBlank">Indicates whether this button represents a blank tile.</param>
        private void SetBoardButton(int row, int col, string text, bool isBlank)
        {
            Button btn = _cells[row, col];
            btn.Text = text;
            if (text == "")
            {
                SetValueModification(btn, GameController.GetValueModification(new Cell(row, col)));
            }
            else if (isBlank)
            {
                btn.BackColor = _playedTileBackground;
                btn.ForeColor = _blankForeground;
                uxToolTips.SetToolTip(btn, "0");
            }
            else
            {
                btn.BackColor = _playedTileBackground;
                btn.ForeColor = _normalForeground;
                uxToolTips.SetToolTip(btn, GameController.GetValue(text[0]).ToString());
            }
        }

        /// <summary>
        /// Finds the location of the given button.
        /// </summary>
        /// <param name="btn">The button to find.</param>
        /// <returns>The location of btn.</returns>
        private Cell GetBoardLocation(Button btn)
        {
            // This isn't very efficient, but it doesn't need to be.
            for (int i = 0; i < GameController.BoardSize; i++)
            {
                for (int j = 0; j < GameController.BoardSize; j++)
                {
                    if (btn == _cells[i, j])
                    {
                        return new Cell(i, j);
                    }
                }
            }
            throw new ArgumentException("The given button is not on the board.");
        }

        /// <summary>
        /// Handles a Click event on the Play button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPlay_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cell> pending = _controller.PendingCells;
                int score = _controller.Play();
                EndTurn(score + " points.", pending);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Play", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Handles a Click event on the "Trade Tiles" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxTrade_Click(object sender, EventArgs e)
        {
            uxTradeDialog.SetCharacters(_controller.GetCurrentPlayerTiles());
            if (uxTradeDialog.ShowDialog() == DialogResult.OK)
            {
                List<char> tiles = uxTradeDialog.SelectedCharacters;
                try
                {
                    _controller.Trade(tiles);
                    EndTurn(tiles.Count + " tiles traded.", new List<Cell>());
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Invalid Trade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Ends the current turn, displaying the given message.
        /// </summary>
        /// <param name="msg">The message to display.</param>
        /// <param name="pending">The cells on which tiles were placed on this turn.</param>
        private void EndTurn(string msg, List<Cell> pending)
        {
            // Blank out the tray tiles.
           /* for (int i = 0; i < _letters.Length; i++)
            {
                SetTrayButton(_letters[i], "");
            }
            */
            Update();

            // Update the score.
            uxScoreA.Text = _controller.GetScore(0).ToString();
            uxScoreB.Text = _controller.GetScore(1).ToString();

            // Show the message.
            MessageBox.Show(msg, "Play made", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LinkedListCell<Play> bestPlay = GetBestPlay();
            while(bestPlay != null)
            {

                _controller.AddTile(bestPlay.Data.Letter, new Cell(bestPlay.Data.Row, bestPlay.Data.Column), bestPlay.Data.IsBlank);
                SetBoardButton(bestPlay.Data.Row, bestPlay.Data.Column, bestPlay.Data.Letter.ToString(), bestPlay.Data.IsBlank);
                bestPlay = bestPlay.Next;

            }

            pending = _controller.PendingCells;
            SwitchPlayers(pending);
            int score = _controller.Play();
            msg = score.ToString();

           

            // Check to see if the game is over.
            if (!CheckEndGame())
            {
                // Update the GUI to reflect that it's the other player's turn.
                SwitchPlayers(pending);
            }
        }

        /// <summary>
        /// Checks to see if the game is over, and if so, either sets up a new one or exits as the user chooses.
        /// <returns>Whether the game is over.</returns>
        /// </summary>
        private bool CheckEndGame()
        {
            if (_controller.GameOver)
            {
                if (MessageBox.Show("Game over.\n\nScore Adjustments:\n    " + uxPlayerALabel.Text + " " + _controller.EndGameScoreAdjustments[0] +
                    "\n    " + uxPlayerBLabel.Text + " " + _controller.EndGameScoreAdjustments[1] + "\n\nPlay again?", "Game Over", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    NewGame();
                }
                else
                {
                    Application.Exit();
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Updates the GUI to change the player whose turn it is.
        /// </summary>
        /// <param name="pending">The cells whose background color needs to be changed.</param>
        private void SwitchPlayers(List<Cell> pending)
        {
            // Change the background for each of the tiles just played.
            foreach (Cell c in pending)
            {
                _cells[c.Row, c.Column].BackColor = _normalTileBackground;
            }

            // Update the tray buttons to show the other player's tiles.
            SetTrayButtons();


            // Enable/disable scoreboard to indicate it's the other player's turn.
            uxPlayerALabel.Enabled = !uxPlayerALabel.Enabled;
            uxScoreA.Enabled = !uxScoreA.Enabled;
            uxPlayerBLabel.Enabled = !uxPlayerBLabel.Enabled;
            uxScoreB.Enabled = !uxScoreB.Enabled;
        }

       /// <summary>
       /// Look for a play from a given cell in the given direction.
       /// </summary>
       /// <param name="cell">the next cell to be examined for current play.</param>
       /// <param name="list">the linked list containing descriptions of all thetiles placed so far on the current word.</param>
        /// <param name="isHorizontal">the direction of the play. (true for horizontal and false for vertical)</param>
       /// <param name="trie">the trie containing all valid completions of the word formed up to the given cell.</param>
       /// <param name="numberOfTiles">the number of tiles that must be played in order connect with pre-existing tiles, or to reach the center cell if no tiles have been played.</param>
       /// <param name="tiles">the tiles held by the current player</param>
       /// <param name="b">the array of bool indicating whether the coresponding tiles held by the player has been placed or not.</param>
       /// <param name="bestScore">the best score of all the plays begin with the plays currently in the LinkedListCell<Play> list. </param>
       /// <returns></returns>
        private LinkedListCell<Play> LookPlay(Cell cell, LinkedListCell<Play> list, bool isHorizontal, Trie trie, int numberOfTiles, List<char> tiles, bool[] b, out int bestScore)
        {
            if(trie == null)
            {
                bestScore = 0;
                return null;
            }
            else if(!GameController.IsOnBoard(cell))
            {
                if (list != null && trie.Contains(""))
                {
                    bestScore = _controller.EvaluatePlay();
                    return list;
                }
                else
                {
                    bestScore = 0;
                    return null;
                }
            }
            else if(_controller.GetLetter(cell) == 0)
            {
                if(list != null && numberOfTiles <= 0 && trie.Contains(""))
                {
                    bestScore = _controller.EvaluatePlay();
                    return list;
                }
                else
                {
                    bestScore = 0;
                    LinkedListCell<Play> bestplay = list;
                    Cell c = cell;
                    int j = -1;
                    for (int i = 0; i < 7; i++)
                    {
                        int k = i;
                        if (!b[k] && (tiles[k] != ' '))
                        {
                            _controller.AddTile(tiles[k], c, false);  
                            string word = _controller.GetWord(_controller.GetWordStart(c, !isHorizontal), !isHorizontal);

                            if(word.Length == 1 || _controller.Dictionary.Contains(word))
                            {
                                c = c.Step(1, isHorizontal);
                                Play p = new Play(tiles[k], c.Row, c.Column, true);
                                list = new LinkedListCell<Play>(p, list);
                                b[k] = true;
                                int bs = bestScore;
                                list = LookPlay(c, list, isHorizontal, trie.GetChild(tiles[k]), numberOfTiles - 1, tiles, b, out bs);
                                if (bs > bestScore)
                                {
                                    bestScore = bs;
                                    bestplay = list;
                                }
                            }
                            _controller.RemoveTile(cell);   
                            b = new bool[7];
                            c = cell;
                            list = null;
                            trie = _controller.Dictionary;
                            j++;
                            i = j;
                        }
                        else if(!b[k] && tiles[k] == ' ' )
                        {
                           for(char ch = 'A'; ch <= 'Z'; ch++)
                           {
                               _controller.AddTile(ch, c, true);
                               string word = _controller.GetWord(_controller.GetWordStart(c, !isHorizontal), !isHorizontal);

                               if (word.Length == 1 || _controller.Dictionary.Contains(word))
                               {
                                   c = c.Step(1, isHorizontal);
                                   Play p = new Play(ch, c.Row, c.Column, true);
                                   list = new LinkedListCell<Play>(p, list);
                                   b[k] = true;
                                   int bs = bestScore;
                                   list = LookPlay(c, list, isHorizontal, trie.GetChild(ch), numberOfTiles - 1, tiles, b, out bs);
                                   if (bs > bestScore)
                                   {
                                       bestScore = bs;
                                       bestplay = list;
                                   }
                               }
                               _controller.RemoveTile(cell);
                               b = new bool[7];
                               c = cell;
                               list = null;
                               bestScore = 0;
                               trie = _controller.Dictionary;
                               j++;
                               i = j;
                           }
                        }
                    }
                    return bestplay;
                }
            }
            else
            {
                _controller.GetLetter(cell);
                cell = cell.Step(1, isHorizontal);
                Play p = new Play(_controller.GetLetter(cell), cell.Row, cell.Column, true);
                list = new LinkedListCell<Play>(p, list);
                return LookPlay(cell, list, isHorizontal, trie.GetChild(_controller.GetLetter(cell)), numberOfTiles - 1, tiles, b, out bestScore);
            }
        }

        /// <summary>
        /// This method scan the borad for cells at which a search should begin.
        /// </summary>
        /// <param name="isHorizontal">The direction the words will be formed. (true for horizontal and false for vertical)</param>
        /// <param name="bestScore">the best score of the best play.</param>
        /// <returns>the best play in the given direction.</returns>
        private LinkedListCell<Play> ScanWhereToBegin(bool isHorizontal, out int bestScore)
        {
            List<char> tiles = _controller.GetCurrentPlayerTiles();
                // Button btn = _cells[15, 15];
            bool[] b = new bool[7];

            bestScore = 0;
            LinkedListCell<Play> bestPlay = null;
            LinkedListCell<Play> bp = null;
            int bs = 0;
            for(int i = 0; i < GameController.BoardSize; i++)
            {
 
                    for (int j = 0; j < GameController.BoardSize; j++)
                    {
                        Cell c = new Cell(i, j);
                        int dis = _controller.DistanceFromTiles(c, isHorizontal);
                        int disV = _controller.DistanceFromTiles(c, !isHorizontal);
                     if (dis > 0 || disV > 0)
                     {
                         if(dis>0)
                         {
                             if (dis > tiles.Count)
                             {
                                 int r = dis - tiles.Count;
                                 c = c.Step(r, isHorizontal);
                                 dis = dis - r;
                             }

                             bp = LookPlay(c, null, isHorizontal, _controller.Dictionary, dis, tiles, b, out bestScore);
                             if(bestScore > bs)
                             {
                                 bestPlay = bp;
                                 bs = bestScore;
                             }

                             if (dis == 1)
                             {
                                 Cell c1 = new Cell(i, j + 1);
                                 dis = _controller.DistanceFromTiles(c1, isHorizontal);
                             }
                             else if (dis == 0)
                             {
                                 if (_controller.GetLetter(c) != '0')
                                 {
                                     dis = 0;
                                 }
                                 else
                                 {
                                     Cell c1 = new Cell(i, j + 1);
                                     dis = _controller.DistanceFromTiles(c1, isHorizontal);
                                 }
                             }
                             else
                             {
                                 dis--;
                             }
                         }
                         if(disV > 0)
                         {
                             if (disV > tiles.Count)
                             {
                                 int r = disV - tiles.Count;
                                 c = c.Step(r, isHorizontal);
                                 disV = disV - r;
                             }

                             bestPlay = LookPlay(c, null, !isHorizontal, _controller.Dictionary, disV, tiles, b, out bestScore);

                             if (disV == 1)
                             {
                                 Cell c1 = new Cell(i, j + 1);
                                 disV = _controller.DistanceFromTiles(c1, isHorizontal);
                             }
                             else if (disV == 0)
                             {
                                 if (_controller.GetLetter(c) != '0')
                                 {
                                     disV = 0;
                                 }
                                 else
                                 {
                                     Cell c1 = new Cell(i, j + 1);
                                     disV = _controller.DistanceFromTiles(c1, isHorizontal);
                                 }
                             }
                             else
                             {
                                 disV--;
                             }
                         }
                            
                    }
                       
                    }
                }
            return bestPlay;
      }

        /// <summary>
        /// Gets the best play for the computer.
        /// </summary>
        /// <returns>The best play</returns>
        private  LinkedListCell<Play> GetBestPlay()
        {
            int bs1 = 0;
            int bs2 = 0;
            int bestScore = 0;
            LinkedListCell<Play> bp1 = null;
            LinkedListCell<Play> bp2 = null;
            LinkedListCell<Play> bestPlay = null;
            bp1 = ScanWhereToBegin(true, out bs1);
            bp2 = ScanWhereToBegin(false, out bs2);
            if(bs1 >= bs2)
            {
                bestScore = bs1;
                bestPlay = bp1;
            }
            else
            {
                bestScore = bs2;
                bestPlay = bp2;
            }

            return bestPlay;
           
        }


    }
}
