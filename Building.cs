using System;

namespace BuildingClass {

            class Building
            {
                //  Creating Building properties
                private string _designer;
                private DateTime _timeConstructed;
                private string _address;
                private string _owner;
                public int Stories { get; set; }
                public double Width { get; set; }
                public double Depth { get; set; }
                public double Volume
                    {
                        get
                            {
                            return (Width * Depth * (Stories * 3));
                            }
                    }
                // Setting Building constructor
                public Building(string address)
                {
                    address = _address;
                }
                // A method that sets date and time of construction
                public void Construct()
                {
                    _timeConstructed = DateTime.Now;
                }
                // method that logs information to the console
                public void Purchase(string ownerName)
                {
                    _owner = ownerName;
                    Console.WriteLine($"Designed by {_owner}. Constructed on {_timeConstructed}. Owned by {_owner}. {Volume} cubic meters of space.");
                }

}
}

