using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.IViews;

namespace WindowsFormsApp1
{
    public partial class ShowAll : Form, IShowEveryone
    {
        public ShowAll()
        {
            InitializeComponent();
        }

        //public string Text;
        public event EventHandler ShowEvent;
        //public void Response(string response)
        //{
        //    writeAll.Text = response;
        //}
        public void Response(IEnumerable<Hero> heros)
        {
            string response = "";
            if (heros.Count()!=0)
            {
                int k = 0;
                foreach(Hero one in heros)
                {
                    k = ++k;
                    response = response + k + ")" + "Name: " + one.Name + " HP: " + one.Hp + " Energy: " + one.Energy + " Skills: " + one.Skills + '\n';
                }
            }
            else
            {
                response = "date's not finding";
            }
            writeAll.Text = response;
        }
       

        private void Form3_Load(object sender, EventArgs e)
        {
            ShowEvent?.Invoke(this, new EventArgs());
            createHero a = new createHero();
            //if (a.RETURN_col() > 0)
            //{
            //    writeAll.Text = "";
            //    for (int i = 0; i < a.RETURN_col(); i++)
            //    {
            //        NH hero = a.RETURN(i);
            //        int k = i + 1;
            //        writeAll.Text = writeAll.Text+k+ ")" + hero.input();
            //    }
            //}
            //else
            //{
            //    writeAll.Text = "date's not finding";
            //}
        }

        private void writeAll_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
