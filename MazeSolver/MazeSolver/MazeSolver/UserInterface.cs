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
using Ksu.Cis300.Graphs;

namespace Ksu.Cis300.MazeSolver
{
    /// <summary>
    /// A GUI for a program that generates and solves mazes.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// The graph representation of the maze.
        /// </summary>
        private DirectedGraph<Cell, Direction> _graph;

        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles a New Maze event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNewMaze_Click(object sender, EventArgs e)
        {
            uxMaze.Generate();
            _graph = GetGraph(uxMaze);
        }

        /// <summary>
        /// Builds a graph from the given maze.
        /// </summary>
        /// <param name="maze">The maze.</param>
        /// <returns>The resulting graph.</returns>
        private DirectedGraph<Cell, Direction> GetGraph(Maze maze)
        {
            DirectedGraph<Cell, Direction> graph = new DirectedGraph<Cell, Direction>();

            for (int i = 0; i < maze.MazeHeight; i++)
            {
                for (int j = 0; j < maze.MazeWidth; j++)
                {
                    Cell node = new Cell(i, j);
                    if (!graph.ContainsNode(node))
                    {
                        graph.AddNode(node);
                    }
                    for (Direction d = Direction.North; d <= Direction.West; d++)
                    {
                        if (maze.IsClear(node, d))
                        {
                            graph.AddEdge(node, maze.Step(node, d), d);
                        }
                    }
                }
            }

            return graph;
        }

        /// <summary>
        /// Handes a MouseClick event on the maze.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMaze_MouseClick(object sender, MouseEventArgs e)
        {
            uxMaze.EraseAllPaths();
            Cell cell;
            try
            {
                cell = uxMaze.GetCellFromPixel(e.Location);
            }
            catch (ArgumentException)
            {
                // Mouse was outside the maze - do nothing.
                return;
            }
            Dictionary<Cell, Cell> paths;
            Cell end = FindPath(cell, _graph, out paths);
            if (end == new Cell(0, 0))
            {
                MessageBox.Show("No path found.");
            }
            else
            {
                DisplayPath(cell, end, paths, _graph);
            }
            uxMaze.Invalidate(); // Redraw the maze.
        }

        /// <summary>
        /// Displays the path from the given start node to the given end node in the given graph
        /// using the given shortest path tree.
        /// </summary>
        /// <param name="start">The start node.</param>
        /// <param name="end">The end node.</param>
        /// <param name="paths">The shortest paths.</param>
        /// <param name="graph">The graph.</param>
        private void DisplayPath(Cell start, Cell end, Dictionary<Cell, Cell> paths,
            DirectedGraph<Cell, Direction> graph)
        {
            while (end != start)
            {
                Direction d;
                graph.TryGetEdge(paths[end], end, out d);
                DrawPath(paths[end], d);
                end = paths[end];
            }
        }

        /// <summary>
        /// Draws a path from the given cell in the given direction.
        /// </summary>
        /// <param name="cell">The cell from which to begin drawing.</param>
        /// <param name="d">The direction in which to draw.</param>
        private void DrawPath(Cell cell, Direction d)
        {
            uxMaze.DrawPath(cell, d);
        }

        /// <summary>
        /// Finds a shortest path from the given node in the given graph to a node that is not a cell
        /// in the given maze.
        /// </summary>
        /// <param name="node">The starting node.</param>
        /// <param name="graph">The graph.</param>
        /// <param name="paths">The shortest paths.</param>
        /// <returns>The final point of the path, or (0, 0) if there is no path. </returns>
        private Cell FindPath(Cell node, DirectedGraph<Cell, Direction> graph,
            out Dictionary<Cell, Cell> paths)
        {
            paths = new Dictionary<Cell, Cell>();

            Queue<Tuple<Cell, Cell>> q = new Queue<Tuple<Cell, Cell>>();
            paths.Add(node, node);
            foreach (Tuple<Cell, Direction> edge in graph.OutgoingEdges(node))
            {
                q.Enqueue(new Tuple<Cell, Cell>(node, edge.Item1));
            }
            while (q.Count > 0)
            {
                Tuple<Cell, Cell> edge = q.Dequeue();
                if (!paths.ContainsKey(edge.Item2))
                {
                    paths.Add(edge.Item2, edge.Item1);
                    if (!IsInMaze(edge.Item2))
                    {
                        return edge.Item2;
                    }
                    foreach (Tuple<Cell, Direction> outgoing in graph.OutgoingEdges(edge.Item2))
                    {
                        q.Enqueue(new Tuple<Cell, Cell>(edge.Item2, outgoing.Item1));
                    }
                }
            }
            return new Cell(0, 0);

        }

        /// <summary>
        /// Determines whether the given cell is within the maze.
        /// </summary>
        /// <param name="cell">The cell.</param>
        /// <returns>Whether cell is within the maze.</returns>
        private bool IsInMaze(Cell cell)
        {
            return uxMaze.IsInMaze(cell);
        }

        /// <summary>
        /// Handles a Load event on the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserInterface_Load(object sender, EventArgs e)
        {
            // The debugger won't catch an exception within this event handler,
            // so we'll do it ourselves. Exceptions here indicate programmer error.
            try
            {
                _graph = GetGraph(uxMaze);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Application.Exit();
            }
        }
    }
}
