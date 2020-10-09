using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp1.Models
{
    class HeroesContext:DbContext
    {
        public HeroesContext(): base("DefaultConnection")
        {

        }
        public DbSet<Hero> Heroes { get; set; }
    }
}
