using System;
using Zoo.Classes;
namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal lion = new Animal("Mhsn","Mammals",10,"Meat",true,false,5);
            Animal eagle = new Animal("Sager", "Brids", 13, "Meat", true, true, 3);
            Zoo.Classes.Zoo turtle = new Animal("Samera", "Reptiles", 20, "Grass", false, true, 10);
            Animal blueTang = new Animal("Hala","Fish",2,"Kelp",false,true,20);
            Animal frog = new Animal("Froggy", "Amphibians",3, "Slugs",false,true,19);
            Animal sheep = new Animal("hooar", "Mammals", 2, "Grass", false, false, 13);
        }
    }
}
