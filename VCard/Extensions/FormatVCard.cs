using VCard.Models.Common;

namespace VCard.Extenseions
{
    public static class FormatVCard
    {
        public static string ToVCard(this Contact contact)
        {
            string VCard = $" FirsName : {contact.name.first}\n" +
                $" LastName : {contact.name.last}\n " +
                $"Email : {contact.email}\n " +
                $"Phone : {contact.phone}\n " +
                $"City : {contact.location.city}\n " +
                $"Country : {contact.location.country}\n " +
                $"Id : {contact.id.name}";

            return VCard;
        }
    }
}
