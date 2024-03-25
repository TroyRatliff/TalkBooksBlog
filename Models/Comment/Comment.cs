using System;
using TalkBooksBlog.Data;

namespace TalkBooksBlog.Models.Comment
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
    }
}
