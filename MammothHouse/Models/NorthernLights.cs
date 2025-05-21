namespace MammothHouse.Models
{
    public class NorthernLights : IList_Items
    {
        public string Title { get; set; } = "Northern Lights Information";
        public string Description { get; set; }

        public string HouseRules { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AboutTheHouse { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AboutYourStay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string WIFIInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LocalInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NorthernLightsInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ContactInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void BacktoMenu()
        {
            throw new NotImplementedException();
        }

        public NorthernLights()
        {
            Description = "We hope that if you are staying with us during the dark winter months that you will see the lights right from the porch!  If you want to go chase" +
                "some lights, we recommend packing snacks and something hot to drink and check out the following places:" +
                "Murphy Dome" +
                "Ester Dome" +
                "Cleary Summit" +
                "Pedro Dome" +

                "You can also check out https://www.gi.alaska.edu/monitors/aurora-forecast to see what the aurora forecast is during your stay.";
        }
    }
}

