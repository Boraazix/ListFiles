using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListFiles
{
    public partial class FormOutput : Form
    {
        private static FormOutput _instance;
        public FormOutput()
        {
            InitializeComponent();
        }

        static FormOutput()
        {
            _instance = GetInstance();
        }

        public static FormOutput GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new FormOutput();
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if(TxtOutput.Text != "")
            {
                Clipboard.SetText(TxtOutput.Text);
                LblCopied.Visible = true;
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 2000;
                timer.Tick += (senderTimer, eTimer) =>
                {
                    LblCopied.Visible = false;
                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();
            }
        }
    }
}
