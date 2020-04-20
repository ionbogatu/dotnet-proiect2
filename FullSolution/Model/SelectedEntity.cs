using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Model
{
    [DataContract(IsReference = true)]
    public class SelectedEntity
    {
        [DataMember]
        public int? id;
        [DataMember]
        public string name;
        [DataMember]
        public string description;
        [DataMember]
        public string path;
        [DataMember]
        public string imagePath;
        [DataMember]
        public DateTime createdAt;
        [DataMember]
        public List<KeyValuePair<string, string>> properties;
    }
}
