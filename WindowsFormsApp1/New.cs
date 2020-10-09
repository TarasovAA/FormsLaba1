using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.IViews;

namespace WindowsFormsApp1
{
    public partial class New : Form, INew
    {
       
        public New()
        {
            InitializeComponent();
            
        }

        public event EventHandler<NewHeroForEventArgs> ClickButtonEvent;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string c = Energy3.Text;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            
            
            int a;
            if (Name1.Text == "")
            {
                Name1.Text = "enter  name your hero";
            }
            else if (HP2.Text == "")
            {
                HP2.Text = "enter lives your hero";
            }
            else if (!Int32.TryParse(HP2.Text, out a))
            {
                HP2.Text = "Leves is must be number";
            }
            else if (Energy3.Text == "")
            {
                Energy3.Text = "enter energy your hero";
            }
            else if (!Int32.TryParse(Energy3.Text, out a))
            {
                Energy3.Text = "energy is must be number";
            }
            else if (Ability1.Text == "")
            {
                Ability1.Text = "enter  abilitie your hero";
            }
            else
            {
                if (ClickButtonEvent != null)
                {
                    ClickButtonEvent(this, new NewHeroForEventArgs(Name1.Text, Int32.Parse(HP2.Text), Int32.Parse(Energy3.Text), Ability1.Text));
                }
                Close();
            }
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }
    }
}
