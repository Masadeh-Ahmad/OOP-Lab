﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    interface IAnimal
    {

        void getOlder();
        void dead();
        void changeName(string newName);
    }
}
