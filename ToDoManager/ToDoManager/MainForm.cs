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
        #region フィールド
        /// <summary>
        /// ToDoサービスのインスタンス。
        /// </summary>
        private readonly TodoService FService = new TodoService();
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            UpdateList();
            SetFieldsReadOnly(true);
        }

        #region privateメソッド
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
            foreach (var wItem in FService.GetItems(vFilter))
            {
                FLstItems.Items.Add(wItem);
            }
        }

        /// <summary>
        /// 追加ボタンのクリックイベント。
        /// </summary>
        private void FBtnAdd_Click(object sender, EventArgs e)
        {
            using (var wForm = new TodoEditForm(new TodoItem()))
            {
                if (wForm.ShowDialog() == DialogResult.OK)
                {
                    FService.AddOrUpdate(wForm.Item);
                    UpdateList();
                }
            }
        }

        /// <summary>
        /// 編集ボタンのクリックイベント。
        /// </summary>
        private void FBtnEdit_Click(object sender, EventArgs e)
        {
            if (FLstItems.SelectedItem is TodoItem wSelected)
            {
                using (var wForm = new TodoEditForm(wSelected))
                {
                    if (wForm.ShowDialog() == DialogResult.OK)
                    {
                        FService.AddOrUpdate(wForm.Item);
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
            if (FLstItems.SelectedItem is TodoItem wSelected)
            {
                FService.Delete(wSelected.Id);
                UpdateList();
            }
        }

        /// <summary>
        /// 期限順ボタンのクリックイベント。
        /// </summary>
        private void FBtnSort_Click(object sender, EventArgs e)
        {
            var wSorted = FService.GetSortedItems();
            FLstItems.Items.Clear();
            foreach (var wItem in wSorted) FLstItems.Items.Add(wItem);
        }

        /// <summary>
        /// 保存ボタンのクリックイベント。
        /// </summary>
        private void FBtnXml_Click(object sender, EventArgs e)
        {
            FService.ExportXml();
            MessageBox.Show("保存しました。");
        }

        /// <summary>
        /// 読込ボタンのクリックイベント。
        /// </summary>
        private void FBtnXmlLoad_Click(object sender, EventArgs e)
        {
            using (var wDialog = new OpenFileDialog())
            {
                wDialog.Filter = "XMLファイル (*.xml)|*.xml|すべてのファイル (*.*)|*.*";
                wDialog.Title = "ファイルを選択";
                if (wDialog.ShowDialog() == DialogResult.OK)
                {
                    FService.LoadXml(wDialog.FileName);
                    UpdateList();
                    MessageBox.Show("ファイルを読み込みました。");
                }
            }
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
        #endregion
    }
}
