﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{

    class Fjender
    {
        public string Name;
        public int HP;
        public int Skade;
        public Spiller target { get; }


        public static List<Fjender> fjender = new List<Fjender>
        {
            new Fjender("Mus", 2, 1),
            new Fjender("Bandit", 5, 3),
            new Fjender("Drage", 15, 8)

        };
        public Fjender (string name, int hp, int skade)
        {
            Name = name;
            HP = hp;
            Skade = skade;
        }
        public void angreb()
        {
            Console.WriteLine(Name + " angriber dig og gør " + Skade);
            target.HP -= Skade;

            if(target.evade == true)
            {
                Console.WriteLine("Monsteret prøver at ramme dig, men ramte ikke");
                target.evade = false;
            }

        }



    }
}
