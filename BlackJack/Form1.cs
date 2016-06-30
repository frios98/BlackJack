using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class JackBlack : Form
    {
        //global variables
        Random random = new Random();
        Image[] imgCard = { BlackJack.Properties.Resources.card0, BlackJack.Properties.Resources.card1, BlackJack.Properties.Resources.card2,
            BlackJack.Properties.Resources.card3, BlackJack.Properties.Resources.card4, BlackJack.Properties.Resources.card5,
            BlackJack.Properties.Resources.card6, BlackJack.Properties.Resources.card7, BlackJack.Properties.Resources.card8,
            BlackJack.Properties.Resources.card9, BlackJack.Properties.Resources.card10, BlackJack.Properties.Resources.card11,
            BlackJack.Properties.Resources.card12 };
        List<int> playerHand = new List<int>();
        List<int> aiHand = new List<int>();

        public JackBlack()
        {
            InitializeComponent();
            playerHand.Add(randomCard());
            playerHand.Add(randomCard());
            showHand();

        }

        private void showHand()
        {
            lblPlayerCards.Text = string.Join(", ", playerHand.ToArray());
        }

        private void showDealerHand()
        {
            lblDealerHand.Text = string.Join(", ", aiHand.ToArray());
        }

        private int randomCard()
        {
            int card = random.Next(1, 11);
            return card;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dealCard();
            showHand();
            addHand();
        }

        private void addHand()
        {
            int total = playerHand.Sum();
            string total2 = total.ToString();
            if (total == 21)
            {
                //end game, money goes to player and resets game
                resetGame();
            }
            else if (total > 21)
            {
                //bust, vice versa
                resetGame();
            }
        }

        private void dealCard()
        {
            playerHand.Add(randomCard());
        }
        //fold method
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = false;
            addHand();
            aiTurn();
        }

        private void resetGame()
        {
            int p = playerHand.Sum();
            int ai = aiHand.Sum();
            if (p > 21)
            {
                MessageBox.Show("Sorry. No winning for you");
            }
            else if (p == 21 || p > ai )
            {
                MessageBox.Show("You Won. Feel great about yourself.");
            }
            else if (ai > p)
            {
                MessageBox.Show("Sorry. No winning for you");
            }
            else if (p == ai)
            {
                MessageBox.Show("It's a Draw!");
            }
                
            playerHand.Clear();
            aiHand.Clear();
            showDealerHand();
            dealCard();
            dealCard();
            showHand();
            button2.Enabled = true;
            button1.Enabled = true;
        }

        private void aiTurn()
        {
            aiHand.Add(randomCard());
            aiHand.Add(randomCard());
            while (aiHand.Sum() <= 17)
            {
                aiHand.Add(randomCard());
            }
            showDealerHand();
            resetGame();
        }
    }
}
