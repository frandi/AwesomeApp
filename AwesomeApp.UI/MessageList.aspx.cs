using AwesomeApp.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AwesomeApp.UI
{
    public partial class MessageList : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuItem = "contact";
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<AwesomeApp.DA.Message> gvMessages_GetData()
        {
            IGeneralService service = new GeneralService();
            var items = service.GetMessages();
            return items.AsQueryable();
        }
    }
}