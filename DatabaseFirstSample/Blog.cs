//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirstSample
{
    using System;
    using System.Collections.Generic;
    
    public partial class Blog
    {
        public Blog()
        {
            this.Posts = new HashSet<Post>();
        }
    
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    
        public virtual ICollection<Post> Posts { get; set; }
    }
}
