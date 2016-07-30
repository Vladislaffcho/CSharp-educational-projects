using System;
using System.Runtime.Serialization;

namespace JSONparsing
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string StartDate { get; set; }
        [DataMember]
        public string EndDate { get; set; }
        [DataMember]
        public string PromoCode { get; set; }
        [DataMember]
        public double PromoValue { get; set; }
        [DataMember]
        public string Fio { get; set; }
        public  SearchDump SearchDump { get; set; }
    }
}