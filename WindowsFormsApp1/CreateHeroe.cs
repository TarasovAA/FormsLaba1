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
    public partial class createHero : Form, IMainView
    {
        //static List<NH> heros = new List<NH> {  };
        

        public event EventHandler<NewWindowEventArgs> ClickButtonEvent;

        public createHero()
        {
            InitializeComponent();
        }
        public void Create(string a, string b , string c, string d)
        {
            //NH e = new NH(a, b, c, d);
            //heros.Add(e);
            
        }

        //public NH RETURN(int i)
        //{
        //    return heros[i];
        //}
 

        //public int RETURN_col()
        //{
        //    return heros.Count;
        //}
        //public string DELETE(int i)
        //{
        //    if (i >= 0 && i < RETURN_col())
        //    {
        //        string t = "this element was deleted: " + heros[i].input();
        //        heros.RemoveAt(i);
        //        return t;
        //    }
        //    else { return "the Character is not founded"; }
        //}
        //public string SHOW(int i)
        //{
        //    if (i >= 0 && i < RETURN_col())
        //    {
        //        return heros[i].input();
        //    }
        //    else { return "the Character is not founded"; }
        //}

       
        private void New_Click(object sender, EventArgs e)
        {
            ClickButtonEvent?.Invoke(this, new NewWindowEventArgs("New"));
            //New a = new New();
            //a.ShowDialog();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            ClickButtonEvent?.Invoke(this, new NewWindowEventArgs("Delete"));
            //DelCharacter del = new DelCharacter();
            //del.ShowDialog();
        }

        private void Sh_Click(object sender, EventArgs e)
        {
            ClickButtonEvent?.Invoke(this, new NewWindowEventArgs("ShowOne"));
            //Show sh = new Show();
            //sh.ShowDialog();
        }

        private void All_Click(object sender, EventArgs e)
        {
            ClickButtonEvent?.Invoke(this, new NewWindowEventArgs("ShowAll"));
            //ShowAll S_ALL = new ShowAll();
            //S_ALL.ShowDialog();
        }

        private void CreateHeroe_Load(object sender, EventArgs e)
        {

        }
    }
}
