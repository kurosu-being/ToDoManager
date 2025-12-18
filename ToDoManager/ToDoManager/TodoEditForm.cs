using System;
using System.Windows.Forms;
using ToDoManager.Models;

namespace ToDoManager
{
    /// <summary>
    /// ToDoアイテムの編集フォーム
    /// </summary>
    public partial class TodoEditForm : Form
    {
        #region フィールド
        // Designerで定義されるコントロールはここに宣言されている前提
        #endregion

        #region プロパティ
        /// <summary>
        /// 編集対象のToDoアイテムを取得
        /// </summary>
        public TodoItem Item { get; private set; }
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vItem">編集対象のToDoアイテム</param>
        public TodoEditForm(TodoItem vItem)
        {
            InitializeComponent();
            this.Item = vItem;
            FTxtTitle.Text = vItem.Title;
            FTxtContent.Text = vItem.Content;
            FDtpDueDate.Value = vItem.DueDate == default(DateTime) ? DateTime.Now : vItem.DueDate;
            FChkDone.Checked = vItem.IsCompleted;
        }

        #region privateメソッド
        /// <summary>
        /// 保存ボタンがクリックされたときの処理
        /// </summary>
        /// <param name="sender">イベントの送信元</param>
        /// <param name="e">イベントデータ</param>
        private void FBtnSave_Click(object sender, EventArgs e)
        {
            Item.Title = FTxtTitle.Text;
            Item.Content = FTxtContent.Text;
            Item.DueDate = FDtpDueDate.Value;
            Item.IsCompleted = FChkDone.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion
    }
}
