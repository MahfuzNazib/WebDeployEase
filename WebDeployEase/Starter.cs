namespace WebDeployEase
{
    public partial class Starter : Form
    {
        public Starter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtApplicationName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            InstallationProcess installationProcess = new InstallationProcess();
            installationProcess.Show();

            this.Hide();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void backgroundProgress_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Starter_Load(object sender, EventArgs e)
        {
            
        }

        private void txtFolderPath_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOpenFolderPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowserDialog.SelectedPath;
            }
            else
            {
                MessageBox.Show("Please Select a Application Folder Path");
            }
        }
    }
}