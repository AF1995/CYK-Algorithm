namespace CYK
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtSentense = new System.Windows.Forms.TextBox();
            this.lblSentense = new System.Windows.Forms.Label();
            this.grpAddGrammar = new System.Windows.Forms.GroupBox();
            this.chkIsAxiome = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtNonTerminal = new System.Windows.Forms.TextBox();
            this.lblNonTerminal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.cboTokens = new System.Windows.Forms.ComboBox();
            this.lblTokens = new System.Windows.Forms.Label();
            this.lblTokenization = new System.Windows.Forms.Label();
            this.lblTokenizationResult = new System.Windows.Forms.Label();
            this.lblCYKAlgorithmResult = new System.Windows.Forms.Label();
            this.lblCYKAlgorithm = new System.Windows.Forms.Label();
            this.grdCYKTable = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpAddGrammar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCYKTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.grpInput);
            this.splitContainer1.Panel1.Controls.Add(this.grpAddGrammar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Size = new System.Drawing.Size(243, 214);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.btnValidate);
            this.grpInput.Controls.Add(this.lblResult);
            this.grpInput.Controls.Add(this.txtSentense);
            this.grpInput.Controls.Add(this.lblSentense);
            this.grpInput.Location = new System.Drawing.Point(359, 33);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(381, 149);
            this.grpInput.TabIndex = 1;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input:";
            this.grpInput.Visible = false;
            // 
            // btnValidate
            // 
            this.btnValidate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnValidate.Location = new System.Drawing.Point(149, 57);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(115, 44);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(162, 111);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(88, 24);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Rejected";
            // 
            // txtSentense
            // 
            this.txtSentense.Location = new System.Drawing.Point(81, 23);
            this.txtSentense.Name = "txtSentense";
            this.txtSentense.Size = new System.Drawing.Size(294, 24);
            this.txtSentense.TabIndex = 1;
            this.txtSentense.TextChanged += new System.EventHandler(this.txtSentense_TextChanged);
            // 
            // lblSentense
            // 
            this.lblSentense.AutoSize = true;
            this.lblSentense.Location = new System.Drawing.Point(6, 30);
            this.lblSentense.Name = "lblSentense";
            this.lblSentense.Size = new System.Drawing.Size(69, 17);
            this.lblSentense.TabIndex = 0;
            this.lblSentense.Text = "Sentense:";
            // 
            // grpAddGrammar
            // 
            this.grpAddGrammar.Controls.Add(this.chkIsAxiome);
            this.grpAddGrammar.Controls.Add(this.btnAdd);
            this.grpAddGrammar.Controls.Add(this.txtValue);
            this.grpAddGrammar.Controls.Add(this.lblValue);
            this.grpAddGrammar.Controls.Add(this.txtNonTerminal);
            this.grpAddGrammar.Controls.Add(this.lblNonTerminal);
            this.grpAddGrammar.Location = new System.Drawing.Point(42, 33);
            this.grpAddGrammar.Name = "grpAddGrammar";
            this.grpAddGrammar.Size = new System.Drawing.Size(311, 149);
            this.grpAddGrammar.TabIndex = 0;
            this.grpAddGrammar.TabStop = false;
            this.grpAddGrammar.Text = "Add Grammar:";
            // 
            // chkIsAxiome
            // 
            this.chkIsAxiome.AutoSize = true;
            this.chkIsAxiome.Checked = true;
            this.chkIsAxiome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsAxiome.Location = new System.Drawing.Point(213, 103);
            this.chkIsAxiome.Name = "chkIsAxiome";
            this.chkIsAxiome.Size = new System.Drawing.Size(89, 21);
            this.chkIsAxiome.TabIndex = 5;
            this.chkIsAxiome.Text = "Is Axiome";
            this.chkIsAxiome.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(132, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(132, 67);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(153, 24);
            this.txtValue.TabIndex = 3;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(81, 74);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(45, 17);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Value:";
            // 
            // txtNonTerminal
            // 
            this.txtNonTerminal.Location = new System.Drawing.Point(132, 32);
            this.txtNonTerminal.Name = "txtNonTerminal";
            this.txtNonTerminal.Size = new System.Drawing.Size(153, 24);
            this.txtNonTerminal.TabIndex = 1;
            // 
            // lblNonTerminal
            // 
            this.lblNonTerminal.AutoSize = true;
            this.lblNonTerminal.Location = new System.Drawing.Point(32, 35);
            this.lblNonTerminal.Name = "lblNonTerminal";
            this.lblNonTerminal.Size = new System.Drawing.Size(94, 17);
            this.lblNonTerminal.TabIndex = 0;
            this.lblNonTerminal.Text = "Non-Terminal:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Enabled = false;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splitContainer1);
            this.pnlMain.Location = new System.Drawing.Point(40, 61);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(243, 214);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlDetails
            // 
            this.pnlDetails.AutoScroll = true;
            this.pnlDetails.Controls.Add(this.splitContainer2);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetails.Location = new System.Drawing.Point(0, 28);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(753, 474);
            this.pnlDetails.TabIndex = 3;
            this.pnlDetails.Visible = false;
            // 
            // cboTokens
            // 
            this.cboTokens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTokens.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cboTokens.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboTokens.FormattingEnabled = true;
            this.cboTokens.Location = new System.Drawing.Point(91, 118);
            this.cboTokens.Name = "cboTokens";
            this.cboTokens.Size = new System.Drawing.Size(193, 32);
            this.cboTokens.TabIndex = 1;
            // 
            // lblTokens
            // 
            this.lblTokens.AutoSize = true;
            this.lblTokens.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTokens.Location = new System.Drawing.Point(4, 121);
            this.lblTokens.Name = "lblTokens";
            this.lblTokens.Size = new System.Drawing.Size(81, 24);
            this.lblTokens.TabIndex = 0;
            this.lblTokens.Text = "Tokens:";
            // 
            // lblTokenization
            // 
            this.lblTokenization.AutoSize = true;
            this.lblTokenization.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblTokenization.Location = new System.Drawing.Point(3, 8);
            this.lblTokenization.Name = "lblTokenization";
            this.lblTokenization.Size = new System.Drawing.Size(154, 29);
            this.lblTokenization.TabIndex = 2;
            this.lblTokenization.Text = "Tokenization:";
            // 
            // lblTokenizationResult
            // 
            this.lblTokenizationResult.AutoSize = true;
            this.lblTokenizationResult.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblTokenizationResult.ForeColor = System.Drawing.Color.Red;
            this.lblTokenizationResult.Location = new System.Drawing.Point(153, 8);
            this.lblTokenizationResult.Name = "lblTokenizationResult";
            this.lblTokenizationResult.Size = new System.Drawing.Size(90, 29);
            this.lblTokenizationResult.TabIndex = 3;
            this.lblTokenizationResult.Text = "FAILED";
            this.lblTokenizationResult.Visible = false;
            // 
            // lblCYKAlgorithmResult
            // 
            this.lblCYKAlgorithmResult.AutoSize = true;
            this.lblCYKAlgorithmResult.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblCYKAlgorithmResult.ForeColor = System.Drawing.Color.Red;
            this.lblCYKAlgorithmResult.Location = new System.Drawing.Point(177, 47);
            this.lblCYKAlgorithmResult.Name = "lblCYKAlgorithmResult";
            this.lblCYKAlgorithmResult.Size = new System.Drawing.Size(90, 29);
            this.lblCYKAlgorithmResult.TabIndex = 5;
            this.lblCYKAlgorithmResult.Text = "FAILED";
            this.lblCYKAlgorithmResult.Visible = false;
            // 
            // lblCYKAlgorithm
            // 
            this.lblCYKAlgorithm.AutoSize = true;
            this.lblCYKAlgorithm.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblCYKAlgorithm.Location = new System.Drawing.Point(3, 47);
            this.lblCYKAlgorithm.Name = "lblCYKAlgorithm";
            this.lblCYKAlgorithm.Size = new System.Drawing.Size(171, 29);
            this.lblCYKAlgorithm.TabIndex = 4;
            this.lblCYKAlgorithm.Text = "CYK Algorithm:";
            // 
            // grdCYKTable
            // 
            this.grdCYKTable.AllowUserToAddRows = false;
            this.grdCYKTable.AllowUserToDeleteRows = false;
            this.grdCYKTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCYKTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCYKTable.Location = new System.Drawing.Point(0, 0);
            this.grdCYKTable.Name = "grdCYKTable";
            this.grdCYKTable.ReadOnly = true;
            this.grdCYKTable.RowHeadersWidth = 51;
            this.grdCYKTable.RowTemplate.Height = 26;
            this.grdCYKTable.Size = new System.Drawing.Size(751, 148);
            this.grdCYKTable.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.lblTokenization);
            this.splitContainer2.Panel1.Controls.Add(this.lblCYKAlgorithmResult);
            this.splitContainer2.Panel1.Controls.Add(this.lblTokens);
            this.splitContainer2.Panel1.Controls.Add(this.lblCYKAlgorithm);
            this.splitContainer2.Panel1.Controls.Add(this.cboTokens);
            this.splitContainer2.Panel1.Controls.Add(this.lblTokenizationResult);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(753, 474);
            this.splitContainer2.SplitterDistance = 170;
            this.splitContainer2.TabIndex = 7;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.AutoScroll = true;
            this.splitContainer3.Panel1.Controls.Add(this.grdCYKTable);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.AutoScroll = true;
            this.splitContainer3.Size = new System.Drawing.Size(753, 300);
            this.splitContainer3.SplitterDistance = 150;
            this.splitContainer3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 502);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CYK Algorithm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpAddGrammar.ResumeLayout(false);
            this.grpAddGrammar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCYKTable)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpAddGrammar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtNonTerminal;
        private System.Windows.Forms.Label lblNonTerminal;
        private System.Windows.Forms.CheckBox chkIsAxiome;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtSentense;
        private System.Windows.Forms.Label lblSentense;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.ComboBox cboTokens;
        private System.Windows.Forms.Label lblTokens;
        private System.Windows.Forms.Label lblTokenizationResult;
        private System.Windows.Forms.Label lblTokenization;
        private System.Windows.Forms.Label lblCYKAlgorithmResult;
        private System.Windows.Forms.Label lblCYKAlgorithm;
        private System.Windows.Forms.DataGridView grdCYKTable;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}

