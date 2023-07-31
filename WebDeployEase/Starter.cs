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
            bool IsValidate = UserInputValidation();

            if(IsValidate)
            {
                InstallationProcess installationProcess = new InstallationProcess();
                installationProcess.Show();

                this.Hide();
            }
            
        }

        private bool UserInputValidation()
        {
            if(string.IsNullOrEmpty(txtApplicationName.Text))
            {
                MessageBox.Show("Please Define Application Name", "Invalid Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtFolderPath.Text))
            {
                MessageBox.Show("Please Define Application Folder Path", "Invalid Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtDatabaseName.Text))
            {
                MessageBox.Show("Please Define Database Name", "Invalid Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
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