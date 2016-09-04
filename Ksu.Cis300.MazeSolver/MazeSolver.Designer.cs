namespace Ksu.Cis300.MazeSolver
{
    partial class MazeSolver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxMaze = new Ksu.Cis300.MazeLibrary.Maze();
            this.uxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxMaze
            // 
            this.uxMaze.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxMaze.AutoSize = true;
            this.uxMaze.Location = new System.Drawing.Point(13, 13);
            this.uxMaze.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxMaze.Name = "uxMaze";
            this.uxMaze.PathColor = System.Drawing.SystemColors.Highlight;
            this.uxMaze.Size = new System.Drawing.Size(495, 399);
            this.uxMaze.TabIndex = 0;
            this.uxMaze.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uxMaze_MouseClick);
            // 
            // uxButton
            // 
            this.uxButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButton.Location = new System.Drawing.Point(185, 434);
            this.uxButton.Name = "uxButton";
            this.uxButton.Size = new System.Drawing.Size(157, 42);
            this.uxButton.TabIndex = 1;
            this.uxButton.Text = "New Maze";
            this.uxButton.UseVisualStyleBackColor = true;
            this.uxButton.Click += new System.EventHandler(this.uxButton_Click);
            // 
            // MazeSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 488);
            this.Controls.Add(this.uxButton);
            this.Controls.Add(this.uxMaze);
            this.Name = "MazeSolver";
            this.Text = "Maze Solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MazeLibrary.Maze uxMaze;
        private System.Windows.Forms.Button uxButton;
    }
}

