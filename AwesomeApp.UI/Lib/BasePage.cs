using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwesomeApp.UI
{
    public abstract class BasePage : System.Web.UI.Page
    {
        private string _menuItem;
        public string MenuItem
        {
            get { return _menuItem; }
            set { _menuItem = value; }
        }

    }
}