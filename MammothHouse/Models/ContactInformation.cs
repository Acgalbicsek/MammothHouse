namespace MammothHouse.Models
{
    public class ContactInformation : IList_Items
    {

        public string Title { get; set; } = "Contact Information";
        public string Description { get; set; }


        public string HouseRules { get; set ; }
        public string AboutTheHouse { get ; set ; }
        public string AboutYourStay { get; set ; }
        public string WIFIInformation { get ; set; }
        public string LocalInformation { get ; set ; }
        public string NorthernLightsInformation { get ; set ; }
        string IList_Items.ContactInformation { get ; set ; }

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
