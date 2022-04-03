using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public abstract class AnimalCage : Zoo
    {
        public virtual int size { get; set; }
        public int cageNum;
        public AnimalCage(int cageNum)
        {
            this.cageNum = cageNum;
            this.size = 20;
        }
    }
}


