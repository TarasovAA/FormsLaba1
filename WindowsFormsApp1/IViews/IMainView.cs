using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.IViews
{
    public interface IMainView
    {
        //string NameNewWindow { get; }
        event EventHandler<NewWindowEventArgs> ClickButtonEvent;
    }

    public class NewWindowEventArgs : EventArgs
    {
        string windowName;
        public NewWindowEventArgs(string buttonName)
        {
            windowName = buttonName;
        }
        public string WindowName { get { return windowName; } }
    }
}
