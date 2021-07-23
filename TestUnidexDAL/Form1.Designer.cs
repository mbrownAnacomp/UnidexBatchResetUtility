
namespace TestUnidexDAL
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpDatabase = new System.Windows.Forms.GroupBox();
            this.rbLoosePaperUAT = new System.Windows.Forms.RadioButton();
            this.rbBumedUAT = new System.Windows.Forms.RadioButton();
            this.rbLoosePaper = new System.Windows.Forms.RadioButton();
            this.rbBUMED = new System.Windows.Forms.RadioButton();
            this.grpOperation = new System.Windows.Forms.GroupBox();
            this.rbCreateBox = new System.Windows.Forms.RadioButton();
            this.rbPDFAFinish = new System.Windows.Forms.RadioButton();
            this.rbDeleteIBMLBatch = new System.Windows.Forms.RadioButton();
            this.rbPrepComplete = new System.Windows.Forms.RadioButton();
            this.rbBlankCheck = new System.Windows.Forms.RadioButton();
            this.rbUnitizerFinished = new System.Windows.Forms.RadioButton();
            this.rbUnidexFinished = new System.Windows.Forms.RadioButton();
            this.rbQAMNRA = new System.Windows.Forms.RadioButton();
            this.rbPulledPriority = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.grpDatabase.SuspendLayout();
            this.grpOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 282);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(122, 199);
            this.listBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(227, 282);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(404, 199);
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "UnidexBumed",
            "UnidexBumedLoosePaper",
            "UnidexUAT"});
            this.comboBox1.Location = new System.Drawing.Point(429, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Run Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpDatabase
            // 
            this.grpDatabase.Controls.Add(this.rbLoosePaperUAT);
            this.grpDatabase.Controls.Add(this.rbBumedUAT);
            this.grpDatabase.Controls.Add(this.rbLoosePaper);
            this.grpDatabase.Controls.Add(this.rbBUMED);
            this.grpDatabase.Location = new System.Drawing.Point(12, 49);
            this.grpDatabase.Name = "grpDatabase";
            this.grpDatabase.Size = new System.Drawing.Size(253, 147);
            this.grpDatabase.TabIndex = 6;
            this.grpDatabase.TabStop = false;
            this.grpDatabase.Text = "Select Project";
            // 
            // rbLoosePaperUAT
            // 
            this.rbLoosePaperUAT.AutoSize = true;
            this.rbLoosePaperUAT.Location = new System.Drawing.Point(21, 101);
            this.rbLoosePaperUAT.Name = "rbLoosePaperUAT";
            this.rbLoosePaperUAT.Size = new System.Drawing.Size(110, 17);
            this.rbLoosePaperUAT.TabIndex = 3;
            this.rbLoosePaperUAT.TabStop = true;
            this.rbLoosePaperUAT.Text = "Loose Paper UAT";
            this.rbLoosePaperUAT.UseVisualStyleBackColor = true;
            this.rbLoosePaperUAT.CheckedChanged += new System.EventHandler(this.rbLoosePaperUAT_CheckedChanged);
            // 
            // rbBumedUAT
            // 
            this.rbBumedUAT.AutoSize = true;
            this.rbBumedUAT.Location = new System.Drawing.Point(21, 78);
            this.rbBumedUAT.Name = "rbBumedUAT";
            this.rbBumedUAT.Size = new System.Drawing.Size(89, 17);
            this.rbBumedUAT.TabIndex = 2;
            this.rbBumedUAT.TabStop = true;
            this.rbBumedUAT.Text = "BUMED UAT";
            this.rbBumedUAT.UseVisualStyleBackColor = true;
            this.rbBumedUAT.CheckedChanged += new System.EventHandler(this.rbBumedUAT_CheckedChanged);
            // 
            // rbLoosePaper
            // 
            this.rbLoosePaper.AutoSize = true;
            this.rbLoosePaper.Location = new System.Drawing.Point(21, 55);
            this.rbLoosePaper.Name = "rbLoosePaper";
            this.rbLoosePaper.Size = new System.Drawing.Size(85, 17);
            this.rbLoosePaper.TabIndex = 1;
            this.rbLoosePaper.TabStop = true;
            this.rbLoosePaper.Text = "Loose Paper";
            this.rbLoosePaper.UseVisualStyleBackColor = true;
            this.rbLoosePaper.CheckedChanged += new System.EventHandler(this.rbLoosePaper_CheckedChanged);
            // 
            // rbBUMED
            // 
            this.rbBUMED.AutoSize = true;
            this.rbBUMED.Location = new System.Drawing.Point(21, 32);
            this.rbBUMED.Name = "rbBUMED";
            this.rbBUMED.Size = new System.Drawing.Size(100, 17);
            this.rbBUMED.TabIndex = 0;
            this.rbBUMED.TabStop = true;
            this.rbBUMED.Text = "Unidex BUMED";
            this.rbBUMED.UseVisualStyleBackColor = true;
            this.rbBUMED.CheckedChanged += new System.EventHandler(this.rbBUMED_CheckedChanged);
            // 
            // grpOperation
            // 
            this.grpOperation.Controls.Add(this.rbCreateBox);
            this.grpOperation.Controls.Add(this.rbPDFAFinish);
            this.grpOperation.Controls.Add(this.rbDeleteIBMLBatch);
            this.grpOperation.Controls.Add(this.rbPrepComplete);
            this.grpOperation.Controls.Add(this.rbBlankCheck);
            this.grpOperation.Controls.Add(this.rbUnitizerFinished);
            this.grpOperation.Controls.Add(this.rbUnidexFinished);
            this.grpOperation.Controls.Add(this.rbQAMNRA);
            this.grpOperation.Controls.Add(this.rbPulledPriority);
            this.grpOperation.Location = new System.Drawing.Point(337, 49);
            this.grpOperation.Name = "grpOperation";
            this.grpOperation.Size = new System.Drawing.Size(464, 204);
            this.grpOperation.TabIndex = 7;
            this.grpOperation.TabStop = false;
            this.grpOperation.Text = "Select Operation";
            this.grpOperation.Validated += new System.EventHandler(this.grpOperation_Validated);
            // 
            // rbCreateBox
            // 
            this.rbCreateBox.AutoSize = true;
            this.rbCreateBox.Location = new System.Drawing.Point(283, 170);
            this.rbCreateBox.Name = "rbCreateBox";
            this.rbCreateBox.Size = new System.Drawing.Size(140, 17);
            this.rbCreateBox.TabIndex = 8;
            this.rbCreateBox.TabStop = true;
            this.rbCreateBox.Text = "Create Loose Paper Box";
            this.rbCreateBox.UseVisualStyleBackColor = true;
            // 
            // rbPDFAFinish
            // 
            this.rbPDFAFinish.AutoSize = true;
            this.rbPDFAFinish.Location = new System.Drawing.Point(27, 170);
            this.rbPDFAFinish.Name = "rbPDFAFinish";
            this.rbPDFAFinish.Size = new System.Drawing.Size(157, 17);
            this.rbPDFAFinish.TabIndex = 7;
            this.rbPDFAFinish.TabStop = true;
            this.rbPDFAFinish.Text = "Reset Batch to PDFA Finish";
            this.rbPDFAFinish.UseVisualStyleBackColor = true;
            // 
            // rbDeleteIBMLBatch
            // 
            this.rbDeleteIBMLBatch.AutoSize = true;
            this.rbDeleteIBMLBatch.Location = new System.Drawing.Point(288, 31);
            this.rbDeleteIBMLBatch.Name = "rbDeleteIBMLBatch";
            this.rbDeleteIBMLBatch.Size = new System.Drawing.Size(152, 17);
            this.rbDeleteIBMLBatch.TabIndex = 6;
            this.rbDeleteIBMLBatch.TabStop = true;
            this.rbDeleteIBMLBatch.Text = "Delete Batches From IBML";
            this.rbDeleteIBMLBatch.UseVisualStyleBackColor = true;
            // 
            // rbPrepComplete
            // 
            this.rbPrepComplete.AutoSize = true;
            this.rbPrepComplete.Location = new System.Drawing.Point(27, 147);
            this.rbPrepComplete.Name = "rbPrepComplete";
            this.rbPrepComplete.Size = new System.Drawing.Size(168, 17);
            this.rbPrepComplete.TabIndex = 5;
            this.rbPrepComplete.TabStop = true;
            this.rbPrepComplete.Text = "Reset Batch to Prep Complete";
            this.rbPrepComplete.UseVisualStyleBackColor = true;
            // 
            // rbBlankCheck
            // 
            this.rbBlankCheck.AutoSize = true;
            this.rbBlankCheck.Location = new System.Drawing.Point(27, 124);
            this.rbBlankCheck.Name = "rbBlankCheck";
            this.rbBlankCheck.Size = new System.Drawing.Size(181, 17);
            this.rbBlankCheck.TabIndex = 4;
            this.rbBlankCheck.TabStop = true;
            this.rbBlankCheck.Text = "Reset to Ready For Blank Check";
            this.rbBlankCheck.UseVisualStyleBackColor = true;
            // 
            // rbUnitizerFinished
            // 
            this.rbUnitizerFinished.AutoSize = true;
            this.rbUnitizerFinished.Location = new System.Drawing.Point(27, 101);
            this.rbUnitizerFinished.Name = "rbUnitizerFinished";
            this.rbUnitizerFinished.Size = new System.Drawing.Size(149, 17);
            this.rbUnitizerFinished.TabIndex = 3;
            this.rbUnitizerFinished.TabStop = true;
            this.rbUnitizerFinished.Text = "Reset To Unitizer Finished";
            this.rbUnitizerFinished.UseVisualStyleBackColor = true;
            // 
            // rbUnidexFinished
            // 
            this.rbUnidexFinished.AutoSize = true;
            this.rbUnidexFinished.Location = new System.Drawing.Point(27, 78);
            this.rbUnidexFinished.Name = "rbUnidexFinished";
            this.rbUnidexFinished.Size = new System.Drawing.Size(147, 17);
            this.rbUnidexFinished.TabIndex = 2;
            this.rbUnidexFinished.TabStop = true;
            this.rbUnidexFinished.Text = "Reset To Unidex Finished";
            this.rbUnidexFinished.UseVisualStyleBackColor = true;
            // 
            // rbQAMNRA
            // 
            this.rbQAMNRA.AutoSize = true;
            this.rbQAMNRA.Location = new System.Drawing.Point(27, 55);
            this.rbQAMNRA.Name = "rbQAMNRA";
            this.rbQAMNRA.Size = new System.Drawing.Size(134, 17);
            this.rbQAMNRA.TabIndex = 1;
            this.rbQAMNRA.TabStop = true;
            this.rbQAMNRA.Text = "Reset To QA at MNRA";
            this.rbQAMNRA.UseVisualStyleBackColor = true;
            // 
            // rbPulledPriority
            // 
            this.rbPulledPriority.AutoSize = true;
            this.rbPulledPriority.Location = new System.Drawing.Point(27, 32);
            this.rbPulledPriority.Name = "rbPulledPriority";
            this.rbPulledPriority.Size = new System.Drawing.Size(135, 17);
            this.rbPulledPriority.TabIndex = 0;
            this.rbPulledPriority.TabStop = true;
            this.rbPulledPriority.Text = "Reset To Pulled Priority";
            this.rbPulledPriority.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Batch List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Status";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(482, 491);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(100, 59);
            this.btnProcess.TabIndex = 11;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(779, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Information";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(645, 282);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(342, 199);
            this.listBox3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpOperation);
            this.Controls.Add(this.grpDatabase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpDatabase.ResumeLayout(false);
            this.grpDatabase.PerformLayout();
            this.grpOperation.ResumeLayout(false);
            this.grpOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpDatabase;
        private System.Windows.Forms.RadioButton rbLoosePaperUAT;
        private System.Windows.Forms.RadioButton rbBumedUAT;
        private System.Windows.Forms.RadioButton rbLoosePaper;
        private System.Windows.Forms.RadioButton rbBUMED;
        private System.Windows.Forms.GroupBox grpOperation;
        private System.Windows.Forms.RadioButton rbPulledPriority;
        private System.Windows.Forms.RadioButton rbQAMNRA;
        private System.Windows.Forms.RadioButton rbUnidexFinished;
        private System.Windows.Forms.RadioButton rbUnitizerFinished;
        private System.Windows.Forms.RadioButton rbBlankCheck;
        private System.Windows.Forms.RadioButton rbPrepComplete;
        private System.Windows.Forms.RadioButton rbDeleteIBMLBatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.RadioButton rbPDFAFinish;
        private System.Windows.Forms.RadioButton rbCreateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox3;
    }
}

