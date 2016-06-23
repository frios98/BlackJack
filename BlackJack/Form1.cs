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
    public partial class Form1 : Form
    {
        //global variables
        Random random = new Random();
        Image[] imgCard = { BlackJack.Properties.Resources.card0, BlackJack.Properties.Resources.card1, BlackJack.Properties.Resources.card2,
            BlackJack.Properties.Resources.card3, BlackJack.Properties.Resources.card4, BlackJack.Properties.Resources.card5,
            BlackJack.Properties.Resources.card6, BlackJack.Properties.Resources.card7, BlackJack.Properties.Resources.card8,
            BlackJack.Properties.Resources.card9, BlackJack.Properties.Resources.card10, BlackJack.Properties.Resources.card11,
            BlackJack.Properties.Resources.card12 };

        public Form1()
        {
            InitializeComponent();
        }

        private int randomCard()
        {
            int card = random.Next(0, 13);
            return card;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var card = randomCard();
            PictureBox pbCard = new PictureBox();
            pbCard.Image = imgCard[card];
            pbCard.Dock = DockStyle.Fill;
            layoutPlayerCards.Controls.Add(pbCard);
        }
    }
}
