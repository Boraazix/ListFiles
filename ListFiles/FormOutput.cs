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
        private static String _path, _separator;
        private static int _cutEnd, _cutStart;
        private static bool _enumerator, _type;
        public FormOutput()
        {
            InitializeComponent();
            BuildList();
        }

        public static FormOutput GetInstance(String path, int cutStart, int cutEnd, bool enumerator, String separator, bool type)
        {
            _path = path; _separator = separator; _cutEnd = cutEnd;
            _cutStart = cutStart; _enumerator = enumerator; _type = type;

            if (_instance == null || _instance.IsDisposed)
                _instance = new FormOutput();
            _instance.WindowState = FormWindowState.Normal;

            return _instance;
        }

        private void BuildList()
        {
            StringBuilder sb = new StringBuilder();
            string[] files = Directory.GetFiles(_path);
            int start = 0 + _cutStart, count=1;
            int end = files.Length - _cutEnd;
            for (int i = start ; i < end ; i++)
            {
                if (Path.GetFileName(files[i]) == "desktop.ini")
                {
                    continue;
                }
                sb.AppendLine((_enumerator?$"{count++} {_separator} ":"")+(_type ? Path.GetFileName(files[i]) : Path.GetFileNameWithoutExtension(files[i])));
            }
            TxtOutput.Text = sb.ToString();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            TxtOutput.Text = "aa";
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
