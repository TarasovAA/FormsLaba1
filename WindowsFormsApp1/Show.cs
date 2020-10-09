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
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Show : Form, IShowOnlyOne
    {
        public Show()
        {
            InitializeComponent();
        }

        public event EventHandler<OnesIndexEventArgs> TryFindOneEvent;
        public void Response(Hero hero)
        {
            if(hero!=null)
            {
                ShowBox.Text = "Name:" + hero.Name + " HP" + hero.Hp + " Energy" + hero.Energy + " Skills" + hero.Skills + '\n';
            }
            else { WriteBox.Text = "insert mumber"; }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void Sh_Click(object sender, EventArgs e)
        {
            TryFindOneEvent?.Invoke(this, new OnesIndexEventArgs(WriteBox.Text));
            //createHero a = new createHero();
            //int g;
            //if (Int32.TryParse(WriteBox.Text, out g))
            //{
            //    ShowBox.Text = a.SHOW(g-1); ;
            //}
            //else
            //{
            //    WriteBox.Text = "insert mumber";
            //}
        }

        private void Show_Load(object sender, EventArgs e)
        {

        }

       
    }
}
