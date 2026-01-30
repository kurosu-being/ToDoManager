using System;
using System.Xml.Serialization;

namespace ToDoManager.Models
{
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


    /// <summary>
    /// ToDoアイテムのエンティティクラス
    /// </summary>
    [Serializable]
    public class TodoItem : EntityBase
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

        /// <summary>
        /// タイトルと完了状態を表す文字列を返します。
        /// </summary>
        /// <returns>表示用文字列</returns>
        public override string ToString()
        {
            return $"[{(IsCompleted ? "完了" : "未")}] {Title}";
        }

        /// <summary>
        /// タイトルのバリデーションを行います。
        /// </summary>
        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Title))
            {
                throw new ArgumentException("タイトルは必須です。");
            }
        }
    }
}
