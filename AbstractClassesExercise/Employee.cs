﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesExercise
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} says, \"I quit!\" **drops mic**");
        }

        
    }
}
