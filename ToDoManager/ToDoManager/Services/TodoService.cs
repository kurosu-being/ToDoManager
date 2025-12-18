using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        private readonly string C_FilePath = "todo_data.xml";
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TodoService() { }

        #region publicメソッド
        /// <summary>
        /// ToDoアイテムのディクショナリを取得する。
        /// </summary>
        /// <returns>Idをキー、TodoItemを値とするディクショナリ</returns>
        public Dictionary<int, TodoItem> GetItemMap()
        {
            return FItems.ToDictionary(x => x.Id);
        }

        /// <summary>
        /// フィルタ条件に一致するToDoアイテムの列挙を返す。
        /// </summary>
        /// <param name="vFilter">タイトルに含まれる文字列（nullまたは空で全件）</param>
        /// <returns>条件に一致するToDoアイテムの列挙</returns>
        public IEnumerable<TodoItem> GetItems(string vFilter = null)
        {
            // 短絡評価の活用
            var vQuery = FItems.Where(x => string.IsNullOrEmpty(vFilter) || x.Title.Contains(vFilter));
            foreach (var vItem in vQuery) yield return vItem;
        }

        /// <summary>
        /// 期限順にソートされたToDoアイテムのリストを返す。
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
        public void AddOrUpdate(TodoItem vItem)
        {
            // 責務分離: 引数チェック
            if (vItem == null) throw new ArgumentNullException(nameof(vItem));
            if (string.IsNullOrWhiteSpace(vItem.Title)) throw new ArgumentException("タイトルが必要です");

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
            using (var vSw = new StreamWriter(C_FilePath)) // using ステートメント
            {
                vSerializer.Serialize(vSw, FItems);
            }
        }

        /// <summary>
        /// XMLファイルからToDoアイテムを読み込み
        /// </summary>
        public void LoadXml()
        {
            if (!File.Exists(C_FilePath)) return;
            var vSerializer = new XmlSerializer(typeof(List<TodoItem>));
            using (var vSr = new StreamReader(C_FilePath))
            {
                FItems = (List<TodoItem>)vSerializer.Deserialize(vSr);
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
