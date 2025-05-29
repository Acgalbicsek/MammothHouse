using System.Security.Cryptography.X509Certificates;

namespace MammothHouse.Models
{
    public class WIFI : IList_Items
    {
        public string Title { get; set; } = "WIFI Information";
        public string Description { get; set; }
        public string HouseRules { get ; set ; }
        public string AboutTheHouse { get ; set ; }
        public string AboutYourStay { get ; set ; }
        public string WIFIInformation { get ; set ; }
        public string LocalInformation { get ; set ; }
        public string NorthernLightsInformation { get ; set ; }
        public string ContactInformation { get; set ; }

        public void BacktoMenu()
        {
            throw new NotImplementedException();
        }

        public WIFI()
        {
            Description = "Wi-Fi Name(s) = Verizon -MiFi88ooL-ACgF  or  RC400L-Co" +
                "Password(s) = d8b9154e  or  154a26a0" +
                "If you are working during your trip, it will help your connection strength to turn off your camera if you are on zoom.  Also, downsizing the amount of devices" +
                "you have connected will also improve the strength of the Wi-Fi.  While we do have an unlimited plan of data, there is a cap, and no way to get more data if it is used" +
                "during your stay.  The data plan resets on the 16th of every month.";
        }
    }
}

