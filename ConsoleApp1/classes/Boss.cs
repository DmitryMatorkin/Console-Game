﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    internal class Boss:Character
    {
        public Boss(string name, uint health, uint currentHealth, int strong, int protect, uint level, int minAttack, int maxAttack) : base(name, health, currentHealth, strong, protect, level, minAttack, maxAttack)
        {

        }
    }
}
