using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flat_APP_Boilerplate
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //indicator
            pnlIndicator.Height = btnHome.Height;
            pnlIndicator.Top = btnHome.Top;
            //Home Panel display
            if (!pnlMaster.Controls.Contains(ucHome.Instance))
            {
                pnlMaster.Controls.Add(ucHome.Instance);
                ucHome.Instance.Dock = DockStyle.Fill;
                ucHome.Instance.BringToFront();
            }
            else
            {
                ucHome.Instance.BringToFront();
            }
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            //indicator
            pnlIndicator.Height = btnMessages.Height;
            pnlIndicator.Top = btnMessages.Top;
            //Messages panel display
            if (!pnlMaster.Controls.Contains(ucMessages.Instance))
            {
                pnlMaster.Controls.Add(ucMessages.Instance);
                ucMessages.Instance.Dock = DockStyle.Fill;
                ucMessages.Instance.BringToFront();
            }
            else
            {
                ucMessages.Instance.BringToFront();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //indicator
            pnlIndicator.Height = btnSave.Height;
            pnlIndicator.Top = btnSave.Top;
            if (!pnlMaster.Controls.Contains(ucSave.Instance))
            {
                pnlMaster.Controls.Add(ucSave.Instance);
                ucSave.Instance.Dock = DockStyle.Fill;
                ucSave.Instance.BringToFront();
            }
            else
            {
                ucSave.Instance.BringToFront();
            }
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            //indicator
            pnlIndicator.Height = btnShare.Height;
            pnlIndicator.Top = btnShare.Top;
            if (!pnlMaster.Controls.Contains(ucShare.Instance))
            {
                pnlMaster.Controls.Add(ucShare.Instance);
                ucShare.Instance.Dock = DockStyle.Fill;
                ucShare.Instance.BringToFront();
            }
            else
            {
                ucShare.Instance.BringToFront();
            }
        }

        private void btnDataConnection_Click(object sender, EventArgs e)
        {
            //indicator
            pnlIndicator.Height = btnDataConnection.Height;
            pnlIndicator.Top = btnDataConnection.Top;
            if (!pnlMaster.Controls.Contains(ucDatabase.Instance))
            {
                pnlMaster.Controls.Add(ucDatabase.Instance);
                ucDatabase.Instance.Dock = DockStyle.Fill;
                ucDatabase.Instance.BringToFront();
            }
            else
            {
                ucDatabase.Instance.BringToFront();
            }
        }

        private void btnPlatform_Click(object sender, EventArgs e)
        {
            //indicator
            pnlIndicator.Height = btnPlatform.Height;
            pnlIndicator.Top = btnPlatform.Top;
            if (!pnlMaster.Controls.Contains(ucPlatform.Instance))
            {
                pnlMaster.Controls.Add(ucPlatform.Instance);
                ucPlatform.Instance.Dock = DockStyle.Fill;
                ucPlatform.Instance.BringToFront();
            }
            else
            {
                ucPlatform.Instance.BringToFront();
            }
        }

        private void btnVersion_Click(object sender, EventArgs e)
        {
            //indicator
            pnlIndicator.Height = btnVersion.Height;
            pnlIndicator.Top = btnVersion.Top;
            if (!pnlMaster.Controls.Contains(ucVersion.Instance))
            {
                pnlMaster.Controls.Add(ucVersion.Instance);
                ucVersion.Instance.Dock = DockStyle.Fill;
                ucVersion.Instance.BringToFront();
            }
            else
            {
                ucVersion.Instance.BringToFront();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!pnlMaster.Controls.Contains(ucHome.Instance))
            {
                pnlMaster.Controls.Add(ucHome.Instance);
                ucHome.Instance.Dock = DockStyle.Fill;
                ucHome.Instance.BringToFront();
            }
            else
            {
                ucHome.Instance.BringToFront();
            }
        }
    }
}
