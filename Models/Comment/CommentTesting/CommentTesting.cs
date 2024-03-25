using System;
using TalkBooksBlog.Data;
using Microsoft.EntityFrameworkCore;


namespace TalkBooksBlog.Models.Comment.CommentTesting.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of your ApplicationDbContext
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-TalkBooksBlog-7d940f7c-8f39-408a-befd-4b6d7818fc2c;Trusted_Connection=True;MultipleActiveResultSets=true").Options;
            var dbContext = new ApplicationDbContext(options);

            // Create an instance of CommentManager and pass in the ApplicationDbContext
            var commentManager = new CommentManager(dbContext);

            // Create a new comment
            var newComment = new Comment
            {
                Content = "This is a test comment",
                CreatedAt = DateTime.Now,
                UserId = 123 // Replace with the actual user ID
            };

            // Display the comment content
            Console.WriteLine("New Comment Content: " + newComment.Content);

            // Add the comment
            commentManager.AddComment(newComment);

            // Get the comment by ID
            var retrievedComment = commentManager.GetCommentById(newComment.Id);

            // Update the comment
            retrievedComment.Content = "Updated comment content";
            commentManager.UpdateComment(retrievedComment);

            // Delete the comment
            commentManager.DeleteComment(retrievedComment);

            Console.WriteLine("Testing completed!");
            
            // Pause the console so you can see the output
            Console.ReadLine();
        }
    }
}