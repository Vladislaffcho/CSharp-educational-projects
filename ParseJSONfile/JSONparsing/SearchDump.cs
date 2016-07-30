using System.Runtime.Serialization;

namespace JSONparsing
{
    [DataContract]
    public class SearchDump
    {
        [DataMember]
        public Product Product { get; set; } 
    }
}