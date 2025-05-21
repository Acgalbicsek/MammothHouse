namespace MammothHouse.Models
{
    public interface IList_Items
    {
        //no fields Amy!

        public string HouseRules { get; set; }
        public string AboutTheHouse {  get; set; } 
        public string AboutYourStay { get; set; }
        public string WIFIInformation {  get; set; }    
        public string LocalInformation {  get; set; }
        public string NorthernLightsInformation {  get; set; }
        public string ContactInformation { get; set; }

        //methods that work for all

        public void BacktoMenu();


    }
}
