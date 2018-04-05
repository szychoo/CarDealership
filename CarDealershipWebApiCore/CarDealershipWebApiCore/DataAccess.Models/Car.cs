using System;

namespace CarDealership.Model
{
    public class Car
    {
        public int Id { get; set; }

        //public Make Make { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public DateTime ProductionYear { get; set; }

        public short EngineSize { get; set; }

        public short HorsePower { get; set; }

        //public Color Color { get; set; }

        public string Color { get; set; }
    }
}
