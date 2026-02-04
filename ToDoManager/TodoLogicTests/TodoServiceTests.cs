using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using ToDoManager.Models;
using ToDoManager.Services;

namespace ToDoManagerTests {
    /// <summary>
    /// TodoServiceの単体テストクラス
    /// </summary>
    [TestClass]
    public class TodoServiceTests
    {
        /// <summary>
        /// AddOrUpdateで新規アイテムが追加されること
        /// </summary>
        [TestMethod]
        public void AddOrUpdate_ToDoの追加()
        {
            var wService = new TodoService();
            var wItem = new TodoItem { Title = "Test", Content = "TestContent", DueDate = DateTime.Today, IsCompleted = false };
            wService.AddOrUpdate(wItem);
            var wItems = wService.GetItems().ToList();
            Assert.AreEqual(1, wItems.Count);
            Assert.AreEqual("Test", wItems[0].Title);
        }

        /// <summary>
        /// AddOrUpdateで既存アイテムが更新されること
        /// </summary>
        [TestMethod]
        public void AddOrUpdate_ToDoの更新()
        {
            var wService = new TodoService();
            var wItem = new TodoItem { Title = "Test", Content = "TestContent", DueDate = DateTime.Today, IsCompleted = false };
            wService.AddOrUpdate(wItem);
            wItem.Title = "Updated";
            wService.AddOrUpdate(wItem);
            var wItems = wService.GetItems().ToList();
            Assert.AreEqual(1, wItems.Count);
            Assert.AreEqual("Updated", wItems[0].Title);
        }

        /// <summary>
        /// Deleteでアイテムが削除されること
        /// </summary>
        [TestMethod]
        public void Delete_ToDoの削除()
        {
            var wService = new TodoService();
            var wItem = new TodoItem { Title = "Test", Content = "TestContent", DueDate = DateTime.Today, IsCompleted = false };
            wService.AddOrUpdate(wItem);
            wService.Delete(wItem.Id);
            var wItems = wService.GetItems().ToList();
            Assert.AreEqual(0, wItems.Count);
        }

        /// <summary>
        /// GetSortedItemsで期限順にソートされること
        /// </summary>
        [TestMethod]
        public void GetSortedItems_期限順にソート()
        {
            var wService = new TodoService();
            var wItem1 = new TodoItem { Title = "A", DueDate = DateTime.Today.AddDays(2) };
            var wItem2 = new TodoItem { Title = "B", DueDate = DateTime.Today.AddDays(1) };
            wService.AddOrUpdate(wItem1);
            wService.AddOrUpdate(wItem2);
            var wSorted = wService.GetSortedItems();
            Assert.AreEqual("B", wSorted[0].Title);
            Assert.AreEqual("A", wSorted[1].Title);
        }

        [TestMethod]
        public void SortByAddedOrder_追加順にソート()
        {
            var wService = new TodoService();
            var wItem1 = new TodoItem { Title = "First", DueDate = DateTime.Today.AddDays(2) };
            var wItem2 = new TodoItem { Title = "Second", DueDate = DateTime.Today.AddDays(1) };
            wService.AddOrUpdate(wItem1);
            wService.AddOrUpdate(wItem2);
            var wSorted = wService.GetItems().ToList();
            Assert.AreEqual("First", wSorted[0].Title);
            Assert.AreEqual("Second", wSorted[1].Title);
        }
    }
}
