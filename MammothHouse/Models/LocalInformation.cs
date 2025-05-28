namespace MammothHouse.Models
{
    public class Local_Information : IList_Items
    {
        public string Title { get; set; } = "Local To-Do's";
        public string Description { get; set; }
        public string HouseRules { get ; set ; }
        public string AboutTheHouse { get; set ; }
        public string AboutYourStay { get ; set; }
        public string WIFIInformation { get ; set; }
        public string LocalInformation { get ; set ; }
        public string NorthernLightsInformation { get; set; }
        public string ContactInformation { get; set; }

        public void BacktoMenu()
        {
            throw new NotImplementedException();
        }

        public Local_Information()
        {
            Description = "Some of our favorite restaurants are Lulu's, Blue Roof Bistro, Aurora Mediterranean Grill, Kanpai, Hari Om, and Pad Thai on College Road." +
                "Alaska is known for its small coffee huts!  We would highly recommend checking one out, they are all over! Mocha Dan's is fairly close to our house." +


                "Hiking Trails:" +
                "Right here in the backyard! feel free to explore the woods, you should find some trails!" +
                "Angel Rocks Trail" +
                "Creamers Field" +
                "UAF Trail System" +
                "Granite Tors" +
                "Wickersham Dome" +
                "YOU MUST BRING BUG DOPE WHEN YOU GO ON ANY HIKE!  YOU WILL NOT MAKE IT WITHOUT IT! A bug net is also very handy to have." +

                "Fishing Spots:" +
                "Olnes Pond" +
                "Birch Lake and Quartz Lake" +
                "The Chena River: Go down Chena Hot Springs Road and take your pick of where to pull off!" +
                "White Fish Campground: ten miles away from the house, going North on the Elliot Highway" +

                "Grocery Stores:" +
                "Fred Meyers" +
                "Walmart" +
                "Roaming Root(has a small selection of local produce and a large selection of local wares)" +
                "Co-Op Market Grocery and Deli" +

                "Tanana Valley Farmers Market is open from May - September.  Hours of operation are every Wednesday 11am-4pm and every Saturday 9am -4pm." +
                "Please come and support our local businesses!";
        }
    }
}

