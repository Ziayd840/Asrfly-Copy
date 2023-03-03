using Asrfly.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asrfly.Gui;

namespace Asrfly
{
    public partial class Main : Form
    {
        private readonly PageManger pageManger;
        public Main()
        {
            InitializeComponent();
            pageManger = new PageManger(this);
            pageManger.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
        }
        #region Events

        private void buttonHome_Click(object sender, EventArgs e)
        {
            pageManger.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
               
        }
        #endregion
    }
}
