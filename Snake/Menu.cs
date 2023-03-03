using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Menu : Form
    {
        Form1 game;

        public Menu(Form1 game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            game.XDim = int.Parse(xDim.Text);
            game.YDim = int.Parse(yDim.Text);
            game.speed = int.Parse(speed.Text);
            this.Close();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
