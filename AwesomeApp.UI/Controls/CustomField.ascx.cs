using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AwesomeApp.UI.Controls
{
    public partial class CustomField : System.Web.UI.UserControl
    {
        public string LabelValue
        {
            get
            {
                return lblLabel.Text;
            }
            set
            {
                lblLabel.Text = value;
            }
        }

        public string InputValue
        {
            get
            {
                return txtInput.Text;
            }
            set
            {
                txtInput.Text = value;
            }
        }

        public TextBoxMode InputType
        {
            get
            {
                return txtInput.TextMode;
            }
            set
            {
                txtInput.TextMode = value;
            }
        }

        private bool _isRequired = false;
        public bool IsRequired
        {
            set
            {
                _isRequired = value;
            }
        }

        public string RequiredValidationError
        {
            set
            {
                rfvInput.Text = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            rfvInput.Enabled = _isRequired;
        }
    }
}