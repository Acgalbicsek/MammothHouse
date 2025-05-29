namespace MammothHouse.Models
{
    public class AboutYourStay : IList_Items
    {
        public string Title { get; set; } = "About Your Stay";
        public string Description { get; set; } 
        public string HouseRules { get ; set ; }
        public string AboutTheHouse { get; set ; }
        public string WIFIInformation { get ; set ; }
        public string LocalInformation { get ; set ; }
        public string NorthernLightsInformation { get; set ; }
        public string ContactInformation { get ; set ; }
        string IList_Items.AboutYourStay { get ; set ; }

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
