using AwesomeApp.DA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeApp.BL
{
    public class GeneralService: IGeneralService
    {
        public void SendMessage(string name, string email, string message)
        {
            DataContext _db = new DataContext();

            _db.Messages.Add(new Message() { Name = name, Email = email, Content = message, Date = DateTime.Now });
            _db.SaveChanges();
        }


        public IEnumerable<Message> GetMessages()
        {
            DataContext _db = new DataContext();

            return _db.Messages.OrderByDescending(m => m.Date).ToList();
        }
    }
}
