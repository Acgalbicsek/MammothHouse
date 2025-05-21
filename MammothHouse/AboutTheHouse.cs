namespace MammothHouse
{
    public class AboutTheHouse : IList_Items
    {
        public string TItle { get; set; } = "About The House";
        public string Description { get; set; }

        public string HouseRules { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AboutYourStay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string WIFIInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LocalInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NorthernLightsInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ContactInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IList_Items.AboutTheHouse { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void BacktoMenu()
        {
            throw new NotImplementedException();
        }

        public AboutTheHouse()
        {
            Description = "The noise you hear when you turn on the shower, flush the toilet, or run water from the sink is our water pump.  It should not be running when" +
                "the appliances that use water are off.  If you hear it running when the sinks and the shower are off, and it runs for more than 5 minutes, please contact Theodora and Shelton!" +

                "If the indoor garbage can fills up during your stay, please put it in the silver trash can outside.  Do not put trash on the porch, it will attract animals." +
                "If you are chilly, please feel free to turn up the heat on the Toyo stove in the living room.  Putting the ceiling fans on low help move the heat around the house." +
                "There is also a fan/space heater in the bedroom and in the bathroom for you to use." +
                "There is a washer and dryer that you are more than welcome to use!  We ask that you use the QUICK CYCLE on the washing machine.  It helps conserve the water we haul" +
                "There is a fire extinguisher under the sink.  If the smoke alarm goes off the fire department will respond.  So please contact Theodora and Shelton so they can cancel the fire department." +
                "There is a small first aid kit in the kitchen drawer.";
        }

    }
}

