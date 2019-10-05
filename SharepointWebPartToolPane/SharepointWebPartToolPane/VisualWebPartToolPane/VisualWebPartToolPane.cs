using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace SharepointWebPartToolPane.VisualWebPartToolPane
{
    [ToolboxItemAttribute(false)]
    public class VisualWebPartToolPane : WebPart
    {
        // Visual Studio might automatically update this path when you change the Visual Web Part project item.
        private const string _ascxPath = @"~/_CONTROLTEMPLATES/15/SharepointWebPartToolPane/VisualWebPartToolPane/VisualWebPartToolPaneUserControl.ascx";

        protected override void CreateChildControls()
        {
            Control control = Page.LoadControl(_ascxPath);
            Controls.Add(control);
        }

        public string YunusEmreWebPartTitle;
        [Category("Yunus Emre Webpart Settings"),
        Personalizable(PersonalizationScope.Shared),
        WebBrowsable(true),
        WebDisplayName("Yunus Emre WebPart Title"),
        WebDescription("Yunus Emre WebPart Title")]
        public string _YunusEmreWebPartTitle
        {
            get { return YunusEmreWebPartTitle; }
            set { YunusEmreWebPartTitle = value; }
        }
    }
}
