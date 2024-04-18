namespace ListFiles
{
    public partial class FormMain : Form
    {
        private static FormMain _instance;
        public FormMain()
        {
            InitializeComponent();
        }
        static FormMain()
        {
            _instance = GetInstance();
        }
        public static FormMain GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new FormMain();
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void BtnSearchFolder_Click(object sender, EventArgs e)
        {
            if (FbdSearchFolder.ShowDialog() == DialogResult.OK)
                TxtFolder.Text = FbdSearchFolder.SelectedPath;
        }
        private void BtnGenerateList_Click(object sender, EventArgs e)
        {
            FormOutput.GetInstance().Show();
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
