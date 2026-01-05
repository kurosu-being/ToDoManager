namespace ToDoManager
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // コントロール宣言（F接頭辞＋パスカル型）
        private System.Windows.Forms.TextBox FTxtTitle;
        private System.Windows.Forms.TextBox FTxtContent;
        private System.Windows.Forms.DateTimePicker FDtpDueDate;
        private System.Windows.Forms.CheckBox FChkDone;
        private System.Windows.Forms.ListBox FLstItems;
        private System.Windows.Forms.Button FBtnAdd;
        private System.Windows.Forms.Button FBtnEdit;
        private System.Windows.Forms.Button FBtnDelete;
        private System.Windows.Forms.Button FBtnXml;
        private System.Windows.Forms.Button FBtnXmlLoad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByDueDateToolStripMenuItem;
        private System.Windows.Forms.StatusStrip FStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel FStatusLabel;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.FTxtTitle = new System.Windows.Forms.TextBox();
            this.FTxtContent = new System.Windows.Forms.TextBox();
            this.FDtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.FChkDone = new System.Windows.Forms.CheckBox();
            this.FLstItems = new System.Windows.Forms.ListBox();
            this.FBtnAdd = new System.Windows.Forms.Button();
            this.FBtnEdit = new System.Windows.Forms.Button();
            this.FBtnDelete = new System.Windows.Forms.Button();
            this.FBtnXml = new System.Windows.Forms.Button();
            this.FBtnXmlLoad = new System.Windows.Forms.Button();
            this.FTitleLabel = new System.Windows.Forms.Label();
            this.FContentLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByDueDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FStatusStrip = new System.Windows.Forms.StatusStrip();
            this.FStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FMainCmbPriority = new System.Windows.Forms.ComboBox();
            this.FMainPriorityLabel = new System.Windows.Forms.Label();
            this.FTxtSearch = new System.Windows.Forms.TextBox();
            this.FBtnSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.FStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FTxtTitle
            // 
            this.FTxtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FTxtTitle.Location = new System.Drawing.Point(483, 166);
            this.FTxtTitle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FTxtTitle.Name = "FTxtTitle";
            this.FTxtTitle.Size = new System.Drawing.Size(331, 25);
            this.FTxtTitle.TabIndex = 0;
            // 
            // FTxtContent
            // 
            this.FTxtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FTxtContent.Location = new System.Drawing.Point(483, 232);
            this.FTxtContent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FTxtContent.Multiline = true;
            this.FTxtContent.Name = "FTxtContent";
            this.FTxtContent.Size = new System.Drawing.Size(331, 88);
            this.FTxtContent.TabIndex = 1;
            // 
            // FDtpDueDate
            // 
            this.FDtpDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FDtpDueDate.Location = new System.Drawing.Point(483, 338);
            this.FDtpDueDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FDtpDueDate.Name = "FDtpDueDate";
            this.FDtpDueDate.Size = new System.Drawing.Size(331, 25);
            this.FDtpDueDate.TabIndex = 2;
            // 
            // FChkDone
            // 
            this.FChkDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FChkDone.Location = new System.Drawing.Point(483, 382);
            this.FChkDone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FChkDone.Name = "FChkDone";
            this.FChkDone.Size = new System.Drawing.Size(133, 28);
            this.FChkDone.TabIndex = 3;
            this.FChkDone.Text = "完了";
            // 
            // FLstItems
            // 
            this.FLstItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLstItems.ItemHeight = 18;
            this.FLstItems.Location = new System.Drawing.Point(14, 82);
            this.FLstItems.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FLstItems.MinimumSize = new System.Drawing.Size(164, 298);
            this.FLstItems.Name = "FLstItems";
            this.FLstItems.Size = new System.Drawing.Size(408, 382);
            this.FLstItems.TabIndex = 4;
            this.FLstItems.SelectedIndexChanged += new System.EventHandler(this.FLstItems_SelectedIndexChanged);
            // 
            // FBtnAdd
            // 
            this.FBtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FBtnAdd.Location = new System.Drawing.Point(483, 82);
            this.FBtnAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FBtnAdd.Name = "FBtnAdd";
            this.FBtnAdd.Size = new System.Drawing.Size(93, 45);
            this.FBtnAdd.TabIndex = 5;
            this.FBtnAdd.Text = "追加(&A)";
            this.FBtnAdd.UseVisualStyleBackColor = true;
            this.FBtnAdd.Click += new System.EventHandler(this.FBtnAdd_Click);
            // 
            // FBtnEdit
            // 
            this.FBtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FBtnEdit.Location = new System.Drawing.Point(698, 82);
            this.FBtnEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FBtnEdit.Name = "FBtnEdit";
            this.FBtnEdit.Size = new System.Drawing.Size(93, 45);
            this.FBtnEdit.TabIndex = 6;
            this.FBtnEdit.Text = "編集(&E)";
            this.FBtnEdit.UseVisualStyleBackColor = true;
            this.FBtnEdit.Click += new System.EventHandler(this.FBtnEdit_Click);
            // 
            // FBtnDelete
            // 
            this.FBtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FBtnDelete.Location = new System.Drawing.Point(595, 82);
            this.FBtnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FBtnDelete.Name = "FBtnDelete";
            this.FBtnDelete.Size = new System.Drawing.Size(93, 45);
            this.FBtnDelete.TabIndex = 7;
            this.FBtnDelete.Text = "削除(&D)";
            this.FBtnDelete.UseVisualStyleBackColor = true;
            this.FBtnDelete.Click += new System.EventHandler(this.FBtnDelete_Click);
            // 
            // FBtnXml
            // 
            this.FBtnXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FBtnXml.Location = new System.Drawing.Point(696, 511);
            this.FBtnXml.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FBtnXml.Name = "FBtnXml";
            this.FBtnXml.Size = new System.Drawing.Size(120, 45);
            this.FBtnXml.TabIndex = 9;
            this.FBtnXml.Text = "保存(&S)";
            this.FBtnXml.UseVisualStyleBackColor = true;
            this.FBtnXml.Click += new System.EventHandler(this.FBtnXml_Click);
            // 
            // FBtnXmlLoad
            // 
            this.FBtnXmlLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FBtnXmlLoad.Location = new System.Drawing.Point(568, 511);
            this.FBtnXmlLoad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FBtnXmlLoad.Name = "FBtnXmlLoad";
            this.FBtnXmlLoad.Size = new System.Drawing.Size(120, 45);
            this.FBtnXmlLoad.TabIndex = 10;
            this.FBtnXmlLoad.Text = "読込(&L)";
            this.FBtnXmlLoad.UseVisualStyleBackColor = true;
            this.FBtnXmlLoad.Click += new System.EventHandler(this.FBtnXmlLoad_Click);
            // 
            // FTitleLabel
            // 
            this.FTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FTitleLabel.AutoSize = true;
            this.FTitleLabel.Location = new System.Drawing.Point(480, 144);
            this.FTitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FTitleLabel.Name = "FTitleLabel";
            this.FTitleLabel.Size = new System.Drawing.Size(61, 18);
            this.FTitleLabel.TabIndex = 11;
            this.FTitleLabel.Text = "タイトル";
            // 
            // FContentLabel
            // 
            this.FContentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FContentLabel.AutoSize = true;
            this.FContentLabel.Location = new System.Drawing.Point(480, 210);
            this.FContentLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FContentLabel.Name = "FContentLabel";
            this.FContentLabel.Size = new System.Drawing.Size(44, 18);
            this.FContentLabel.TabIndex = 12;
            this.FContentLabel.Text = "内容";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(894, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 19);
            this.fileToolStripMenuItem.Text = "ファイル";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loadToolStripMenuItem.Text = "読込(&L)";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.FBtnXmlLoad_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "保存(&S)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.FBtnXml_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editItemToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(43, 19);
            this.editToolStripMenuItem.Text = "編集";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.addToolStripMenuItem.Text = "追加(&A)";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.FBtnAdd_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.deleteToolStripMenuItem.Text = "削除(&D)";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.FBtnDelete_Click);
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.editItemToolStripMenuItem.Text = "編集(&E)";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.FBtnEdit_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByDueDateToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(43, 19);
            this.viewToolStripMenuItem.Text = "表示";
            // 
            // sortByDueDateToolStripMenuItem
            // 
            this.sortByDueDateToolStripMenuItem.Name = "sortByDueDateToolStripMenuItem";
            this.sortByDueDateToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sortByDueDateToolStripMenuItem.Text = "期限順(&O)";
            this.sortByDueDateToolStripMenuItem.Click += new System.EventHandler(this.FBtnSort_Click);
            // 
            // FStatusStrip
            // 
            this.FStatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.FStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FStatusLabel});
            this.FStatusStrip.Location = new System.Drawing.Point(0, 579);
            this.FStatusStrip.Name = "FStatusStrip";
            this.FStatusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 23, 0);
            this.FStatusStrip.Size = new System.Drawing.Size(894, 22);
            this.FStatusStrip.TabIndex = 14;
            this.FStatusStrip.Text = "statusStrip1";
            // 
            // FStatusLabel
            // 
            this.FStatusLabel.Name = "FStatusLabel";
            this.FStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // FMainCmbPriority
            // 
            this.FMainCmbPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FMainCmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FMainCmbPriority.FormattingEnabled = true;
            this.FMainCmbPriority.Items.AddRange(new object[] {
            "高",
            "中",
            "低"});
            this.FMainCmbPriority.Location = new System.Drawing.Point(483, 448);
            this.FMainCmbPriority.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FMainCmbPriority.Name = "FMainCmbPriority";
            this.FMainCmbPriority.Size = new System.Drawing.Size(333, 26);
            this.FMainCmbPriority.TabIndex = 15;
            // 
            // FMainPriorityLabel
            // 
            this.FMainPriorityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FMainPriorityLabel.AutoSize = true;
            this.FMainPriorityLabel.Location = new System.Drawing.Point(480, 426);
            this.FMainPriorityLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FMainPriorityLabel.Name = "FMainPriorityLabel";
            this.FMainPriorityLabel.Size = new System.Drawing.Size(62, 18);
            this.FMainPriorityLabel.TabIndex = 16;
            this.FMainPriorityLabel.Text = "優先度";
            // 
            // FTxtSearch
            // 
            this.FTxtSearch.Location = new System.Drawing.Point(14, 44);
            this.FTxtSearch.Name = "FTxtSearch";
            this.FTxtSearch.Size = new System.Drawing.Size(225, 25);
            this.FTxtSearch.TabIndex = 20;
            // 
            // FBtnSearch
            // 
            this.FBtnSearch.Location = new System.Drawing.Point(245, 44);
            this.FBtnSearch.Name = "FBtnSearch";
            this.FBtnSearch.Size = new System.Drawing.Size(105, 29);
            this.FBtnSearch.TabIndex = 21;
            this.FBtnSearch.Text = "検索";
            this.FBtnSearch.UseVisualStyleBackColor = true;
            this.FBtnSearch.Click += new System.EventHandler(this.FBtnSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 601);
            this.Controls.Add(this.FMainCmbPriority);
            this.Controls.Add(this.FMainPriorityLabel);
            this.Controls.Add(this.FStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.FContentLabel);
            this.Controls.Add(this.FTitleLabel);
            this.Controls.Add(this.FTxtTitle);
            this.Controls.Add(this.FTxtContent);
            this.Controls.Add(this.FDtpDueDate);
            this.Controls.Add(this.FChkDone);
            this.Controls.Add(this.FLstItems);
            this.Controls.Add(this.FBtnAdd);
            this.Controls.Add(this.FBtnEdit);
            this.Controls.Add(this.FBtnDelete);
            this.Controls.Add(this.FBtnXml);
            this.Controls.Add(this.FBtnXmlLoad);
            this.Controls.Add(this.FTxtSearch);
            this.Controls.Add(this.FBtnSearch);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(820, 590);
            this.Name = "MainForm";
            this.Text = "ToDo管理";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FStatusStrip.ResumeLayout(false);
            this.FStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FTitleLabel;
        private System.Windows.Forms.Label FContentLabel;
        private System.Windows.Forms.ComboBox FMainCmbPriority;
        private System.Windows.Forms.Label FMainPriorityLabel;
        private System.Windows.Forms.TextBox FTxtSearch;
        private System.Windows.Forms.Button FBtnSearch;
    }
}
