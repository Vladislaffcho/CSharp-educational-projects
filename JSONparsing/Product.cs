using System.Runtime.Serialization;

namespace JSONparsing
{
    [DataContract]
    public class Product
    {
        [DataMember(Name = "sys")]
        public string Sys { get; set; }
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "provider_id")]
        public int ProviderId { get; set; }
        [DataMember(Name = "company_id")]
        public int CompanyId { get; set; }
        [DataMember(Name = "short")]
        public string Short { get; set; }
        [DataMember(Name = "record_id")]
        public string RecordId { get; set; }
        [DataMember(Name = "title")]
        public string Title { get; set; }
        [DataMember(Name = "seotext")]
        public string SeoText { get; set; }
        [DataMember(Name = "csys")]
        public string Csys { get; set; }
        [DataMember(Name = "cshort")]
        public string Cshort { get; set; }
        [DataMember(Name = "ccode")]
        public int Ccode { get; set; }
    }
}