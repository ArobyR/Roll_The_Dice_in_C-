using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roll_the_magic_dice
{
    public partial class Principal1 : Form
    {

        public Principal1()
        {
            InitializeComponent();
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private int Generator()
        {
            int Dice1, Dice2;
            var seed = Environment.TickCount;
            var r1 = new Random(seed);
            Dice1 = r1.Next(1, 7);
            Dice2 = r1.Next(1, 7);

            lblDice1.Text = Convert.ToString(Dice1);
            lblDice2.Text = Convert.ToString(Dice2);
            int result = Dice1 + Dice2;

            return result;
        }
        
        private void Confirmation()
        {
            int n = Generator();
            if (n == 7 || n == 12)
            {
                Winner();
            }
            else if (n % 2 != 0 && n != 7)
            {
                Loser();
            }
            else if (n % 2 == 0 && n != 12)
            {
                Loser();
                MessageBox.Show("GAME OVER!", "LOSER", MessageBoxButtons.OK, MessageBoxIcon.None);
                Close();
            }
        }

        private void Winner()
        {
            lblWinner.Text = "YOU WIN!";
        }
        private void Loser()
        {
            lblWinner.Text = "You lost";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Confirmation();

            /*
            // Game Rules
            if (result == 7 || result == 12)
            {
                // Label is better than msbox
                lblWinner.Text = "YOU WON!";
            }
            if (result != 7 && result % 2 != 0)
            {
                lblWinner.Text = "You're loser";
                //MessageBox.Show("You lost the game. Do you want to continue?", "LOSER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                MessageBox.Show("GAME OVER!", "LOSER", MessageBoxButtons.OK, MessageBoxIcon.None);
                //Close();
            }
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MRRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- If the player rolls a 7 or a 12 the player wins. \n" +
                "- If the sum of both is a number other than 7 then the player loses but " +
                "can continue playing. \n" +
                "- If the sum of both is an even number different from 12 then you LOSE" +
                " and the GAME IS OVER.",
                "RULES", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void MAAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by:\n" +
                "\nAroby Rosario", "About", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void MEexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
