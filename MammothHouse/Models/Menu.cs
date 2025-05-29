namespace MammothHouse.Models
{
    public class Menu : IList_Items
    {
        public string HouseRules { get ; set ; }
        public string AboutTheHouse { get ; set ; }
        public string AboutYourStay { get ; set ; }
        public string WIFIInformation { get ; set ; }
        public string LocalInformation { get ; set ; }
        public string NorthernLightsInformation { get; set ; }
        public string ContactInformation { get; set ; }

        

        public void BacktoMenu()
        {
            
            Console.WriteLine("Back To Main Menu");
        }

        public void Add(string item)
        {
            Add(item);

        }

    }
}
