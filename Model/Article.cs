using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Model
{
    public class Article
    {
        [Key]
        public Guid id{get;set;}
        public string title{get;set;}
        public string categories{get;set;}
        public string author{get;set;}
        public string content{get;set;}
        public string url_img{get;set;}
        public DateTime created_at{get;set;}
        public DateTime published_at{get;set;}
        public string UserId{get;set;}
    }
}