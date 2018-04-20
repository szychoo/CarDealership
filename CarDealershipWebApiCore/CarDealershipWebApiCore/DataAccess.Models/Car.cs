using System.ComponentModel.DataAnnotations;

namespace CarDealership.Model
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        //public Make Make { get; set; }

        [StringLength(50)]
        public string Make { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        public short ProductionYear { get; set; }

        public short EngineSize { get; set; }

        public short HorsePower { get; set; }

        //public Color Color { get; set; }

        [StringLength(50)]
        public string Color { get; set; }
    }
}
