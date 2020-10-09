using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.IViews
{
    public interface IDeletercs
    {
        event EventHandler<DeleteEventArgs> ClickButtonEvent;
        void Response(string response1, string response2);
    }
    public class DeleteEventArgs : EventArgs
    {
        string index;
        public string Index { get { return index; } }
        public DeleteEventArgs(string index)
        {
            this.index = index;
        }
    }
}
