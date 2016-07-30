using System.Runtime.Serialization;

namespace JSONparsing
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public string Sys { get; set; }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Short { get; set; }
    }
}