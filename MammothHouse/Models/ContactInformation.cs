namespace MammothHouse.Models
{
    public class ContactInformation : IList_Items
    {

        public string Title { get; set; } = "Contact Information";
        public string Description { get; set; }


        public string HouseRules { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AboutTheHouse { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AboutYourStay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string WIFIInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LocalInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NorthernLightsInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IList_Items.ContactInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void BacktoMenu()
        {
            throw new NotImplementedException();
        }

        public ContactInformation() {

            Description = "If there is a power outage, a water issue, or anything else of that nature, please reach out to the hosts or the in-town manager." +
                    "Theodora/Shelton: (928) 607-9263" +
                    "Amy: (907) 987-9030";
        
        
        
        }


    }
}
