using System.Runtime.Serialization;

namespace WcfService
{
    [DataContract(IsReference = true)]
    class SelectedEntity
    {
        [DataMember]
        public int id;
        [DataMember]
        public string name;
        [DataMember]
        public string description;
        [DataMember]
        public string path;
        [DataMember]
        public string imagePath;
        [DataMember]
        public System.DateTime createdAt;
        [DataMember]
        public System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>> properties;
    }
}
