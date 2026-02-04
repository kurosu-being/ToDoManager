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
        /// Validateでタイトル未入力時に例外が発生すること
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Validate_ThrowsException_WhenTitleIsEmpty()
        {
            var wItem = new TodoItem { Title = "" };
            wItem.Validate();
        }
    }
}
