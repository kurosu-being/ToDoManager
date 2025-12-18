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
        private System.Windows.Forms.Button FBtnSort;
        private System.Windows.Forms.Button FBtnXml;
        private System.Windows.Forms.Button FBtnXmlLoad;

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
            this.FBtnSort = new System.Windows.Forms.Button();
            this.FBtnXml = new System.Windows.Forms.Button();
            this.FBtnXmlLoad = new System.Windows.Forms.Button();
            this.FTitleLabel = new System.Windows.Forms.Label();
            this.FContentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FTxtTitle
            // 
            this.FTxtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FTxtTitle.Location = new System.Drawing.Point(299, 35);
            this.FTxtTitle.Name = "FTxtTitle";
            this.FTxtTitle.Size = new System.Drawing.Size(200, 19);
            this.FTxtTitle.TabIndex = 0;
            // 
            // FTxtContent
            // 
            this.FTxtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FTxtContent.Location = new System.Drawing.Point(299, 79);
            this.FTxtContent.Multiline = true;
            this.FTxtContent.Name = "FTxtContent";
            this.FTxtContent.Size = new System.Drawing.Size(200, 60);
            this.FTxtContent.TabIndex = 1;
            // 
            // FDtpDueDate
            // 
            this.FDtpDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FDtpDueDate.Location = new System.Drawing.Point(299, 149);
            this.FDtpDueDate.Name = "FDtpDueDate";
            this.FDtpDueDate.Size = new System.Drawing.Size(200, 19);
            this.FDtpDueDate.TabIndex = 2;
            // 
            // FChkDone
            // 
            this.FChkDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FChkDone.Location = new System.Drawing.Point(299, 179);
            this.FChkDone.Name = "FChkDone";
            this.FChkDone.Size = new System.Drawing.Size(80, 19);
            this.FChkDone.TabIndex = 3;
            this.FChkDone.Text = "完了";
            // 
            // FLstItems
            // 
            this.FLstItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLstItems.ItemHeight = 12;
            this.FLstItems.Location = new System.Drawing.Point(20, 20);
            this.FLstItems.MinimumSize = new System.Drawing.Size(100, 200);
            this.FLstItems.Name = "FLstItems";
            this.FLstItems.Size = new System.Drawing.Size(250, 292);
            this.FLstItems.TabIndex = 4;
            this.FLstItems.SelectedIndexChanged += new System.EventHandler(this.FLstItems_SelectedIndexChanged);
            // 
            // FBtnAdd
            // 
            this.FBtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FBtnAdd.Location = new System.Drawing.Point(20, 340);
            this.FBtnAdd.Name = "FBtnAdd";
            this.FBtnAdd.Size = new System.Drawing.Size(80, 30);
            this.FBtnAdd.TabIndex = 5;
            this.FBtnAdd.Text = "追加(&A)";
            this.FBtnAdd.UseVisualStyleBackColor = true;
            this.FBtnAdd.Click += new System.EventHandler(this.FBtnAdd_Click);
            // 
            // FBtnEdit
            // 
            this.FBtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FBtnEdit.Location = new System.Drawing.Point(110, 340);
            this.FBtnEdit.Name = "FBtnEdit";
            this.FBtnEdit.Size = new System.Drawing.Size(80, 30);
            this.FBtnEdit.TabIndex = 6;
            this.FBtnEdit.Text = "編集(&E)";
            this.FBtnEdit.UseVisualStyleBackColor = true;
            this.FBtnEdit.Click += new System.EventHandler(this.FBtnEdit_Click);
            // 
            // FBtnDelete
            // 
            this.FBtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FBtnDelete.Location = new System.Drawing.Point(200, 340);
            this.FBtnDelete.Name = "FBtnDelete";
            this.FBtnDelete.Size = new System.Drawing.Size(80, 30);
            this.FBtnDelete.TabIndex = 7;
            this.FBtnDelete.Text = "削除(&D)";
            this.FBtnDelete.UseVisualStyleBackColor = true;
            this.FBtnDelete.Click += new System.EventHandler(this.FBtnDelete_Click);
            // 
            // FBtnSort
            // 
            this.FBtnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FBtnSort.Location = new System.Drawing.Point(319, 238);
            this.FBtnSort.Name = "FBtnSort";
            this.FBtnSort.Size = new System.Drawing.Size(80, 30);
            this.FBtnSort.TabIndex = 8;
            this.FBtnSort.Text = "期限順(&O)";
            this.FBtnSort.UseVisualStyleBackColor = true;
            this.FBtnSort.Click += new System.EventHandler(this.FBtnSort_Click);
            // 
            // FBtnXml
            // 
            this.FBtnXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FBtnXml.Location = new System.Drawing.Point(419, 238);
            this.FBtnXml.Name = "FBtnXml";
            this.FBtnXml.Size = new System.Drawing.Size(80, 30);
            this.FBtnXml.TabIndex = 9;
            this.FBtnXml.Text = "XML保存(&S)";
            this.FBtnXml.UseVisualStyleBackColor = true;
            this.FBtnXml.Click += new System.EventHandler(this.FBtnXml_Click);
            // 
            // FBtnXmlLoad
            // 
            this.FBtnXmlLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FBtnXmlLoad.Location = new System.Drawing.Point(419, 278);
            this.FBtnXmlLoad.Name = "FBtnXmlLoad";
            this.FBtnXmlLoad.Size = new System.Drawing.Size(80, 30);
            this.FBtnXmlLoad.TabIndex = 10;
            this.FBtnXmlLoad.Text = "XML読込(&L)";
            this.FBtnXmlLoad.UseVisualStyleBackColor = true;
            this.FBtnXmlLoad.Click += new System.EventHandler(this.FBtnXmlLoad_Click);
            // 
            // FTitleLabel
            // 
            this.FTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FTitleLabel.AutoSize = true;
            this.FTitleLabel.Location = new System.Drawing.Point(297, 20);
            this.FTitleLabel.Name = "FTitleLabel";
            this.FTitleLabel.Size = new System.Drawing.Size(40, 12);
            this.FTitleLabel.TabIndex = 11;
            this.FTitleLabel.Text = "タイトル";
            // 
            // FContentLabel
            // 
            this.FContentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FContentLabel.AutoSize = true;
            this.FContentLabel.Location = new System.Drawing.Point(297, 64);
            this.FContentLabel.Name = "FContentLabel";
            this.FContentLabel.Size = new System.Drawing.Size(29, 12);
            this.FContentLabel.TabIndex = 12;
            this.FContentLabel.Text = "内容";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 400);
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
            this.Controls.Add(this.FBtnSort);
            this.Controls.Add(this.FBtnXml);
            this.Controls.Add(this.FBtnXmlLoad);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MainForm";
            this.Text = "ToDo管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FTitleLabel;
        private System.Windows.Forms.Label FContentLabel;
    }
}
