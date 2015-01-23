namespace MyLogViewer
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
            this.components = new System.ComponentModel.Container();
            this.FileMenu = new System.Windows.Forms.MenuStrip();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opneFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkError = new System.Windows.Forms.CheckBox();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.chkInfo = new System.Windows.Forms.CheckBox();
            this.chkWarn = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbFilePathValue = new System.Windows.Forms.Label();
            this.lbFilePathName = new System.Windows.Forms.Label();
            this.lisLogMessage = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.contextCopyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyMeny = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtMessageValue = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FileMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextCopyMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileMenu
            // 
            this.FileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.FileMenu.Location = new System.Drawing.Point(0, 0);
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(1060, 24);
            this.FileMenu.TabIndex = 7;
            this.FileMenu.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opneFileToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.freshToolStripMenuItem});
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.openFileToolStripMenuItem.Text = "File";
            // 
            // opneFileToolStripMenuItem
            // 
            this.opneFileToolStripMenuItem.Name = "opneFileToolStripMenuItem";
            this.opneFileToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.opneFileToolStripMenuItem.Text = "OpenFile";
            this.opneFileToolStripMenuItem.Click += new System.EventHandler(this.opneFileToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // freshToolStripMenuItem
            // 
            this.freshToolStripMenuItem.Name = "freshToolStripMenuItem";
            this.freshToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.freshToolStripMenuItem.Text = "Fresh";
            this.freshToolStripMenuItem.Click += new System.EventHandler(this.freshToolStripMenuItem_Click);
            // 
            // chkError
            // 
            this.chkError.AutoSize = true;
            this.chkError.Checked = true;
            this.chkError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkError.Location = new System.Drawing.Point(45, 10);
            this.chkError.Name = "chkError";
            this.chkError.Size = new System.Drawing.Size(68, 24);
            this.chkError.TabIndex = 8;
            this.chkError.Text = "Error";
            this.chkError.UseVisualStyleBackColor = true;
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Checked = true;
            this.chkDebug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDebug.Location = new System.Drawing.Point(255, 10);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(81, 24);
            this.chkDebug.TabIndex = 10;
            this.chkDebug.Text = "Debug";
            this.chkDebug.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // chkInfo
            // 
            this.chkInfo.AutoSize = true;
            this.chkInfo.Checked = true;
            this.chkInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInfo.Location = new System.Drawing.Point(189, 10);
            this.chkInfo.Name = "chkInfo";
            this.chkInfo.Size = new System.Drawing.Size(60, 24);
            this.chkInfo.TabIndex = 11;
            this.chkInfo.Text = "Info";
            this.chkInfo.UseVisualStyleBackColor = true;
            // 
            // chkWarn
            // 
            this.chkWarn.AutoSize = true;
            this.chkWarn.Checked = true;
            this.chkWarn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWarn.Location = new System.Drawing.Point(118, 11);
            this.chkWarn.Name = "chkWarn";
            this.chkWarn.Size = new System.Drawing.Size(70, 24);
            this.chkWarn.TabIndex = 12;
            this.chkWarn.Text = "Warn";
            this.chkWarn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.chkError);
            this.groupBox1.Controls.Add(this.chkDebug);
            this.groupBox1.Controls.Add(this.chkInfo);
            this.groupBox1.Controls.Add(this.chkWarn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(665, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 37);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(340, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 28);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearchText
            // 
            this.txtSearchText.AcceptsReturn = true;
            this.txtSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchText.Location = new System.Drawing.Point(306, 5);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(264, 29);
            this.txtSearchText.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(576, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 31);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbFilePathValue);
            this.panel2.Controls.Add(this.lbFilePathName);
            this.panel2.Controls.Add(this.txtSearchText);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 37);
            this.panel2.TabIndex = 16;
            // 
            // lbFilePathValue
            // 
            this.lbFilePathValue.AutoSize = true;
            this.lbFilePathValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilePathValue.Location = new System.Drawing.Point(55, 5);
            this.lbFilePathValue.Name = "lbFilePathValue";
            this.lbFilePathValue.Size = new System.Drawing.Size(0, 16);
            this.lbFilePathValue.TabIndex = 17;
            // 
            // lbFilePathName
            // 
            this.lbFilePathName.AutoSize = true;
            this.lbFilePathName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilePathName.Location = new System.Drawing.Point(3, 2);
            this.lbFilePathName.Name = "lbFilePathName";
            this.lbFilePathName.Size = new System.Drawing.Size(38, 16);
            this.lbFilePathName.TabIndex = 16;
            this.lbFilePathName.Text = "Path:";
            this.lbFilePathName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lisLogMessage
            // 
            this.lisLogMessage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lisLogMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lisLogMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisLogMessage.FullRowSelect = true;
            this.lisLogMessage.GridLines = true;
            this.lisLogMessage.Location = new System.Drawing.Point(0, 0);
            this.lisLogMessage.Name = "lisLogMessage";
            this.lisLogMessage.ShowGroups = false;
            this.lisLogMessage.Size = new System.Drawing.Size(800, 418);
            this.lisLogMessage.TabIndex = 17;
            this.lisLogMessage.UseCompatibleStateImageBehavior = false;
            this.lisLogMessage.View = System.Windows.Forms.View.Details;
            this.lisLogMessage.SelectedIndexChanged += new System.EventHandler(this.lisLogMessage_SelectedIndexChanged);
            this.lisLogMessage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lisLogMessage_MouseDown);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "LineNumber";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DateTime";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "LogLevel";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Message";
            this.columnHeader3.Width = 800;
            // 
            // contextCopyMenu
            // 
            this.contextCopyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyMeny});
            this.contextCopyMenu.Name = "contextCopyMenu";
            this.contextCopyMenu.Size = new System.Drawing.Size(100, 26);
            // 
            // CopyMeny
            // 
            this.CopyMeny.Name = "CopyMeny";
            this.CopyMeny.Size = new System.Drawing.Size(99, 22);
            this.CopyMeny.Text = "Copy";
            // 
            // openLogFileDialog
            // 
            this.openLogFileDialog.FileName = "openFileDialog1";
            // 
            // txtMessageValue
            // 
            this.txtMessageValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtMessageValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageValue.Location = new System.Drawing.Point(800, 61);
            this.txtMessageValue.Multiline = true;
            this.txtMessageValue.Name = "txtMessageValue";
            this.txtMessageValue.Size = new System.Drawing.Size(260, 418);
            this.txtMessageValue.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lisLogMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 418);
            this.panel1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 479);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMessageValue);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FileMenu);
            this.MainMenuStrip = this.FileMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FileMenu.ResumeLayout(false);
            this.FileMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextCopyMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip FileMenu;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkError;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.CheckBox chkInfo;
        private System.Windows.Forms.CheckBox chkWarn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbFilePathName;
        private System.Windows.Forms.ToolStripMenuItem opneFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freshToolStripMenuItem;
        private System.Windows.Forms.ListView lisLogMessage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip contextCopyMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyMeny;
        private System.Windows.Forms.OpenFileDialog openLogFileDialog;
        private System.Windows.Forms.Label lbFilePathValue;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtMessageValue;
        private System.Windows.Forms.Panel panel1;
    }
}

