using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public abstract class AnimalProperties : AnimalCage,IAnimal
    {
       
        public virtual string animalName { get; set; }
        public int age;
        public virtual string eats { get; set; }
        public abstract bool isPredatory { get; set; }
        public abstract bool layEggs { get; set; }
        
        public AnimalProperties(string animalName, int age,int cageNum) :base(cageNum) 
        {
            this.animalName = animalName;   
            this.age = age; 
            this.eats = eats; 
        }
        public virtual void getOlder()
        {
            this.age++;
        }
        public abstract void dead();
        public abstract void addEats(string add);

        public virtual void changeName(string newName)
        {
            this.Name = newName;
        }


    }
   
}
