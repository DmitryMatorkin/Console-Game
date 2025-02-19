using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    internal class Character
    {
        public string Name { get; set; }
      
        public uint Health { get; set; }
       
        public uint CurrentHealth { get; set; }
      
        public int Strong { get; set; }
      
      
        public int Protect { get; set; }
        
        public uint Level { get; set; }
       
        public int MinAttack { get; set; }
       
        public int MaxAttack { get; set; }
        public Character(string name, uint health, uint currentHealth, int strong, int protect, uint level, int minAttack, int maxAttack)
        {
            Name = name;
            Health = health;
            CurrentHealth = currentHealth;
            Strong = strong;
            Protect = protect;
            Level = level;
            MinAttack = minAttack;
            MaxAttack = maxAttack;
        }
    }
}
