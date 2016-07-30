using System.Runtime.Serialization;

namespace JSONparsing
{
    [DataContract]
    public class SearchDump
    {
        [DataMember(Name = "product")]
        public Product Product { get; set; } 
    }
}