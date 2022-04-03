using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public abstract class Zoo
    {
        public string Name;
        public string Location;
        public string ownerName;

        public Zoo()
        {
            this.Name = "North Zoo";
            this.Location = "Amman";
            this.ownerName ="Ahmad";
        }
    }

}
