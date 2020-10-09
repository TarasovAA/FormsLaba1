using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.IViews
{
    public interface IShowEveryone
    {
        event EventHandler ShowEvent;
        void Response(IEnumerable<Hero> heros);
    }
}
