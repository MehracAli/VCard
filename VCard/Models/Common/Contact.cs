using System.ComponentModel.DataAnnotations;

namespace VCard.Models.Common
{
    public class Contact
    {
        public Name name { get; set; }
        public Location location { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public Id id { get; set; }
    }
}
