using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace SharepointWebPartToolPane.VisualWebPartToolPane
{
    public partial class VisualWebPartToolPaneUserControl : UserControl
    {
        VisualWebPartToolPane webpart;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Parent is VisualWebPartToolPane)
            {
                webpart = (VisualWebPartToolPane)this.Parent;
            }

            lblText.Text = webpart._YunusEmreWebPartTitle;
        }
    }
}
