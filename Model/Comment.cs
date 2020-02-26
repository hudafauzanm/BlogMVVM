using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Model
{
    public class Comment
    {
        [Key]
        public Guid id {get;set;}
        public string comment{get;set;}
        public string commenter_id{get;set;}
        public string article_id{get;set;}
        
    }
}