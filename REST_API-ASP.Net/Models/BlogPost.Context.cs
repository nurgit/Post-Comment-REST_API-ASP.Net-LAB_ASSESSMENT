﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace REST_API_ASP.Net.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Xml.Serialization;

    public partial class BlogPostDBContext : DbContext
    {
        public BlogPostDBContext()
            : base("name=BlogPostDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        [JsonIgnore,XmlIgnore]
        public virtual DbSet<Comment> Comments { get; set; }
        [JsonIgnore, XmlIgnore]
        public virtual DbSet<Post> Posts { get; set; }
    }
}
