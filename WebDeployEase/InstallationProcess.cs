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

        private void ProcessToLoginDefaultDatabase()
        {
            Thread.Sleep(2000);
            panelLoginDefaultDatabase.Visible = true;

            ProcessToCreateDatabase();
        }

        private void ProcessToCreateDatabase()
        {
            Thread.Sleep(2000);
            panelDatabaseCreate.Visible = true;

            ProcessToRunAllStoreProcedure();
        }

        private void ProcessToRunAllStoreProcedure()
        {
            Thread.Sleep(2000);
            panelRunningAllSP.Visible = true;

            ProcessToRunAllViews();
        }

        private void ProcessToRunAllViews()
        {
            Thread.Sleep(2000);
            panelRunningAllViews.Visible = true;

            ProcessToCompleteInstallation();
        }

        private void ProcessToCompleteInstallation()
        {
            Thread.Sleep(2000);
            panelProcessCompleted.Visible = true;

            // Close Intallation Progress Bar
            pnlInstalling.Visible = false;
        }
    }
}
