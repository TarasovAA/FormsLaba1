using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.IViews
{
    public interface INew
    {
        event EventHandler<NewHeroForEventArgs> ClickButtonEvent;
    }
    public class NewHeroForEventArgs : EventArgs
    {
        string name;
        int hp;
        int energy;
        string skills;
        public NewHeroForEventArgs(string a, int b, int c, string d)
        {
           
            name = a;
            hp = b;
            energy = c;
            skills = d;
        }
        public string Name { get { return name; } }
        public int HP { get { return hp; } }
        public int Energy { get { return energy; } }
        public string Skills { get { return skills; } }
    }
}
