namespace ListFiles
{
    partial class FormOutput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOutput));
            PnlMain = new Panel();
            LblCopied = new Label();
            BtnCopy = new Button();
            BtnBack = new Button();
            TxtOutput = new TextBox();
            PnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // PnlMain
            // 
            PnlMain.Controls.Add(LblCopied);
            PnlMain.Controls.Add(BtnCopy);
            PnlMain.Controls.Add(BtnBack);
            PnlMain.Controls.Add(TxtOutput);
            PnlMain.Location = new Point(0, 0);
            PnlMain.Name = "PnlMain";
            PnlMain.Size = new Size(516, 415);
            PnlMain.TabIndex = 0;
            // 
            // LblCopied
            // 
            LblCopied.AutoSize = true;
            LblCopied.ForeColor = Color.Green;
            LblCopied.Location = new Point(258, 388);
            LblCopied.Name = "LblCopied";
            LblCopied.Size = new Size(84, 15);
            LblCopied.TabIndex = 3;
            LblCopied.Text = "Texto copiado!";
            LblCopied.Visible = false;
            // 
            // BtnCopy
            // 
            BtnCopy.Location = new Point(348, 384);
            BtnCopy.Name = "BtnCopy";
            BtnCopy.Size = new Size(75, 23);
            BtnCopy.TabIndex = 2;
            BtnCopy.Text = "Copiar";
            BtnCopy.UseVisualStyleBackColor = true;
            BtnCopy.Click += BtnCopy_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(429, 384);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(75, 23);
            BtnBack.TabIndex = 1;
            BtnBack.Text = "Voltar";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // TxtOutput
            // 
            TxtOutput.Font = new Font("Segoe UI", 10F);
            TxtOutput.Location = new Point(12, 12);
            TxtOutput.MaxLength = 999999999;
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.PlaceholderText = "Sem arquivos :/";
            TxtOutput.ReadOnly = true;
            TxtOutput.ScrollBars = ScrollBars.Both;
            TxtOutput.Size = new Size(492, 366);
            TxtOutput.TabIndex = 0;
            // 
            // FormOutput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 415);
            Controls.Add(PnlMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(532, 454);
            MinimumSize = new Size(532, 454);
            Name = "FormOutput";
            Text = "Lista";
            PnlMain.ResumeLayout(false);
            PnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMain;
        private TextBox TxtOutput;
        private Button BtnCopy;
        private Button BtnBack;
        private Label LblCopied;
    }
}