//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public partial class Comment
    {
        public int CommentId { get; set; }
        public string Comment1 { get; set; }
        public int PostId { get; set; }

        [JsonIgnore, XmlIgnore]
        public virtual Post Post { get; set; }
    }
}
