using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCommanderKrupa
{
    public partial class Form1 : Form, IView
    {
        IPanel activePanel;
        IPanel passivePanel;

        public Form1()
        {
            InitializeComponent();
        }

        #region IView
        public IPanel LeftPanel
        {
            get
            {
                return tcPanelLeft;
            }
        }

        public IPanel RightPanel
        {
            get
            {
                return tcPanelRight;
            }
        }
        #endregion

        private void tcPanelLeft_Click(object sender, EventArgs e)
        {
            activePanel = LeftPanel;
            passivePanel = RightPanel;
            tcPanelLeft.BackColor = Color.Aqua;
            tcPanelRight.BackColor = Color.Gainsboro;
        }

        private void tcPanelRight_Click(object sender, EventArgs e)
        {
            activePanel = RightPanel;
            passivePanel = LeftPanel;
            tcPanelLeft.BackColor = Color.Gainsboro;
            tcPanelRight.BackColor = Color.Aqua;
        }

        public event Action<IPanel, IPanel> Copy;
        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            if (Copy != null)
            {
                Copy(activePanel, passivePanel);
            }
        }

        public event Action<IPanel, IPanel> Move;
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (Move != null)
            {
                Move(activePanel, passivePanel);
            }
        }
    }
}
