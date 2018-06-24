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
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

       
        private void StartButton_Click_1(object sender, EventArgs e)
        {
            PokerGameMainScreen mainscreen = new PokerGameMainScreen();

            mainscreen.ShowDialog();
            this.Hide();
        }

       

        }
    }

