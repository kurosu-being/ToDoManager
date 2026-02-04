using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using ToDoManager.Models;

namespace ToDoManager.Services {
    /// <summary>
    /// ToDoアイテムの管理や永続化を行うサービスクラス
    /// </summary>
    public class TodoService : IDisposable {
        #region フィールド
        private List<TodoItem> FItems = new List<TodoItem>();
        private string C_FilePath = "todos.xml";
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TodoService() {
        }

        #region publicメソッド

        /// <summary>
        /// フィルタ条件に一致するToDoアイテムの列挙を返す
        /// </summary>
        /// <param name="vFilter">タイトルまたは内容に含まれる文字列（nullまたは空で全件）</param>
        /// <returns>条件に一致するToDoアイテムの列挙</returns>
        public IEnumerable<TodoItem> GetItems(string vFilter = null) {
            var wQuery = FItems.Where(x => string.IsNullOrEmpty(vFilter) || x.Title.Contains(vFilter) || x.Content.Contains(vFilter));
            foreach (var wItem in wQuery) yield return wItem;
        }

        /// <summary>
        /// 期限順にソートされたToDoアイテムのリストを返す
        /// </summary>
        /// <returns>期限順のToDoアイテムリスト</returns>
        public List<TodoItem> GetSortedItems() => FItems.OrderBy(x => x.DueDate).ToList();

        /// <summary>
        /// ToDoアイテムを追加または更新
        /// </summary>
        /// <param name="vItem">追加・更新するToDoアイテム</param>
        /// <returns>成功時true/失敗時false</returns>
        public void AddOrUpdate(TodoItem vItem) {
            if (vItem == null) throw new ArgumentNullException(nameof(vItem));

            var wExisting = FItems.FirstOrDefault(x => x.Id == vItem.Id);
            if (wExisting != null) {
                wExisting.Title = vItem.Title;
                wExisting.Content = vItem.Content;
                wExisting.DueDate = vItem.DueDate;
                wExisting.IsCompleted = vItem.IsCompleted;
            } else {
                vItem.Id = FItems.Any() ? FItems.Max(x => x.Id) + 1 : 1;
                FItems.Add(vItem);
            }
        }

        /// <summary>
        /// 指定したIDのToDoアイテムを削除
        /// </summary>
        /// <param name="vId">削除するToDoアイテムのID</param>
        public void Delete(int vId) {
            var wItem = FItems.FirstOrDefault(x => x.Id == vId);
            if (wItem != null) FItems.Remove(wItem);
        }

        /// <summary>
        /// XMLで保存
        /// </summary>
        public void Export() {
            var wSerializer = new XmlSerializer(typeof(List<TodoItem>));
            using (var wWriter = new StreamWriter(C_FilePath)) wSerializer.Serialize(wWriter, FItems);
        }

        /// <summary>
        /// XMLで読込
        /// </summary>
        public bool Import() {
            if (!File.Exists(C_FilePath)) return false;
            var wSerializer = new XmlSerializer(typeof(List<TodoItem>));
            using (var wStreamReader = new StreamReader(C_FilePath)) {
                FItems = (List<TodoItem>)wSerializer.Deserialize(wStreamReader);
            }

            SortByDueDate();
            return true;
        }

        /// <summary>
        /// 期限順にソート
        /// </summary>
        public void SortByDueDate() {
            var wSortedItems = FItems.OrderBy(x => x.DueDate);
        }

        /// <summary>
        /// 追加順にソート
        /// </summary>
        public void SortByAddedOrder() => FItems = FItems.OrderBy(x => x.Id).ToList();

        /// <summary>
        /// リソースの解放処理
        /// </summary>
        public void Dispose() {
        }
        #endregion
    }
}
