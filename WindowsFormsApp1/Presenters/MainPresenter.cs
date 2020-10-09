using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using WindowsFormsApp1.IViews;
using WindowsFormsApp1.Models;
using System.Data.Entity;
using System.ComponentModel;

namespace WindowsFormsApp1.Presenters
{
    public class MainPresenter
    {

        IMainView currentView;
        INew n;
        IShowEveryone S_ALL;
        IDeletercs del;
        IShowOnlyOne sh;
        HeroesContext db;      
        private BindingList<Hero> heros { get; set; }

        public MainPresenter(IMainView mv)
        {
            db = new HeroesContext();
            db.Heroes.Load();
            heros = db.Heroes.Local.ToBindingList();
            currentView = mv;
            mv.ClickButtonEvent += Mv_ClickButtonEvent;
        }

        private void Mv_ClickButtonEvent(object sender, NewWindowEventArgs e)
        {
            
            switch(e.WindowName)
            {
                case "New":
                    n = new New();
                    n.ClickButtonEvent += N_ClickButtonEvent;
                    (n as System.Windows.Forms.Form).ShowDialog();
                    //n.ShowDialog();
                    break;
                case "ShowAll":
                    S_ALL = new ShowAll();
                    S_ALL.ShowEvent += (s, ea) => { S_ALL.Response(heros.ToList()); };
                    (S_ALL as System.Windows.Forms.Form).ShowDialog();
                    break;
                case "Delete":
                    del = new DelCharacter();
                    del.ClickButtonEvent += Del_ClickButtonEvent;
                    (del as System.Windows.Forms.Form).ShowDialog();
                    break;
                case "ShowOne":
                    sh = new Show();
                    sh.TryFindOneEvent += (s, ea) => { sh.Response(SHOW((int)ea.Index - 1)); };
                    (sh as System.Windows.Forms.Form).ShowDialog();
                    break;
                default:
                    throw new NotImplementedException();
            }
                
           
        }
        

        private void Del_ClickButtonEvent(object sender, DeleteEventArgs e)
        {
            int g;
            string response1="";
            string response2="";
            if (Int32.TryParse(e.Index, out g))
            {
                response1 = DELETE(g - 1);
                db.SaveChanges();
            }
            else
            {
                response2 = "insert mumber";
            }
            del.Response(response1,response2);
        }

        private void N_ClickButtonEvent(object sender, NewHeroForEventArgs e)
        {
            Hero newHero = new Hero { Name=e.Name, Hp=e.HP, Energy=e.Energy, Skills=e.Skills };
            heros.Add(newHero);
            db.SaveChanges();
        }


        private Hero RETURN(int i)
        {
            return heros[i];
        }


        private int RETURN_col()
        {
            return heros.Count;
        }

        private string DELETE(int i)
        {
            if (i >= 0 && i < RETURN_col())
            {
                string t = "this element was deleted: " + "Name:" + heros[i].Name + " HP" + heros[i].Hp + " Energy" + heros[i].Energy + " Skills" + heros[i].Skills;
                heros.RemoveAt(i);
                return t;
            }
            else { return "the Character is not founded"; }
        }

        private Hero SHOW(int i)
        {
            if (i >= 0 && i < RETURN_col())
            {
                return heros[i];
            }
            else { return null; }
        }
    }
}
