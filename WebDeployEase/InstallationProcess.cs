using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebDeployEase
{
    public partial class InstallationProcess : Form
    {
        public InstallationProcess()
        {
            InitializeComponent();
        }

        private void InstallationProcess_Load(object sender, EventArgs e)
        {
            HideInstallationSteps();
        }

        private void HideInstallationSteps()
        {
            panelLoginDefaultDatabase.Visible = false;
            panelDatabaseCreate.Visible = false;
            panelRunningAllSP.Visible = false;
            panelRunningAllViews.Visible = false;
            panelProcessCompleted.Visible = false;
        }
    }
}
