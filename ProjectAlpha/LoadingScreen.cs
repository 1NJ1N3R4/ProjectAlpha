using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAlpha
{
    public partial class LoadingScreen : Form
    {


        public LoadingScreen()
        {
            InitializeComponent();
        }



        private async void LoadingScreen_Load(object sender, EventArgs e)
        {
            // Smoothly update the progress bar
            for (int i = 0; i <= 100; i++)
            {
                siticoneProgressBar1.Value = i; 
                await Task.Delay(20); 
            }

            
            this.Close();
        }

        private void siticoneProgressBar1_ValueChanged(object sender, EventArgs e)
        {
            if (siticoneProgressBar1.Value == 100)
            {
                ProjectAlpha PA = new ProjectAlpha();
                PA.Show();
                this.Close();
            }
        }
    }
    }
