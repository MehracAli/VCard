using Newtonsoft.Json;
using VCard.Extenseions;
using VCard.Extensions;
using VCard.Models.Common;

HttpClient httpClient = new HttpClient();

httpClient.BaseAddress = new Uri("https://randomuser.me/api");
var httpResponse = httpClient.GetAsync(httpClient.BaseAddress + "/?inc=name,email,phone,location,id").Result;
var responseString = await httpResponse.Content.ReadAsStringAsync();
ContactList contactList = JsonConvert.DeserializeObject<ContactList>(responseString);

foreach (var contact in contactList.results)
{
    string VCard = contact.ToVCard();
    VCard.SaveAsText(contact.name.first);
    VCard.GenerateQR(contact.name.first);
    Console.WriteLine(VCard);
}



