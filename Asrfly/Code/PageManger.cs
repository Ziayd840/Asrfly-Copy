using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace Asrfly.Code
{
   public class PageManger
    {
        private readonly Main main;

        public PageManger(Main main)
        {
            this.main = main;
        }
        public void LoadPage(UserControl PageUserControl)
        {
            // load old page
            var oldpage = main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldpage != null)
            {
                main.panelContainer.Controls.Remove(oldpage);
                oldpage.Dispose();

            }
            PageUserControl.Dock = DockStyle.Fill;
            main.panelContainer.Controls.Add(PageUserControl);

        }
    }
}
