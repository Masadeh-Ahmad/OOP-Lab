using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    interface IAnimal
    {
        string animalName { get; set; }
        string eats { get; set; }
        bool isPredatory { get; set; }
        bool layEggs { get; set; }
        void getOlder();
        void dead();
        void changeName(string newName);
    }
}
