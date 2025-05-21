namespace MammothHouse.Models
{
    public class HouseRules : IList_Items
    {
        public string Title { get; set; } = "House Rules";
        public string Description { get; set; }
        public string AboutTheHouse { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AboutYourStay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string WIFIInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LocalInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NorthernLightsInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ContactInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IList_Items.HouseRules { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        

        public void BacktoMenu()
        {
            throw new NotImplementedException();
        }

        public HouseRules()
        {
            Description = "Woodstove is not for guest use.  It is only for an emergency when there is a power outage in the colder months." +
                "In the case of a power outage, contact the hosts and the manager will come out to light it for you." +
                "No Smoking" +
                "No Pets" +
                "Any fats or grease need to be put into glass jars under the sink." +
                "Septic tank is for human waste and toilet paper only.  Do not flush anything else.  There is a trash can provided in the bathroom.";
                
        }
    }
}
