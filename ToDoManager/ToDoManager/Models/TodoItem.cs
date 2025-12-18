using System;
using System.Xml.Serialization;

namespace ToDoManager.Models
{
    // 抽象クラス (OOP: 抽象化)
    /// <summary>
    /// ToDoエンティティの基底クラス
    /// </summary>
    public abstract class EntityBase
    {
        /// <summary>
        /// エンティティのID。
        /// </summary>
        public int Id { get; set; }
    }

    // インターフェース (OOP: インターフェース)
    /// <summary>
    /// 保存可能なエンティティのインターフェース
    /// </summary>
    public interface ISavable
    {
        /// <summary>
        /// エンティティのサマリーを取得
        /// </summary>
        /// <returns>サマリー文字列</returns>
        string GetSummary();
    }

    /// <summary>
    /// ToDoアイテムのエンティティクラス
    /// </summary>
    [Serializable]
    public class TodoItem : EntityBase, ISavable
    {
        /// <summary>
        /// タイトル。
        /// </summary>
        [XmlElement("Title")]
        public string Title { get; set; }

        /// <summary>
        /// 内容。
        /// </summary>
        [XmlElement("Content")]
        public string Content { get; set; }

        /// <summary>
        /// 期限日。
        /// </summary>
        [XmlElement("DueDate")]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// 完了フラグ。
        /// </summary>
        [XmlElement("IsCompleted")]
        public bool IsCompleted { get; set; }

        // インターフェースの明示的な実装
        /// <summary>
        /// サマリー文字列を取得する。
        /// </summary>
        /// <returns>サマリー文字列</returns>
        string ISavable.GetSummary()
        {
            return $"{Title} (期限: {DueDate:yyyy/MM/dd})";
        }

        // 三項演算子の活用
        public override string ToString()
        {
            return $"[{(IsCompleted ? "完了" : "未")}] {Title}";
        }
    }
}
