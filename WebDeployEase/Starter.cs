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
            if(UserInputValidation())
            {
                InstallationProcess installationProcess = new InstallationProcess();
                installationProcess.Show();

                this.Hide();
            }
            
        }

        private bool IsInputEmpty(TextBox textBox, string errorMessage)
        {
            if(string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show(errorMessage, "Invalid Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool UserInputValidation()
        {
            if (IsInputEmpty(txtApplicationName, "Please Define Application Name"))
                return false;

            if (IsInputEmpty(txtFolderPath, "Please Define Application Folder Path"))
                return false;

            if (IsInputEmpty(txtDatabaseName, "Please Define Database Name"))
                return false;

            return true;
        }

        private bool IsInputEmpty(string text, string v)
        {
            throw new NotImplementedException();
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