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
        /// ID
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
        /// サマリーを取得
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
        /// タイトル
        /// </summary>
        [XmlElement("Title")]
        public string Title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [XmlElement("Content")]
        public string Content { get; set; }

        /// <summary>
        /// 期限日
        /// </summary>
        [XmlElement("DueDate")]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// 完了フラグ
        /// </summary>
        [XmlElement("IsCompleted")]
        public bool IsCompleted { get; set; }

        private PriorityLevel _priority = PriorityLevel.Normal;

        /// <summary>
        /// 優先度
        /// </summary>
        [XmlElement("Priority")]
        public PriorityLevel Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        // インターフェースの明示的な実装
        /// <summary>
        /// サマリー文字列を取得
        /// </summary>
        /// <returns>サマリー文字列</returns>
        string ISavable.GetSummary()
        {
            return $"{Title} (期限: {DueDate:yyyy/MM/dd})";
        }

        /// <summary>
        /// タイトルと完了状態を表す文字列を返します。
        /// </summary>
        /// <returns>表示用文字列</returns>
        public override string ToString()
        {
            return $"[{(IsCompleted ? "完了" : "未")}] {Title}";
        }

        /// <summary>
        /// このアイテムが有効な状態か診断します。
        /// 不正な場合は例外を投げます。
        /// </summary>
        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(this.Title))
            {
                throw new ArgumentException("タイトルは必須入力です。");
            }
        }
    }

    /// <summary>
    /// 優先度レベル
    /// </summary>
    public enum PriorityLevel
    {
        High,
        Normal,
        Low
    }
}
