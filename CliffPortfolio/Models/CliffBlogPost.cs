﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CliffPortfolio.Models
{
    public class CliffBlogPost
    {
        public int Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; } //<Nullable>  or ?  to set value as null-able
        public string Title { get; set; }
        [AllowHtml]
        public string Body { get; set; }
        public string MediaURL { get; set; }
        public bool Published { get; set; }
        public string Slug { get; set; }  //can type "prop" then tab tab to setup these, a little faster
        //public string CommentBody { get; set; }

        public virtual ICollection<BlogComment> Comments { get; set; }  //navigation property, expects a class that defines objects, "list of T" name for collections.

        public CliffBlogPost()   //this is a constructor that creates a class.......
        {
            Comments = new HashSet<BlogComment>();

        }

        //public static string BlogPostMaxLength(this string value, int maxLength)
        //{
        //    if (value == null)
        //    {
        //        return null;
        //    }
        //    if (maxLength < 0)
        //    {
        //        return "";
        //    }
        //    return value.Substring(0, Math.Min(value.Length, maxLength));
        //}

    }
}