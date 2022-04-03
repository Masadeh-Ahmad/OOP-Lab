using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public class Animal : AnimalProperties
    {
        public override bool isPredatory { get; set; }
        public override bool layEggs { get; set; }
        public override string eats { get; set; }

        public virtual string type { get; set; }

        public Animal(string animalName,string type,int age, string eats,bool isPredatory, bool layEggs,int cageNum) : base(animalName, age, cageNum)
        {
            this.isPredatory = isPredatory;
            this.layEggs = layEggs;
            this.eats = eats;
            this.type = type;
        }
        public override void getOlder()
        {
            this.age++;
        }
        public override void dead()
        {
            this.age = 0;
            this.Name = $"{this.Name} (dead)";
        }
        public override void addEats(string add)
        {
            this.eats = this.eats + add;
        }

    }
}
