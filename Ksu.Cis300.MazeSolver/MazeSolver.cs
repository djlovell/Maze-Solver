/* Ksu.Cis300.MazeSolver.cs
 * Author: Daniel J Lovell 
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
using Ksu.Cis300.MazeLibrary;

namespace Ksu.Cis300.MazeSolver
{
    /// <summary>
    /// The maze solver class generates a random maze, and solves it 
    /// starting at a selected location. 
    /// </summary>
    public partial class MazeSolver : Form
    {
        /// <summary>
        /// This initializes the maze solver program.
        /// </summary>
        public MazeSolver()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This button generates a new maze when the user clicks it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButton_Click(object sender, EventArgs e)
        {
            uxMaze.Generate();
        }

        /// <summary>
        /// This method allows the user to enter, by mouse, his/her desired
        /// starting location in the maze. The proram then calls a draw method 
        /// to "solve the maze."
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMaze_MouseClick(object sender, MouseEventArgs e)
        {
            
            Cell startingLocation = uxMaze.GetCellFromPixel(e.Location);
            if (uxMaze.IsInMaze(startingLocation))
            {
                
                uxMaze.EraseAllPaths();
                DrawPath(startingLocation);
                
                uxMaze.Invalidate();
            }
        }

        /// <summary>
        /// The DrawPath method, when called, takes in the selected starting position 
        /// and space by space finds the way out of the maze. As it progresses, spots
        /// that are visited are stored in memory, and a Stack structure remembers 
        /// the turn by turn directions the program follows, allowing it to "backtrack."
        /// Once it is detected that it is outside of the maze, the program displays a bright
        /// blue line tracing the path. If no solution can be found (closed box), the program
        /// will display a message box stating the fact.
        /// </summary>
        /// <param name="c">This paremeter gives the program a starting location.</param>
        public void DrawPath(Cell c)
        {
            
            Stack<Direction> stack = new Stack<Direction>();
            bool[,] pathHistory = new bool[uxMaze.MazeHeight, uxMaze.MazeWidth];
            pathHistory[c.Row,c.Column] = true;
            Direction d =  Direction.North;

            while (uxMaze.IsInMaze(c)) 
            {
                if (d == Direction.North || d == Direction.East ||
                    d == Direction.South || d == Direction.West)
                {

                    if (uxMaze.IsClear(c, d) && ((uxMaze.IsInMaze( uxMaze.Step(c, d) ) == false ||
                       pathHistory[uxMaze.Step(c, d).Row, uxMaze.Step(c, d).Column] == false))  
                       )
                    {
                        uxMaze.DrawPath(c, d);
                        
                        c = uxMaze.Step(c, d);
                        stack.Push(d);
                        d = Direction.North;

                        if (uxMaze.IsInMaze(c))
                        {
                            pathHistory[c.Row, c.Column] = true;
                        }
                    }
                    else 
                    {
                        d++;
                    }
                }

                else if (d != Direction.North && d != Direction.East
                    && d != Direction.South && d != Direction.West && stack.Count != 0)
                {

                    d = stack.Pop();
                    c = uxMaze.ReverseStep(c, d);
                    uxMaze.ErasePath(c, d);
                    d++;
                }
                else 
                {
                    MessageBox.Show("There is no available exit path.");
                    return;
                }
            } 
        }
    }
}
