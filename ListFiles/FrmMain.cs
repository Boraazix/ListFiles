namespace ListFiles
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnSearchFolder_Click(object sender, EventArgs e)
        {
            if (FbdSearchFolder.ShowDialog() == DialogResult.OK)
                TxtFolder.Text = FbdSearchFolder.SelectedPath;
        }

        private void ChkEnum_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkEnum.Checked)
            {
                TxtSeparator.Enabled = true;
            }
            else
            {
                TxtSeparator.Enabled = false;
            }
        }
    }
}
