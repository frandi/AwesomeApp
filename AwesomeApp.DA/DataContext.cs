using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeApp.DA
{
    public class DataContext: DbContext
    {
        public DbSet<Message> Messages { get; set; }
    }
}
