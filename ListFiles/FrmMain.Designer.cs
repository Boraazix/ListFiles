namespace ListFiles
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PnlMain = new Panel();
            GrpParameters = new GroupBox();
            ChkType = new CheckBox();
            TxtSeparator = new TextBox();
            LblSeparator = new Label();
            LblIgnoreAtFirst = new Label();
            NudIgnoreAtFirst = new NumericUpDown();
            BtnGenerateList = new Button();
            LblIgnoreAtTheFinal = new Label();
            ChkEnum = new CheckBox();
            NudIgnoreAtTheFinal = new NumericUpDown();
            GrpFolder = new GroupBox();
            LblFolder = new Label();
            TxtFolder = new TextBox();
            BtnSearchFolder = new Button();
            FbdSearchFolder = new FolderBrowserDialog();
            PnlMain.SuspendLayout();
            GrpParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudIgnoreAtFirst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudIgnoreAtTheFinal).BeginInit();
            GrpFolder.SuspendLayout();
            SuspendLayout();
            // 
            // PnlMain
            // 
            PnlMain.Controls.Add(GrpParameters);
            PnlMain.Controls.Add(GrpFolder);
            PnlMain.Location = new Point(0, 0);
            PnlMain.Name = "PnlMain";
            PnlMain.Size = new Size(423, 179);
            PnlMain.TabIndex = 0;
            // 
            // GrpParameters
            // 
            GrpParameters.Controls.Add(ChkType);
            GrpParameters.Controls.Add(TxtSeparator);
            GrpParameters.Controls.Add(LblSeparator);
            GrpParameters.Controls.Add(LblIgnoreAtFirst);
            GrpParameters.Controls.Add(NudIgnoreAtFirst);
            GrpParameters.Controls.Add(BtnGenerateList);
            GrpParameters.Controls.Add(LblIgnoreAtTheFinal);
            GrpParameters.Controls.Add(ChkEnum);
            GrpParameters.Controls.Add(NudIgnoreAtTheFinal);
            GrpParameters.Location = new Point(12, 79);
            GrpParameters.Name = "GrpParameters";
            GrpParameters.Size = new Size(400, 90);
            GrpParameters.TabIndex = 1;
            GrpParameters.TabStop = false;
            GrpParameters.Text = "Parâmetros dos arquivos";
            // 
            // ChkType
            // 
            ChkType.AutoSize = true;
            ChkType.Font = new Font("Segoe UI", 10F);
            ChkType.Location = new Point(309, 22);
            ChkType.Name = "ChkType";
            ChkType.Size = new Size(54, 23);
            ChkType.TabIndex = 4;
            ChkType.Text = "Tipo";
            ChkType.UseVisualStyleBackColor = true;
            // 
            // TxtSeparator
            // 
            TxtSeparator.Font = new Font("Segoe UI", 11F);
            TxtSeparator.Location = new Point(267, 50);
            TxtSeparator.MaxLength = 1;
            TxtSeparator.Name = "TxtSeparator";
            TxtSeparator.Size = new Size(21, 27);
            TxtSeparator.TabIndex = 3;
            TxtSeparator.Text = "-";
            TxtSeparator.TextAlign = HorizontalAlignment.Center;
            // 
            // LblSeparator
            // 
            LblSeparator.AutoSize = true;
            LblSeparator.Font = new Font("Segoe UI", 10F);
            LblSeparator.Location = new Point(187, 51);
            LblSeparator.Name = "LblSeparator";
            LblSeparator.Size = new Size(74, 19);
            LblSeparator.TabIndex = 9;
            LblSeparator.Text = "Separador:";
            // 
            // LblIgnoreAtFirst
            // 
            LblIgnoreAtFirst.AutoSize = true;
            LblIgnoreAtFirst.Font = new Font("Segoe UI", 10F);
            LblIgnoreAtFirst.Location = new Point(11, 22);
            LblIgnoreAtFirst.Name = "LblIgnoreAtFirst";
            LblIgnoreAtFirst.Size = new Size(112, 19);
            LblIgnoreAtFirst.TabIndex = 3;
            LblIgnoreAtFirst.Text = "Ignorar no início:";
            // 
            // NudIgnoreAtFirst
            // 
            NudIgnoreAtFirst.Location = new Point(129, 22);
            NudIgnoreAtFirst.Name = "NudIgnoreAtFirst";
            NudIgnoreAtFirst.Size = new Size(44, 23);
            NudIgnoreAtFirst.TabIndex = 0;
            // 
            // BtnGenerateList
            // 
            BtnGenerateList.Location = new Point(307, 53);
            BtnGenerateList.Name = "BtnGenerateList";
            BtnGenerateList.Size = new Size(75, 23);
            BtnGenerateList.TabIndex = 5;
            BtnGenerateList.Text = "Gerar lista";
            BtnGenerateList.UseVisualStyleBackColor = true;
            // 
            // LblIgnoreAtTheFinal
            // 
            LblIgnoreAtTheFinal.AutoSize = true;
            LblIgnoreAtTheFinal.Font = new Font("Segoe UI", 10F);
            LblIgnoreAtTheFinal.Location = new Point(11, 51);
            LblIgnoreAtTheFinal.Name = "LblIgnoreAtTheFinal";
            LblIgnoreAtTheFinal.Size = new Size(106, 19);
            LblIgnoreAtTheFinal.TabIndex = 5;
            LblIgnoreAtTheFinal.Text = "Ignorar no final:";
            // 
            // ChkEnum
            // 
            ChkEnum.AutoSize = true;
            ChkEnum.Checked = true;
            ChkEnum.CheckState = CheckState.Checked;
            ChkEnum.Font = new Font("Segoe UI", 10F);
            ChkEnum.Location = new Point(192, 22);
            ChkEnum.Name = "ChkEnum";
            ChkEnum.Size = new Size(103, 23);
            ChkEnum.TabIndex = 2;
            ChkEnum.Text = "Enumeração";
            ChkEnum.UseVisualStyleBackColor = true;
            ChkEnum.CheckedChanged += ChkEnum_CheckedChanged;
            // 
            // NudIgnoreAtTheFinal
            // 
            NudIgnoreAtTheFinal.Location = new Point(129, 51);
            NudIgnoreAtTheFinal.Name = "NudIgnoreAtTheFinal";
            NudIgnoreAtTheFinal.Size = new Size(44, 23);
            NudIgnoreAtTheFinal.TabIndex = 1;
            // 
            // GrpFolder
            // 
            GrpFolder.Controls.Add(LblFolder);
            GrpFolder.Controls.Add(TxtFolder);
            GrpFolder.Controls.Add(BtnSearchFolder);
            GrpFolder.Location = new Point(11, 12);
            GrpFolder.Name = "GrpFolder";
            GrpFolder.Size = new Size(401, 61);
            GrpFolder.TabIndex = 0;
            GrpFolder.TabStop = false;
            GrpFolder.Text = "Diretório";
            // 
            // LblFolder
            // 
            LblFolder.AutoSize = true;
            LblFolder.Font = new Font("Segoe UI", 10F);
            LblFolder.Location = new Point(12, 23);
            LblFolder.Name = "LblFolder";
            LblFolder.Size = new Size(45, 19);
            LblFolder.TabIndex = 0;
            LblFolder.Text = "Pasta:";
            // 
            // TxtFolder
            // 
            TxtFolder.Location = new Point(63, 22);
            TxtFolder.Name = "TxtFolder";
            TxtFolder.Size = new Size(239, 23);
            TxtFolder.TabIndex = 0;
            // 
            // BtnSearchFolder
            // 
            BtnSearchFolder.Location = new Point(308, 22);
            BtnSearchFolder.Name = "BtnSearchFolder";
            BtnSearchFolder.Size = new Size(75, 23);
            BtnSearchFolder.TabIndex = 1;
            BtnSearchFolder.Text = "Procurar";
            BtnSearchFolder.UseVisualStyleBackColor = true;
            BtnSearchFolder.Click += BtnSearchFolder_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 179);
            Controls.Add(PnlMain);
            Name = "FormMain";
            Text = "Listar Arquivos";
            PnlMain.ResumeLayout(false);
            GrpParameters.ResumeLayout(false);
            GrpParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudIgnoreAtFirst).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudIgnoreAtTheFinal).EndInit();
            GrpFolder.ResumeLayout(false);
            GrpFolder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMain;
        private FolderBrowserDialog FbdSearchFolder;
        private Button BtnSearchFolder;
        private TextBox TxtFolder;
        private Label LblFolder;
        private Label LblIgnoreAtFirst;
        private NumericUpDown NudIgnoreAtTheFinal;
        private Label LblIgnoreAtTheFinal;
        private NumericUpDown NudIgnoreAtFirst;
        private GroupBox GrpFolder;
        private Button BtnGenerateList;
        private CheckBox ChkEnum;
        private GroupBox GrpParameters;
        private TextBox TxtSeparator;
        private Label LblSeparator;
        private CheckBox ChkType;
    }
}
