namespace MammothHouse
{
    public class AboutYourStay : IList_Items
    {
        public string Title { get; set; } = "About Your Stay";
        public string Description { get; set; } 
        public string HouseRules { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AboutTheHouse { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string WIFIInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LocalInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NorthernLightsInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ContactInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IList_Items.AboutYourStay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void BacktoMenu()
        {
            throw new NotImplementedException();
        }
        public AboutYourStay()
        {
            Description = "Check in time is 4pm, and check out time is 11am.  Before you leave, please make sure the following items are done:" +
                "All dishes are washed and put away" +
                "Take all trash out to the silver trash can" +
                "Turn the toyo down to 66-68º" +
                "Put dirty towels in the hamper" +
                "Make sure you have all your belongings!  Shipping is expensive to get your items back" +
                "Please lock the door behind you and dont forget to hit the AWAY button on the security panel.";
                
        }
    }
}
