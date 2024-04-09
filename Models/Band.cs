using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public class Band
    {

        public int? Priority {  get; set; }
        
        public int? Balance { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }


        public virtual ICollection<Instrument> RequiredInstruments { get; set; }

        public Band()
        {
            RequiredInstruments = new HashSet<Instrument>();
        }

        public override string ToString()
        {
            if(Balance == null)
            {
                return $"[{Id}]: {Name} has no checking account";
            }
            else
            {
                if(Priority == null)
                {
                    return $"[{Id}]: {Name} has a balance of {Balance}";

                }
                else
                {
                    return $"[{Id}]: {Name} has a balance of {Balance} with a priority of {Priority}";

                }
            }
        }

    }
}
