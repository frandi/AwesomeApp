using AwesomeApp.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AwesomeApp.UI
{
    public partial class Contact : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuItem = "contact";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = fieldName.InputValue;
            string email = fieldEmail.InputValue;
            string message = fieldMessage.InputValue;

            IGeneralService service = new GeneralService();
            service.SendMessage(name, email, message);

            lblMessage.Text = "Thank you, your message has been sent.";

        }
    }
}