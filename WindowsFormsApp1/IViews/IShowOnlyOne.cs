using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.IViews
{
    public interface IShowOnlyOne
    {
        event EventHandler<OnesIndexEventArgs> TryFindOneEvent;
        void Response(Hero hero);
    }

    public class OnesIndexEventArgs : EventArgs
    {
        private int? index;
        public int? Index { get { return index; } }
        public OnesIndexEventArgs(string index)
        {
            int i;
            if(Int32.TryParse(index, out i))
            {
                this.index = i;
            }
        }
    }
}
