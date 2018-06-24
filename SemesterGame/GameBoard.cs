using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterGame
{
    public partial class GameBoard : Form

         

        

    {

        
        public GameBoard(string name, string nametwo )
        {
            InitializeComponent();

            

            PlayerLabel1.Text = name.ToString();

            PlayerLabelTwo.Text = nametwo.ToString();
        }



    



        private void GameBoard_Load(object sender, EventArgs e)
        {

            
        }

        private void DealCardsButton_Click(object sender, EventArgs e)
        {
            CardPictureBox.Image = CardsImageList.Images[1];

                
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            PokerGameMainScreen myscreen = new PokerGameMainScreen();

            myscreen.Show();

            this.Hide();
        }
    }
}
