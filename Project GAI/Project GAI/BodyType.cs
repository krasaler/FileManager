//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectGAI
{
    using System;
    using System.Collections.Generic;
    
    public partial class BodyType
    {
        public BodyType()
        {
            this.Models = new HashSet<Model>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int BodyTypeClassificationsId { get; set; }
    
        public virtual BodyTypeClassification BodyTypeClassifications { get; set; }
        public virtual ICollection<Model> Models { get; set; }
    }
}