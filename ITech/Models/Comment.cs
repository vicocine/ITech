//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITech.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public Nullable<int> Level { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> CommentID { get; set; }
    }
}