using System.Runtime.Serialization;

namespace JSONparsing
{
    [DataContract]
    public class User
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "name_f")]
        public string NameF { get; set; }
        [DataMember(Name = "name_i")]
        public string NameI { get; set; }
        [DataMember(Name = "name_o")]
        public string NameO { get; set; }
        [DataMember(Name = "iin")]
        public string Iin { get; set; }
        [DataMember(Name = "born")]
        public string Born { get; set; }
        [DataMember(Name = "name_en")]
        public string NameEn { get; set; }
        [DataMember(Name = "doctype")]
        public int Doctype { get; set; }
        [DataMember(Name = "series")]
        public string Series { get; set; }
        [DataMember(Name = "number")]
        public int Number { get; set; }
        [DataMember(Name = "whogot")]
        public string WhoGot { get; set; }
        [DataMember(Name = "whengot")]
        public string WhenGot { get; set; }
        [DataMember(Name = "regadres")]
        public string RegAdres { get; set; }
        [DataMember(Name = "zip")]
        public int Zip { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}