

namespace Models
{
    public enum instrumentTypeEnum {STRINGS, PERCUSSION, WIND, SYNTH }

    public class Instrument
    {
        public string Color {  get; set; }
        public string Description { get; set; }
        public int? Year { get; set; }



        public int Id { get; set; }

        public string Name { get; set; }

        public instrumentTypeEnum Type{ get; set; }

        


        public virtual Manufacturer Manufacturer { get; set; }

        public int ManufacturerId { get; set; }

        public virtual Band Band { get; set; }

        public int BandId { get; set; }

        public override string ToString()
        {
            return $"[{Id}]: {Name} ";
        }

    }
}