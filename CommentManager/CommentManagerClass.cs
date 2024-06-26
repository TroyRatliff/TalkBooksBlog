﻿using System.Linq;
using Microsoft.EntityFrameworkCore;
using TalkBooksBlog.Models.Comment;
//SOLID principles 
//Single Responsibility Principle - My CommentManager class has a single responsibility, which is to manage comments.
//Dependency Inversion Principle - My CommentManager class depends on the abstraction provided by the ApplicationDbContext class through dependency injection.

namespace TalkBooksBlog.Data
{
    public class CommentManager
    {
        private readonly ApplicationDbContext _context;

        public CommentManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

        public Comment GetCommentById(int commentId)
        {
            return _context.Comments.FirstOrDefault(c => c.Id == commentId);
        }

        public void UpdateComment(Comment comment)
        {
            _context.Comments.Update(comment);
            _context.SaveChanges();
        }

        public void DeleteComment(Comment comment)
        {
            _context.Comments.Remove(comment);
            _context.SaveChanges();
        }
    }
}
