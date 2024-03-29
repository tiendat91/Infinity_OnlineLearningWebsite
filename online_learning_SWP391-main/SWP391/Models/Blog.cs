﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391.Models
{
    [Table("Blogs")]
    public class Blog
    {
        public string BlogId { get; set; }
        public string Title { get; set; }
        public string Brief { get; set; }
        public string Content { get; set; }
        public string VideoURL { get; set; }
        public int SlideId { get; set; }
        public virtual Slide Slide { get; set; }
        public string ThumbnailURL { get; set; }
        public DateTime? CreatedDate { get; set; }
        public virtual Status Status { get; set; }
        public int StatusId { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
        public virtual AppUser User { get; set; }
        public string UserId { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
