using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SemesterGame
{
    public partial class PokerGameMainScreen : Form


        
    {

  


        public PokerGameMainScreen()

            

            
            
        {
            
            
            InitializeComponent();


            
        }

        

        private void PokerGameMainScreen_Load(object sender, EventArgs e)
        {
            StreamReader str;

            string players;


            str = File.OpenText("../../PlayerSelection.csv");


            while (!str.EndOfStream)
            {
                players = str.ReadLine();

                PlayerSelectListBox.Items.Add(players);
            }
        }

        private void AddPlayersTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PlayerSelectListBox.Items.Add(AddPlayersTextBox.Text);

                AddPlayersTextBox.Clear();
            }

           
        }

        

        private void GO_Click(object sender, EventArgs e)
        {

        

            string name = PlayerSelectListBox.SelectedItem.ToString();
            string nametwo = PlayerSelectListBox.SelectedItem.ToString();

            GameBoard mygame = new GameBoard(name, nametwo);

            mygame.ShowDialog();

            this.Hide();
            


            
        }

    }
}


            


        
    

    
    

