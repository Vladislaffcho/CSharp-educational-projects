using System.Runtime.Serialization;

namespace JSONparsing
{
    [DataContract]
    public class CreateDump
    {
        [DataMember(Name = "user")]
        public User User { get; set; }
    }
}