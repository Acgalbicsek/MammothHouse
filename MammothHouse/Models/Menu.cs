namespace MammothHouse.Models
{
    public class Menu : IList_Items
    {
        public string HouseRules { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AboutTheHouse { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AboutYourStay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string WIFIInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LocalInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NorthernLightsInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ContactInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        

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
