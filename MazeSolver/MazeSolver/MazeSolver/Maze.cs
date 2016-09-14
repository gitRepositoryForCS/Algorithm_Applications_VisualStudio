/* Maze.cs
 * Author: Rod Howell 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.MazeSolver
{
    /// <summary>
    /// A GUI control for displaying random mazes and paths within them.
    /// </summary>
    public partial class Maze : UserControl
    {
        /// <summary>
        /// Constructs a new Maze.
        /// </summary>
        public Maze()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The width of a wall in pixels.
        /// </summary>
        private const int _wallWidth = 3;

        /// <summary>
        /// The width and height of a single cell in pixels, as measured from the center of the 
        /// surrounding walls.
        /// </summary>
        private const int _cellSize = _wallWidth + 20;

        /// <summary>
        /// The width and height of single cell in pixels, including the widths of the surrounding
        /// walls.
        /// </summary>
        private const int _externalCellSize = _wallWidth + _cellSize;

        /// <summary>
        /// The pixel distance between the top or left edge of the control and any outer walls.
        /// </summary>
        private const int _mazeOffset = _cellSize / 2;

        /// <summary>
        /// The minimum pixel distance between the top or left edge of the control and any parallel 
        /// paths.
        /// </summary>
        private const int _pathOffset = _cellSize;

        /// <summary>
        /// The probability that any given cell boundary will contain a wall.
        /// </summary>
        private const double _wallProbability = 0.5;

        /// <summary>
        /// The vertical walls.
        /// </summary>
        private bool[,] _verticalWalls;

        /// <summary>
        /// The horizontal walls.
        /// </summary>
        private bool[,] _horizontalWalls;

        /// <summary>
        /// The vertical steps in the current path(s).
        /// </summary>
        private bool[,] _verticalSteps;

        /// <summary>
        /// The horizontal steps in the current path(s).
        /// </summary>
        private bool[,] _horizontalSteps;

        /// <summary>
        /// The random number generator.
        /// </summary>
        private Random _randomNumbers = new Random();

        /// <summary>
        /// The height of the maze in cells.
        /// </summary>
        private int _mazeHeight = 1;

        /// <summary>
        /// The width of the maze in cells.
        /// </summary>
        private int _mazeWidth = 1;

        /// <summary>
        /// The color of the path(s).
        /// </summary>
        private Color _pathColor = SystemColors.Highlight;

        /// <summary>
        /// Gets the height of the maze in cells.
        /// </summary>
        public int MazeHeight
        {
            get
            {
                return _mazeHeight;
            }
        }

        /// <summary>
        /// Gets the width of the maze in cells.
        /// </summary>
        public int MazeWidth
        {
            get
            {
                return _mazeWidth;
            }
        }

        /// <summary>
        /// Gets or sets the color of the path(s).
        /// </summary>
        public Color PathColor
        {
            get
            {
                return _pathColor;
            }
            set
            {
                _pathColor = value;
            }
        }

        /// <summary>
        /// Generates and draws a random maze to fill the available space.
        /// </summary>
        public void Generate()
        {
            _mazeHeight = (Height - _cellSize) / _cellSize;
            _mazeWidth = (Width - _cellSize) / _cellSize;
            _verticalWalls = new bool[_mazeHeight, _mazeWidth + 1];
            _verticalSteps = new bool[_mazeHeight + 1, _mazeWidth];
            _horizontalWalls = new bool[_mazeHeight + 1, _mazeWidth];
            _horizontalSteps = new bool[_mazeHeight, _mazeWidth + 1];
            for (int i = 0; i < _mazeHeight; i++)
            {
                for (int j = 0; j <= _mazeWidth; j++)
                {
                    SetRandomWall(_verticalWalls, i, j);
                }
            }
            for (int i = 0; i <= _mazeHeight; i++)
            {
                for (int j = 0; j < _mazeWidth; j++)
                {
                    SetRandomWall(_horizontalWalls, i, j);
                }
            }
            Invalidate();
        }

        /// <summary>
        /// Randomly determines whether to set the given location of the given array
        /// to <c>true</c>. 
        /// </summary>
        /// <remarks>
        /// <c>i</c> and <c>j</c> must be valid indices into walls.
        /// </remarks>
        /// <param name="walls">The array.</param>
        /// <param name="i">The row of the array.</param>
        /// <param name="j">The column of the array.</param>
        private void SetRandomWall(bool[,] walls, int i, int j)
        {
            if (_randomNumbers.NextDouble() < _wallProbability)
            {
                walls[i, j] = true;
            }
        }

        /// <summary>
        /// Draws the control as necessary.
        /// </summary>
        /// <param name="e">The event arguments containing the graphics context.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Draw(_verticalWalls, _wallWidth, _externalCellSize, _mazeOffset, _mazeOffset,
                e, ForeColor);
            Draw(_horizontalWalls, _externalCellSize, _wallWidth, _mazeOffset, _mazeOffset,
                e, ForeColor);
            Draw(_verticalSteps, _wallWidth, _externalCellSize, _pathOffset, 0, e, _pathColor);
            Draw(_horizontalSteps, _externalCellSize, _wallWidth, 0, _pathOffset, e, _pathColor);
        }

        /// <summary>
        /// Draws blocks of the given size as indicated by the given array. 
        /// </summary>
        /// <remarks>
        /// The upper left corner of
        /// each block is defined by a grid of points separated by <c>_cellSize</c> pixels.
        /// </remarks>
        /// <param name="marks">An array indicating at which grid points blocks are to be drawn.</param>
        /// <param name="width">The width of each block in pixels.</param>
        /// <param name="height">The height of each block in pixels.</param>
        /// <param name="hOff">The horizontal distance from the left edge of the control to the rightmost
        /// grid points.</param>
        /// <param name="vOff">The vertical distance from the top edge of the control to the topmost
        /// grid points.</param>
        /// <param name="e">The event arguments containing the graphics context.</param>
        /// <param name="col">The color to use.</param>
        private void Draw(bool[,] marks, int width, int height, int hOff,
            int vOff, PaintEventArgs e, Color col)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(col);
            Brush brush = new SolidBrush(col);
            int x = hOff;
            int y = vOff;
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    Rectangle mark = new Rectangle(x, y, width, height);
                    if (marks[i, j] && e.ClipRectangle.IntersectsWith(mark))
                    {
                        g.DrawRectangle(pen, mark);
                        g.FillRectangle(brush, mark);
                    }
                    x += _cellSize;
                }
                x = hOff;
                y += _cellSize;
            }
        }

        /// <summary>
        /// Converts a pixel location to a maze cell.
        /// </summary>
        /// <param name="start">A pixel location.</param>
        /// <returns>The maze cell containing that pixel location.</returns>
        /// <exception cref="ArgumentException">If the pixel location is outside the maze.</exception>
        public Cell GetCellFromPixel(Point start)
        {
            if (start.X < _mazeOffset || start.X >= _mazeWidth * _cellSize + _mazeOffset ||
                start.Y < _mazeOffset || start.Y >= _mazeHeight * _cellSize + _mazeOffset)
            {
                throw new ArgumentException();
            }
            return new Cell((start.Y - _mazeOffset) / _cellSize,
                (start.X - _mazeOffset) / _cellSize);
        }

        /// <summary>
        /// Determines whether the way is clear to move from the given cell in the given
        /// direction. 
        /// </summary>
        /// <param name="cell">The starting cell.</param>
        /// <param name="d">The direction in which to move.</param>
        /// <returns>Whether the way is clear to move in the given direction.</returns>
        /// <exception cref="ArgumentException">If <c>cell</c> is not in the maze.</exception>
        public bool IsClear(Cell cell, Direction d)
        {
            if (!IsInMaze(cell))
            {
                throw new ArgumentException();
            }
            return d == Direction.North && !_horizontalWalls[cell.Row, cell.Column] ||
                d == Direction.East && !_verticalWalls[cell.Row, cell.Column + 1] ||
                d == Direction.South && !_horizontalWalls[cell.Row + 1, cell.Column] ||
                d == Direction.West && !_verticalWalls[cell.Row, cell.Column];
        }

        /// <summary>
        /// Determines whether the given point refers to a cell in the maze.
        /// </summary>
        /// <param name="cell">The point.</param>
        /// <returns>Whether <c>cell</c> is a cell in the maze.</returns>
        public bool IsInMaze(Cell cell)
        {
            return cell.Row >= 0 && cell.Column >= 0 && cell.Row < _mazeHeight && cell.Column < _mazeWidth;
        }

        /// <summary>
        /// Adds a path from the given cell, one step in the given direction.
        /// </summary>
        /// <param name="cell">The starting cell.</param>
        /// <param name="d">The direction in which to go from the starting cell.</param>
        /// <exception cref="ArgumentException">If <c>cell</c> is not in the maze or if there is a wall blocking the 
        /// way.</exception>
        public void DrawPath(Cell cell, Direction d)
        {
            Cell next = Step(cell, d);
            if (!IsInMaze(cell) || !IsClear(cell, d))
            {
                throw new ArgumentException();
            }
            SetStep(cell, d, true);
        }

        /// <summary>
        /// Finds the cell one step in the given direction from the given cell. 
        /// </summary>
        /// <remarks>
        /// Neither cell needs to be inside the maze, and walls are ignored.
        /// </remarks>
        /// <param name="cell">The starting cell.</param>
        /// <param name="d">The direction to go.</param>
        /// <returns>The next cell in the given direction from the given cell.</returns>
        /// <exception cref="ArgumentException">If <c>d</c> is not one of the four directions>.</exception>
        public Cell Step(Cell cell, Direction d)
        {
            switch (d)
            {
                case Direction.North:
                    return new Cell(cell.Row - 1, cell.Column);
                case Direction.East:
                    return new Cell(cell.Row, cell.Column + 1);
                case Direction.South:
                    return new Cell(cell.Row + 1, cell.Column);
                case Direction.West:
                    return new Cell(cell.Row, cell.Column - 1);
                default:
                    throw new ArgumentException();
            }
        }

        /// <summary>
        /// Finds the cell one step in the direction opposite the given direction from the given cell. 
        /// </summary>
        /// <remarks>
        /// Neither cell needs to be inside the maze, and walls are ignored.
        /// </remarks>
        /// <param name="cell">The starting cell.</param>
        /// <param name="d">The direction opposite the direction to go.</param>
        /// <returns>The next cell in the direction opposite <c>d</c>.</returns>
        /// <exception cref="ArgumentException">If <c>d</c> is not one of the four directions.</exception>
        public Cell ReverseStep(Cell cell, Direction d)
        {
            if (d < Direction.South)
            {
                return Step(cell, d + 2);
            }
            else
            {
                return Step(cell, d - 2);
            }
        }

        /// <summary>
        /// Sets the step from the given cell in the given direction to either contain a path or to contain
        /// no path, as determined by <c>val</c>. 
        /// </summary>
        /// <remarks>
        /// <c>cell</c> must be inside the maze. 
        /// </remarks>
        /// <param name="cell">The starting cell.</param>
        /// <param name="d">The direction to go from <c>cell</c>.</param>
        /// <param name="val">Whether a path should be present at this step.</param>
        /// <exception cref="ArgumentException">If <c>d</c> is not one of the four directions.</exception>
        private void SetStep(Cell cell, Direction d, bool val)
        {
            switch (d)
            {
                case Direction.North:
                    _verticalSteps[cell.Row, cell.Column] = val;
                    break;
                case Direction.East:
                    _horizontalSteps[cell.Row, cell.Column + 1] = val;
                    break;
                case Direction.South:
                    _verticalSteps[cell.Row + 1, cell.Column] = val;
                    break;
                case Direction.West:
                    _horizontalSteps[cell.Row, cell.Column] = val;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        /// <summary>
        /// Removes all paths from the maze.
        /// </summary>
        public void EraseAllPaths()
        {
            ClearArray(_horizontalSteps);
            ClearArray(_verticalSteps);
        }

        /// <summary>
        /// Sets all elements of the given array to <c>false</c>.
        /// </summary>
        /// <param name="array">The array.</param>
        private void ClearArray(bool[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = false;
                }
            }
        }

        /// <summary>
        /// Removes any path from the given cell to the adjacent cell in the given direction.
        /// </summary>
        /// <remarks>
        /// The adjacent cell need not be in the maze.
        /// </remarks>
        /// <param name="cell">The starting cell.</param>
        /// <param name="d">The direction of the ending cell from the starting cell.</param>
        /// <exception cref="ArgumentException">If <c>cell</c> is not in the maze.</exception>
        public void ErasePath(Cell cell, Direction d)
        {
            Cell next = Step(cell, d);
            if (!IsInMaze(cell))
            {
                throw new ArgumentException();
            }
            SetStep(cell, d, false);
        }

        /// <summary>
        /// Handles a Load event by generating a maze.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Maze_Load(object sender, EventArgs e)
        {
            Generate();

        }
    }
}
