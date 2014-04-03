using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeApp.BL
{
    public interface IGeneralService
    {
        void SendMessage(string name, string email, string message);
        IEnumerable<DA.Message> GetMessages();
    }
}
