using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Models
{

    public class Manufacturer
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Instrument> Instruments { get; set; }

        public Manufacturer()
        {
            Instruments = new HashSet<Instrument>();
        }

        public override string ToString()
        {
            return $"[{Id}]: {Name} ";
        }
    }
}
