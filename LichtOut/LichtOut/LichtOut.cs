using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LichtOut
{
    public partial class LichtOut : Form
    {
        private int gameMode = -1;

        public LichtOut()
        {
            InitializeComponent();
        }

        private void game_Click(object sender, EventArgs e)
        {
            Button check = (Button)sender;
            if (check.Text == "EASY")
            {
                gameMode = 0;
            }
            else
            {
                gameMode = 1;
            }
            this.chooseColorPanel.Visible = true;
        }

        private void rb_on_color(object sender, EventArgs e)
        {
            RadioButton input = (RadioButton)sender;

            switch (input.Text)
            {
                case "YELLOW":
                    this.pnl_OnLight.BackColor = Color.Yellow;
                    break;
                case "GREEN":
                    this.pnl_OnLight.BackColor = Color.LightGreen;
                    break;
                case "BLUE":
                    this.pnl_OnLight.BackColor = Color.LightBlue;
                    break;
                case "PINK":
                    this.pnl_OnLight.BackColor = Color.LightPink;
                    break;
                default:
                    break;
            }
        }

        private void rb_off_color(object sender, EventArgs e)
        {
            RadioButton input = (RadioButton)sender;

            switch (input.Text)
            {
                case "GRAY":
                    this.pnl_OffLight.BackColor = Color.DarkGray;
                    break;
                case "DARK GREEN":
                    this.pnl_OffLight.BackColor = Color.Green;
                    break;
                case "DARK BLUE":
                    this.pnl_OffLight.BackColor = Color.Blue;
                    break;
                case "DEEP PINK":
                    this.pnl_OffLight.BackColor = Color.DeepPink;
                    break;
                default:
                    break;
            }
        }

        private void btn_sartGame_Click(object sender, EventArgs e)
        {
            this.pnl_startGame.Visible = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void LichtOut_Load(object sender, EventArgs e)
        {

        }

        private void GetNeighbours(LightTile[,] tiles)
        {
            for (int row = 0; row < tiles.GetLength(0); row++)
            {
                for (int col = 0; col < tiles.GetLength(1); col++)
                {
                    tiles[row, col].Neighbours.Add(tiles[row, col]);

                    if (row > 0)
                    {
                        tiles[row, col].Neighbours.Add(tiles[row - 1, col]);
                        
                    }
                    if (row < tiles.GetLength(0) - 1)
                    {
                        tiles[row, col].Neighbours.Add(tiles[row + 1, col]);
                    }
                    if (col > 0)
                    {
                        tiles[row, col].Neighbours.Add(tiles[row, col - 1]);
 
                    }
                    if (col < tiles.GetLength(1) - 1)
                    {
                        tiles[row, col].Neighbours.Add(tiles[row, col + 1]);
                    }
                }
            }
        }
    }
}
