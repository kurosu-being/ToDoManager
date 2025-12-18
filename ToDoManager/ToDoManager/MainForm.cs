using System;
using System.Linq;
using System.Windows.Forms;
using ToDoManager.Models;
using ToDoManager.Services;

namespace ToDoManager
{
    /// <summary>
    /// メインのToDo管理フォーム
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// ToDoサービスのインスタンス。
        /// </summary>
        private readonly TodoService FService = new TodoService();

        /// <summary>
        /// MainFormの新しいインスタンスを初期化
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            FService.LoadXml();
            UpdateList();
            SetFieldsReadOnly(true);
        }

        /// <summary>
        /// 右側の入力フィールドの編集可否を設定
        /// </summary>
        /// <param name="vIsReadOnly">読み取り専用にする場合はtrue</param>
        private void SetFieldsReadOnly(bool vIsReadOnly)
        {
            FTxtTitle.ReadOnly = vIsReadOnly;
            FTxtContent.ReadOnly = vIsReadOnly;
            FDtpDueDate.Enabled = !vIsReadOnly;
            FChkDone.Enabled = !vIsReadOnly;
        }

        /// <summary>
        /// ToDoリストを更新
        /// </summary>
        /// <param name="vFilter">タイトルのフィルタ文字列</param>
        private void UpdateList(string vFilter = null)
        {
            FLstItems.Items.Clear();
            foreach (var vItem in FService.GetItems(vFilter))
            {
                FLstItems.Items.Add(vItem);
            }
        }

        /// <summary>
        /// 追加ボタンのクリックイベント。
        /// </summary>
        private void FBtnAdd_Click(object sender, EventArgs e)
        {
            using (var vForm = new TodoEditForm(new TodoItem()))
            {
                if (vForm.ShowDialog() == DialogResult.OK)
                {
                    FService.AddOrUpdate(vForm.Item);
                    UpdateList();
                }
            }
        }

        /// <summary>
        /// 編集ボタンのクリックイベント。
        /// </summary>
        private void FBtnEdit_Click(object sender, EventArgs e)
        {
            if (FLstItems.SelectedItem is TodoItem vSelected)
            {
                using (var vForm = new TodoEditForm(vSelected))
                {
                    if (vForm.ShowDialog() == DialogResult.OK)
                    {
                        FService.AddOrUpdate(vForm.Item);
                        UpdateList();
                    }
                }
            }
        }

        /// <summary>
        /// 削除ボタンのクリックイベント。
        /// </summary>
        private void FBtnDelete_Click(object sender, EventArgs e)
        {
            if (FLstItems.SelectedItem is TodoItem vSelected)
            {
                FService.Delete(vSelected.Id);
                UpdateList();
            }
        }

        /// <summary>
        /// 期限順ボタンのクリックイベント。
        /// </summary>
        private void FBtnSort_Click(object sender, EventArgs e)
        {
            var vSorted = FService.GetSortedItems();
            FLstItems.Items.Clear();
            foreach (var vItem in vSorted) FLstItems.Items.Add(vItem);
        }

        /// <summary>
        /// XML保存ボタンのクリックイベント。
        /// </summary>
        private void FBtnXml_Click(object sender, EventArgs e)
        {
            FService.ExportXml();
            MessageBox.Show("XMLに保存しました。");
        }

        /// <summary>
        /// XML読込ボタンのクリックイベント。
        /// </summary>
        private void FBtnXmlLoad_Click(object sender, EventArgs e)
        {
            FService.LoadXml();
            UpdateList();
            MessageBox.Show("XMLを読み込みました。");
        }

        /// <summary>
        /// リストボックスの選択変更イベント。
        /// </summary>
        private void FLstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FLstItems.SelectedItem is TodoItem vSelected)
            {
                FTxtTitle.Text = vSelected.Title;
                FTxtContent.Text = vSelected.Content;
                FDtpDueDate.Value = vSelected.DueDate;
                FChkDone.Checked = vSelected.IsCompleted;
                SetFieldsReadOnly(true); // 常に読み取り専用
            }
            else
            {
                FTxtTitle.Text = string.Empty;
                FTxtContent.Text = string.Empty;
                FDtpDueDate.Value = DateTime.Now;
                FChkDone.Checked = false;
                SetFieldsReadOnly(true);
            }
        }
    }
}
