using System;
using System.Runtime.Serialization;

namespace SampleSoap.Models
{
    [DataContract]
    public class PersonModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
    }
}
