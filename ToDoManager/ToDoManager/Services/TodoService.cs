using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Xml.Serialization;
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
            if (vItem == null) throw new ArgumentNullException(nameof(vItem));
            //バリデーションチェック
            vItem.Validate();

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
            var wSerializer = new XmlSerializer(typeof(List<TodoItem>));
            if (string.IsNullOrWhiteSpace(FFilePath))
            {
                using (var wSaveFileDialog = new SaveFileDialog())
                {
                    wSaveFileDialog.Title = "名前を付けて保存";
                    wSaveFileDialog.Filter = "XMLファイル (*.xml)|*.xml|すべてのファイル (*.*)|*.*";
                    wSaveFileDialog.FileName = DefaultFileName;
                    wSaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    if (wSaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FFilePath = wSaveFileDialog.FileName;
                    }
                    else
                    {
                        // ユーザーがキャンセルした場合は保存処理を中断
                        return;
                    }
                }
            }
            try
            {
                using (var wStreamWriter = new StreamWriter(FFilePath))
                {
                    wSerializer.Serialize(wStreamWriter, FItems);
                }
                MessageBox.Show("保存しました。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception wEx)
            {
                MessageBox.Show($"保存中にエラーが発生しました：{wEx.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                using (var wStreamReader = new StreamReader(vFilePath))
                {
                    FItems = (List<TodoItem>)wSerializer.Deserialize(wStreamReader);
                    FFilePath = vFilePath;
                }
            }
            catch (Exception wEx)
            {
                MessageBox.Show($"読込中にエラーが発生しました：{wEx.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// リソースの解放処理
        /// </summary>
        public void Dispose()
        {
        }
        #endregion
    }
}
