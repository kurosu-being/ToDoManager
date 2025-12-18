using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using ToDoManager.Models;
using ToDoManager.Services;
using System.Collections.Generic;

namespace ToDoManagerTests
{
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
        public void AddOrUpdate_AddsNewItem()
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
        public void AddOrUpdate_UpdatesExistingItem()
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
        public void Delete_RemovesItem()
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
        public void GetSortedItems_ReturnsItemsSortedByDueDate()
        {
            var wService = new TodoService();
            var wItem1 = new TodoItem { Title = "A", DueDate = DateTime.Today.AddDays(2) };
            var wItem2 = new TodoItem { Title = "B", DueDate = DateTime.Today.AddDays(1) };
            wService.AddOrUpdate(wItem1);
            wService.AddOrUpdate(wItem2);
            var vSorted = wService.GetSortedItems();
            Assert.AreEqual("B", vSorted[0].Title);
            Assert.AreEqual("A", vSorted[1].Title);
        }

        /// <summary>
        /// GetItemMapでディクショナリが正しく返ること
        /// </summary>
        [TestMethod]
        public void GetItemMap_ReturnsDictionary()
        {
            var wService = new TodoService();
            var wItem = new TodoItem { Title = "Test" };
            wService.AddOrUpdate(wItem);
            var wMap = wService.GetItemMap();
            Assert.IsTrue(wMap.ContainsKey(wItem.Id));
            Assert.AreEqual(wItem.Title, wMap[wItem.Id].Title);
        }
    }
}
