//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System.Runtime.Serialization;

    [DataContract(IsReference = true)]
    public partial class resource_eav
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int resource_id { get; set; }
        [DataMember]
        public int attribute_id { get; set; }
        [DataMember]
        public int value_id { get; set; }
        [DataMember]
        public int resource_attribute_valuesId { get; set; }
        [DataMember]
        public int resourceId { get; set; }
        [DataMember]
        public int resource_attributes_Id { get; set; }

        [DataMember]
        public virtual resource_attribute_values resource_attribute_values { get; set; }
        [DataMember]
        public virtual resource_attributes resource_attributes { get; set; }
        [DataMember]
        public virtual resource resource { get; set; }
    }
}
