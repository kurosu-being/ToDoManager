using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ToDoManager.Models;

namespace ToDoManagerTests
{
    /// <summary>
    /// TodoItemの単体テストクラス
    /// </summary>
    [TestClass]
    public class TodoItemTests
    {
        /// <summary>
        /// ToStringが期待通りのフォーマットを返すこと
        /// </summary>
        [TestMethod]
        public void ToString_ReturnsExpectedFormat()
        {
            var wItem = new TodoItem { Title = "Test", IsCompleted = true };
            Assert.AreEqual("[完了] Test", wItem.ToString());
        }

        /// <summary>
        /// GetSummaryが期待通りのサマリーを返すこと
        /// </summary>
        [TestMethod]
        public void GetSummary_ReturnsExpectedSummary()
        {
            var wItem = new TodoItem { Title = "Test", DueDate = new DateTime(2024, 1, 1) };
            var wSummary = ((ISavable)wItem).GetSummary();
            Assert.AreEqual("Test (期限: 2024/01/01)", wSummary);
        }
    }
}
