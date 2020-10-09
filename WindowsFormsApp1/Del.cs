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
    public partial class DelCharacter : Form, IDeletercs
    {
        public DelCharacter()
        {
            InitializeComponent();
        }

        public event EventHandler<DeleteEventArgs> ClickButtonEvent;
        public void Response(string info1, string info2)
        {
            SwowBox.Text = info1;
            delBox.Text = info2;
        }

        private void del_Click(object sender, EventArgs e)
        {
            ClickButtonEvent?.Invoke(this, new DeleteEventArgs(delBox.Text));
            //createHero a = new createHero();
            //int g;
            //if (Int32.TryParse(delBox.Text, out g))
            //{
            //    SwowBox.Text = a.DELETE(g-1);
            //}
            //else
            //{
            //    delBox.Text = "insert mumber";
            //}

        }

      
        

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DelCharacter_Load(object sender, EventArgs e)
        {

        }

        private void SwowBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void delBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
