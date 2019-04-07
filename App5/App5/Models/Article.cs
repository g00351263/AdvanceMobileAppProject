using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace App5.Model
{

    public class Article
    {
        public Source source { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Content { get; set; }
  

    public class Source
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class ArticlesResult
    {

        public List<Article> Articles { get; set; }
         }


        }
    } 

