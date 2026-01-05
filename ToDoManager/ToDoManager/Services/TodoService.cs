using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Windows.Forms;
using ToDoManager.Models;

namespace ToDoManager.Services
{
    /// <summary>
    /// ToDoアイテムの管理や永続化を行うサービスクラス
    /// </summary>
    public class TodoService : IDisposable
    {
        #region フィールド
        private List<TodoItem> FItems = new List<TodoItem>();
        private string FFilePath;
        private const string DefaultFileName = "TodoItems.xml";
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TodoService() { }

        #region publicメソッド
        /// <summary>
        /// ToDoアイテムのディクショナリを取得する
        /// </summary>
        /// <returns>Idをキー、TodoItemを値とするディクショナリ</returns>
        public Dictionary<int, TodoItem> GetItemMap()
        {
            return FItems.ToDictionary(x => x.Id);
        }

        /// <summary>
        /// フィルタ条件に一致するToDoアイテムの列挙を返す
        /// </summary>
        /// <param name="vFilter">タイトルに含まれる文字列（nullまたは空で全件）</param>
        /// <returns>条件に一致するToDoアイテムの列挙</returns>
        public IEnumerable<TodoItem> GetItems(string vFilter = null)
        {
            // yield return を使った遅延実行
            var wQuery = FItems.Where(x => string.IsNullOrEmpty(vFilter) || x.Title.Contains(vFilter));
            foreach (var wItem in wQuery) yield return wItem;
        }

        /// <summary>
        /// 期限順にソートされたToDoアイテムのリストを返す
        /// </summary>
        /// <returns>期限順のToDoアイテムリスト</returns>
        public List<TodoItem> GetSortedItems()
        {
            if (!FItems.Any()) return new List<TodoItem>();
            return FItems.OrderBy(x => x.DueDate).ToList();
        }

        /// <summary>
        /// ToDoアイテムを追加または更新
        /// </summary>
        /// <param name="vItem">追加・更新するToDoアイテム</param>
        /// <returns>成功時true/失敗時false</returns>
        public void AddOrUpdate(TodoItem vItem)
        {
            // 責務分離: 引数チェック
            if (vItem == null) throw new ArgumentNullException(nameof(vItem));
            if (string.IsNullOrWhiteSpace(vItem.Title))
            {
                MessageBox.Show("タイトルを入力して下さい。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var vExisting = FItems.FirstOrDefault(x => x.Id == vItem.Id);
            if (vExisting != null)
            {
                vExisting.Title = vItem.Title;
                vExisting.Content = vItem.Content;
                vExisting.DueDate = vItem.DueDate;
                vExisting.IsCompleted = vItem.IsCompleted;
            }
            else
            {
                vItem.Id = FItems.Any() ? FItems.Max(x => x.Id) + 1 : 1;
                FItems.Add(vItem);
            }
        }

        /// <summary>
        /// 指定したIDのToDoアイテムを削除
        /// </summary>
        /// <param name="vId">削除するToDoアイテムのID</param>
        public void Delete(int vId)
        {
            var vItem = FItems.FirstOrDefault(x => x.Id == vId);
            if (vItem != null) FItems.Remove(vItem);
        }

        /// <summary>
        /// ToDoアイテムをXMLファイルに保存
        /// </summary>
        public void ExportXml()
        {
            var vSerializer = new XmlSerializer(typeof(List<TodoItem>));
            if (string.IsNullOrWhiteSpace(FFilePath))
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "名前を付けて保存";
                    saveFileDialog.Filter = "XMLファイル (*.xml)|*.xml|すべてのファイル (*.*)|*.*";
                    saveFileDialog.FileName = DefaultFileName;
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FFilePath = saveFileDialog.FileName;
                        MessageBox.Show("保存しました。");
                    }
                    else
                    {
                        // ユーザーがキャンセルした場合は保存処理を中断
                        return;
                    }
                }
            }
            using (var vSw = new StreamWriter(FFilePath))
            {
                vSerializer.Serialize(vSw, FItems);
                MessageBox.Show("保存しました。");
            }
        }

        /// <summary>
        /// 指定したXMLファイルからToDoアイテムを読み込み
        /// </summary>
        /// <param name="vFilePath">読み込むXMLファイルのパス</param>
        public void LoadXml(string vFilePath)
        {
            if (string.IsNullOrWhiteSpace(vFilePath) || !File.Exists(vFilePath)) return;
            var wSerializer = new XmlSerializer(typeof(List<TodoItem>));
            using (var wSr = new StreamReader(vFilePath))
            {
                FItems = (List<TodoItem>)wSerializer.Deserialize(wSr);
                FFilePath = vFilePath;
            }
        }

        /// <summary>
        /// リソースの解放処理
        /// </summary>
        public void Dispose()
        {
            // 終了時の処理など
        }
        #endregion
    }
}
