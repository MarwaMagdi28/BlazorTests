using BlazorAppTest.Models;

namespace BlazorAppTest.Pages
{
    public partial class Home
    {
        private bool DisplayEmail = true;
        private List<Contact> contacts;

        private Dictionary<string, object> MyTextboxAttributes = new Dictionary<string, object>
    {
        {"placeholder", "First Name" },
        { "disabled", "disabled"},
    };

        private void DeleteContact(Contact contact)
        {
            contacts.Remove(contact);
        }

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(5000);
            // contacts = new List<Contact>();
            contacts = new List<Contact>
        {
            new Contact
            {

                FirstName = "Aalaa",
                LastName = "Mohammed",
                Email = "aalaa@gmail.com"

            },
             new Contact
            {

                FirstName = "Adham",
                LastName = "Muhamed",
                Email = "adham@gmail.com"

            },
            new Contact
            {

                FirstName = "Marwa",
                LastName = "Magdi",
                Email = "marwa@gmail.com"

            }
        };
            base.OnInitializedAsync();
        }

    }
}
